using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000588 RID: 1416
public class AdvanceNoticeNewEnemyTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x060043BE RID: 17342 RVA: 0x00175E04 File Offset: 0x00174004
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUINiagara)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x00175FF8 File Offset: 0x001741F8
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeNewEnemyTabView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeNewEnemyTabView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060043C0 RID: 17344 RVA: 0x0017603C File Offset: 0x0017423C
	protected override void RefreshView()
	{
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		switch (AdvanceNoticeConfig.Instance.GetAdvertisingTabEnemyById(currentSubTabId).Type)
		{
		case 1:
			this.RefreshEnemyView();
			break;
		case 2:
			this.RefreshVisionView();
			break;
		case 3:
			this.RefreshFetterView();
			break;
		}
		base.GetScrollViewWithScrollbar(20).SetScrollProgress(0f);
	}

	// Token: 0x060043C1 RID: 17345 RVA: 0x001760A8 File Offset: 0x001742A8
	protected void RefreshEnemyView()
	{
		base.GetItem(4).SetUIActive(false);
		base.GetTexture(0).SetUIActive(true);
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabEnemy advertisingTabEnemyById = AdvanceNoticeConfig.Instance.GetAdvertisingTabEnemyById(currentSubTabId);
		base.SetTextureByPath(advertisingTabEnemyById.MainPic, base.GetTexture(0), null, null);
		this.SetLeftText(advertisingTabEnemyById);
		base.GetItem(12).SetUIActive(true);
		base.GetText(11).SetUIActive(true);
		base.GetItem(13).SetUIActive(false);
		base.GetItem(16).SetUIActive(true);
		base.GetLayoutBase(18).RootUIComp.Get().SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), advertisingTabEnemyById.EnemyDescription, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "AdvertisingEnemy_Description", Array.Empty<object>());
		UUIText text = base.GetText(19);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(true);
	}

	// Token: 0x060043C2 RID: 17346 RVA: 0x001761AC File Offset: 0x001743AC
	protected void RefreshVisionView()
	{
		base.GetItem(4).SetUIActive(false);
		base.GetTexture(0).SetUIActive(true);
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabEnemy advertisingTabEnemyById = AdvanceNoticeConfig.Instance.GetAdvertisingTabEnemyById(currentSubTabId);
		base.SetTextureByPath(advertisingTabEnemyById.MainPic, base.GetTexture(0), null, null);
		this.SetLeftText(advertisingTabEnemyById);
		List<string> list = new List<string>();
		foreach (string item in advertisingTabEnemyById.VisionFetterIconListIter())
		{
			list.Add(item);
		}
		this.VisionFetterLayout.RefreshByData(list, null, false);
		base.GetItem(12).SetUIActive(true);
		base.GetText(11).SetUIActive(true);
		base.GetItem(13).SetUIActive(true);
		base.GetItem(16).SetUIActive(true);
		base.GetLayoutBase(18).RootUIComp.Get().SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), advertisingTabEnemyById.VisionDescription, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "AdvertisingEnemy_Fetter", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "AdvertisingEnemy_Skill", Array.Empty<object>());
		UUIText text = base.GetText(19);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(true);
	}

	// Token: 0x060043C3 RID: 17347 RVA: 0x0017632C File Offset: 0x0017452C
	protected void RefreshFetterView()
	{
		base.GetItem(4).SetUIActive(true);
		base.GetTexture(0).SetUIActive(false);
		int currentSubTabId = this.ViewModel.CurrentSubTabId;
		AdvertisingTabEnemy advertisingTabEnemyById = AdvanceNoticeConfig.Instance.GetAdvertisingTabEnemyById(currentSubTabId);
		this.SetLeftText(advertisingTabEnemyById);
		this.SetSpriteByPath(advertisingTabEnemyById.SuitCoreSprite, base.GetSprite(5), false, null, null);
		this.SetSpriteByPath(advertisingTabEnemyById.SuitCoreBgSprite, base.GetSprite(6), false, null, null);
		base.SetTextureByPath(advertisingTabEnemyById.SuitOuterBgTexture, base.GetTexture(7), null, null);
		FColor fcolor = FColor.FromHex(advertisingTabEnemyById.SuitNiagaraColor);
		FLinearColor value = new FLinearColor(ref fcolor);
		base.GetUiNiagara(10).SetNiagaraVarLinearColor("Color", value);
		Dictionary<int, string> dictionary = advertisingTabEnemyById.VisionEffectMap();
		List<IAdvanceNoticeFetterSuitDetailItemData> list = new List<IAdvanceNoticeFetterSuitDetailItemData>();
		foreach (KeyValuePair<int, string> keyValuePair in dictionary)
		{
			AdvanceNoticeFetterSuitDetailItemData item = new AdvanceNoticeFetterSuitDetailItemData
			{
				TitleTextData = new TableTextArgNew("AdvertisingEnemy_FetterTitle", new <>z__ReadOnlySingleElementList<object>(keyValuePair.Key)),
				DescTextData = new TableTextArgNew(keyValuePair.Value, Array.Empty<object>())
			};
			list.Add(item);
		}
		this.FetterSuitDetailLayout.RefreshByData(list, null, false);
		base.GetItem(12).SetUIActive(false);
		base.GetText(11).SetUIActive(false);
		base.GetLayoutBase(18).RootUIComp.Get().SetUIActive(true);
		UUIText text = base.GetText(19);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x060043C4 RID: 17348 RVA: 0x001764E4 File Offset: 0x001746E4
	private void SetLeftText(AdvertisingTabEnemy config)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Title, Array.Empty<object>());
		if (StringUtils.IsEmpty(config.Description))
		{
			base.GetText(3).SetUIActive(false);
			return;
		}
		base.GetText(3).SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), config.Description, Array.Empty<object>());
	}

	// Token: 0x060043C5 RID: 17349 RVA: 0x00176571 File Offset: 0x00174771
	[NullableContext(1)]
	private AdvanceNoticeSuitItem CreateFetterItem()
	{
		return new AdvanceNoticeSuitItem();
	}

	// Token: 0x060043C6 RID: 17350 RVA: 0x00176578 File Offset: 0x00174778
	[NullableContext(1)]
	private AdvanceNoticeFetterSuitDetailItem CreateFetterSuitDetailItem()
	{
		return new AdvanceNoticeFetterSuitDetailItem();
	}

	// Token: 0x040034AE RID: 13486
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AdvanceNoticeSuitItem, string> VisionFetterLayout;

	// Token: 0x040034AF RID: 13487
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AdvanceNoticeFetterSuitDetailItem, IAdvanceNoticeFetterSuitDetailItemData> FetterSuitDetailLayout;

	// Token: 0x0200682C RID: 26668
	private class EComponentDefine
	{
		// Token: 0x0402256D RID: 140653
		public const int VisionTexture = 0;

		// Token: 0x0402256E RID: 140654
		public const int SubTitleText = 1;

		// Token: 0x0402256F RID: 140655
		public const int TitleText = 2;

		// Token: 0x04022570 RID: 140656
		public const int DescText = 3;

		// Token: 0x04022571 RID: 140657
		public const int ElementRootItem = 4;

		// Token: 0x04022572 RID: 140658
		public const int SuitCoreSprite = 5;

		// Token: 0x04022573 RID: 140659
		public const int SuitCoreBgSprite = 6;

		// Token: 0x04022574 RID: 140660
		public const int SuitOuterBgTexture = 7;

		// Token: 0x04022575 RID: 140661
		public const int SuitOuterEffectTextureA = 8;

		// Token: 0x04022576 RID: 140662
		public const int SuitOuterEffectTextureB = 9;

		// Token: 0x04022577 RID: 140663
		public const int SuitNiagara = 10;

		// Token: 0x04022578 RID: 140664
		public const int ScrollText = 11;

		// Token: 0x04022579 RID: 140665
		public const int TopTitleItem = 12;

		// Token: 0x0402257A RID: 140666
		public const int VisionTitleItem = 13;

		// Token: 0x0402257B RID: 140667
		public const int VisionTitleText = 14;

		// Token: 0x0402257C RID: 140668
		public const int VisionFetterLayout = 15;

		// Token: 0x0402257D RID: 140669
		public const int EnemyTitleItem = 16;

		// Token: 0x0402257E RID: 140670
		public const int EnemyTitleText = 17;

		// Token: 0x0402257F RID: 140671
		public const int FetterSuitLayout = 18;

		// Token: 0x04022580 RID: 140672
		public const int ReminderText = 19;

		// Token: 0x04022581 RID: 140673
		public const int DescScrollView = 20;
	}
}
