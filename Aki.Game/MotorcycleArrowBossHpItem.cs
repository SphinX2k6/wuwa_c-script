using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CC6 RID: 7366
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBossHpItem : UiPanelBase
{
	// Token: 0x0600DF08 RID: 57096 RVA: 0x00343924 File Offset: 0x00341B24
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

	// Token: 0x0600DF09 RID: 57097 RVA: 0x003439C0 File Offset: 0x00341BC0
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

	// Token: 0x0600DF0A RID: 57098 RVA: 0x00343A4C File Offset: 0x00341C4C
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

	// Token: 0x0600DF0B RID: 57099 RVA: 0x00343B4C File Offset: 0x00341D4C
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

	// Token: 0x04006685 RID: 26245
	private const int SCROLL_DURATION = 500;

	// Token: 0x04006686 RID: 26246
	protected UUIArtText HpArtText;

	// Token: 0x04006687 RID: 26247
	protected UUIArtText ShieldArtText;

	// Token: 0x04006688 RID: 26248
	protected UUIText TimeText;

	// Token: 0x04006689 RID: 26249
	[Nullable(1)]
	private readonly DigitScroll HpDigitScroll = new DigitScroll();

	// Token: 0x0400668A RID: 26250
	[Nullable(1)]
	private readonly DigitScroll ShieldDigitScroll = new DigitScroll();

	// Token: 0x0400668B RID: 26251
	private LevelSequencePlayer HpSequencePlayer;

	// Token: 0x0400668C RID: 26252
	private LevelSequencePlayer ShieldSequencePlayer;

	// Token: 0x020082C4 RID: 33476
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AA88 RID: 174728
		public const int ItemHp = 0;

		// Token: 0x0402AA89 RID: 174729
		public const int ArtTextMonsterHp = 1;

		// Token: 0x0402AA8A RID: 174730
		public const int ItemShield = 2;

		// Token: 0x0402AA8B RID: 174731
		public const int ArtTextShield = 3;

		// Token: 0x0402AA8C RID: 174732
		public const int ItemTime = 4;

		// Token: 0x0402AA8D RID: 174733
		public const int TextTime = 5;
	}
}
