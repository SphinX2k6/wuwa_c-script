using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200103E RID: 4158
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardItem : GridProxyAbstract<int>
{
	// Token: 0x0600A58A RID: 42378 RVA: 0x0030B284 File Offset: 0x00309484
	protected unsafe override void OnRegisterComponent()
	{
		int num = 25;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A58B RID: 42379 RVA: 0x0030B632 File Offset: 0x00309832
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		this.RegisterTermView();
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600A58C RID: 42380 RVA: 0x0030B668 File Offset: 0x00309868
	protected override void OnBeforeDestroy()
	{
		this.UnRegisterTermView();
	}

	// Token: 0x0600A58D RID: 42381 RVA: 0x0030B670 File Offset: 0x00309870
	public void SetActivityDataType(EFloroRanchActivityDataType activityDataType)
	{
		this.ActivityDataType = new EFloroRanchActivityDataType?(activityDataType);
	}

	// Token: 0x0600A58E RID: 42382 RVA: 0x0030B67E File Offset: 0x0030987E
	private FloroRanchActivityData GetActivityDataForUnlock()
	{
		return FloroRanchModel.Instance.GetActivityData(this.ActivityDataType.GetValueOrDefault(), true);
	}

	// Token: 0x0600A58F RID: 42383 RVA: 0x0030B698 File Offset: 0x00309898
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		base.GetItem(19).SetAlpha(0f);
		this.CardId = data;
		if (this.CardType == EFloroRanchCardType.Phantom)
		{
			this.RefreshPhantomCardData();
		}
		else
		{
			this.RefreshToyCardData();
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.CardData.GetName(), Array.Empty<object>());
		base.GetText(13).SetText(this.CardData.Desc, true);
		base.GetText(13).bBestFit = false;
		FloroRanchRarityData floroRanchRarity = FloroRanchModel.Instance.GetFloroRanchRarity(this.CardData.GetRarity());
		UUITexture texture = base.GetTexture(5);
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
		base.SetTextureShowUntilLoaded(this.CardData.GetIcon(), base.GetTexture(5), null);
		base.SetTextureShowUntilLoaded(this.CardData.GetIcon(), base.GetTexture(18), null);
		base.SetTextureShowUntilLoaded(floroRanchRarity.GetRarityDetailCardBigBg(), base.GetTexture(1), null);
		base.SetTextureShowUntilLoaded(floroRanchRarity.GetRarityDetailCardSmallBg(), base.GetTexture(2), null);
		base.SetTextureShowUntilLoaded(floroRanchRarity.GetSelectTexture(), base.GetTexture(16), null);
		bool flag = floroRanchRarity.IsGoldRarity();
		UUITexture texture2 = base.GetTexture(20);
		if (texture2 != null)
		{
			texture2.SetUIActive(false);
		}
		UUITexture texture3 = base.GetTexture(21);
		if (texture3 != null)
		{
			texture3.SetUIActive(flag || floroRanchRarity.IsSpecialRarity());
		}
		UUITexture texture4 = base.GetTexture(1);
		if (texture4 != null)
		{
			texture4.SetIsGray(false);
		}
		UUITexture texture5 = base.GetTexture(2);
		if (texture5 != null)
		{
			texture5.SetIsGray(false);
		}
		FloroRanchCurrencyConfigData floroRanchCurrencyConfig = FloroRanchModel.Instance.GetFloroRanchCurrencyConfig(ECurrencyType.Salary);
		base.SetTextureShowUntilLoaded(floroRanchCurrencyConfig.GetIcon(), base.GetTexture(11), null);
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		FloroRanchActivityData activityDataForUnlock = this.GetActivityDataForUnlock();
		this.UnlockConditionText = ((this.CardType == EFloroRanchCardType.Phantom) ? activityDataForUnlock.GetCardConditionText(this.CardId) : activityDataForUnlock.GetToyConditionText(this.CardId));
		this.RefreshRecommendSprite();
	}

	// Token: 0x0600A590 RID: 42384 RVA: 0x0030B880 File Offset: 0x00309A80
	public void RefreshPhantomCardData()
	{
		FloroRanchActivityData activityDataForUnlock = this.GetActivityDataForUnlock();
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		FloroRanchCardData floroRanchCardData = FloroRanchModel.Instance.GetFloroRanchCardData(this.CardId);
		this.CardData = floroRanchCardData;
		UUIText text = base.GetText(12);
		if (text != null)
		{
			text.SetText(floroRanchCardData.GetBasicSalary().ToString(), true);
		}
		FloroRanchRaceData floroRanchRaceData = FloroRanchModel.Instance.GetFloroRanchRaceData(floroRanchCardData.GetRace());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), floroRanchRaceData.GetRaceName(), Array.Empty<object>());
		base.SetTextureShowUntilLoaded(floroRanchRaceData.SmallIcon, base.GetTexture(8), null);
		UUIItem item3 = base.GetItem(14);
		if (item3 != null)
		{
			item3.SetUIActive(floroRanchCardData.IsSpecialPhantom);
		}
		UUIItem item4 = base.GetItem(15);
		if (item4 != null)
		{
			item4.SetUIActive(activityDataForUnlock.IsCardHasNewLabel(this.CardId));
		}
		UUIText text2 = base.GetText(6);
		if (text2 != null)
		{
			text2.ShowTextNew("Farm_CardType1");
		}
		UUIItem item5 = base.GetItem(22);
		if (item5 == null)
		{
			return;
		}
		item5.SetUIActive(false);
	}

	// Token: 0x0600A591 RID: 42385 RVA: 0x0030B99C File Offset: 0x00309B9C
	public void RefreshToyCardData()
	{
		FloroRanchToyData floroRanchToyData = FloroRanchModel.Instance.GetFloroRanchToyData(this.CardId);
		this.CardData = floroRanchToyData;
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(14);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(15);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.ShowTextNew("Farm_CardType2");
		}
		UUIItem item5 = base.GetItem(22);
		if (item5 != null)
		{
			item5.SetUIActive(true);
		}
		FloroRanchRaceData toyRaceData = floroRanchToyData.GetToyRaceData();
		if (toyRaceData != null)
		{
			UUIItem item6 = base.GetItem(22);
			if (item6 != null)
			{
				item6.SetUIActive(true);
			}
			base.SetTextureShowUntilLoaded(toyRaceData.SmallIcon, base.GetTexture(23), null);
			return;
		}
		UUIItem item7 = base.GetItem(22);
		if (item7 == null)
		{
			return;
		}
		item7.SetUIActive(false);
	}

	// Token: 0x0600A592 RID: 42386 RVA: 0x0030BA82 File Offset: 0x00309C82
	public void HideNewLabel()
	{
		UUIItem item = base.GetItem(15);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600A593 RID: 42387 RVA: 0x0030BA98 File Offset: 0x00309C98
	public void SetLock()
	{
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText("??", true);
		}
		UUIText text2 = base.GetText(12);
		if (text2 != null)
		{
			text2.SetText("+?", true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), this.UnlockConditionText, Array.Empty<object>());
		base.GetText(13).bBestFit = false;
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUITexture texture = base.GetTexture(5);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		this.RefreshRecommendSprite();
	}

	// Token: 0x0600A594 RID: 42388 RVA: 0x0030BB30 File Offset: 0x00309D30
	private void RefreshRecommendSprite()
	{
		FloroRanchActivityData activityDataForUnlock = this.GetActivityDataForUnlock();
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		bool flag = activityDataForUnlock.IsSubDungeonRecommendItem(subInstanceId, this.CardId, this.CardType);
		UUISprite sprite = base.GetSprite(24);
		if (!flag)
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			return;
		}
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
	}

	// Token: 0x0600A595 RID: 42389 RVA: 0x0030BB80 File Offset: 0x00309D80
	public void SetInteractive(bool interactiveEnable)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(interactiveEnable);
	}

	// Token: 0x0600A596 RID: 42390 RVA: 0x0030BB94 File Offset: 0x00309D94
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.CardId);
		}
	}

	// Token: 0x0600A597 RID: 42391 RVA: 0x0030BBB5 File Offset: 0x00309DB5
	public void SetToggleCallBack(Action<int, int> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600A598 RID: 42392 RVA: 0x0030BBBE File Offset: 0x00309DBE
	public void SetCanToggleExecuteFunction(Func<int, bool> canExecuteFunction)
	{
		this.OnCanExecuteChangeCallBack = canExecuteFunction;
	}

	// Token: 0x0600A599 RID: 42393 RVA: 0x0030BBC7 File Offset: 0x00309DC7
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600A59A RID: 42394 RVA: 0x0030BBD0 File Offset: 0x00309DD0
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600A59B RID: 42395 RVA: 0x0030BBD9 File Offset: 0x00309DD9
	public void SetToggleState(bool isSelect)
	{
		base.GetExtendToggle(0).SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A59C RID: 42396 RVA: 0x0030BBF4 File Offset: 0x00309DF4
	private void RegisterTermView()
	{
		ETermExplanationViewType etermExplanationViewType = (this.OverrideTermViewType != ETermExplanationViewType.Center) ? this.OverrideTermViewType : ETermExplanationViewType.Center;
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(13),
			ViewType = etermExplanationViewType,
			ReportType = ETermExplanationReportType.FloroRanch,
			AttachDirection = ((etermExplanationViewType == ETermExplanationViewType.Side) ? new ETermExplanationViewAttachDirection?(ETermExplanationViewAttachDirection.Left) : null),
			AttachItem = base.GetRootItem(),
			Group = new ETermExplanationGroup?(ETermExplanationGroup.FloroRanchCard),
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch)
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600A59D RID: 42397 RVA: 0x0030BC80 File Offset: 0x00309E80
	private void UnRegisterTermView()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(13));
	}

	// Token: 0x0600A59E RID: 42398 RVA: 0x0030BC94 File Offset: 0x00309E94
	private bool OnCanExecuteChange()
	{
		return this.OnCanExecuteChangeCallBack == null || this.OnCanExecuteChangeCallBack(base.GridIndex);
	}

	// Token: 0x0600A59F RID: 42399 RVA: 0x0030BCB4 File Offset: 0x00309EB4
	public void PlayAppearAnim()
	{
		FloroRanchRarityData floroRanchRarity = FloroRanchModel.Instance.GetFloroRanchRarity(this.CardData.GetRarity());
		if (floroRanchRarity.IsGoldRarity() || floroRanchRarity.IsSpecialRarity())
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("GoldCard", false, null, false);
			return;
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600A5A0 RID: 42400 RVA: 0x0030BD1E File Offset: 0x00309F1E
	public void StopAppearAnim()
	{
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		base.GetItem(19).SetAlpha(0f);
	}

	// Token: 0x0600A5A1 RID: 42401 RVA: 0x0030BD3F File Offset: 0x00309F3F
	public void SetItemAlpha(float alpha)
	{
		base.GetItem(19).SetAlpha(alpha);
	}

	// Token: 0x040060EC RID: 24812
	private int CardId;

	// Token: 0x040060ED RID: 24813
	private EFloroRanchActivityDataType? ActivityDataType;

	// Token: 0x040060EE RID: 24814
	public EFloroRanchCardType CardType;

	// Token: 0x040060EF RID: 24815
	public IFloroRanchCardOrToyData CardData;

	// Token: 0x040060F0 RID: 24816
	public string UnlockConditionText = "";

	// Token: 0x040060F1 RID: 24817
	public ETermExplanationViewType OverrideTermViewType;

	// Token: 0x040060F2 RID: 24818
	[Nullable(2)]
	protected Action<int, int> OnToggleCallBack;

	// Token: 0x040060F3 RID: 24819
	[Nullable(2)]
	private Func<int, bool> OnCanExecuteChangeCallBack;

	// Token: 0x040060F4 RID: 24820
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007291 RID: 29329
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040254D9 RID: 152793
		public const int ToggleRoot = 0;

		// Token: 0x040254DA RID: 152794
		public const int TextureQualityA = 1;

		// Token: 0x040254DB RID: 152795
		public const int TextureQualityB = 2;

		// Token: 0x040254DC RID: 152796
		public const int TextName = 3;

		// Token: 0x040254DD RID: 152797
		public const int TextureIconBg = 4;

		// Token: 0x040254DE RID: 152798
		public const int TextureIcon = 5;

		// Token: 0x040254DF RID: 152799
		public const int TextTypeName = 6;

		// Token: 0x040254E0 RID: 152800
		public const int ItemRacePanel = 7;

		// Token: 0x040254E1 RID: 152801
		public const int TextureRaceIcon = 8;

		// Token: 0x040254E2 RID: 152802
		public const int TextRaceName = 9;

		// Token: 0x040254E3 RID: 152803
		public const int ItemIncomePanel = 10;

		// Token: 0x040254E4 RID: 152804
		public const int TextureIncomeIcon = 11;

		// Token: 0x040254E5 RID: 152805
		public const int TextIncomeNum = 12;

		// Token: 0x040254E6 RID: 152806
		public const int TextDescription = 13;

		// Token: 0x040254E7 RID: 152807
		public const int ItemPhantomIcon = 14;

		// Token: 0x040254E8 RID: 152808
		public const int ItemNew = 15;

		// Token: 0x040254E9 RID: 152809
		public const int TextureSelect = 16;

		// Token: 0x040254EA RID: 152810
		public const int ItemUnknownPanel = 17;

		// Token: 0x040254EB RID: 152811
		public const int TextureIconMask = 18;

		// Token: 0x040254EC RID: 152812
		public const int CardItemRoot = 19;

		// Token: 0x040254ED RID: 152813
		public const int GoldCardQualityTexture = 20;

		// Token: 0x040254EE RID: 152814
		public const int GoldCardQualityTextureB = 21;

		// Token: 0x040254EF RID: 152815
		public const int ItemToyRaceType = 22;

		// Token: 0x040254F0 RID: 152816
		public const int TextureToyRaceIcon = 23;

		// Token: 0x040254F1 RID: 152817
		public const int RecommendSprite = 24;
	}
}
