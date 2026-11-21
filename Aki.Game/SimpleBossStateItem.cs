using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001192 RID: 4498
[NullableContext(1)]
[Nullable(0)]
public class SimpleBossStateItem : UiPanelBase
{
	// Token: 0x0600B369 RID: 45929 RVA: 0x0035068C File Offset: 0x0034E88C
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

	// Token: 0x0600B36A RID: 45930 RVA: 0x00350758 File Offset: 0x0034E958
	protected override void OnStart()
	{
		this.BossNameText = base.GetText(1);
		this.HpBarSprite = base.GetSprite(7);
		this.ShieldBarSprite = base.GetSprite(10);
		this.HpBufferSprite = base.GetSprite(9);
		base.GetSprite(14).SetUIActive(false);
	}

	// Token: 0x0600B36B RID: 45931 RVA: 0x003507A9 File Offset: 0x0034E9A9
	protected override void OnBeforeShow()
	{
		base.GetItem(11).SetUIActive(false);
		base.GetText(0).SetUIActive(false);
	}

	// Token: 0x0600B36C RID: 45932 RVA: 0x003507C6 File Offset: 0x0034E9C6
	protected override void OnBeforeHide()
	{
		this.StopBarLerpAnimation();
	}

	// Token: 0x0600B36D RID: 45933 RVA: 0x003507D0 File Offset: 0x0034E9D0
	private float GetSafeHpPercent(FKSC_HeadHpContext headInfo)
	{
		float num = (float)headInfo.CurHp / (float)headInfo.MaxHp;
		if (num <= 1f)
		{
			return num;
		}
		return 1f;
	}

	// Token: 0x0600B36E RID: 45934 RVA: 0x003507FC File Offset: 0x0034E9FC
	public void RefreshBossInfo(FKSC_HeadHpContext headInfo)
	{
		this.ShieldMax = (float)headInfo.Shield;
		float safeHpPercent = this.GetSafeHpPercent(headInfo);
		this.HpStateMachine.TargetPercent = safeHpPercent;
		this.HpStateMachine.CurrentPercent = safeHpPercent;
	}

	// Token: 0x0600B36F RID: 45935 RVA: 0x00350836 File Offset: 0x0034EA36
	public void SetBossName(string bossName)
	{
		this.BossNameText.ShowTextNew(bossName);
	}

	// Token: 0x0600B370 RID: 45936 RVA: 0x00350844 File Offset: 0x0034EA44
	public void UpdateHeadStateInfo(FKSC_HeadHpContext headInfo)
	{
		float safeHpPercent = this.GetSafeHpPercent(headInfo);
		this.HpBarSprite.SetFillAmount(safeHpPercent);
		this.PlayBarAnimation(safeHpPercent);
		float num = (this.ShieldMax == 0f) ? 0f : ((float)headInfo.Shield / this.ShieldMax);
		this.SetShieldBarPercent((num > 1f) ? 1f : num);
	}

	// Token: 0x0600B371 RID: 45937 RVA: 0x003508A8 File Offset: 0x0034EAA8
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

	// Token: 0x0600B372 RID: 45938 RVA: 0x00350912 File Offset: 0x0034EB12
	private void StopBarLerpAnimation()
	{
		base.GetItem(8).SetUIActive(false);
		this.HpStateMachine.Reset();
	}

	// Token: 0x0600B373 RID: 45939 RVA: 0x0035092C File Offset: 0x0034EB2C
	private void SetBarBufferPercent(float percent)
	{
		UUISprite hpBufferSprite = this.HpBufferSprite;
		if (hpBufferSprite == null)
		{
			return;
		}
		hpBufferSprite.SetFillAmount(percent);
	}

	// Token: 0x0600B374 RID: 45940 RVA: 0x0035093F File Offset: 0x0034EB3F
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

	// Token: 0x0600B375 RID: 45941 RVA: 0x00350970 File Offset: 0x0034EB70
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

	// Token: 0x04006793 RID: 26515
	[Nullable(2)]
	private UUIText BossNameText;

	// Token: 0x04006794 RID: 26516
	[Nullable(2)]
	private UUISprite HpBarSprite;

