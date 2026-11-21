using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006106 RID: 24838
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowEnterVehicleNpc : LevelFlowActionBase
	{
		// Token: 0x0603B896 RID: 243862 RVA: 0x010E1647 File Offset: 0x010DF847
		public LevelFlowEnterVehicleNpc Init(EnterNpcVehicle params_)
		{
			this.Params = params_;
			return this;
		}

		// Token: 0x0603B897 RID: 243863 RVA: 0x010E1651 File Offset: 0x010DF851
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		}

		// Token: 0x0603B898 RID: 243864 RVA: 0x010E166F File Offset: 0x010DF86F
		protected override void OnExecute()
		{
			if (this.Params == null)
			{
				base.FinishExecute(false);
				return;
			}
			if (this.Params.Target == 0)
			{
				base.FinishExecute(false);
				return;
			}
			base.CreateWaitEntityTask(this.Params.Target);
		}

		// Token: 0x0603B899 RID: 243865 RVA: 0x010E16AC File Offset: 0x010DF8AC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		}

		// Token: 0x0603B89A RID: 243866 RVA: 0x010E16CC File Offset: 0x010DF8CC
		protected override void ExecuteWhenEntitiesReady()
		{
			if (this.Params == null)
			{
				base.FinishExecute(false);
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity;
			if (baseCharacter == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.Params.Target);
			WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
			if (entity2 == null)
			{
				global::Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "进入载具NPC时无法获取目标乘客", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			if (worldEntity == null)
			{
				global::Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "进入载具NPC时无法获取目标载具", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			BaseVehiclePerformComponent component = worldEntity.GetComponent<BaseVehiclePerformComponent>();
			if (component == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "进入载具NPC时获取目标载具实体失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TargetVehicle", this.Params.Target);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false);
				return;
			}
			CharacterDriveVehicleComponent component2 = entity2.GetComponent<CharacterDriveVehicleComponent>();
			if (component2 == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelFlow;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "进入载具NPC时获取目标载具实体失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("TargetVehicle", this.Params.Target);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			if (component2.IsOnVehicle)
			{
				base.FinishExecute(true);
				return;
			}
			if (!component.TryEnter(entity2, this.Params.Seat))
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.LevelFlow;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "进入载具NPC时尝试进入载具失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("TargetVehicle", this.Params.Target);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				base.FinishExecute(false);
			}
		}

		// Token: 0x0603B89B RID: 243867 RVA: 0x010E187C File Offset: 0x010DFA7C
		private void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.Params.Target);
			WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
			if (info.VehicleEntity != null)
			{
				int id = info.VehicleEntity.Id;
				int? num = (worldEntity != null) ? new int?(worldEntity.Id) : null;
				if (id == num.GetValueOrDefault() & num != null)
				{
					base.FinishExecute(true);
				}
			}
		}

		// Token: 0x0401F66C RID: 128620
		[Nullable(2)]
		private EnterNpcVehicle Params;
	}
}
