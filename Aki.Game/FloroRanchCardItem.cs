using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B7F RID: 7039
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardItem : GridProxyAbstract<int>
{
	// Token: 0x0600D179 RID: 53625 RVA: 0x003001AC File Offset: 0x002FE3AC
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

	// Token: 0x0600D17A RID: 53626 RVA: 0x0030055A File Offset: 0x002FE75A
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		this.RegisterTermView();
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600D17B RID: 53627 RVA: 0x00300590 File Offset: 0x002FE790
	protected override void OnBeforeDestroy()
	{
		this.UnRegisterTermView();
	}

	// Token: 0x0600D17C RID: 53628 RVA: 0x00300598 File Offset: 0x002FE798
	public void SetActivityDataType(EFloroRanchActivityDataType activityDataType)
	{
		this.ActivityDataType = new EFloroRanchActivityDataType?(activityDataType);
	}

	// Token: 0x0600D17D RID: 53629 RVA: 0x003005A6 File Offset: 0x002FE7A6
	private FloroRanchActivityData GetActivityDataForUnlock()
	{
		return FloroRanchModel.Instance.GetActivityData(this.ActivityDataType.GetValueOrDefault(), true);
	}

	// Token: 0x0600D17E RID: 53630 RVA: 0x003005C0 File Offset: 0x002FE7C0
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

	// Token: 0x0600D17F RID: 53631 RVA: 0x003007A8 File Offset: 0x002FE9A8
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

	// Token: 0x0600D180 RID: 53632 RVA: 0x003008C4 File Offset: 0x002FEAC4
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

	// Token: 0x0600D181 RID: 53633 RVA: 0x003009AA File Offset: 0x002FEBAA
	public void HideNewLabel()
	{
		UUIItem item = base.GetItem(15);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600D182 RID: 53634 RVA: 0x003009C0 File Offset: 0x002FEBC0
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

	// Token: 0x0600D183 RID: 53635 RVA: 0x00300A58 File Offset: 0x002FEC58
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

	// Token: 0x0600D184 RID: 53636 RVA: 0x00300AA8 File Offset: 0x002FECA8
	public void SetInteractive(bool interactiveEnable)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(interactiveEnable);
	}

	// Token: 0x0600D185 RID: 53637 RVA: 0x00300ABC File Offset: 0x002FECBC
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.CardId);
		}
	}

	// Token: 0x0600D186 RID: 53638 RVA: 0x00300ADD File Offset: 0x002FECDD
	public void SetToggleCallBack(Action<int, int> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600D187 RID: 53639 RVA: 0x00300AE6 File Offset: 0x002FECE6
	public void SetCanToggleExecuteFunction(Func<int, bool> canExecuteFunction)
	{
		this.OnCanExecuteChangeCallBack = canExecuteFunction;
	}

	// Token: 0x0600D188 RID: 53640 RVA: 0x00300AEF File Offset: 0x002FECEF
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600D189 RID: 53641 RVA: 0x00300AF8 File Offset: 0x002FECF8
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600D18A RID: 53642 RVA: 0x00300B01 File Offset: 0x002FED01
	public void SetToggleState(bool isSelect)
	{
		base.GetExtendToggle(0).SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600D18B RID: 53643 RVA: 0x00300B1C File Offset: 0x002FED1C
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

	// Token: 0x0600D18C RID: 53644 RVA: 0x00300BA8 File Offset: 0x002FEDA8
	private void UnRegisterTermView()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(13));
	}

	// Token: 0x0600D18D RID: 53645 RVA: 0x00300BBC File Offset: 0x002FEDBC
	private bool OnCanExecuteChange()
	{
		return this.OnCanExecuteChangeCallBack == null || this.OnCanExecuteChangeCallBack(base.GridIndex);
	}

	// Token: 0x0600D18E RID: 53646 RVA: 0x00300BDC File Offset: 0x002FEDDC
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

	// Token: 0x0600D18F RID: 53647 RVA: 0x00300C46 File Offset: 0x002FEE46
	public void StopAppearAnim()
	{
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		base.GetItem(19).SetAlpha(0f);
	}

	// Token: 0x0600D190 RID: 53648 RVA: 0x00300C67 File Offset: 0x002FEE67
	public void SetItemAlpha(float alpha)
	{
		base.GetItem(19).SetAlpha(alpha);
	}

	// Token: 0x0400601D RID: 24605
	private int CardId;

	// Token: 0x0400601E RID: 24606
	private EFloroRanchActivityDataType? ActivityDataType;

	// Token: 0x0400601F RID: 24607
	public EFloroRanchCardType CardType;

	// Token: 0x04006020 RID: 24608
	public IFloroRanchCardOrToyData CardData;

	// Token: 0x04006021 RID: 24609
	public string UnlockConditionText = "";

	// Token: 0x04006022 RID: 24610
	public ETermExplanationViewType OverrideTermViewType;

	// Token: 0x04006023 RID: 24611
	[Nullable(2)]
	protected Action<int, int> OnToggleCallBack;

	// Token: 0x04006024 RID: 24612
	[Nullable(2)]
	private Func<int, bool> OnCanExecuteChangeCallBack;

	// Token: 0x04006025 RID: 24613
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008103 RID: 33027
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A1A5 RID: 172453
		public const int ToggleRoot = 0;

		// Token: 0x0402A1A6 RID: 172454
		public const int TextureQualityA = 1;

		// Token: 0x0402A1A7 RID: 172455
		public const int TextureQualityB = 2;

		// Token: 0x0402A1A8 RID: 172456
		public const int TextName = 3;

		// Token: 0x0402A1A9 RID: 172457
		public const int TextureIconBg = 4;

		// Token: 0x0402A1AA RID: 172458
		public const int TextureIcon = 5;

		// Token: 0x0402A1AB RID: 172459
		public const int TextTypeName = 6;

		// Token: 0x0402A1AC RID: 172460
		public const int ItemRacePanel = 7;

		// Token: 0x0402A1AD RID: 172461
		public const int TextureRaceIcon = 8;

		// Token: 0x0402A1AE RID: 172462
		public const int TextRaceName = 9;

		// Token: 0x0402A1AF RID: 172463
		public const int ItemIncomePanel = 10;

		// Token: 0x0402A1B0 RID: 172464
		public const int TextureIncomeIcon = 11;

		// Token: 0x0402A1B1 RID: 172465
		public const int TextIncomeNum = 12;

		// Token: 0x0402A1B2 RID: 172466
		public const int TextDescription = 13;

		// Token: 0x0402A1B3 RID: 172467
		public const int ItemPhantomIcon = 14;

		// Token: 0x0402A1B4 RID: 172468
		public const int ItemNew = 15;

		// Token: 0x0402A1B5 RID: 172469
		public const int TextureSelect = 16;

		// Token: 0x0402A1B6 RID: 172470
		public const int ItemUnknownPanel = 17;

		// Token: 0x0402A1B7 RID: 172471
		public const int TextureIconMask = 18;

		// Token: 0x0402A1B8 RID: 172472
		public const int CardItemRoot = 19;

		// Token: 0x0402A1B9 RID: 172473
		public const int GoldCardQualityTexture = 20;

		// Token: 0x0402A1BA RID: 172474
		public const int GoldCardQualityTextureB = 21;

		// Token: 0x0402A1BB RID: 172475
		public const int ItemToyRaceType = 22;

		// Token: 0x0402A1BC RID: 172476
		public const int TextureToyRaceIcon = 23;

		// Token: 0x0402A1BD RID: 172477
		public const int RecommendSprite = 24;
	}
}
