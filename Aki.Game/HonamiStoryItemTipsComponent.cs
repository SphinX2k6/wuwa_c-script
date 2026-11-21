using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200136D RID: 4973
public class HonamiStoryItemTipsComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x0600C57F RID: 50559 RVA: 0x003AC4EC File Offset: 0x003AA6EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem))
		};
	}

	// Token: 0x0600C580 RID: 50560 RVA: 0x003AC754 File Offset: 0x003AA954
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetItem(14).SetUIActive(false);
		base.GetItem(15).SetUIActive(false);
		base.GetItem(17).SetUIActive(false);
		base.GetItem(18).SetUIActive(false);
		base.GetItem(20).SetUIActive(false);
		base.GetItem(21).SetUIActive(false);
		base.GetExtendToggle(6).RootUIComp.Get().SetUIActive(false);
		UUIItem item = base.GetItem(24);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(23);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		this.PropertyLayout = new GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData>(base.GetVerticalLayout(9), new Func<HonamiStoryTipsPropertyItem>(this.CreateProp), null, false, true);
		this.SkillLayout = new GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo>(base.GetVerticalLayout(11), new Func<HonamiStoryTipsTextItem>(this.CreateSkill), null, false, true);
		base.GetRootItem().SetPivot(new FVector2D(0.5f, 0.5f));
		base.GetRootItem().SetAnchorOffset(new FVector2D(0f, 0f));
	}

	// Token: 0x0600C581 RID: 50561 RVA: 0x003AC880 File Offset: 0x003AAA80
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x0600C582 RID: 50562 RVA: 0x003AC888 File Offset: 0x003AAA88
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600C583 RID: 50563 RVA: 0x003AC8B8 File Offset: 0x003AAAB8
	public UniTask PlayCloseSequence()
	{
		HonamiStoryItemTipsComponent.<PlayCloseSequence>d__8 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<HonamiStoryItemTipsComponent.<PlayCloseSequence>d__8>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600C584 RID: 50564 RVA: 0x003AC8FC File Offset: 0x003AAAFC
	[NullableContext(1)]
	public void Refresh(ItemTipsData dataFrom)
	{
		TipsHonamiStoryData tipsHonamiStoryData = dataFrom as TipsHonamiStoryData;
		if (tipsHonamiStoryData == null)
		{
			return;
		}
		HonamiStoryItem? honamiStoryItem = HonamiStoryConfig.Instance.GetHonamiStoryItem(tipsHonamiStoryData.ConfigId);
		if (honamiStoryItem == null)
		{
			return;
		}
		string name = honamiStoryItem.Value.Name;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), name, Array.Empty<object>());
		string attributesDescription = honamiStoryItem.Value.AttributesDescription;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), attributesDescription, Array.Empty<object>());
		base.GetItem(7).SetUIActive(false);
		string resourceId = (honamiStoryItem.Value.ItemType == 1) ? "SP_TipsTypeIcon1" : "SP_TipsTypeIcon2";
		UiResourceConfig instance = UiResourceConfig.Instance;
		string text = (instance != null) ? instance.GetResourcePath(resourceId) : null;
		this.SetSpriteByPath(text ?? string.Empty, base.GetSprite(2), false, null, null);
		string text2;
		string textStringId = HonamiStoryDefine.Instance.honamiItemTypeMap.TryGetValue((EHonamiStoryItemType)honamiStoryItem.Value.ItemType, out text2) ? text2 : string.Empty;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
		this.SetSpriteByPath(HonamiStoryConfig.Instance.GetHonamiStoryQuality(honamiStoryItem.Value.QualityId).Value.Bg, base.GetSprite(1), false, null, null);
		UUIText text3 = base.GetText(5);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(honamiStoryItem.Value.SellPrice);
		text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.SetItemIcon(base.GetTexture(22), honamiStoryItem.Value.Id, null, null);
		HonamiStoryItemDataBase itemData = HonamiStoryModel.Instance.GetItemData(tipsHonamiStoryData.IncId);
		if (itemData == null || itemData.GetItemType() == EHonamiStoryItemType.Normal)
		{
			return;
		}
		HonamiStoryEquipItemData honamiStoryEquipItemData = HonamiStoryModel.Instance.GetItemData(tipsHonamiStoryData.IncId) as HonamiStoryEquipItemData;
		if (honamiStoryEquipItemData != null)
		{
			int[] mainPropList = honamiStoryEquipItemData.GetMainPropList();
			List<IHonamiStoryTipsPropertyData> list = new List<IHonamiStoryTipsPropertyData>();
			foreach (int propId in mainPropList)
			{
				list.Add(new HonamiStoryTipsPropertyData
				{
					PropId = propId
				});
			}
			this.PropertyLayout.RefreshByData(list, null, true);
			List<IHonamiStoryTipsBuffInfo> buffTempIdList = honamiStoryEquipItemData.GetBuffTempIdList(false);
			this.SkillLayout.RefreshByData(buffTempIdList, null, true);
		}
	}

	// Token: 0x0600C585 RID: 50565 RVA: 0x003ACB71 File Offset: 0x003AAD71
	[NullableContext(1)]
	private HonamiStoryTipsPropertyItem CreateProp()
	{
		return new HonamiStoryTipsPropertyItem();
	}

	// Token: 0x0600C586 RID: 50566 RVA: 0x003ACB78 File Offset: 0x003AAD78
	[NullableContext(1)]
	private HonamiStoryTipsTextItem CreateSkill()
	{
		return new HonamiStoryTipsTextItem();
	}

	// Token: 0x0400708A RID: 28810
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400708B RID: 28811
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> PropertyLayout;

	// Token: 0x0400708C RID: 28812
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> SkillLayout;

	// Token: 0x02007603 RID: 30211
	private enum EDefine
	{
		// Token: 0x04026518 RID: 156952
		TxtName,
		// Token: 0x04026519 RID: 156953
		SpriteTitleBg,
		// Token: 0x0402651A RID: 156954
		SpriteTypeIcon,
		// Token: 0x0402651B RID: 156955
		TxtType,
		// Token: 0x0402651C RID: 156956
		TexCost,
		// Token: 0x0402651D RID: 156957
		TxtLevel,
		// Token: 0x0402651E RID: 156958
		TogLock,
		// Token: 0x0402651F RID: 156959
		PanelTipsTime,
		// Token: 0x04026520 RID: 156960
		TxtTime,
		// Token: 0x04026521 RID: 156961
		PanelTipsProperty,
		// Token: 0x04026522 RID: 156962
		PanelList,
		// Token: 0x04026523 RID: 156963
		PanelSkill,
		// Token: 0x04026524 RID: 156964
		MainDescItem,
		// Token: 0x04026525 RID: 156965
		TxtDesc,
		// Token: 0x04026526 RID: 156966
		BtnConfirmA,
		// Token: 0x04026527 RID: 156967
		BtnConfirmB,
		// Token: 0x04026528 RID: 156968
		PanelBtnR,
		// Token: 0x04026529 RID: 156969
		BtnRA,
		// Token: 0x0402652A RID: 156970
		BtnRB,
		// Token: 0x0402652B RID: 156971
		PanelBtnL,
		// Token: 0x0402652C RID: 156972
		BtnLA,
		// Token: 0x0402652D RID: 156973
		BtnLB,
		// Token: 0x0402652E RID: 156974
		TexItemIcon,
		// Token: 0x0402652F RID: 156975
		PanelBottom,
		// Token: 0x04026530 RID: 156976
		PanelDoubleClicked,
		// Token: 0x04026531 RID: 156977
		TxtDoubleClicked
	}
}
