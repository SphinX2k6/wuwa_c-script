using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x020060F8 RID: 24824
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSphereRangeCondition : LevelFlowConditionBase
	{
		// Token: 0x0603B84F RID: 243791 RVA: 0x010DEADC File Offset: 0x010DCCDC
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

		// Token: 0x0603B850 RID: 243792 RVA: 0x010DEB98 File Offset: 0x010DCD98
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

		// Token: 0x0401F644 RID: 128580
		private float RadiusSquared;

		// Token: 0x0401F645 RID: 128581
		private Vector Center = Vector.ZeroVectorProxy;

		// Token: 0x0401F646 RID: 128582
		[Nullable(2)]
		private BaseActorComponent TargetActorComponent;
	}
}
