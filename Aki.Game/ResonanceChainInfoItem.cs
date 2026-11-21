using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E13 RID: 7699
[NullableContext(2)]
[Nullable(0)]
public class ResonanceChainInfoItem : UiPanelBase
{
	// Token: 0x06013102 RID: 78082 RVA: 0x00593458 File Offset: 0x00591658
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

	// Token: 0x06013103 RID: 78083 RVA: 0x005935A0 File Offset: 0x005917A0
	protected override void OnStart()
	{
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(5));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnConfirmButtonClick));
		this.NeedItem = new MediumItemGrid();
		this.NeedItem.Initialize(base.GetItem(4).GetOwner());
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		TermExplanationController.Instance.RegisterTextHyperlink(base.GetText(2), ETermExplanationViewType.Side, ETermExplanationReportType.RoleDeviceList, ETermExplanationViewAttachDirection.Right, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
	}

	// Token: 0x06013104 RID: 78084 RVA: 0x0059362C File Offset: 0x0059182C
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(2));
	}

	// Token: 0x06013105 RID: 78085 RVA: 0x00593640 File Offset: 0x00591840
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

	// Token: 0x06013106 RID: 78086 RVA: 0x0059370C File Offset: 0x0059190C
	private void OnBackButtonClick()
	{
		EventSystem.Instance.Emit(EEventName.OnRoleInternalViewQuit);
	}

	// Token: 0x06013107 RID: 78087 RVA: 0x00593720 File Offset: 0x00591920
	public void ShowItem()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06013108 RID: 78088 RVA: 0x00593748 File Offset: 0x00591948
	public void HideItem()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
	}

	// Token: 0x06013109 RID: 78089 RVA: 0x00593770 File Offset: 0x00591970
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
						ItemController.Instance.OpenItemTipsByItemId(kvp.Key, true, null, false);
					});
				}
			}
		}
	}

	// Token: 0x0601310A RID: 78090 RVA: 0x00593A6C File Offset: 0x00591C6C
	public void Update(int roleId, int resonanceId, bool isTrial = false)
	{
		this.RoleId = roleId;
		this.ResonanceId = new int?(resonanceId);
		this.Refresh(isTrial);
	}

	// Token: 0x0601310B RID: 78091 RVA: 0x00593A88 File Offset: 0x00591C88
	private void RefreshResonanceSprite(int index)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_DeviceNum");
		defaultInterpolatedStringHandler.AppendFormatted<int>(index);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(11), true, null, null);
	}

	// Token: 0x0601310C RID: 78092 RVA: 0x00593AE1 File Offset: 0x00591CE1
	public int? GetResonanceId()
	{
		return this.ResonanceId;
	}

	// Token: 0x0601310D RID: 78093 RVA: 0x00593AE9 File Offset: 0x00591CE9
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

	// Token: 0x0400A3CA RID: 41930
	private int RoleId;

	// Token: 0x0400A3CB RID: 41931
	private int? ResonanceId;

	// Token: 0x0400A3CC RID: 41932
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400A3CD RID: 41933
	private MediumItemGrid NeedItem;

	// Token: 0x0400A3CE RID: 41934
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x020080E6 RID: 32998
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04029AEF RID: 170735
		NameText,
		// Token: 0x04029AF0 RID: 170736
		DescriptionScrollView,
		// Token: 0x04029AF1 RID: 170737
		SkillDescriptionText,
		// Token: 0x04029AF2 RID: 170738
		NeedNode,
		// Token: 0x04029AF3 RID: 170739
		NeedItem,
		// Token: 0x04029AF4 RID: 170740
		ConfirmButtonItem,
		// Token: 0x04029AF5 RID: 170741
		ActivatedItem,
		// Token: 0x04029AF6 RID: 170742
		FrontItem,
		// Token: 0x04029AF7 RID: 170743
		BgDescriptionText,
		// Token: 0x04029AF8 RID: 170744
		BackButton,
		// Token: 0x04029AF9 RID: 170745
		NeedItemNode,
		// Token: 0x04029AFA RID: 170746
		ResonanceNumSprite
	}
}
