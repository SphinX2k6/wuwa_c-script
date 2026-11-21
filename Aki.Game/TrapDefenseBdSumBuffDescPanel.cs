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

// Token: 0x02002198 RID: 8600
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdSumBuffDescPanel : UiPanelBase
{
	// Token: 0x0601527D RID: 86653 RVA: 0x0062782C File Offset: 0x00625A2C
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

	// Token: 0x0601527E RID: 86654 RVA: 0x00627877 File Offset: 0x00625A77
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x0601527F RID: 86655 RVA: 0x0062787C File Offset: 0x00625A7C
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

	// Token: 0x06015280 RID: 86656 RVA: 0x00627B5F File Offset: 0x00625D5F
	[Conditional("WITH_EDITOR")]
	private void EditorShowActorLabel()
	{
	}

	// Token: 0x06015281 RID: 86657 RVA: 0x00627B64 File Offset: 0x00625D64
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdSumBuffDescPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBuffDescPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015282 RID: 86658 RVA: 0x00627BA8 File Offset: 0x00625DA8
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

	// Token: 0x06015283 RID: 86659 RVA: 0x00627BE3 File Offset: 0x00625DE3
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x06015284 RID: 86660 RVA: 0x00627BE5 File Offset: 0x00625DE5
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(11).CanExecuteChange.Unbind();
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(6));
	}

	// Token: 0x06015285 RID: 86661 RVA: 0x00627C0C File Offset: 0x00625E0C
	private void UpdateDataBase(TrapDefenseBdBuffData data, TrapDefenseBdBuff? config = null)
	{
		this.BdBuffData = data;
		this.UpdateBgQuality();
		this.UpdateBuffConfig(config ?? data.BdBuffConfig);
		this.UpdateBdIcon();
	}

	// Token: 0x06015286 RID: 86662 RVA: 0x00627C4C File Offset: 0x00625E4C
	private void UpdateBuffConfig(TrapDefenseBdBuff config)
	{
		base.GetText(5).ShowTextNew(config.Name);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), config.Desc, config.DescArgs());
		base.SetTextureByPath(config.Icon, base.GetTexture(3), null, null);
		base.SetTextureByPath(config.SubIcon, base.GetTexture(17), null, null);
	}

	// Token: 0x06015287 RID: 86663 RVA: 0x00627CC8 File Offset: 0x00625EC8
	public void UpdateBuffLockShowState()
	{
		base.GetText(5).ShowTextNew(ETrapDefenseTextKey.BdBuffLockShowName.ToString());
	}

	// Token: 0x06015288 RID: 86664 RVA: 0x00627CE8 File Offset: 0x00625EE8
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

	// Token: 0x06015289 RID: 86665 RVA: 0x00627D6C File Offset: 0x00625F6C
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

	// Token: 0x0601528A RID: 86666 RVA: 0x00627DB8 File Offset: 0x00625FB8
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

	// Token: 0x0601528B RID: 86667 RVA: 0x00627E14 File Offset: 0x00626014
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

	// Token: 0x0601528C RID: 86668 RVA: 0x00627E6C File Offset: 0x0062606C
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

	// Token: 0x0601528D RID: 86669 RVA: 0x00627EF4 File Offset: 0x006260F4
	public void UpdateBdIcon()
	{
		string icon = this.BdBuffData.GetBelongBdData().Config.Icon;
		base.SetTextureByPath(icon, base.GetTexture(8), null, null);
	}

	// Token: 0x0601528E RID: 86670 RVA: 0x00627F30 File Offset: 0x00626130
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

	// Token: 0x0601528F RID: 86671 RVA: 0x00627FBC File Offset: 0x006261BC
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

	// Token: 0x06015290 RID: 86672 RVA: 0x00627FE7 File Offset: 0x006261E7
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

	// Token: 0x06015291 RID: 86673 RVA: 0x0062800C File Offset: 0x0062620C
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

	// Token: 0x06015292 RID: 86674 RVA: 0x006280A0 File Offset: 0x006262A0
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

	// Token: 0x06015293 RID: 86675 RVA: 0x0062811C File Offset: 0x0062631C
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

	// Token: 0x06015294 RID: 86676 RVA: 0x00628198 File Offset: 0x00626398
	public void SetTextureBgByResId(string resId, UUITexture uiTexture)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
		base.SetTextureByPath(resourcePath, uiTexture, null, null);
	}

	// Token: 0x06015295 RID: 86677 RVA: 0x006281C4 File Offset: 0x006263C4
	public void SetSpriteBgByResId(string resId, UUISprite uiSprite)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
		this.SetSpriteByPath(resourcePath, uiSprite, false, null, null);
	}

	// Token: 0x06015296 RID: 86678 RVA: 0x006281F0 File Offset: 0x006263F0
	public void SetSwitchStrengthenShowState(bool show)
	{
		this.SwitchComponent.SetActive(show);
		if (show)
		{
			this.SwitchComponent.SetToggleState(this.BdBuffData.IsShowStrengthen);
		}
	}

	// Token: 0x06015297 RID: 86679 RVA: 0x00628217 File Offset: 0x00626417
	private void OnClickSwitchStrengthen(EToggleState state)
	{
		Action<bool, TrapDefenseBdBuffData> switchStrengthenCallback = this.SwitchStrengthenCallback;
		if (switchStrengthenCallback == null)
		{
			return;
		}
		switchStrengthenCallback(state == EToggleState.ETT_Checked, this.BdBuffData);
	}

	// Token: 0x06015298 RID: 86680 RVA: 0x00628233 File Offset: 0x00626433
	private void OnClickToggleRoot(EToggleState check)
	{
		Action<TrapDefenseBdBuffData> onSelectCallback = this.OnSelectCallback;
		if (onSelectCallback == null)
		{
			return;
		}
		onSelectCallback(this.BdBuffData);
	}

	// Token: 0x06015299 RID: 86681 RVA: 0x0062824B File Offset: 0x0062644B
	private bool CanExecuteChange()
	{
		Func<bool> onCanClickCallback = this.OnCanClickCallback;
		return onCanClickCallback != null && onCanClickCallback();
	}

	// Token: 0x0601529A RID: 86682 RVA: 0x00628260 File Offset: 0x00626460
	public void UpdateRecommendState()
	{
		bool item = this.BdBuffData.GetBelongBdData().PreAddedBuffIsActiveNewQuality(1).Item1;
		int quality = this.BdBuffData.Config.Quality;
		int? recommendByType = item ? new int?(this.GetRecommendEffectType(quality)) : null;
		this.SetRecommendByType(recommendByType);
		this.SetRecommendQualityLight(item, quality);
	}

	// Token: 0x0400B38F RID: 45967
	public TrapDefenseBdBuffData BdBuffData;

	// Token: 0x0400B390 RID: 45968
	public CommonSwitchItem SwitchComponent;

	// Token: 0x0400B391 RID: 45969
	public Action<bool, TrapDefenseBdBuffData> SwitchStrengthenCallback;

	// Token: 0x0400B392 RID: 45970
	public Action<TrapDefenseBdBuffData> OnSelectCallback;

	// Token: 0x0400B393 RID: 45971
	public Func<bool> OnCanClickCallback;

	// Token: 0x0200844A RID: 33866
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402AAC8 RID: 174792
		public const int ItemSwitchComponent = 0;

		// Token: 0x0402AAC9 RID: 174793
		public const int TextureBgQualityLight = 1;

		// Token: 0x0402AACA RID: 174794
		public const int TextureIconQualityLight = 2;

		// Token: 0x0402AACB RID: 174795
		public const int TextureIcon = 3;

		// Token: 0x0402AACC RID: 174796
		public const int ItemStrengthenTips = 4;

		// Token: 0x0402AACD RID: 174797
		public const int TextTitle = 5;

		// Token: 0x0402AACE RID: 174798
		public const int TextDesc = 6;

		// Token: 0x0402AACF RID: 174799
		public const int ItemBdIcon = 7;

		// Token: 0x0402AAD0 RID: 174800
		public const int TextureBdIcon = 8;

		// Token: 0x0402AAD1 RID: 174801
		public const int SpriteRecommendQualityLight = 9;

		// Token: 0x0402AAD2 RID: 174802
		public const int SpriteRecommendQualityLine = 10;

		// Token: 0x0402AAD3 RID: 174803
		public const int ToggleRoot = 11;

		// Token: 0x0402AAD4 RID: 174804
		public const int ItemRecommendEffectBlue = 12;

		// Token: 0x0402AAD5 RID: 174805
		public const int ItemRecommendEffectPurple = 13;

		// Token: 0x0402AAD6 RID: 174806
		public const int ItemRecommendEffectGold = 14;

		// Token: 0x0402AAD7 RID: 174807
		public const int ItemStrengthenEffectPurple = 15;

		// Token: 0x0402AAD8 RID: 174808
		public const int ItemStrengthenEffectGold = 16;

		// Token: 0x0402AAD9 RID: 174809
		public const int TextureSubIcon = 17;

		// Token: 0x0402AADA RID: 174810
		public const int ItemRecommendEffectGreen = 18;
	}
}
