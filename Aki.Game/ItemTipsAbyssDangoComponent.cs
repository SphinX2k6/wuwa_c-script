using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A6A RID: 6762
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsAbyssDangoComponent : TipsBaseSubComponent
{
	// Token: 0x0600C716 RID: 50966 RVA: 0x002D4F78 File Offset: 0x002D3178
	public ItemTipsAbyssDangoComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsChipInfo", rootUiItem, false);
	}

	// Token: 0x0600C717 RID: 50967 RVA: 0x002D4FE4 File Offset: 0x002D31E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C718 RID: 50968 RVA: 0x002D5201 File Offset: 0x002D3401
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x0600C719 RID: 50969 RVA: 0x002D521F File Offset: 0x002D341F
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x0600C71A RID: 50970 RVA: 0x002D523D File Offset: 0x002D343D
	private void RefreshFuncState(int _)
	{
		this.RefreshView(this.CurrentData);
	}

	// Token: 0x0600C71B RID: 50971 RVA: 0x002D524C File Offset: 0x002D344C
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsAbyssDangoComponent.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsAbyssDangoComponent.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C71C RID: 50972 RVA: 0x002D5290 File Offset: 0x002D3490
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<DangoAbyssTipsAttributeItem, AttrListScrollData>(base.GetVerticalLayout(1), this.CreateItem, base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		this.TagScroller = new GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetVerticalLayout(3), this.CreateTagItem, base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600C71D RID: 50973 RVA: 0x002D52F4 File Offset: 0x002D34F4
	public override void Refresh(ItemTipsData sourceData)
	{
		TipsAbyssDangoData data = (TipsAbyssDangoData)sourceData;
		Action action = delegate()
		{
			this.RefreshView(data);
		};
		if (base.InAsyncLoading())
		{
			this.OperationMap["Refresh"] = action;
			return;
		}
		action();
	}

	// Token: 0x0600C71E RID: 50974 RVA: 0x002D5348 File Offset: 0x002D3548
	private void RefreshView(TipsAbyssDangoData data)
	{
		this.CurrentData = data;
		AttrListScrollData[] pluginShowAttributeList = DangoAbyssModel.Instance.GetPluginShowAttributeList(data.ConfigId);
		this.RefreshAttribute(pluginShowAttributeList.ToList<AttrListScrollData>());
		DangoAbyssDefine.DangoAbyssTagData[] pluginShowTagDataList = DangoAbyssModel.Instance.GetPluginShowTagDataList(data.ConfigId);
		this.RefreshTag(pluginShowTagDataList.ToList<DangoAbyssDefine.DangoAbyssTagData>());
		string itemBgDesc = DangoAbyssConfig.Instance.GetItemBgDesc(data.ConfigId);
		base.GetText(6).SetText(itemBgDesc, true);
		this.RefreshState(data);
		this.RefreshInActiveRedItem(data);
		this.RefreshConfirmBtn(data);
		this.RefreshLockToggle(data);
		this.RefreshIcon(data);
		this.RefreshName(data);
		this.RefreshQuality(data);
		this.RefreshType(data);
	}

	// Token: 0x0600C71F RID: 50975 RVA: 0x002D53F0 File Offset: 0x002D35F0
	private void RefreshState(TipsAbyssDangoData data)
	{
		this.StateConfirm = DangoAbyssDefine.EAbyssItemTipsState.None;
		if (data.DangoId > 0 && data.SlotIndex >= 0)
		{
			DangoAbyssDefine.IAbyssItemTipsData data2 = new DangoAbyssDefine.IAbyssItemTipsData
			{
				DangoId = data.DangoId,
				SlotIndex = data.SlotIndex,
				IncId = data.IncId
			};
			this.StateConfirm = DangoAbyssModel.Instance.GetDangoAbyssItemTipsConfirmState(data2);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.WDX;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral("当前按钮状态：");
		defaultInterpolatedStringHandler.AppendFormatted<DangoAbyssDefine.EAbyssItemTipsState>(this.StateConfirm);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600C720 RID: 50976 RVA: 0x002D5494 File Offset: 0x002D3694
	private void RefreshIcon(TipsAbyssDangoData data)
	{
		DangoPluginIconInfo dangoPluginIconInfo = new DangoPluginIconInfo
		{
			PluginItemId = data.ConfigId
		};
		MediumItemGridDangoPluginIconComponent pluginIconItem = this.PluginIconItem;
		if (pluginIconItem == null)
		{
			return;
		}
		pluginIconItem.RefreshByInfo(dangoPluginIconInfo);
	}

	// Token: 0x0600C721 RID: 50977 RVA: 0x002D54C4 File Offset: 0x002D36C4
	private void RefreshLockToggle(TipsAbyssDangoData data)
	{
		ItemConfig dangoItemConfig = DangoAbyssModel.Instance.GetDangoItemConfig(data.ConfigId);
		TypeInfo? itemTypeConfig = InventoryConfig.Instance.GetItemTypeConfig((int)dangoItemConfig.ItemType.Value);
		int incId = data.IncId;
		if (data.IncId > 0)
		{
			this.TipsLockButton.Refresh(data.IncId, data.CanClickLockButton);
			this.TipsLockButton.SetDeprecateToggleVisible(itemTypeConfig.Value.Deprecate);
			TipsLockButton tipsLockButton = this.TipsLockButton;
			if (tipsLockButton == null)
			{
				return;
			}
			tipsLockButton.SetUiActive(true);
			return;
		}
		else
		{
			TipsLockButton tipsLockButton2 = this.TipsLockButton;
			if (tipsLockButton2 == null)
			{
				return;
			}
			tipsLockButton2.SetUiActive(false);
			return;
		}
	}

	// Token: 0x0600C722 RID: 50978 RVA: 0x002D555C File Offset: 0x002D375C
	private void RefreshConfirmBtn(TipsAbyssDangoData data)
	{
		this.ConfirmBtnItem.SetUiActive(true);
		switch (this.StateConfirm)
		{
		case DangoAbyssDefine.EAbyssItemTipsState.DiffDango:
			this.ConfirmBtnItem.TrySetLocalTextNew("Text_PhantomReplace_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.TakeOff:
			this.ConfirmBtnItem.TrySetLocalTextNew("Text_PhantomTakeOff_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.Switch:
			this.ConfirmBtnItem.TrySetLocalTextNew("Text_PhantomReplace_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.Move:
			this.ConfirmBtnItem.TrySetLocalTextNew("Text_PhantomPutOn_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.Replace:
			this.ConfirmBtnItem.TrySetLocalTextNew("Text_PhantomReplace_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.PutOn:
			this.ConfirmBtnItem.TrySetLocalTextNew("Text_PhantomPutOn_Text", Array.Empty<object>());
			return;
		default:
			this.ConfirmBtnItem.SetUiActive(false);
			return;
		}
	}

	// Token: 0x0600C723 RID: 50979 RVA: 0x002D5634 File Offset: 0x002D3834
	private void RefreshInActiveRedItem(TipsAbyssDangoData data)
	{
		this.InActiveRedItem.SetUiActive(true);
		this.InActiveRedItem.SetDetailButtonVisible(false);
		DangoAbyssDefine.EAbyssItemTipsState stateConfirm = this.StateConfirm;
		if (stateConfirm == DangoAbyssDefine.EAbyssItemTipsState.ErrorDango)
		{
			int dangoItemBelongId = DangoAbyssModel.Instance.GetDangoItemBelongId(data.IncId);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(DangoAbyssConfig.Instance.GetDangoRoleById(dangoItemBelongId).Value.Name, null);
			this.InActiveRedItem.SetText("Text_DangoEquipErrorDango_Text", new object[]
			{
				localTextNew
			});
			return;
		}
		if (stateConfirm == DangoAbyssDefine.EAbyssItemTipsState.Same)
		{
			this.InActiveRedItem.SetText("Text_DangoEquipSame_Text", Array.Empty<object>());
			return;
		}
		if (stateConfirm != DangoAbyssDefine.EAbyssItemTipsState.Repeat)
		{
			this.InActiveRedItem.SetUiActive(false);
			return;
		}
		this.InActiveRedItem.SetText("Text_DangoEquipRepeat_Text", Array.Empty<object>());
	}

	// Token: 0x0600C724 RID: 50980 RVA: 0x002D56F6 File Offset: 0x002D38F6
	private void RefreshAttribute(List<AttrListScrollData> data)
	{
		this.AttributeScroller.RefreshByData(data, null, false);
	}

	// Token: 0x0600C725 RID: 50981 RVA: 0x002D5706 File Offset: 0x002D3906
	private void RefreshTag(List<DangoAbyssDefine.DangoAbyssTagData> data)
	{
		this.TagScroller.RefreshByData(data, null, false);
	}

	// Token: 0x0600C726 RID: 50982 RVA: 0x002D5718 File Offset: 0x002D3918
	private void RefreshName(TipsAbyssDangoData data)
	{
		UUIText text = base.GetText(10);
		FColor color = FColor.FromHex(DangoAbyssConfig.Instance.GetAbyssQualityByPluginItemId(data.ConfigId).Value.DropColor);
		text.SetColor(color);
		LguiUtil.Instance.SetLocalTextNew(text, data.Title, Array.Empty<object>());
	}

	// Token: 0x0600C727 RID: 50983 RVA: 0x002D5774 File Offset: 0x002D3974
	private void RefreshQuality(TipsAbyssDangoData data)
	{
		UUINiagara uiNiagara = base.GetUiNiagara(13);
		uiNiagara.DeactivateSystem();
		UUITexture texture = base.GetTexture(11);
		AbyssQuality value = DangoAbyssConfig.Instance.GetAbyssQualityByPluginItemId(data.ConfigId).Value;
		string tipsQualityTexturePath = value.TipsQualityTexturePath;
		FColor color = FColor.FromHex(value.QualityColor);
		uiNiagara.SetColor(color);
		uiNiagara.ActivateSystem(true);
		base.SetTextureByPath(tipsQualityTexturePath, texture, null, null);
	}

	// Token: 0x0600C728 RID: 50984 RVA: 0x002D57E8 File Offset: 0x002D39E8
	private void RefreshType(TipsAbyssDangoData data)
	{
		int slotType = DangoAbyssConfig.Instance.GetDangoItemById(data.ConfigId).Value.SlotType;
		string textStringId;
		if (DangoAbyssDefine.textPluginType.TryGetValue((DangoAbyssDefine.ESlotType)slotType, out textStringId))
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(14), textStringId, Array.Empty<object>());
		}
	}

	// Token: 0x0600C729 RID: 50985 RVA: 0x002D5840 File Offset: 0x002D3A40
	private void OnConfirmBtnClick(int _)
	{
		if (this.StateConfirm == DangoAbyssDefine.EAbyssItemTipsState.DiffDango)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoAbyssEquipPluginDiffDango);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.OnPluginItemEquipConfirm));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.OnPluginItemEquipConfirm();
	}

	// Token: 0x0600C72A RID: 50986 RVA: 0x002D588C File Offset: 0x002D3A8C
	private void OnPluginItemEquipConfirm()
	{
		if (this.CurrentData == null)
		{
			return;
		}
		DangoAbyssDefine.IAbyssItemTipsData data = new DangoAbyssDefine.IAbyssItemTipsData
		{
			DangoId = this.CurrentData.DangoId,
			SlotIndex = this.CurrentData.SlotIndex,
			IncId = this.CurrentData.IncId
		};
		int[] dangoAbyssItemNewEquip = DangoAbyssModel.Instance.GetDangoAbyssItemNewEquip(data, this.StateConfirm);
		DangoAbyssActivityController.Instance.RequestPutPluginOnDango(this.CurrentData.DangoId, dangoAbyssItemNewEquip, this.StateConfirm);
	}

	// Token: 0x0600C72B RID: 50987 RVA: 0x002D590C File Offset: 0x002D3B0C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 2)
		{
			return null;
		}
		string name = configParams[1];
		UUIItem guideUiItem = base.GetGuideUiItem(name);
		if (guideUiItem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			guideUiItem,
			guideUiItem
		};
	}

	// Token: 0x04005BB1 RID: 23473
	[Nullable(2)]
	private TipsAbyssDangoData CurrentData;

	// Token: 0x04005BB2 RID: 23474
	[Nullable(2)]
	private InActiveRedItem InActiveRedItem;

	// Token: 0x04005BB3 RID: 23475
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04005BB4 RID: 23476
	[Nullable(2)]
	private MediumItemGridDangoPluginIconComponent PluginIconItem;

	// Token: 0x04005BB5 RID: 23477
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssTipsAttributeItem, AttrListScrollData> AttributeScroller;

	// Token: 0x04005BB6 RID: 23478
	[Nullable(2)]
	private TipsLockButton TipsLockButton;

	// Token: 0x04005BB7 RID: 23479
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;

	// Token: 0x04005BB8 RID: 23480
	private DangoAbyssDefine.EAbyssItemTipsState StateConfirm;

	// Token: 0x04005BB9 RID: 23481
	private readonly Func<DangoAbyssTagItem> CreateTagItem = () => new DangoAbyssTagItem
	{
		GetValueByTips = true
	};

	// Token: 0x04005BBA RID: 23482
	private readonly Func<DangoAbyssTipsAttributeItem> CreateItem = () => new DangoAbyssTipsAttributeItem();

	// Token: 0x02007FB5 RID: 32693
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029B29 RID: 170793
		LockItem,
		// Token: 0x04029B2A RID: 170794
		BaseAttributeLayout,
		// Token: 0x04029B2B RID: 170795
		BaseAttributeItem,
		// Token: 0x04029B2C RID: 170796
		TagPropVertical,
		// Token: 0x04029B2D RID: 170797
		TagPropItem,
		// Token: 0x04029B2E RID: 170798
		DescItem,
		// Token: 0x04029B2F RID: 170799
		DescText,
		// Token: 0x04029B30 RID: 170800
		ConfirmBtnItem,
		// Token: 0x04029B31 RID: 170801
		InActiveRedItem,
		// Token: 0x04029B32 RID: 170802
		PluginIconItem,
		// Token: 0x04029B33 RID: 170803
		TextName,
		// Token: 0x04029B34 RID: 170804
		IconQuality,
		// Token: 0x04029B35 RID: 170805
		IconMain,
		// Token: 0x04029B36 RID: 170806
		NiagaraQuality,
		// Token: 0x04029B37 RID: 170807
		TextPluginType
	}
}
