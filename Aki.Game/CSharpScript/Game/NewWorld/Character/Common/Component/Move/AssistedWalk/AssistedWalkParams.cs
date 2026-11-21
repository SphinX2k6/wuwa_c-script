using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk
{
	// Token: 0x020063BA RID: 25530
	[NullableContext(1)]
	[Nullable(0)]
	public class AssistedWalkParams : AttachMoveParams
	{
		// Token: 0x1700759A RID: 30106
		// (get) Token: 0x0603DE55 RID: 253525 RVA: 0x011F7208 File Offset: 0x011F5408
		public static AssistedWalkParams Default { get; } = new AssistedWalkParams(null);

		// Token: 0x0603DE56 RID: 253526 RVA: 0x011F7210 File Offset: 0x011F5410
		[NullableContext(2)]
		public AssistedWalkParams(BP_AssistedWalkConfig_C data = null) : base(data)
		{
			if (data == null)
			{
				return;
			}
			this.BaseMoveSpeed = (float)data.BaseMoveSpeed;
			this.LeaderTurnSpeed = (float)data.LeaderTurnSpeed;
			this.AnimSpeedRateRange.Set((double)data.AnimSpeedRateRange.X, (double)data.AnimSpeedRateRange.Y);
			Transform startTransform = this.StartTransform;
			FTransform startTransform2 = data.StartTransform;
			startTransform.FromUeTransform(startTransform2);
			for (int i = 0; i < data.LeaderGameplayTagList.GameplayTags.Num(); i++)
			{
				this.LeaderGameplayTagList.Add(data.LeaderGameplayTagList.GameplayTags.Get(i).TagId());
			}
		}

		// Token: 0x04020DEB RID: 134635
		public List<int> LeaderGameplayTagList = new List<int>();

		// Token: 0x04020DEC RID: 134636
		public float BaseMoveSpeed = 45f;

		// Token: 0x04020DED RID: 134637
		public float LeaderTurnSpeed = 30f;

		// Token: 0x04020DEE RID: 134638
		public Vector2D AnimSpeedRateRange = new Vector2D(1.0, 1.0);

		// Token: 0x04020DEF RID: 134639
		public Transform StartTransform = Transform.Create();
	}
}
