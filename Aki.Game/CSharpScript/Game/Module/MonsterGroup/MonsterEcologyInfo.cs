using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020043A5 RID: 17317
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterEcologyInfo
	{
		// Token: 0x0602BBC8 RID: 179144 RVA: 0x00C46320 File Offset: 0x00C44520
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

		// Token: 0x17005782 RID: 22402
		// (get) Token: 0x0602BBC9 RID: 179145 RVA: 0x00C463A3 File Offset: 0x00C445A3
		// (set) Token: 0x0602BBCA RID: 179146 RVA: 0x00C463AC File Offset: 0x00C445AC
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

		// Token: 0x0602BBCB RID: 179147 RVA: 0x00C463E0 File Offset: 0x00C445E0
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

		// Token: 0x04017933 RID: 96563
		private const float TARGET_END_DISTANCE = 30f;

		// Token: 0x04017934 RID: 96564
		public readonly int PbDataId;

		// Token: 0x04017935 RID: 96565
		public readonly int EntityId;

		// Token: 0x04017936 RID: 96566
		[Nullable(2)]
		public CharacterActorComponent ActorComp;

		// Token: 0x04017937 RID: 96567
		[Nullable(2)]
		public BaseMoveComponent MoveComp;

		// Token: 0x04017938 RID: 96568
		[Nullable(2)]
		public BaseGroupAiComponent GroupAiComp;

		// Token: 0x04017939 RID: 96569
		[Nullable(2)]
		public MonsterGroupEcologyInfo Group;

		// Token: 0x0401793A RID: 96570
		public bool IsCaptain;

		// Token: 0x0401793B RID: 96571
		public Vector TargetLocation = Vector.Create();

		// Token: 0x0401793C RID: 96572
		public Rotator TargetRotator = Rotator.Create();

		// Token: 0x0401793D RID: 96573
		private EGroupEcologyState GroupEcologyStateInternal;
	}
}
