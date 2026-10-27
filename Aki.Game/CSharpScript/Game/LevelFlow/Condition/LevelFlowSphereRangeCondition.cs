using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x02006F77 RID: 28535
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSphereRangeCondition : LevelFlowConditionBase
	{
		// Token: 0x060456A1 RID: 284321 RVA: 0x01134CD8 File Offset: 0x01132ED8
		public LevelFlowSphereRangeCondition Init(float radius, Vector center)
		{
			if (Global.BaseCharacter == null)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "Invalid BaseCharacter", default(ReadOnlySpan<ValueTuple<string, object>>));
				return this;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(Global.BaseCharacter.EntityId);
			if (entityById == null || !entityById.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Invalid EntityId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetEntityId", Global.BaseCharacter.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return this;
			}
			this.TargetActorComponent = entityById.Entity.CheckGetComponent<BaseActorComponent>();
			if (this.TargetActorComponent == null)
			{
				return this;
			}
			this.RadiusSquared = radius * radius;
			this.Center = center;
			return this;
		}

		// Token: 0x060456A2 RID: 284322 RVA: 0x01134D94 File Offset: 0x01132F94
		protected override void OnTick(float delta)
		{
			if (this.TargetActorComponent == null || !this.TargetActorComponent.Valid)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "TargetActorComponent is invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			if (Vector.DistSquared(this.TargetActorComponent.ActorLocationProxy, this.Center) <= (double)this.RadiusSquared)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0402438F RID: 148367
		private float RadiusSquared;

		// Token: 0x04024390 RID: 148368
		private Vector Center = Vector.ZeroVectorProxy;

		// Token: 0x04024391 RID: 148369
		[Nullable(2)]
		private BaseActorComponent TargetActorComponent;
	}
}
