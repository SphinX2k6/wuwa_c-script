using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Npc.Logics
{
	// Token: 0x020062FB RID: 25339
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayingMontageInfo
	{
		// Token: 0x0603D4AC RID: 251052 RVA: 0x011B5D0C File Offset: 0x011B3F0C
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

		// Token: 0x0603D4AD RID: 251053 RVA: 0x011B5D70 File Offset: 0x011B3F70
		public bool CheckPlayCondition()
		{
			return this.OnCheckPlayCondition == null || this.OnCheckPlayCondition(this);
		}

		// Token: 0x0603D4AE RID: 251054 RVA: 0x011B5D88 File Offset: 0x011B3F88
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

		// Token: 0x0603D4AF RID: 251055 RVA: 0x011B5DF7 File Offset: 0x011B3FF7
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

		// Token: 0x0603D4B0 RID: 251056 RVA: 0x011B5E14 File Offset: 0x011B4014
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

		// Token: 0x04020821 RID: 133153
		public int Uid;

		// Token: 0x04020822 RID: 133154
		public int EntityId;

		// Token: 0x04020823 RID: 133155
		[Nullable(1)]
		public string MontagePath = "";

		// Token: 0x04020824 RID: 133156
		public PlayMontageConfig MontageConfig;

		// Token: 0x04020825 RID: 133157
		public CharacterAnimationComponent AnimComp;

		// Token: 0x04020826 RID: 133158
		public UAnimMontage BodyMontage;

		// Token: 0x04020827 RID: 133159
		public TimerHandle TimerHandle;

		// Token: 0x04020828 RID: 133160
		private Func<PlayingMontageInfo, bool> OnCheckPlayCondition;

		// Token: 0x04020829 RID: 133161
		private Action<PlayingMontageInfo> OnPlayMontage;

		// Token: 0x0402082A RID: 133162
		private Action<PlayingMontageInfo> OnStopMontage;
	}
}
