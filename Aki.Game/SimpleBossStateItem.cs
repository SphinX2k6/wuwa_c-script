using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CD0 RID: 7376
[NullableContext(1)]
[Nullable(0)]
public class SimpleBossStateItem : UiPanelBase
{
	// Token: 0x0600DF4C RID: 57164 RVA: 0x00344C64 File Offset: 0x00342E64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUISprite))
		};
	}

	// Token: 0x0600DF4D RID: 57165 RVA: 0x00344D30 File Offset: 0x00342F30
	protected override void OnStart()
	{
		this.BossNameText = base.GetText(1);
		this.HpBarSprite = base.GetSprite(7);
		this.ShieldBarSprite = base.GetSprite(10);
		this.HpBufferSprite = base.GetSprite(9);
		base.GetSprite(14).SetUIActive(false);
	}

	// Token: 0x0600DF4E RID: 57166 RVA: 0x00344D81 File Offset: 0x00342F81
	protected override void OnBeforeShow()
	{
		base.GetItem(11).SetUIActive(false);
		base.GetText(0).SetUIActive(false);
	}

	// Token: 0x0600DF4F RID: 57167 RVA: 0x00344D9E File Offset: 0x00342F9E
	protected override void OnBeforeHide()
	{
		this.StopBarLerpAnimation();
	}

	// Token: 0x0600DF50 RID: 57168 RVA: 0x00344DA8 File Offset: 0x00342FA8
	private float GetSafeHpPercent(FKSC_HeadHpContext headInfo)
	{
		float num = (float)headInfo.CurHp / (float)headInfo.MaxHp;
		if (num <= 1f)
		{
			return num;
		}
		return 1f;
	}

	// Token: 0x0600DF51 RID: 57169 RVA: 0x00344DD4 File Offset: 0x00342FD4
	public void RefreshBossInfo(FKSC_HeadHpContext headInfo)
	{
		this.ShieldMax = (float)headInfo.Shield;
		float safeHpPercent = this.GetSafeHpPercent(headInfo);
		this.HpStateMachine.TargetPercent = safeHpPercent;
		this.HpStateMachine.CurrentPercent = safeHpPercent;
	}

	// Token: 0x0600DF52 RID: 57170 RVA: 0x00344E0E File Offset: 0x0034300E
	public void SetBossName(string bossName)
	{
		this.BossNameText.ShowTextNew(bossName);
	}

	// Token: 0x0600DF53 RID: 57171 RVA: 0x00344E1C File Offset: 0x0034301C
	public void UpdateHeadStateInfo(FKSC_HeadHpContext headInfo)
	{
		float safeHpPercent = this.GetSafeHpPercent(headInfo);
		this.HpBarSprite.SetFillAmount(safeHpPercent);
		this.PlayBarAnimation(safeHpPercent);
		float num = (this.ShieldMax == 0f) ? 0f : ((float)headInfo.Shield / this.ShieldMax);
		this.SetShieldBarPercent((num > 1f) ? 1f : num);
	}

	// Token: 0x0600DF54 RID: 57172 RVA: 0x00344E80 File Offset: 0x00343080
	private void PlayBarAnimation(float hpPercent)
	{
		if (hpPercent < this.HpStateMachine.TargetPercent)
		{
			bool flag = this.HpStateMachine.IsOriginState();
			this.HpStateMachine.GetHit(hpPercent, this.HpStateMachine.CurrentPercent);
			if (flag && !this.HpStateMachine.IsOriginState())
			{
				this.SetBarBufferPercent(this.HpStateMachine.CurrentPercent);
			}
			base.GetItem(8).SetUIActive(true);
		}
	}

	// Token: 0x0600DF55 RID: 57173 RVA: 0x00344EEA File Offset: 0x003430EA
	private void StopBarLerpAnimation()
	{
		base.GetItem(8).SetUIActive(false);
		this.HpStateMachine.Reset();
	}

	// Token: 0x0600DF56 RID: 57174 RVA: 0x00344F04 File Offset: 0x00343104
	private void SetBarBufferPercent(float percent)
	{
		UUISprite hpBufferSprite = this.HpBufferSprite;
		if (hpBufferSprite == null)
		{
			return;
		}
		hpBufferSprite.SetFillAmount(percent);
	}

	// Token: 0x0600DF57 RID: 57175 RVA: 0x00344F17 File Offset: 0x00343117
	private void SetShieldBarPercent(float percent)
	{
		if (percent > 0f)
		{
			this.ShieldBarSprite.SetFillAmount(percent);
			this.ShieldBarSprite.SetUIActive(true);
			return;
		}
		this.ShieldBarSprite.SetUIActive(false);
	}

	// Token: 0x0600DF58 RID: 57176 RVA: 0x00344F48 File Offset: 0x00343148
	public void OnTick(float delta)
	{
		if (!this.HpStateMachine.IsOriginState())
		{
			float num = this.HpStateMachine.UpdatePercent(delta);
			if (num < 0f)
			{
				this.StopBarLerpAnimation();
				return;
			}
			if (num <= 1f)
			{
				this.SetBarBufferPercent(num);
			}
		}
	}

	// Token: 0x040066B4 RID: 26292
	[Nullable(2)]
	private UUIText BossNameText;

	// Token: 0x040066B5 RID: 26293
	[Nullable(2)]
	private UUISprite HpBarSprite;

	// Token: 0x040066B6 RID: 26294
	[Nullable(2)]
	private UUISprite ShieldBarSprite;

	// Token: 0x040066B7 RID: 26295
	[Nullable(2)]
	private UUISprite HpBufferSprite;

	// Token: 0x040066B8 RID: 26296
	private float ShieldMax;

	// Token: 0x040066B9 RID: 26297
	private readonly HpBufferStateMachine HpStateMachine = new HpBufferStateMachine();

	// Token: 0x020082D2 RID: 33490
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x0402AAC6 RID: 174790
		public const int BossLevelText = 0;

		// Token: 0x0402AAC7 RID: 174791
		public const int BossNameText = 1;

		// Token: 0x0402AAC8 RID: 174792
		public const int RageItem = 2;

		// Token: 0x0402AAC9 RID: 174793
		public const int ToughBg = 3;

		// Token: 0x0402AACA RID: 174794
		public const int RageBar = 4;

		// Token: 0x0402AACB RID: 174795
		public const int HpShieldBarItem = 5;

		// Token: 0x0402AACC RID: 174796
		public const int HpBarItem = 6;

		// Token: 0x0402AACD RID: 174797
		public const int NormalHpBarSprite = 7;

		// Token: 0x0402AACE RID: 174798
		public const int BarBufferCanvas = 8;

		// Token: 0x0402AACF RID: 174799
		public const int BarBufferSprite = 9;

		// Token: 0x0402AAD0 RID: 174800
		public const int ShieldBarSprite = 10;

		// Token: 0x0402AAD1 RID: 174801
		public const int ToughItem = 11;

		// Token: 0x0402AAD2 RID: 174802
		public const int MaxHardnessEffect = 12;

		// Token: 0x0402AAD3 RID: 174803
		public const int BuffHorizontalItem = 13;

		// Token: 0x0402AAD4 RID: 174804
		public const int HpLight = 14;

		// Token: 0x0402AAD5 RID: 174805
		public const int HardnessNormal = 15;

		// Token: 0x0402AAD6 RID: 174806
		public const int HardnessBreak = 16;

		// Token: 0x0402AAD7 RID: 174807
		public const int FallDownItem = 17;

		// Token: 0x0402AAD8 RID: 174808
		public const int FallDownBar = 18;

		// Token: 0x0402AAD9 RID: 174809
		public const int FallDownBarSign = 19;

		// Token: 0x0402AADA RID: 174810
		public const int RageReduceLittle = 20;

		// Token: 0x0402AADB RID: 174811
		public const int HpFlicker = 21;

		// Token: 0x0402AADC RID: 174812
		public const int RageReduceLargeCanvas = 22;

		// Token: 0x0402AADD RID: 174813
		public const int RageReduceLarge = 23;

		// Token: 0x0402AADE RID: 174814
		public const int RageEmpty = 24;

		// Token: 0x0402AADF RID: 174815
		public const int AnimSmallHit = 25;

		// Token: 0x0402AAE0 RID: 174816
		public const int AnimBigHit = 26;

		// Token: 0x0402AAE1 RID: 174817
		public const int AnimToughStart = 27;

		// Token: 0x0402AAE2 RID: 174818
		public const int AnimToughHit = 28;

		// Token: 0x0402AAE3 RID: 174819
		public const int AnimToughFlick = 29;

		// Token: 0x0402AAE4 RID: 174820
		public const int AnimToughClose = 30;

		// Token: 0x0402AAE5 RID: 174821
		public const int AnimBreak = 31;

		// Token: 0x0402AAE6 RID: 174822
		public const int ExtraItem = 32;

		// Token: 0x0402AAE7 RID: 174823
		public const int BloodModeIcon = 33;

		// Token: 0x0402AAE8 RID: 174824
		public const int WeaknessContainer = 34;

		// Token: 0x0402AAE9 RID: 174825
		public const int HpWeaknessNode = 35;

		// Token: 0x0402AAEA RID: 174826
		public const int HpWeaknessSprite1 = 36;

		// Token: 0x0402AAEB RID: 174827
		public const int HpWeaknessEffect = 37;

		// Token: 0x0402AAEC RID: 174828
		public const int AniHpWeaknessFull = 38;

		// Token: 0x0402AAED RID: 174829
		public const int AniHpWeaknessBreak = 39;
	}
}
