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

// Token: 0x02001EAB RID: 7851
public class HonamiStoryItemTipsComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x0600F160 RID: 61792 RVA: 0x003A09E4 File Offset: 0x0039EBE4
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

	// Token: 0x0600F161 RID: 61793 RVA: 0x003A0C4C File Offset: 0x0039EE4C
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

	// Token: 0x0600F162 RID: 61794 RVA: 0x003A0D78 File Offset: 0x0039EF78
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x0600F163 RID: 61795 RVA: 0x003A0D80 File Offset: 0x0039EF80
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600F164 RID: 61796 RVA: 0x003A0DB0 File Offset: 0x0039EFB0
	public UniTask PlayCloseSequence()
	{
		HonamiStoryItemTipsComponent.<PlayCloseSequence>d__8 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<HonamiStoryItemTipsComponent.<PlayCloseSequence>d__8>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600F165 RID: 61797 RVA: 0x003A0DF4 File Offset: 0x0039EFF4
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

	// Token: 0x0600F166 RID: 61798 RVA: 0x003A1069 File Offset: 0x0039F269
	[NullableContext(1)]
	private HonamiStoryTipsPropertyItem CreateProp()
	{
		return new HonamiStoryTipsPropertyItem();
	}

	// Token: 0x0600F167 RID: 61799 RVA: 0x003A1070 File Offset: 0x0039F270
	[NullableContext(1)]
	private HonamiStoryTipsTextItem CreateSkill()
	{
		return new HonamiStoryTipsTextItem();
	}

	// Token: 0x04006FA9 RID: 28585
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006FAA RID: 28586
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> PropertyLayout;

	// Token: 0x04006FAB RID: 28587
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> SkillLayout;

	// Token: 0x0200847E RID: 33918
	private enum EDefine
	{
		// Token: 0x0402B1F4 RID: 176628
		TxtName,
		// Token: 0x0402B1F5 RID: 176629
		SpriteTitleBg,
		// Token: 0x0402B1F6 RID: 176630
		SpriteTypeIcon,
		// Token: 0x0402B1F7 RID: 176631
		TxtType,
		// Token: 0x0402B1F8 RID: 176632
		TexCost,
		// Token: 0x0402B1F9 RID: 176633
		TxtLevel,
		// Token: 0x0402B1FA RID: 176634
		TogLock,
		// Token: 0x0402B1FB RID: 176635
		PanelTipsTime,
		// Token: 0x0402B1FC RID: 176636
		TxtTime,
		// Token: 0x0402B1FD RID: 176637
		PanelTipsProperty,
		// Token: 0x0402B1FE RID: 176638
		PanelList,
		// Token: 0x0402B1FF RID: 176639
		PanelSkill,
		// Token: 0x0402B200 RID: 176640
		MainDescItem,
		// Token: 0x0402B201 RID: 176641
		TxtDesc,
		// Token: 0x0402B202 RID: 176642
		BtnConfirmA,
		// Token: 0x0402B203 RID: 176643
		BtnConfirmB,
		// Token: 0x0402B204 RID: 176644
		PanelBtnR,
		// Token: 0x0402B205 RID: 176645
		BtnRA,
		// Token: 0x0402B206 RID: 176646
		BtnRB,
		// Token: 0x0402B207 RID: 176647
		PanelBtnL,
		// Token: 0x0402B208 RID: 176648
		BtnLA,
		// Token: 0x0402B209 RID: 176649
		BtnLB,
		// Token: 0x0402B20A RID: 176650
		TexItemIcon,
		// Token: 0x0402B20B RID: 176651
		PanelBottom,
		// Token: 0x0402B20C RID: 176652
		PanelDoubleClicked,
		// Token: 0x0402B20D RID: 176653
		TxtDoubleClicked
	}
}
