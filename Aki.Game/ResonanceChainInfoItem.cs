using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002898 RID: 10392
[NullableContext(2)]
[Nullable(0)]
public class ResonanceChainInfoItem : UiPanelBase
{
	// Token: 0x06015702 RID: 87810 RVA: 0x00568610 File Offset: 0x00566810
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBackButtonClick))
		};
	}

	// Token: 0x06015703 RID: 87811 RVA: 0x00568758 File Offset: 0x00566958
	protected override void OnStart()
	{
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(5));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnConfirmButtonClick));
		this.NeedItem = new MediumItemGrid();
		this.NeedItem.Initialize(base.GetItem(4).GetOwner());
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		TermExplanationController.Instance.RegisterTextHyperlink(base.GetText(2), ETermExplanationViewType.Side, ETermExplanationReportType.RoleDeviceList, ETermExplanationViewAttachDirection.Right, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
	}

	// Token: 0x06015704 RID: 87812 RVA: 0x005687E4 File Offset: 0x005669E4
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(2));
	}

	// Token: 0x06015705 RID: 87813 RVA: 0x005687F8 File Offset: 0x005669F8
	private void OnConfirmButtonClick(int _)
	{
		ResonantChain? roleResonanceById = RoleResonanceConfig.Instance.GetRoleResonanceById(this.ResonanceId.Value);
		if (roleResonanceById == null)
		{
			return;
		}
		bool flag = true;
		foreach (KeyValuePair<int, int> keyValuePair in roleResonanceById.Value.ActivateConsume())
		{
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(keyValuePair.Key, 0);
			flag = (flag && commonItemCount >= keyValuePair.Value);
		}
		if (flag)
		{
			RoleController.Instance.SendResonanceUnlockRequest(this.RoleId);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("ResonanceItemNotEnough", Array.Empty<object>());
	}

	// Token: 0x06015706 RID: 87814 RVA: 0x005688C4 File Offset: 0x00566AC4
	private void OnBackButtonClick()
	{
		EventSystem.Instance.Emit(EEventName.OnRoleInternalViewQuit);
	}

	// Token: 0x06015707 RID: 87815 RVA: 0x005688D8 File Offset: 0x00566AD8
	public void ShowItem()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06015708 RID: 87816 RVA: 0x00568900 File Offset: 0x00566B00
	public void HideItem()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
	}

	// Token: 0x06015709 RID: 87817 RVA: 0x00568928 File Offset: 0x00566B28
	public void Refresh(bool isTrial = false)
	{
		ResonantChain? roleResonanceById = RoleResonanceConfig.Instance.GetRoleResonanceById(this.ResonanceId.Value);
		if (roleResonanceById != null)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
			ERoleResonanceNodeState roleResonanceState = RoleModel.Instance.GetRoleResonanceState(roleDataById, roleResonanceById.Value.GroupIndex);
			this.RefreshResonanceSprite(roleResonanceById.Value.GroupIndex);
			base.GetItem(5).SetUIActive(roleResonanceState == ERoleResonanceNodeState.ToBeActivated && !isTrial);
			base.GetItem(6).SetUIActive(roleResonanceState == ERoleResonanceNodeState.Activated && !isTrial);
			base.GetItem(7).SetUIActive(roleResonanceState == ERoleResonanceNodeState.NeedFrontActivated && !isTrial);
			this.NeedItem.GetRootItem().SetUIActive(roleResonanceState != ERoleResonanceNodeState.Activated && !isTrial);
			base.GetItem(10).SetUIActive(roleResonanceState != ERoleResonanceNodeState.Activated && !isTrial);
			base.GetText(0).ShowTextNew(roleResonanceById.Value.NodeName);
			int attributesDescriptionParamsLength = roleResonanceById.Value.AttributesDescriptionParamsLength;
			object[] array = new object[attributesDescriptionParamsLength];
			for (int i = 0; i < attributesDescriptionParamsLength; i++)
			{
				array[i] = roleResonanceById.Value.AttributesDescriptionParams(i);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), roleResonanceById.Value.AttributesDescription, array);
			base.GetText(8).ShowTextNew(roleResonanceById.Value.BgDescription);
			bool redDotVisible = RoleModel.Instance.RedDotResonanceTabHoleCondition(this.RoleId, roleResonanceById.Value.GroupIndex);
			this.ConfirmButtonItem.SetRedDotVisible(redDotVisible);
			if (isTrial)
			{
				return;
			}
			using (Dictionary<int, int>.Enumerator enumerator = roleResonanceById.Value.ActivateConsume().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> kvp = enumerator.Current;
					PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
					{
						ItemConfigId = new int?(kvp.Key)
					};
					int commonItemCount = InventoryModel.Instance.GetCommonItemCount(kvp.Key, 0);
					propMediumItemGrid.BottomTextId = "Text_ItemEnoughText_Text";
					if (commonItemCount < kvp.Value)
					{
						propMediumItemGrid.BottomTextId = "Text_ItemNotEnoughText_Text";
					}
					propMediumItemGrid.BottomTextParameter = new object[]
					{
						commonItemCount,
						kvp.Value
					};
					this.NeedItem.Apply<PropMediumItemGrid>(propMediumItemGrid);
					this.NeedItem.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
					this.NeedItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
					{
						ItemController.Instance.OpenItemTipsByItemId(kvp.Key, true, null);
					});
				}
			}
		}
	}

	// Token: 0x0601570A RID: 87818 RVA: 0x00568C24 File Offset: 0x00566E24
	public void Update(int roleId, int resonanceId, bool isTrial = false)
	{
		this.RoleId = roleId;
		this.ResonanceId = new int?(resonanceId);
		this.Refresh(isTrial);
	}

	// Token: 0x0601570B RID: 87819 RVA: 0x00568C40 File Offset: 0x00566E40
	private void RefreshResonanceSprite(int index)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_DeviceNum");
		defaultInterpolatedStringHandler.AppendFormatted<int>(index);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(11), true, null, null);
	}

	// Token: 0x0601570C RID: 87820 RVA: 0x00568C99 File Offset: 0x00566E99
	public int? GetResonanceId()
	{
		return this.ResonanceId;
	}

	// Token: 0x0601570D RID: 87821 RVA: 0x00568CA1 File Offset: 0x00566EA1
	[NullableContext(1)]
	public UUIItem GetUiItemForGuide()
	{
		ButtonItem confirmButtonItem = this.ConfirmButtonItem;
		object obj;
		if (confirmButtonItem == null)
		{
			obj = null;
		}
		else
		{
			UUIButtonComponent btn = confirmButtonItem.GetBtn();
			obj = ((btn != null) ? btn.GetOwner().GetComponentByClass(UUIItem.StaticClass()) : null);
		}
		return obj as UUIItem;
	}

	// Token: 0x04009FE1 RID: 40929
	private int RoleId;

	// Token: 0x04009FE2 RID: 40930
	private int? ResonanceId;

	// Token: 0x04009FE3 RID: 40931
	private ButtonItem ConfirmButtonItem;

	// Token: 0x04009FE4 RID: 40932
	private MediumItemGrid NeedItem;

	// Token: 0x04009FE5 RID: 40933
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02008E9F RID: 36511
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E3F2 RID: 189426
		NameText,
		// Token: 0x0402E3F3 RID: 189427
		DescriptionScrollView,
		// Token: 0x0402E3F4 RID: 189428
		SkillDescriptionText,
		// Token: 0x0402E3F5 RID: 189429
		NeedNode,
		// Token: 0x0402E3F6 RID: 189430
		NeedItem,
		// Token: 0x0402E3F7 RID: 189431
		ConfirmButtonItem,
		// Token: 0x0402E3F8 RID: 189432
		ActivatedItem,
		// Token: 0x0402E3F9 RID: 189433
		FrontItem,
		// Token: 0x0402E3FA RID: 189434
		BgDescriptionText,
		// Token: 0x0402E3FB RID: 189435
		BackButton,
		// Token: 0x0402E3FC RID: 189436
		NeedItemNode,
		// Token: 0x0402E3FD RID: 189437
		ResonanceNumSprite
	}
}
