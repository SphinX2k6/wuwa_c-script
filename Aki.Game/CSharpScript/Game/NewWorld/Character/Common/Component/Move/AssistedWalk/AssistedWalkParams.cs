using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk
{
	// Token: 0x0200710A RID: 28938
	[NullableContext(1)]
	[Nullable(0)]
	public class AssistedWalkParams : AttachMoveParams
	{
		// Token: 0x17009D0B RID: 40203
		// (get) Token: 0x06046A56 RID: 289366 RVA: 0x011C81E8 File Offset: 0x011C63E8
		public static AssistedWalkParams Default { get; } = new AssistedWalkParams(null);

		// Token: 0x06046A57 RID: 289367 RVA: 0x011C81F0 File Offset: 0x011C63F0
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

		// Token: 0x04025156 RID: 151894
		public List<int> LeaderGameplayTagList = new List<int>();

		// Token: 0x04025157 RID: 151895
		public float BaseMoveSpeed = 45f;

		// Token: 0x04025158 RID: 151896
		public float LeaderTurnSpeed = 30f;

		// Token: 0x04025159 RID: 151897
		public Vector2D AnimSpeedRateRange = new Vector2D(1.0, 1.0);

		// Token: 0x0402515A RID: 151898
		public Transform StartTransform = Transform.Create();
	}
}
