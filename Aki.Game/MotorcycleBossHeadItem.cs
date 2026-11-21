using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001187 RID: 4487
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleBossHeadItem : UiPanelBase
{
	// Token: 0x0600B31E RID: 45854 RVA: 0x0034F018 File Offset: 0x0034D218
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600B31F RID: 45855 RVA: 0x0034F0B4 File Offset: 0x0034D2B4
	protected override void OnStart()
	{
		this.Attack = base.GetItem(0);
		this.BossHead = base.GetTexture(1);
		this.HeadBase = base.GetSprite(2);
		this.BossIcon = base.GetSprite(3);
		this.FinishIcon = base.GetSprite(4);
		this.StateAttack = base.GetItem(5);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600B320 RID: 45856 RVA: 0x0034F120 File Offset: 0x0034D320
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer.Clear();
		this.SequencePlayer = null;
	}

	// Token: 0x0600B321 RID: 45857 RVA: 0x0034F134 File Offset: 0x0034D334
	[NullableContext(1)]
	public void SetBossIconPath(string path)
	{
		base.SetTextureByPath(path, this.BossHead, null, null);
	}

	// Token: 0x0600B322 RID: 45858 RVA: 0x0034F158 File Offset: 0x0034D358
	public void SetBossState(EBossState state, bool bForceRefresh = false)
	{
		if (this.BossState == state && !bForceRefresh)
		{
			return;
		}
		this.BossState = state;
		this.Refresh();
	}

	// Token: 0x0600B323 RID: 45859 RVA: 0x0034F174 File Offset: 0x0034D374
	protected void Refresh()
	{
		this.SequencePlayer.StopPlayingSequence(false, true);
		if (this.BossState == EBossState.WaitStart)
		{
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath("SP_HeadBgNor"), this.HeadBase, true, null, null);
			UUISprite finishIcon = this.FinishIcon;
			if (finishIcon != null)
			{
				finishIcon.SetUIActive(false);
			}
			UUIItem stateAttack = this.StateAttack;
			if (stateAttack != null)
			{
				stateAttack.SetUIActive(true);
			}
			this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
			UUITexture bossHead = this.BossHead;
			if (bossHead == null)
			{
				return;
			}
			bool bUseChangeColor = false;
			FColor? fcolor = null;
			bossHead.SetChangeColor(bUseChangeColor, fcolor);
			return;
		}
		else
		{
			FColor? fcolor;
			if (this.BossState != EBossState.Battle)
			{
				if (this.BossState == EBossState.Finish)
				{
					UUISprite finishIcon2 = this.FinishIcon;
					if (finishIcon2 != null)
					{
						finishIcon2.SetUIActive(true);
					}
					UUIItem stateAttack2 = this.StateAttack;
					if (stateAttack2 != null)
					{
						stateAttack2.SetUIActive(false);
					}
					this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath("SP_HeadBgSuccess"), this.HeadBase, true, null, null);
					this.SequencePlayer.PlaySequencePurely("Defeat", false, false, null, null, false);
					FColor value = FColor.FromHex("375454");
					UUITexture bossHead2 = this.BossHead;
					if (bossHead2 == null)
					{
						return;
					}
					bool bUseChangeColor2 = true;
					fcolor = new FColor?(value);
					bossHead2.SetChangeColor(bUseChangeColor2, fcolor);
				}
				return;
			}
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath("SP_HeadBgNor"), this.HeadBase, true, null, null);
			UUISprite finishIcon3 = this.FinishIcon;
			if (finishIcon3 != null)
			{
				finishIcon3.SetUIActive(false);
			}
			UUIItem stateAttack3 = this.StateAttack;
			if (stateAttack3 != null)
			{
				stateAttack3.SetUIActive(true);
			}
			this.SequencePlayer.PlaySequencePurely("Trigger", false, false, null, null, false);
			UUITexture bossHead3 = this.BossHead;
			if (bossHead3 == null)
			{
				return;
			}
			bool bUseChangeColor3 = false;
			fcolor = null;
			bossHead3.SetChangeColor(bUseChangeColor3, fcolor);
			return;
		}
	}

	// Token: 0x0400675C RID: 26460
	protected EBossState BossState;

	// Token: 0x0400675D RID: 26461
	protected UUIItem Attack;

	// Token: 0x0400675E RID: 26462
	protected UUITexture BossHead;

	// Token: 0x0400675F RID: 26463
	protected UUISprite HeadBase;

	// Token: 0x04006760 RID: 26464
	protected UUISprite BossIcon;

	// Token: 0x04006761 RID: 26465
	protected UUISprite FinishIcon;

	// Token: 0x04006762 RID: 26466
	protected UUIItem StateAttack;

	// Token: 0x04006763 RID: 26467
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0200744C RID: 29772
	[NullableContext(0)]
	private static class EComponentBossHeadItem
	{
		// Token: 0x04025DAA RID: 155050
		public const int Attack = 0;

		// Token: 0x04025DAB RID: 155051
		public const int BossHead = 1;

		// Token: 0x04025DAC RID: 155052
		public const int HeadBase = 2;

		// Token: 0x04025DAD RID: 155053
		public const int BossIcon = 3;

		// Token: 0x04025DAE RID: 155054
		public const int FinishIcon = 4;

		// Token: 0x04025DAF RID: 155055
		public const int StateAttack = 5;
	}
}
