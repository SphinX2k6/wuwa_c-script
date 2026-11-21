using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E84 RID: 3716
[NullableContext(1)]
[Nullable(0)]
public class CommonPropTipsComponent : UiPanelBase
{
	// Token: 0x060094B6 RID: 38070 RVA: 0x002C1C28 File Offset: 0x002BFE28
	public CommonPropTipsComponent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060094B7 RID: 38071 RVA: 0x002C1C74 File Offset: 0x002BFE74
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

	// Token: 0x060094B8 RID: 38072 RVA: 0x002C1E18 File Offset: 0x002C0018
	private void GetWayButtonClick()
	{
		this.IsOpenGetWay = !this.IsOpenGetWay;
		base.GetLayoutBase(5).GetRootComponent().SetUIActive(this.IsOpenGetWay);
		base.GetExtendToggle(4).SetToggleState(this.IsOpenGetWay ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060094B9 RID: 38073 RVA: 0x002C1E68 File Offset: 0x002C0068
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

	// Token: 0x060094BA RID: 38074 RVA: 0x002C1F14 File Offset: 0x002C0114
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

	// Token: 0x060094BB RID: 38075 RVA: 0x002C1FE8 File Offset: 0x002C01E8
	private void SetGetWayState(bool bActive)
	{
		base.GetExtendToggle(4).RootUIComp.Get().SetUIActive(bActive);
		base.GetLayoutBase(5).GetRootComponent().SetUIActive(false);
		this.IsOpenGetWay = false;
		base.GetExtendToggle(4).SetToggleState(this.IsOpenGetWay ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060094BC RID: 38076 RVA: 0x002C2044 File Offset: 0x002C0244
	private void UpdateGetWay(int[] getWayList)
	{
		object[] array = new object[getWayList.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = getWayList[i];
		}
		this.GetWayLayout.AddItemToLayout(array, 1);
	}

	// Token: 0x060094BD RID: 38077 RVA: 0x002C2080 File Offset: 0x002C0280
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

	// Token: 0x060094BE RID: 38078 RVA: 0x002C2100 File Offset: 0x002C0300
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

	// Token: 0x060094BF RID: 38079 RVA: 0x002C21D0 File Offset: 0x002C03D0
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

	// Token: 0x060094C0 RID: 38080 RVA: 0x002C22F8 File Offset: 0x002C04F8
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

	// Token: 0x060094C1 RID: 38081 RVA: 0x002C2340 File Offset: 0x002C0540
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

	// Token: 0x060094C2 RID: 38082 RVA: 0x002C2395 File Offset: 0x002C0595
	public ButtonItem GetDoubleLeftButton()
	{
		return this.DoubleButtonItemList[0];
	}

	// Token: 0x060094C3 RID: 38083 RVA: 0x002C23A3 File Offset: 0x002C05A3
	public ButtonItem GetDoubleRightButton()
	{
		return this.DoubleButtonItemList[1];
	}

	// Token: 0x060094C4 RID: 38084 RVA: 0x002C23B1 File Offset: 0x002C05B1
	[NullableContext(2)]
	public ButtonItem GetOneButton()
	{
		return this.OneButtonItem;
	}

	// Token: 0x060094C5 RID: 38085 RVA: 0x002C23B9 File Offset: 0x002C05B9
	public void SetOneButtonEnable(bool bEnable)
	{
		this.OneButtonItem.SetEnableClick(bEnable);
	}

	// Token: 0x060094C6 RID: 38086 RVA: 0x002C23C7 File Offset: 0x002C05C7
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x060094C7 RID: 38087 RVA: 0x002C23D0 File Offset: 0x002C05D0
	public void PlayStartSequence()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x060094C8 RID: 38088 RVA: 0x002C23F8 File Offset: 0x002C05F8
	public void StopStartSequence()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Start", false, false);
	}

	// Token: 0x04005737 RID: 22327
	[Nullable(2)]
	private UUIText DebugText;

	// Token: 0x04005738 RID: 22328
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutAdd<UiPanelBase> GetWayLayout;

	// Token: 0x04005739 RID: 22329
	protected int ConfigId;

	// Token: 0x0400573A RID: 22330
	protected List<ButtonItem> DoubleButtonItemList = new List<ButtonItem>();

	// Token: 0x0400573B RID: 22331
	[Nullable(2)]
	protected ButtonItem OneButtonItem;

	// Token: 0x0400573C RID: 22332
	protected bool IsOpenGetWay;

	// Token: 0x0400573D RID: 22333
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400573E RID: 22334
	private int DebugTextLoadId = LguiResourceManager.Instance.InvalidId;

	// Token: 0x0200707E RID: 28798
	[NullableContext(0)]
	private enum ECommonPropTipsComponentDefine
	{
		// Token: 0x04024AC6 RID: 150214
		NameText,
		// Token: 0x04024AC7 RID: 150215
		IconTexture,
		// Token: 0x04024AC8 RID: 150216
		TypeText,
		// Token: 0x04024AC9 RID: 150217
		ContentText,
		// Token: 0x04024ACA RID: 150218
		GetWayButton,
		// Token: 0x04024ACB RID: 150219
		GetWayLayout,
		// Token: 0x04024ACC RID: 150220
		BottomItem,
		// Token: 0x04024ACD RID: 150221
		DoubleButtonItem,
		// Token: 0x04024ACE RID: 150222
		OneButtonItem,
		// Token: 0x04024ACF RID: 150223
		CanGetWayItem,
		// Token: 0x04024AD0 RID: 150224
		CantGetWayItem,
		// Token: 0x04024AD1 RID: 150225
		TitleSprite,
		// Token: 0x04024AD2 RID: 150226
		BgDescribeText,
		// Token: 0x04024AD3 RID: 150227
		ChipSprite,
		// Token: 0x04024AD4 RID: 150228
		OwnText,
		// Token: 0x04024AD5 RID: 150229
		GetWayBg
	}
}