	// Token: 0x04006795 RID: 26517
	[Nullable(2)]
	private UUISprite ShieldBarSprite;

	// Token: 0x04006796 RID: 26518
	[Nullable(2)]
	private UUISprite HpBufferSprite;

	// Token: 0x04006797 RID: 26519
	private float ShieldMax;

	// Token: 0x04006798 RID: 26520
	private readonly HpBufferStateMachine HpStateMachine = new HpBufferStateMachine();

	// Token: 0x0200745B RID: 29787
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x04025DEE RID: 155118
		public const int BossLevelText = 0;

		// Token: 0x04025DEF RID: 155119
		public const int BossNameText = 1;

		// Token: 0x04025DF0 RID: 155120
		public const int RageItem = 2;

		// Token: 0x04025DF1 RID: 155121
		public const int ToughBg = 3;

		// Token: 0x04025DF2 RID: 155122
		public const int RageBar = 4;

		// Token: 0x04025DF3 RID: 155123
		public const int HpShieldBarItem = 5;

		// Token: 0x04025DF4 RID: 155124
		public const int HpBarItem = 6;

		// Token: 0x04025DF5 RID: 155125
		public const int NormalHpBarSprite = 7;

		// Token: 0x04025DF6 RID: 155126
		public const int BarBufferCanvas = 8;

		// Token: 0x04025DF7 RID: 155127
		public const int BarBufferSprite = 9;

		// Token: 0x04025DF8 RID: 155128
		public const int ShieldBarSprite = 10;

		// Token: 0x04025DF9 RID: 155129
		public const int ToughItem = 11;

		// Token: 0x04025DFA RID: 155130
		public const int MaxHardnessEffect = 12;

		// Token: 0x04025DFB RID: 155131
		public const int BuffHorizontalItem = 13;

		// Token: 0x04025DFC RID: 155132
		public const int HpLight = 14;

		// Token: 0x04025DFD RID: 155133
		public const int HardnessNormal = 15;

		// Token: 0x04025DFE RID: 155134
		public const int HardnessBreak = 16;

		// Token: 0x04025DFF RID: 155135
		public const int FallDownItem = 17;

		// Token: 0x04025E00 RID: 155136
		public const int FallDownBar = 18;

		// Token: 0x04025E01 RID: 155137
		public const int FallDownBarSign = 19;

		// Token: 0x04025E02 RID: 155138
		public const int RageReduceLittle = 20;

		// Token: 0x04025E03 RID: 155139
		public const int HpFlicker = 21;

		// Token: 0x04025E04 RID: 155140
		public const int RageReduceLargeCanvas = 22;

		// Token: 0x04025E05 RID: 155141
		public const int RageReduceLarge = 23;

		// Token: 0x04025E06 RID: 155142
		public const int RageEmpty = 24;

		// Token: 0x04025E07 RID: 155143
		public const int AnimSmallHit = 25;

		// Token: 0x04025E08 RID: 155144
		public const int AnimBigHit = 26;

		// Token: 0x04025E09 RID: 155145
		public const int AnimToughStart = 27;

		// Token: 0x04025E0A RID: 155146
		public const int AnimToughHit = 28;

		// Token: 0x04025E0B RID: 155147
		public const int AnimToughFlick = 29;

		// Token: 0x04025E0C RID: 155148
		public const int AnimToughClose = 30;

		// Token: 0x04025E0D RID: 155149
		public const int AnimBreak = 31;

		// Token: 0x04025E0E RID: 155150
		public const int ExtraItem = 32;

		// Token: 0x04025E0F RID: 155151
		public const int BloodModeIcon = 33;

		// Token: 0x04025E10 RID: 155152
		public const int WeaknessContainer = 34;

		// Token: 0x04025E11 RID: 155153
		public const int HpWeaknessNode = 35;

		// Token: 0x04025E12 RID: 155154
		public const int HpWeaknessSprite1 = 36;

		// Token: 0x04025E13 RID: 155155
		public const int HpWeaknessEffect = 37;

		// Token: 0x04025E14 RID: 155156
		public const int AniHpWeaknessFull = 38;

		// Token: 0x04025E15 RID: 155157
		public const int AniHpWeaknessBreak = 39;
	}
}
