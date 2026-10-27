using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C1D RID: 11293
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdSumBuffDescPanel : UiPanelBase
{
	// Token: 0x0601784B RID: 96331 RVA: 0x005FAE08 File Offset: 0x005F9008
	public UniTask Init(UUIItem item)
	{
		TrapDefenseBdSumBuffDescPanel.<Init>d__6 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TrapDefenseBdSumBuffDescPanel.<Init>d__6>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0601784C RID: 96332 RVA: 0x005FAE53 File Offset: 0x005F9053
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x0601784D RID: 96333 RVA: 0x005FAE58 File Offset: 0x005F9058
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action<EToggleState>(this.OnClickToggleRoot));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601784E RID: 96334 RVA: 0x005FB13B File Offset: 0x005F933B
	[Conditional("WITH_EDITOR")]
	private void EditorShowActorLabel()
	{
	}

	// Token: 0x0601784F RID: 96335 RVA: 0x005FB140 File Offset: 0x005F9340
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdSumBuffDescPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBuffDescPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017850 RID: 96336 RVA: 0x005FB184 File Offset: 0x005F9384
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(6),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.TrapDefenseBuff
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x06017851 RID: 96337 RVA: 0x005FB1BF File Offset: 0x005F93BF
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x06017852 RID: 96338 RVA: 0x005FB1C1 File Offset: 0x005F93C1
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(11).CanExecuteChange.Unbind();
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(6));
	}

	// Token: 0x06017853 RID: 96339 RVA: 0x005FB1E8 File Offset: 0x005F93E8
	private void UpdateDataBase(TrapDefenseBdBuffData data, TrapDefenseBdBuff? config = null)
	{
		this.BdBuffData = data;
		this.UpdateBgQuality();
		this.UpdateBuffConfig(config ?? data.BdBuffConfig);
		this.UpdateBdIcon();
	}

	// Token: 0x06017854 RID: 96340 RVA: 0x005FB228 File Offset: 0x005F9428
	private void UpdateBuffConfig(TrapDefenseBdBuff config)
	{
		base.GetText(5).ShowTextNew(config.Name);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), config.Desc, config.DescArgs());
		base.SetTextureByPath(config.Icon, base.GetTexture(3), null, null);
		base.SetTextureByPath(config.SubIcon, base.GetTexture(17), null, null);
	}

	// Token: 0x06017855 RID: 96341 RVA: 0x005FB2A4 File Offset: 0x005F94A4
	public void UpdateBuffLockShowState()
	{
		base.GetText(5).ShowTextNew(ETrapDefenseTextKey.BdBuffLockShowName.ToString());
	}

	// Token: 0x06017856 RID: 96342 RVA: 0x005FB2C4 File Offset: 0x005F94C4
	public void UpdateDataShowMode(TrapDefenseBdBuffData data)
	{
		bool isInstance = TrapDefenseModel.Instance.ViewModelBdSum.IsInstance;
		TrapDefenseBdBuff showBdBuffConfig = data.GetShowBdBuffConfig(new bool?(isInstance));
		this.UpdateDataBase(data, new TrapDefenseBdBuff?(showBdBuffConfig));
		this.SetSwitchStrengthenShowState(data.IsCanSwitchStrengthen(new bool?(isInstance)));
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(showBdBuffConfig.Level > 1);
		}
		this.SetRecommendByType(null);
		this.SetStrengthenEffect(null);
	}

	// Token: 0x06017857 RID: 96343 RVA: 0x005FB348 File Offset: 0x005F9548
	public void UpdateDataSelectMode(TrapDefenseBdBuffData data)
	{
		this.UpdateDataBase(data, null);
		this.SetSwitchStrengthenShowState(false);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.SetStrengthenEffect(null);
		this.UpdateRecommendState();
	}

	// Token: 0x06017858 RID: 96344 RVA: 0x005FB394 File Offset: 0x005F9594
	public void UpdateDataGetMode(TrapDefenseBdBuffData data)
	{
		this.UpdateDataBase(data, null);
		this.SetSwitchStrengthenShowState(false);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(data.IsStrengthenFinish());
		}
		this.SetRecommendByType(null);
		this.SetStrengthenEffect(null);
	}

	// Token: 0x06017859 RID: 96345 RVA: 0x005FB3F0 File Offset: 0x005F95F0
	public void UpdateDataStrengthenModeBefore(TrapDefenseBdBuffData data)
	{
		this.UpdateDataBase(data, new TrapDefenseBdBuff?(data.GetStrengthenBeforeConfig()));
		this.SetSwitchStrengthenShowState(false);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.SetRecommendByType(null);
		this.SetStrengthenEffect(null);
	}

	// Token: 0x0601785A RID: 96346 RVA: 0x005FB448 File Offset: 0x005F9648
	public void UpdateDataStrengthenModeAfter(TrapDefenseBdBuffData data)
	{
		this.UpdateDataBase(data, new TrapDefenseBdBuff?(data.GetStrengthenConfig()));
		this.SetSwitchStrengthenShowState(false);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.SetRecommendByType(null);
		int quality = data.Config.Quality;
		if (quality == 4)
		{
			this.SetStrengthenEffect(new int?(15));
			return;
		}
		if (quality == 5)
		{
			this.SetStrengthenEffect(new int?(16));
			return;
		}
		this.SetStrengthenEffect(null);
	}

	// Token: 0x0601785B RID: 96347 RVA: 0x005FB4D0 File Offset: 0x005F96D0
	public void UpdateBdIcon()
	{
		string icon = this.BdBuffData.GetBelongBdData().Config.Icon;
		base.SetTextureByPath(icon, base.GetTexture(8), null, null);
	}

	// Token: 0x0601785C RID: 96348 RVA: 0x005FB50C File Offset: 0x005F970C
	private void UpdateBgQuality()
	{
		UUITexture texture = base.GetTexture(1);
		UUITexture texture2 = base.GetTexture(2);
		int quality = this.BdBuffData.Config.Quality;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("T_TipsQualityTypeLevel");
		defaultInterpolatedStringHandler.AppendFormatted<int>(quality);
		string resId = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("T_TermsIconBgLight");
		defaultInterpolatedStringHandler.AppendFormatted<int>(quality);
		string resId2 = defaultInterpolatedStringHandler.ToStringAndClear();
		this.SetTextureBgByResId(resId, texture);
		this.SetTextureBgByResId(resId2, texture2);
	}

	// Token: 0x0601785D RID: 96349 RVA: 0x005FB598 File Offset: 0x005F9798
	public void SetSelect(bool select)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(11);
		EToggleState state = select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0601785E RID: 96350 RVA: 0x005FB5C3 File Offset: 0x005F97C3
	private int GetRecommendEffectType(int quality)
	{
		switch (quality)
		{
		case 3:
			return 12;
		case 4:
			return 13;
		case 5:
			return 14;
		default:
			return 18;
		}
	}

	// Token: 0x0601785F RID: 96351 RVA: 0x005FB5E8 File Offset: 0x005F97E8
	public void SetRecommendByType(int? type = null)
	{
		foreach (int num in new List<int>
		{
			18,
			12,
			13,
			14
		})
		{
			UUIItem item = base.GetItem(num);
			if (item != null)
			{
				int num2 = num;
				int? num3 = type;
				item.SetUIActive(num2 == num3.GetValueOrDefault() & num3 != null);
			}
		}
	}

	// Token: 0x06017860 RID: 96352 RVA: 0x005FB67C File Offset: 0x005F987C
	public void SetRecommendQualityLight(bool active, int quality)
	{
		UUISprite sprite = base.GetSprite(9);
		UUISprite sprite2 = base.GetSprite(10);
		sprite.SetUIActive(active);
		sprite2.SetUIActive(active);
		if (!active)
		{
			return;
		}
		string hexStr = "#A0FFB2FF";
		switch (quality)
		{
		case 3:
			hexStr = "#8DF7FFFF";
			break;
		case 4:
			hexStr = "#FE69FFFF";
			break;
		case 5:
			hexStr = "#FFDD56FF";
			break;
		}
		sprite.SetColor(FColor.FromHex(hexStr));
		sprite2.SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x06017861 RID: 96353 RVA: 0x005FB6F8 File Offset: 0x005F98F8
	public void SetStrengthenEffect(int? type = null)
	{
		foreach (int num in new List<int>
		{
			15,
			16
		})
		{
			UUIItem item = base.GetItem(num);
			int num2 = num;
			int? num3 = type;
			item.SetUIActive(num2 == num3.GetValueOrDefault() & num3 != null);
		}
	}

	// Token: 0x06017862 RID: 96354 RVA: 0x005FB774 File Offset: 0x005F9974
	public void SetTextureBgByResId(string resId, UUITexture uiTexture)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
		base.SetTextureByPath(resourcePath, uiTexture, null, null);
	}

	// Token: 0x06017863 RID: 96355 RVA: 0x005FB7A0 File Offset: 0x005F99A0
	public void SetSpriteBgByResId(string resId, UUISprite uiSprite)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
		this.SetSpriteByPath(resourcePath, uiSprite, false, null, null);
	}

	// Token: 0x06017864 RID: 96356 RVA: 0x005FB7CC File Offset: 0x005F99CC
	public void SetSwitchStrengthenShowState(bool show)
	{
		this.SwitchComponent.SetActive(show);
		if (show)
		{
			this.SwitchComponent.SetToggleState(this.BdBuffData.IsShowStrengthen);
		}
	}

	// Token: 0x06017865 RID: 96357 RVA: 0x005FB7F3 File Offset: 0x005F99F3
	private void OnClickSwitchStrengthen(EToggleState state)
	{
		Action<bool, TrapDefenseBdBuffData> switchStrengthenCallback = this.SwitchStrengthenCallback;
		if (switchStrengthenCallback == null)
		{
			return;
		}
		switchStrengthenCallback(state == EToggleState.ETT_Checked, this.BdBuffData);
	}

	// Token: 0x06017866 RID: 96358 RVA: 0x005FB80F File Offset: 0x005F9A0F
	private void OnClickToggleRoot(EToggleState check)
	{
		Action<TrapDefenseBdBuffData> onSelectCallback = this.OnSelectCallback;
		if (onSelectCallback == null)
		{
			return;
		}
		onSelectCallback(this.BdBuffData);
	}

	// Token: 0x06017867 RID: 96359 RVA: 0x005FB827 File Offset: 0x005F9A27
	private bool CanExecuteChange()
	{
		Func<bool> onCanClickCallback = this.OnCanClickCallback;
		return onCanClickCallback != null && onCanClickCallback();
	}

	// Token: 0x06017868 RID: 96360 RVA: 0x005FB83C File Offset: 0x005F9A3C
	public void UpdateRecommendState()
	{
		bool item = this.BdBuffData.GetBelongBdData().PreAddedBuffIsActiveNewQuality(1).Item1;
		int quality = this.BdBuffData.Config.Quality;
		int? recommendByType = item ? new int?(this.GetRecommendEffectType(quality)) : null;
		this.SetRecommendByType(recommendByType);
		this.SetRecommendQualityLight(item, quality);
	}

	// Token: 0x0400AF8A RID: 44938
	public TrapDefenseBdBuffData BdBuffData;

	// Token: 0x0400AF8B RID: 44939
	public CommonSwitchItem SwitchComponent;

	// Token: 0x0400AF8C RID: 44940
	public Action<bool, TrapDefenseBdBuffData> SwitchStrengthenCallback;

	// Token: 0x0400AF8D RID: 44941
	public Action<TrapDefenseBdBuffData> OnSelectCallback;

	// Token: 0x0400AF8E RID: 44942
	public Func<bool> OnCanClickCallback;

	// Token: 0x02009207 RID: 37383
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F3C7 RID: 193479
		public const int ItemSwitchComponent = 0;

		// Token: 0x0402F3C8 RID: 193480
		public const int TextureBgQualityLight = 1;

		// Token: 0x0402F3C9 RID: 193481
		public const int TextureIconQualityLight = 2;

		// Token: 0x0402F3CA RID: 193482
		public const int TextureIcon = 3;

		// Token: 0x0402F3CB RID: 193483
		public const int ItemStrengthenTips = 4;

		// Token: 0x0402F3CC RID: 193484
		public const int TextTitle = 5;

		// Token: 0x0402F3CD RID: 193485
		public const int TextDesc = 6;

		// Token: 0x0402F3CE RID: 193486
		public const int ItemBdIcon = 7;

		// Token: 0x0402F3CF RID: 193487
		public const int TextureBdIcon = 8;

		// Token: 0x0402F3D0 RID: 193488
		public const int SpriteRecommendQualityLight = 9;

		// Token: 0x0402F3D1 RID: 193489
		public const int SpriteRecommendQualityLine = 10;

		// Token: 0x0402F3D2 RID: 193490
		public const int ToggleRoot = 11;

		// Token: 0x0402F3D3 RID: 193491
		public const int ItemRecommendEffectBlue = 12;

		// Token: 0x0402F3D4 RID: 193492
		public const int ItemRecommendEffectPurple = 13;

		// Token: 0x0402F3D5 RID: 193493
		public const int ItemRecommendEffectGold = 14;

		// Token: 0x0402F3D6 RID: 193494
		public const int ItemStrengthenEffectPurple = 15;

		// Token: 0x0402F3D7 RID: 193495
		public const int ItemStrengthenEffectGold = 16;

		// Token: 0x0402F3D8 RID: 193496
		public const int TextureSubIcon = 17;

		// Token: 0x0402F3D9 RID: 193497
		public const int ItemRecommendEffectGreen = 18;
	}
}
