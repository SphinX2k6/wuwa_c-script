using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F7F RID: 28543
	public class LevelFlowChangeEntityGravityAction : LevelFlowActionBase
	{
		// Token: 0x060456D0 RID: 284368 RVA: 0x0113702D File Offset: 0x0113522D
		[NullableContext(1)]
		public LevelFlowChangeEntityGravityAction Init(int entityId, global::Vector gravity)
		{
			this.EntityId = entityId;
			this.Gravity = gravity;
			return this;
		}

		// Token: 0x060456D1 RID: 284369 RVA: 0x01137040 File Offset: 0x01135240
		protected override void OnExecute()
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.EntityId);
			if (entityById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("EntityId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.EntityId);
				defaultInterpolatedStringHandler.AppendLiteral(" not found");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			CreatureDataComponent component = entityById.Entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelFlow;
				ELogAuthor author2 = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
				defaultInterpolatedStringHandler.AppendLiteral("EntityId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.EntityId);
				defaultInterpolatedStringHandler.AppendLiteral(" not found CreatureDataComponent");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			if (component.GetEntityType() == EEntityType.Vehicle)
			{
				VehicleGravityComponent component2 = entityById.Entity.GetComponent<VehicleGravityComponent>();
				if (component2 != null)
				{
					component2.SetGravityDirectForVehicle(0, this.Gravity, false, -1f, false);
				}
			}
			else
			{
				BaseGravityComponent component3 = entityById.Entity.GetComponent<BaseGravityComponent>();
				if (component3 != null)
				{
					component3.SetGravityByPriority(0, this.Gravity, true, -1f, true);
				}
			}
			base.FinishExecute(true);
		}

		// Token: 0x040243AB RID: 148395
		private int EntityId;

		// Token: 0x040243AC RID: 148396
		[Nullable(2)]
		private global::Vector Gravity;
	}
}
