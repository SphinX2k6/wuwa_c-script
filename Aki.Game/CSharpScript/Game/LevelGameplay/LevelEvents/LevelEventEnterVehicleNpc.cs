using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B20 RID: 27424
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventEnterVehicleNpc : LevelEventBase
	{
		// Token: 0x060440C1 RID: 278721 RVA: 0x010BA56B File Offset: 0x010B876B
		public LevelEventEnterVehicleNpc(int id) : base(id)
		{
		}

		// Token: 0x060440C2 RID: 278722 RVA: 0x010BA574 File Offset: 0x010B8774
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.Params = (inParams as EnterNpcVehicle);
			this.Context = context;
			if (this.Params == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			int target = this.Params.Target;
			base.CreateWaitEntityTask(this.Params.Target);
		}

		// Token: 0x060440C3 RID: 278723 RVA: 0x010BA5C4 File Offset: 0x010B87C4
		protected override void ExecuteWhenEntitiesReady()
		{
			EnterNpcVehicle @params = this.Params;
			GeneralContext context = this.Context;
			if (@params == null || context == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.ExecuteEnterVehicle(@params, context);
		}

		// Token: 0x060440C4 RID: 278724 RVA: 0x010BA5F8 File Offset: 0x010B87F8
		private void ExecuteEnterVehicle(EnterNpcVehicle config, GeneralContext context)
		{
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
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(config.Target);
			WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
			if (entity2 == null)
			{
				global::Log.Instance.Error(ELogModule.Vehicle, ELogAuthor.YJX, "进入载具NPC时无法获取目标乘客", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			BaseVehiclePerformComponent baseVehiclePerformComponent = (worldEntity != null) ? worldEntity.GetComponent<BaseVehiclePerformComponent>() : null;
			if (baseVehiclePerformComponent == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "进入载具NPC时获取目标载具实体失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TargetVehicle", config.Target);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false, false, true);
				return;
			}
			baseVehiclePerformComponent.TryEnter(entity2, config.Seat);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x040238ED RID: 145645
		[Nullable(2)]
		private EnterNpcVehicle Params;

		// Token: 0x040238EE RID: 145646
		[Nullable(2)]
		private GeneralContext Context;
	}
}
