using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CC5 RID: 7365
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleBossHeadItem : UiPanelBase
{
	// Token: 0x0600DF01 RID: 57089 RVA: 0x003435F0 File Offset: 0x003417F0
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

	// Token: 0x0600DF02 RID: 57090 RVA: 0x0034368C File Offset: 0x0034188C
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

	// Token: 0x0600DF03 RID: 57091 RVA: 0x003436F8 File Offset: 0x003418F8
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer.Clear();
		this.SequencePlayer = null;
	}

	// Token: 0x0600DF04 RID: 57092 RVA: 0x0034370C File Offset: 0x0034190C
	[NullableContext(1)]
	public void SetBossIconPath(string path)
	{
		base.SetTextureByPath(path, this.BossHead, null, null);
	}

	// Token: 0x0600DF05 RID: 57093 RVA: 0x00343730 File Offset: 0x00341930
	public void SetBossState(EBossState state, bool bForceRefresh = false)
	{
		if (this.BossState == state && !bForceRefresh)
		{
			return;
		}
		this.BossState = state;
		this.Refresh();
	}

	// Token: 0x0600DF06 RID: 57094 RVA: 0x0034374C File Offset: 0x0034194C
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

	// Token: 0x0400667D RID: 26237
	protected EBossState BossState;

	// Token: 0x0400667E RID: 26238
	protected UUIItem Attack;

	// Token: 0x0400667F RID: 26239
	protected UUITexture BossHead;

	// Token: 0x04006680 RID: 26240
	protected UUISprite HeadBase;

	// Token: 0x04006681 RID: 26241
	protected UUISprite BossIcon;

	// Token: 0x04006682 RID: 26242
	protected UUISprite FinishIcon;

	// Token: 0x04006683 RID: 26243
	protected UUIItem StateAttack;

	// Token: 0x04006684 RID: 26244
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x020082C3 RID: 33475
	[NullableContext(0)]
	private static class EComponentBossHeadItem
	{
		// Token: 0x0402AA82 RID: 174722
		public const int Attack = 0;

		// Token: 0x0402AA83 RID: 174723
		public const int BossHead = 1;

		// Token: 0x0402AA84 RID: 174724
		public const int HeadBase = 2;

		// Token: 0x0402AA85 RID: 174725
		public const int BossIcon = 3;

		// Token: 0x0402AA86 RID: 174726
		public const int FinishIcon = 4;

		// Token: 0x0402AA87 RID: 174727
		public const int StateAttack = 5;
	}
}
