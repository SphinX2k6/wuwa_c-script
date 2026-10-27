using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x02007102 RID: 28930
	[NullableContext(1)]
	[Nullable(0)]
	internal class SelfieSightLimitSnapshot
	{
		// Token: 0x06046A06 RID: 289286 RVA: 0x011C6098 File Offset: 0x011C4298
		public SelfieSightLimitSnapshot(CharacterAnimationComponent animComp)
		{
			this.SightLockDataCache = animComp.GetSightLockData();
			if (this.SightLockDataCache == null)
			{
				Log.Instance.Warn(ELogModule.PhotoCamera, ELogAuthor.ZJL, "[Selfie] ApplyLimit SightLockDataCache 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06046A07 RID: 289287 RVA: 0x011C60E0 File Offset: 0x011C42E0
		public void ApplyLimit(CharacterAnimationComponent animComp, float[] pitchLimit, float[] yawLimit, FVector? sightDirectInSightBone, FVector? upAxisInSightBone)
		{
			if (this.SightLockDataCache == null)
			{
				Log.Instance.Warn(ELogModule.PhotoCamera, ELogAuthor.ZJL, "[Selfie] ApplyLimit SightLockDataCache 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			animComp.SetSightBoneLimit(yawLimit[0], yawLimit[1], pitchLimit[0], pitchLimit[1], 0f, sightDirectInSightBone ?? this.SightLockDataCache.SightDirectInSightBone, upAxisInSightBone ?? this.SightLockDataCache.UpAxisInSightBone);
		}

		// Token: 0x06046A08 RID: 289288 RVA: 0x011C616C File Offset: 0x011C436C
		public void Restore(CharacterAnimationComponent animComp)
		{
			if (this.SightLockDataCache == null)
			{
				Log.Instance.Warn(ELogModule.PhotoCamera, ELogAuthor.ZJL, "[Selfie] Restore SightLockDataCache 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			animComp.SetSightBoneLimit(this.SightLockDataCache.YawLimit[0], this.SightLockDataCache.YawLimit[1], this.SightLockDataCache.PitchLimit[0], this.SightLockDataCache.PitchLimit[1], this.SightLockDataCache.AssistLimit, this.SightLockDataCache.SightDirectInSightBone, this.SightLockDataCache.UpAxisInSightBone);
		}

		// Token: 0x04025112 RID: 151826
		[Nullable(2)]
		private readonly SightLockData SightLockDataCache;
	}
}
