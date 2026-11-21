using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F29 RID: 3881
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsAbyssDangoComponent : TipsBaseSubComponent
{
	// Token: 0x06009B26 RID: 39718 RVA: 0x002E0070 File Offset: 0x002DE270
	public ItemTipsAbyssDangoComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsChipInfo", rootUiItem, false);
	}

	// Token: 0x06009B27 RID: 39719 RVA: 0x002E00DC File Offset: 0x002DE2DC
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

	// Token: 0x06009B28 RID: 39720 RVA: 0x002E02F9 File Offset: 0x002DE4F9
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x06009B29 RID: 39721 RVA: 0x002E0317 File Offset: 0x002DE517
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x06009B2A RID: 39722 RVA: 0x002E0335 File Offset: 0x002DE535
	private void RefreshFuncState(int _)
	{
		this.RefreshView(this.CurrentData);
	}

	// Token: 0x06009B2B RID: 39723 RVA: 0x002E0344 File Offset: 0x002DE544
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsAbyssDangoComponent.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsAbyssDangoComponent.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009B2C RID: 39724 RVA: 0x002E0388 File Offset: 0x002DE588
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<DangoAbyssTipsAttributeItem, AttrListScrollData>(base.GetVerticalLayout(1), this.CreateItem, base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		this.TagScroller = new GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetVerticalLayout(3), this.CreateTagItem, base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06009B2D RID: 39725 RVA: 0x002E03EC File Offset: 0x002DE5EC
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

	// Token: 0x06009B2E RID: 39726 RVA: 0x002E0440 File Offset: 0x002DE640
	private void RefreshView(TipsAbyssDangoData data)
	{
		this.CurrentData = data;
		AttrListScrollData[] pluginShowAttributeList = DangoAbyssModel.Instance.GetPluginShowAttributeList(data.ConfigId);
		this.RefreshAttribute(pluginShowAttributeList);
		DangoAbyssDefine.DangoAbyssTagData[] pluginShowTagDataList = DangoAbyssModel.Instance.GetPluginShowTagDataList(data.ConfigId);
		this.RefreshTag(pluginShowTagDataList);
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

	// Token: 0x06009B2F RID: 39727 RVA: 0x002E04DC File Offset: 0x002DE6DC
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

	// Token: 0x06009B30 RID: 39728 RVA: 0x002E0580 File Offset: 0x002DE780
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

	// Token: 0x06009B31 RID: 39729 RVA: 0x002E05B0 File Offset: 0x002DE7B0
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

	// Token: 0x06009B32 RID: 39730 RVA: 0x002E0648 File Offset: 0x002DE848
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

	// Token: 0x06009B33 RID: 39731 RVA: 0x002E0720 File Offset: 0x002DE920
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

	// Token: 0x06009B34 RID: 39732 RVA: 0x002E07E2 File Offset: 0x002DE9E2
	private void RefreshAttribute(IReadOnlyList<AttrListScrollData> data)
	{
		this.AttributeScroller.RefreshByData(data, null, false);
	}

	// Token: 0x06009B35 RID: 39733 RVA: 0x002E07F2 File Offset: 0x002DE9F2
	private void RefreshTag(IReadOnlyList<DangoAbyssDefine.DangoAbyssTagData> data)
	{
		this.TagScroller.RefreshByData(data, null, false);
	}

	// Token: 0x06009B36 RID: 39734 RVA: 0x002E0804 File Offset: 0x002DEA04
	private void RefreshName(TipsAbyssDangoData data)
	{
		UUIText text = base.GetText(10);
		FColor color = FColor.FromHex(DangoAbyssConfig.Instance.GetAbyssQualityByPluginItemId(data.ConfigId).Value.DropColor);
		text.SetColor(color);
		LguiUtil.Instance.SetLocalTextNew(text, data.Title, Array.Empty<object>());
	}

	// Token: 0x06009B37 RID: 39735 RVA: 0x002E0860 File Offset: 0x002DEA60
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

	// Token: 0x06009B38 RID: 39736 RVA: 0x002E08D4 File Offset: 0x002DEAD4
	private void RefreshType(TipsAbyssDangoData data)
	{
		int slotType = DangoAbyssConfig.Instance.GetDangoItemById(data.ConfigId).Value.SlotType;
		string textStringId;
		if (DangoAbyssDefine.textPluginType.TryGetValue((DangoAbyssDefine.ESlotType)slotType, out textStringId))
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(14), textStringId, Array.Empty<object>());
		}
	}

	// Token: 0x06009B39 RID: 39737 RVA: 0x002E092C File Offset: 0x002DEB2C
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

	// Token: 0x06009B3A RID: 39738 RVA: 0x002E0978 File Offset: 0x002DEB78
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

	// Token: 0x06009B3B RID: 39739 RVA: 0x002E09F8 File Offset: 0x002DEBF8
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

	// Token: 0x04005C80 RID: 23680
	[Nullable(2)]
	private TipsAbyssDangoData CurrentData;

	// Token: 0x04005C81 RID: 23681
	[Nullable(2)]
	private InActiveRedItem InActiveRedItem;

	// Token: 0x04005C82 RID: 23682
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04005C83 RID: 23683
	[Nullable(2)]
	private MediumItemGridDangoPluginIconComponent PluginIconItem;

	// Token: 0x04005C84 RID: 23684
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssTipsAttributeItem, AttrListScrollData> AttributeScroller;

	// Token: 0x04005C85 RID: 23685
	[Nullable(2)]
	private TipsLockButton TipsLockButton;

	// Token: 0x04005C86 RID: 23686
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;

	// Token: 0x04005C87 RID: 23687
	private DangoAbyssDefine.EAbyssItemTipsState StateConfirm;

	// Token: 0x04005C88 RID: 23688
	private readonly Func<DangoAbyssTagItem> CreateTagItem = () => new DangoAbyssTagItem
	{
		GetValueByTips = true
	};

	// Token: 0x04005C89 RID: 23689
	private readonly Func<DangoAbyssTipsAttributeItem> CreateItem = () => new DangoAbyssTipsAttributeItem();

	// Token: 0x02007144 RID: 28996
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024E66 RID: 151142
		LockItem,
		// Token: 0x04024E67 RID: 151143
		BaseAttributeLayout,
		// Token: 0x04024E68 RID: 151144
		BaseAttributeItem,
		// Token: 0x04024E69 RID: 151145
		TagPropVertical,
		// Token: 0x04024E6A RID: 151146
		TagPropItem,
		// Token: 0x04024E6B RID: 151147
		DescItem,
		// Token: 0x04024E6C RID: 151148
		DescText,
		// Token: 0x04024E6D RID: 151149
		ConfirmBtnItem,
		// Token: 0x04024E6E RID: 151150
		InActiveRedItem,
		// Token: 0x04024E6F RID: 151151
		PluginIconItem,
		// Token: 0x04024E70 RID: 151152
		TextName,
		// Token: 0x04024E71 RID: 151153
		IconQuality,
		// Token: 0x04024E72 RID: 151154
		IconMain,
		// Token: 0x04024E73 RID: 151155
		NiagaraQuality,
		// Token: 0x04024E74 RID: 151156
		TextPluginType
	}
}
