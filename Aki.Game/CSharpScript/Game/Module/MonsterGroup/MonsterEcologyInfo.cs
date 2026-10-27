using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020053C2 RID: 21442
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterEcologyInfo
	{
		// Token: 0x06036C82 RID: 224386 RVA: 0x00CF7278 File Offset: 0x00CF5478
		public MonsterEcologyInfo(int id, CharacterActorComponent actorComp, MonsterGroupEcologyInfo group, bool isCaptain)
		{
			this.PbDataId = id;
			this.EntityId = actorComp.Entity.Id;
			this.ActorComp = actorComp;
			this.MoveComp = this.ActorComp.Entity.GetComponent<BaseMoveComponent>();
			this.GroupAiComp = this.ActorComp.Entity.GetComponent<BaseGroupAiComponent>();
			this.Group = group;
			this.IsCaptain = isCaptain;
		}

		// Token: 0x170083B6 RID: 33718
		// (get) Token: 0x06036C83 RID: 224387 RVA: 0x00CF72FB File Offset: 0x00CF54FB
		// (set) Token: 0x06036C84 RID: 224388 RVA: 0x00CF7304 File Offset: 0x00CF5504
		public EGroupEcologyState GroupEcologyState
		{
			get
			{
				return this.GroupEcologyStateInternal;
			}
			set
			{
				EGroupEcologyState groupEcologyStateInternal = this.GroupEcologyStateInternal;
				if (value == groupEcologyStateInternal)
				{
					return;
				}
				this.GroupEcologyStateInternal = value;
				if (groupEcologyStateInternal == EGroupEcologyState.Ecology)
				{
					BaseGroupAiComponent groupAiComp = this.GroupAiComp;
					if (groupAiComp == null)
					{
						return;
					}
					groupAiComp.StopEcologyAction();
				}
			}
		}

		// Token: 0x06036C85 RID: 224389 RVA: 0x00CF7338 File Offset: 0x00CF5538
		public static string StateToString(EGroupEcologyState state)
		{
			switch (state)
			{
			case EGroupEcologyState.None:
				return "None";
			case EGroupEcologyState.Ready:
				return "Ready";
			case EGroupEcologyState.Ecology:
				return "Ecology";
			default:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Unknown(");
				defaultInterpolatedStringHandler.AppendFormatted<EGroupEcologyState>(state);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			}
		}

		// Token: 0x0401CE9B RID: 118427
		private const float TARGET_END_DISTANCE = 30f;

		// Token: 0x0401CE9C RID: 118428
		public readonly int PbDataId;

		// Token: 0x0401CE9D RID: 118429
		public readonly int EntityId;

		// Token: 0x0401CE9E RID: 118430
		[Nullable(2)]
		public CharacterActorComponent ActorComp;

		// Token: 0x0401CE9F RID: 118431
		[Nullable(2)]
		public BaseMoveComponent MoveComp;

		// Token: 0x0401CEA0 RID: 118432
		[Nullable(2)]
		public BaseGroupAiComponent GroupAiComp;

		// Token: 0x0401CEA1 RID: 118433
		[Nullable(2)]
		public MonsterGroupEcologyInfo Group;

		// Token: 0x0401CEA2 RID: 118434
		public bool IsCaptain;

		// Token: 0x0401CEA3 RID: 118435
		public Vector TargetLocation = Vector.Create();

		// Token: 0x0401CEA4 RID: 118436
		public Rotator TargetRotator = Rotator.Create();

		// Token: 0x0401CEA5 RID: 118437
		private EGroupEcologyState GroupEcologyStateInternal;
	}
}
