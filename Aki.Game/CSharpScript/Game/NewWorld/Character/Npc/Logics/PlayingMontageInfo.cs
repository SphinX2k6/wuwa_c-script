using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Npc.Logics
{
	// Token: 0x02007096 RID: 28822
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayingMontageInfo
	{
		// Token: 0x060463C1 RID: 287681 RVA: 0x01192C00 File Offset: 0x01190E00
		[NullableContext(1)]
		public PlayingMontageInfo(CharacterAnimationComponent animComp, int uid, string path, PlayMontageConfig config, [Nullable(2)] Action<PlayingMontageInfo> onPlay = null, [Nullable(2)] Action<PlayingMontageInfo> onStop = null, [Nullable(2)] Func<PlayingMontageInfo, bool> onCheck = null)
		{
			this.EntityId = animComp.Entity.Id;
			this.AnimComp = animComp;
			this.Uid = uid;
			this.MontagePath = path;
			this.MontageConfig = config;
			this.OnPlayMontage = onPlay;
			this.OnStopMontage = onStop;
			this.OnCheckPlayCondition = onCheck;
		}

		// Token: 0x060463C2 RID: 287682 RVA: 0x01192C64 File Offset: 0x01190E64
		public bool CheckPlayCondition()
		{
			return this.OnCheckPlayCondition == null || this.OnCheckPlayCondition(this);
		}

		// Token: 0x060463C3 RID: 287683 RVA: 0x01192C7C File Offset: 0x01190E7C
		public void OnClearInfo()
		{
			if (this.OnStopMontage != null)
			{
				this.OnStopMontage(this);
			}
			if (this.TimerHandle != null && TimerSystem.Instance.Has(this.TimerHandle))
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
			this.MontageConfig = null;
			this.OnPlayMontage = null;
			this.OnStopMontage = null;
			this.OnCheckPlayCondition = null;
		}

		// Token: 0x060463C4 RID: 287684 RVA: 0x01192CEB File Offset: 0x01190EEB
		public void PlayMontageLoop([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			2
		})] Action<BaseAnimationComponent, PlayingMontageInfo, bool?, Action<UAnimMontage, bool>> endCallback)
		{
			if (this.OnPlayMontage != null)
			{
				this.OnPlayMontage(this);
			}
			this.PlayMontageLogic(endCallback);
		}

		// Token: 0x060463C5 RID: 287685 RVA: 0x01192D08 File Offset: 0x01190F08
		private void PlayMontageLogic([Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			2
		})] Action<BaseAnimationComponent, PlayingMontageInfo, bool?, Action<UAnimMontage, bool>> endCallback)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null || !animComp.Valid)
			{
				return;
			}
			if (this.MontageConfig.IsInfiniteLoop && this.MontageConfig.IsPlayLoop)
			{
				PlayMontageUtils.Instance.Play(this.AnimComp, this.BodyMontage, null);
				return;
			}
			double num;
			if (this.MontageConfig.IsPlayLoop)
			{
				num = this.MontageConfig.PlayMontageTime;
				PlayMontageUtils.Instance.Play(this.AnimComp, this.BodyMontage, null);
			}
			else
			{
				num = this.MontageConfig.OncePlayTime;
				PlayMontageUtils.Instance.PlayOnce(this.AnimComp, this.BodyMontage, null);
			}
			this.MontageConfig.PlayMontageTime = this.MontageConfig.PlayMontageTime - num;
			if (!this.MontageConfig.IsInfiniteLoop && this.MontageConfig.PlayMontageTime <= 20.0)
			{
				this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.TimerHandle = null;
					CharacterAnimationComponent animComp2 = this.AnimComp;
					if (animComp2 == null || !animComp2.Valid)
					{
						return;
					}
					endCallback(this.AnimComp, this, null, null);
				}, (float)((int)num), null, null, true, 1f);
				return;
			}
			this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.TimerHandle = null;
				this.PlayMontageLoop(endCallback);
			}, (float)((int)num), null, null, true, 1f);
		}

		// Token: 0x04024CCF RID: 150735
		public int Uid;

		// Token: 0x04024CD0 RID: 150736
		public int EntityId;

		// Token: 0x04024CD1 RID: 150737
		[Nullable(1)]
		public string MontagePath = "";

		// Token: 0x04024CD2 RID: 150738
		public PlayMontageConfig MontageConfig;

		// Token: 0x04024CD3 RID: 150739
		public CharacterAnimationComponent AnimComp;

		// Token: 0x04024CD4 RID: 150740
		public UAnimMontage BodyMontage;

		// Token: 0x04024CD5 RID: 150741
		public TimerHandle TimerHandle;

		// Token: 0x04024CD6 RID: 150742
		private Func<PlayingMontageInfo, bool> OnCheckPlayCondition;

		// Token: 0x04024CD7 RID: 150743
		private Action<PlayingMontageInfo> OnPlayMontage;

		// Token: 0x04024CD8 RID: 150744
		private Action<PlayingMontageInfo> OnStopMontage;
	}
}
