using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C98 RID: 23704
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventEnterVehicleNpc : LevelEventBase
	{
		// Token: 0x0603A213 RID: 238099 RVA: 0x01063DF7 File Offset: 0x01061FF7
		public LevelEventEnterVehicleNpc(int id) : base(id)
		{
		}

		// Token: 0x0603A214 RID: 238100 RVA: 0x01063E00 File Offset: 0x01062000
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

		// Token: 0x0603A215 RID: 238101 RVA: 0x01063E50 File Offset: 0x01062050
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

		// Token: 0x0603A216 RID: 238102 RVA: 0x01063E84 File Offset: 0x01062084
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

		// Token: 0x0401EB8F RID: 125839
		[Nullable(2)]
		private EnterNpcVehicle Params;

		// Token: 0x0401EB90 RID: 125840
		[Nullable(2)]
		private GeneralContext Context;
	}
}
