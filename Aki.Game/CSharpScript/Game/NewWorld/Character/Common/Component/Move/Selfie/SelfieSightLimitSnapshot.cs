using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x020063B2 RID: 25522
	[NullableContext(1)]
	[Nullable(0)]
	internal class SelfieSightLimitSnapshot
	{
		// Token: 0x0603DE05 RID: 253445 RVA: 0x011F50B8 File Offset: 0x011F32B8
		public SelfieSightLimitSnapshot(CharacterAnimationComponent animComp)
		{
			this.SightLockDataCache = animComp.GetSightLockData();
			if (this.SightLockDataCache == null)
			{
				Log.Instance.Warn(ELogModule.PhotoCamera, ELogAuthor.ZJL, "[Selfie] ApplyLimit SightLockDataCache 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0603DE06 RID: 253446 RVA: 0x011F5100 File Offset: 0x011F3300
		public void ApplyLimit(CharacterAnimationComponent animComp, float[] pitchLimit, float[] yawLimit, FVector? sightDirectInSightBone, FVector? upAxisInSightBone)
		{
			if (this.SightLockDataCache == null)
			{
				Log.Instance.Warn(ELogModule.PhotoCamera, ELogAuthor.ZJL, "[Selfie] ApplyLimit SightLockDataCache 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			animComp.SetSightBoneLimit(yawLimit[0], yawLimit[1], pitchLimit[0], pitchLimit[1], 0f, sightDirectInSightBone ?? this.SightLockDataCache.SightDirectInSightBone, upAxisInSightBone ?? this.SightLockDataCache.UpAxisInSightBone);
		}

		// Token: 0x0603DE07 RID: 253447 RVA: 0x011F518C File Offset: 0x011F338C
		public void Restore(CharacterAnimationComponent animComp)
		{
			if (this.SightLockDataCache == null)
			{
				Log.Instance.Warn(ELogModule.PhotoCamera, ELogAuthor.ZJL, "[Selfie] Restore SightLockDataCache 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			animComp.SetSightBoneLimit(this.SightLockDataCache.YawLimit[0], this.SightLockDataCache.YawLimit[1], this.SightLockDataCache.PitchLimit[0], this.SightLockDataCache.PitchLimit[1], this.SightLockDataCache.AssistLimit, this.SightLockDataCache.SightDirectInSightBone, this.SightLockDataCache.UpAxisInSightBone);
		}

		// Token: 0x04020DA7 RID: 134567
		[Nullable(2)]
		private readonly SightLockData SightLockDataCache;
	}
}
