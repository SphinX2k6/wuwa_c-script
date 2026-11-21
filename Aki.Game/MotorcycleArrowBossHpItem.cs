using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001188 RID: 4488
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBossHpItem : UiPanelBase
{
	// Token: 0x0600B325 RID: 45861 RVA: 0x0034F34C File Offset: 0x0034D54C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIArtText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x0600B326 RID: 45862 RVA: 0x0034F3E8 File Offset: 0x0034D5E8
	protected override void OnStart()
	{
		this.HpArtText = base.GetArtText(1);
		this.ShieldArtText = base.GetArtText(3);
		this.TimeText = base.GetText(5);
		this.HpSequencePlayer = new LevelSequencePlayer(base.GetItem(0));
		this.ShieldSequencePlayer = new LevelSequencePlayer(base.GetItem(2));
		this.HpDigitScroll.Init(0f, 0f, 500f);
		this.ShieldDigitScroll.Init(0f, 0f, 500f);
	}

	// Token: 0x0600B327 RID: 45863 RVA: 0x0034F474 File Offset: 0x0034D674
	[NullableContext(1)]
	public void UpdateHeadStateInfo(FKSC_HeadHpContext headInfo, bool isScroll = true)
	{
		if (isScroll)
		{
			float num = this.HpDigitScroll.SetTarget((float)headInfo.CurHp);
			float num2 = this.ShieldDigitScroll.SetTarget((float)headInfo.Shield);
			if (num < 0f)
			{
				LevelSequencePlayer hpSequencePlayer = this.HpSequencePlayer;
				if (hpSequencePlayer != null)
				{
					hpSequencePlayer.PlayOrReplaySequenceByName("Hit", false, null);
				}
			}
			if (num2 < 0f)
			{
				LevelSequencePlayer shieldSequencePlayer = this.ShieldSequencePlayer;
				if (shieldSequencePlayer != null)
				{
					shieldSequencePlayer.PlayOrReplaySequenceByName("Hit", false, null);
				}
			}
		}
		else
		{
			this.HpDigitScroll.Reset((float)headInfo.CurHp);
			this.ShieldDigitScroll.Reset((float)headInfo.Shield);
			base.GetItem(2).SetUIActive(headInfo.Shield > 0);
		}
		UUIArtText hpArtText = this.HpArtText;
		if (hpArtText != null)
		{
			hpArtText.SetText(MotorcycleUtil.CompactNumberFormat(this.HpDigitScroll.Current));
		}
		UUIArtText shieldArtText = this.ShieldArtText;
		if (shieldArtText == null)
		{
			return;
		}
		shieldArtText.SetText(MotorcycleUtil.CompactNumberFormat(this.ShieldDigitScroll.Current));
	}

	// Token: 0x0600B328 RID: 45864 RVA: 0x0034F574 File Offset: 0x0034D774
	public void OnTick(float delta)
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		float num = (float)motorcycleArrowSubModel.BossFightTime - (float)Time.Instance.WorldTimeSeconds + (float)motorcycleArrowSubModel.BossFightStartTime;
		UUIText timeText = this.TimeText;
		if (timeText != null)
		{
			timeText.SetText(MotorcycleUtil.TimeFormat((num < 0f) ? 0f : num), true);
		}
		if (!this.HpDigitScroll.IsFinished())
		{
			float num2 = this.HpDigitScroll.Tick(delta);
			UUIArtText hpArtText = this.HpArtText;
			if (hpArtText != null)
			{
				hpArtText.SetText(MotorcycleUtil.CompactNumberFormat(num2));
			}
		}
		if (!this.ShieldDigitScroll.IsFinished())
		{
			float num3 = this.ShieldDigitScroll.Tick(delta);
			UUIArtText shieldArtText = this.ShieldArtText;
			if (shieldArtText == null)
			{
				return;
			}
			shieldArtText.SetText(MotorcycleUtil.CompactNumberFormat(num3));
		}
	}

	// Token: 0x04006764 RID: 26468
	private const int SCROLL_DURATION = 500;

	// Token: 0x04006765 RID: 26469
	protected UUIArtText HpArtText;

	// Token: 0x04006766 RID: 26470
	protected UUIArtText ShieldArtText;

	// Token: 0x04006767 RID: 26471
	protected UUIText TimeText;

	// Token: 0x04006768 RID: 26472
	[Nullable(1)]
	private readonly DigitScroll HpDigitScroll = new DigitScroll();

	// Token: 0x04006769 RID: 26473
	[Nullable(1)]
	private readonly DigitScroll ShieldDigitScroll = new DigitScroll();

	// Token: 0x0400676A RID: 26474
	private LevelSequencePlayer HpSequencePlayer;

	// Token: 0x0400676B RID: 26475
	private LevelSequencePlayer ShieldSequencePlayer;

	// Token: 0x0200744D RID: 29773
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025DB0 RID: 155056
		public const int ItemHp = 0;

		// Token: 0x04025DB1 RID: 155057
		public const int ArtTextMonsterHp = 1;

		// Token: 0x04025DB2 RID: 155058
		public const int ItemShield = 2;

		// Token: 0x04025DB3 RID: 155059
		public const int ArtTextShield = 3;

		// Token: 0x04025DB4 RID: 155060
		public const int ItemTime = 4;

		// Token: 0x04025DB5 RID: 155061
		public const int TextTime = 5;
	}
}
