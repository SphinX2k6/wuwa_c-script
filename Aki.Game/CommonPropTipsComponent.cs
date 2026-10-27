using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019C5 RID: 6597
[NullableContext(1)]
[Nullable(0)]
public class CommonPropTipsComponent : UiPanelBase
{
	// Token: 0x0600C0A9 RID: 49321 RVA: 0x002B6C7C File Offset: 0x002B4E7C
	public CommonPropTipsComponent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C0AA RID: 49322 RVA: 0x002B6CC8 File Offset: 0x002B4EC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUISprite)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.GetWayButtonClick))
		};
	}

	// Token: 0x0600C0AB RID: 49323 RVA: 0x002B6E6C File Offset: 0x002B506C
	private void GetWayButtonClick()
	{
		this.IsOpenGetWay = !this.IsOpenGetWay;
		base.GetLayoutBase(5).GetRootComponent().SetUIActive(this.IsOpenGetWay);
		base.GetExtendToggle(4).SetToggleState(this.IsOpenGetWay ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C0AC RID: 49324 RVA: 0x002B6EBC File Offset: 0x002B50BC
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.GetWayLayout = new GenericLayoutAdd<UiPanelBase>(base.GetLayoutBase(5), new TLayoutRefresh<UiPanelBase>(this.InitItem));
		base.GetItem(15).SetUIActive(true);
		this.SetGetWayState(false);
		this.SetBottomState(false, false);
		this.OneButtonItem = new ButtonItem(base.GetItem(8));
		TArray<UUIItem> attachUIChildren = base.GetItem(7).GetAttachUIChildren();
		int i = 0;
		int num = attachUIChildren.Num();
		while (i < num)
		{
			ButtonItem item = new ButtonItem(attachUIChildren.Get(i));
			this.DoubleButtonItemList.Add(item);
			i++;
		}
		this.SetOwnTextState(false);
	}

	// Token: 0x0600C0AD RID: 49325 RVA: 0x002B6F68 File Offset: 0x002B5168
	private ILayoutItem<UiPanelBase> InitItem(object data, UUIItem uiItem, int index, int originalItemIndex)
	{
		int getWayId = (int)data;
		ButtonItem buttonItem = new ButtonItem(uiItem);
		AccessPath? configById = GetWayConfig.Instance.GetConfigById(getWayId);
		if (configById == null)
		{
			return new LayoutItem<UiPanelBase>
			{
				Key = index,
				Value = buttonItem
			};
		}
		buttonItem.SetData(getWayId);
		buttonItem.SetEnableClick(configById.Value.Type == 2);
		buttonItem.SetFunction(delegate(int dataId)
		{
			SkipTaskManager.RunByConfigId(getWayId, this.ConfigId);
		});
		buttonItem.SetButtonAllowEventBubbleUp(true);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(configById.Value.Description, null);
		buttonItem.SetText(localTextNew);
		return new LayoutItem<UiPanelBase>
		{
			Key = index,
			Value = buttonItem
		};
	}

	// Token: 0x0600C0AE RID: 49326 RVA: 0x002B703C File Offset: 0x002B523C
	private void SetGetWayState(bool bActive)
	{
		base.GetExtendToggle(4).RootUIComp.Get().SetUIActive(bActive);
		base.GetLayoutBase(5).GetRootComponent().SetUIActive(false);
		this.IsOpenGetWay = false;
		base.GetExtendToggle(4).SetToggleState(this.IsOpenGetWay ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C0AF RID: 49327 RVA: 0x002B7098 File Offset: 0x002B5298
	private void UpdateGetWay(int[] getWayList)
	{
		this.GetWayLayout.AddItemToLayout(getWayList.Cast<object>().ToArray<object>(), 1);
	}

	// Token: 0x0600C0B0 RID: 49328 RVA: 0x002B70B4 File Offset: 0x002B52B4
	protected void LoadDebugText()
	{
		if (!GlobalData.IsPlayInEditor)
		{
			return;
		}
		if (this.DebugText == null)
		{
			LguiResourceManager.Instance.CancelLoadPrefab(this.DebugTextLoadId);
			this.DebugTextLoadId = LguiResourceManager.Instance.LoadPrefabByResourceId("UiItem_DebugText_Prefab", this.RootItem, delegate([Nullable(2)] AActor actor, string _, ELguiLoadResultType _1)
			{
				this.DebugTextLoadId = LguiResourceManager.Instance.InvalidId;
				this.DebugText = (actor.GetComponentByClass(UUIText.StaticClass()) as UUIText);
				LguiUtil.Instance.SetLocalText(this.DebugText, "CommonTipsDebugItemId", new <>z__ReadOnlySingleElementList<object>(this.ConfigId));
			}, "js_undefined");
			return;
		}
		LguiUtil.Instance.SetLocalText(this.DebugText, "CommonTipsDebugItemId", new <>z__ReadOnlySingleElementList<object>(this.ConfigId));
	}

	// Token: 0x0600C0B1 RID: 49329 RVA: 0x002B7134 File Offset: 0x002B5334
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
		this.GetWayLayout.ClearChildren();
		this.GetWayLayout = null;
		this.OneButtonItem.Destroy(null);
		this.OneButtonItem = null;
		foreach (ButtonItem buttonItem in this.DoubleButtonItemList)
		{
			buttonItem.Destroy(null);
		}
		this.DoubleButtonItemList.Clear();
		LguiResourceManager.Instance.CancelLoadPrefab(this.DebugTextLoadId);
		if (this.DebugText != null)
		{
			ActorSystem.Instance.Put("CommonPropTipsComponent.OnBeforeDestroy", this.DebugText.GetOwner(), null);
			this.DebugText = null;
		}
	}

	// Token: 0x0600C0B2 RID: 49330 RVA: 0x002B7204 File Offset: 0x002B5404
	public void UpdateComponent(int configId, bool needGetWay = false)
	{
		this.ConfigId = configId;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(configId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), itemConfigData.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), itemConfigData.TypeDescription, Array.Empty<object>());
		UUIText text = base.GetText(3);
		if (itemConfigData.AttributesDescription != null)
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text, itemConfigData.AttributesDescription, Array.Empty<object>());
		}
		else
		{
			text.SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), itemConfigData.BgDescription, Array.Empty<object>());
		base.SetItemIcon(base.GetTexture(1), this.ConfigId, null, null);
		base.SetItemQualityIcon(base.GetSprite(11), this.ConfigId, null, CommonDefine.EQualityIconType.TipsSprite, null);
		this.LoadDebugText();
		if (needGetWay)
		{
			this.GetWayLayout.ClearChildren();
			if (itemConfigData.ItemAccess != null && itemConfigData.ItemAccess.Length != 0)
			{
				this.UpdateGetWay(itemConfigData.ItemAccess);
				this.SetGetWayState(true);
				return;
			}
		}
		this.SetGetWayState(false);
	}

	// Token: 0x0600C0B3 RID: 49331 RVA: 0x002B732C File Offset: 0x002B552C
	public void SetBottomState(bool bActive, bool isOneButton)
	{
		UUIItem item = base.GetItem(6);
		if (!bActive)
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		UUIItem item2 = base.GetItem(8);
		UUIItem item3 = base.GetItem(7);
		item2.SetUIActive(isOneButton);
		item3.SetUIActive(!isOneButton);
	}

	// Token: 0x0600C0B4 RID: 49332 RVA: 0x002B7374 File Offset: 0x002B5574
	public void SetOwnTextState(bool bActive)
	{
		UUIText text = base.GetText(14);
		if (bActive)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ConfigId, 0);
			LguiUtil.Instance.SetLocalText(text, "ItemTipsHaveNum", new <>z__ReadOnlySingleElementList<object>(itemCountByConfigId));
			text.SetUIActive(true);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600C0B5 RID: 49333 RVA: 0x002B73C9 File Offset: 0x002B55C9
	public ButtonItem GetDoubleLeftButton()
	{
		return this.DoubleButtonItemList[0];
	}

	// Token: 0x0600C0B6 RID: 49334 RVA: 0x002B73D7 File Offset: 0x002B55D7
	public ButtonItem GetDoubleRightButton()
	{
		return this.DoubleButtonItemList[1];
	}

	// Token: 0x0600C0B7 RID: 49335 RVA: 0x002B73E5 File Offset: 0x002B55E5
	[NullableContext(2)]
	public ButtonItem GetOneButton()
	{
		return this.OneButtonItem;
	}

	// Token: 0x0600C0B8 RID: 49336 RVA: 0x002B73ED File Offset: 0x002B55ED
	public void SetOneButtonEnable(bool bEnable)
	{
		this.OneButtonItem.SetEnableClick(bEnable);
	}

	// Token: 0x0600C0B9 RID: 49337 RVA: 0x002B73FB File Offset: 0x002B55FB
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600C0BA RID: 49338 RVA: 0x002B7404 File Offset: 0x002B5604
	public void PlayStartSequence()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600C0BB RID: 49339 RVA: 0x002B742C File Offset: 0x002B562C
	public void StopStartSequence()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Start", false, false);
	}

	// Token: 0x04005685 RID: 22149
	[Nullable(2)]
	private UUIText DebugText;

	// Token: 0x04005686 RID: 22150
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutAdd<UiPanelBase> GetWayLayout;

	// Token: 0x04005687 RID: 22151
	protected int ConfigId;

	// Token: 0x04005688 RID: 22152
	protected List<ButtonItem> DoubleButtonItemList = new List<ButtonItem>();

	// Token: 0x04005689 RID: 22153
	[Nullable(2)]
	protected ButtonItem OneButtonItem;

	// Token: 0x0400568A RID: 22154
	protected bool IsOpenGetWay;

	// Token: 0x0400568B RID: 22155
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400568C RID: 22156
	private int DebugTextLoadId = LguiResourceManager.Instance.InvalidId;

	// Token: 0x02007EEF RID: 32495
	[NullableContext(0)]
	private enum ECommonPropTipsComponentDefine
	{
		// Token: 0x04029789 RID: 169865
		NameText,
		// Token: 0x0402978A RID: 169866
		IconTexture,
		// Token: 0x0402978B RID: 169867
		TypeText,
		// Token: 0x0402978C RID: 169868
		ContentText,
		// Token: 0x0402978D RID: 169869
		GetWayButton,
		// Token: 0x0402978E RID: 169870
		GetWayLayout,
		// Token: 0x0402978F RID: 169871
		BottomItem,
		// Token: 0x04029790 RID: 169872
		DoubleButtonItem,
		// Token: 0x04029791 RID: 169873
		OneButtonItem,
		// Token: 0x04029792 RID: 169874
		CanGetWayItem,
		// Token: 0x04029793 RID: 169875
		CantGetWayItem,
		// Token: 0x04029794 RID: 169876
		TitleSprite,
		// Token: 0x04029795 RID: 169877
		BgDescribeText,
		// Token: 0x04029796 RID: 169878
		ChipSprite,
		// Token: 0x04029797 RID: 169879
		OwnText,
		// Token: 0x04029798 RID: 169880
		GetWayBg
	}
}
