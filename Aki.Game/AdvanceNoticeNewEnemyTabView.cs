using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010D4 RID: 4308
public class AdvanceNoticeNewEnemyTabView : AdvanceNoticeTabViewBase
{
	// Token: 0x06007028 RID: 28712 RVA: 0x0016D448 File Offset: 0x0016B648
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

	// Token: 0x06007029 RID: 28713 RVA: 0x0016D63C File Offset: 0x0016B83C
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeNewEnemyTabView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeNewEnemyTabView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600702A RID: 28714 RVA: 0x0016D680 File Offset: 0x0016B880
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

	// Token: 0x0600702B RID: 28715 RVA: 0x0016D6EC File Offset: 0x0016B8EC
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

	// Token: 0x0600702C RID: 28716 RVA: 0x0016D7F0 File Offset: 0x0016B9F0
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

	// Token: 0x0600702D RID: 28717 RVA: 0x0016D970 File Offset: 0x0016BB70
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

	// Token: 0x0600702E RID: 28718 RVA: 0x0016DB28 File Offset: 0x0016BD28
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

	// Token: 0x0600702F RID: 28719 RVA: 0x0016DBB5 File Offset: 0x0016BDB5
	[NullableContext(1)]
	private AdvanceNoticeSuitItem CreateFetterItem()
	{
		return new AdvanceNoticeSuitItem();
	}

	// Token: 0x06007030 RID: 28720 RVA: 0x0016DBBC File Offset: 0x0016BDBC
	[NullableContext(1)]
	private AdvanceNoticeFetterSuitDetailItem CreateFetterSuitDetailItem()
	{
		return new AdvanceNoticeFetterSuitDetailItem();
	}

	// Token: 0x04003415 RID: 13333
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AdvanceNoticeSuitItem, string> VisionFetterLayout;

	// Token: 0x04003416 RID: 13334
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AdvanceNoticeFetterSuitDetailItem, IAdvanceNoticeFetterSuitDetailItemData> FetterSuitDetailLayout;

	// Token: 0x02007698 RID: 30360
	private class EComponentDefine
	{
		// Token: 0x04027224 RID: 160292
		public const int VisionTexture = 0;

		// Token: 0x04027225 RID: 160293
		public const int SubTitleText = 1;

		// Token: 0x04027226 RID: 160294
		public const int TitleText = 2;

		// Token: 0x04027227 RID: 160295
		public const int DescText = 3;

		// Token: 0x04027228 RID: 160296
		public const int ElementRootItem = 4;

		// Token: 0x04027229 RID: 160297
		public const int SuitCoreSprite = 5;

		// Token: 0x0402722A RID: 160298
		public const int SuitCoreBgSprite = 6;

		// Token: 0x0402722B RID: 160299
		public const int SuitOuterBgTexture = 7;

		// Token: 0x0402722C RID: 160300
		public const int SuitOuterEffectTextureA = 8;

		// Token: 0x0402722D RID: 160301
		public const int SuitOuterEffectTextureB = 9;

		// Token: 0x0402722E RID: 160302
		public const int SuitNiagara = 10;

		// Token: 0x0402722F RID: 160303
		public const int ScrollText = 11;

		// Token: 0x04027230 RID: 160304
		public const int TopTitleItem = 12;

		// Token: 0x04027231 RID: 160305
		public const int VisionTitleItem = 13;

		// Token: 0x04027232 RID: 160306
		public const int VisionTitleText = 14;

		// Token: 0x04027233 RID: 160307
		public const int VisionFetterLayout = 15;

		// Token: 0x04027234 RID: 160308
		public const int EnemyTitleItem = 16;

		// Token: 0x04027235 RID: 160309
		public const int EnemyTitleText = 17;

		// Token: 0x04027236 RID: 160310
		public const int FetterSuitLayout = 18;

		// Token: 0x04027237 RID: 160311
		public const int ReminderText = 19;

		// Token: 0x04027238 RID: 160312
		public const int DescScrollView = 20;
	}
}
