using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FA6 RID: 28582
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowVehicleForceStopPathLineMove : LevelFlowActionBase
	{
		// Token: 0x0604578F RID: 284559 RVA: 0x0113BD23 File Offset: 0x01139F23
		[NullableContext(1)]
		public LevelFlowVehicleForceStopPathLineMove Init(ETargetVehicle type, int? entityId = null)
		{
			this.Type = new ETargetVehicle?(type);
			this.EntityId = entityId;
			return this;
		}

		// Token: 0x06045790 RID: 284560 RVA: 0x0113BD3C File Offset: 0x01139F3C
		protected unsafe override void OnExecute()
		{
			Entity targetVehicleEntity = this.GetTargetVehicleEntity(this.Type.Value, this.EntityId);
			if (targetVehicleEntity == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "目标实体不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", this.Type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.FinishExecute(true);
				return;
			}
			VehicleSplineMoveComponent component = targetVehicleEntity.GetComponent<VehicleSplineMoveComponent>();
			if (component != null)
			{
				component.ForceStopSplineMove();
			}
			base.FinishExecute(true);
		}

		// Token: 0x06045791 RID: 284561 RVA: 0x0113BDF0 File Offset: 0x01139FF0
		private Entity GetTargetVehicleEntity(ETargetVehicle type, int? entityId)
		{
			if (type == ETargetVehicle.Current)
			{
				return this.GetVehicleEntityFromPlayerRole();
			}
			if (type != ETargetVehicle.Appointed)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "不支持的目标类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (entityId == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YJX, "目标类型为Appointed时，entityId不能为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId.Value);
			if (entityByPbDataId == null)
			{
				return null;
			}
			return entityByPbDataId.Entity;
		}

		// Token: 0x06045792 RID: 284562 RVA: 0x0113BE80 File Offset: 0x0113A080
		private Entity GetVehicleEntityFromPlayerRole()
		{
			if (Global.BaseCharacter == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YJX, "获取玩家载具失败，找不到全局玩家角色", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			Entity entity = Global.BaseCharacter.CharacterActorComponent.Entity;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null;
			if (characterDriveVehicleComponent == null)
			{
				return null;
			}
			return characterDriveVehicleComponent.VehicleEntity;
		}

		// Token: 0x04024400 RID: 148480
		private ETargetVehicle? Type;

		// Token: 0x04024401 RID: 148481
		private int? EntityId;
	}
}
