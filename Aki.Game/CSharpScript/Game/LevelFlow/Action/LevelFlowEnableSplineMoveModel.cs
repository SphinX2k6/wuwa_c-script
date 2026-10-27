using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F83 RID: 28547
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowEnableSplineMoveModel : LevelFlowActionBase
	{
		// Token: 0x060456E0 RID: 284384 RVA: 0x011373E9 File Offset: 0x011355E9
		[NullableContext(1)]
		public LevelFlowEnableSplineMoveModel Init(EnableSplineMoveModel inParams, [Nullable(2)] GeneralContext context)
		{
			this.InParams = inParams;
			this.Context = context;
			return this;
		}

		// Token: 0x060456E1 RID: 284385 RVA: 0x011373FC File Offset: 0x011355FC
		protected unsafe override void OnExecute()
		{
			ISplineMoveConfig config = this.InParams.Config;
			GeneralContext context = this.Context;
			TriggerContext triggerContext = context as TriggerContext;
			if (triggerContext != null)
			{
				if (triggerContext.TriggerEntityId != null)
				{
					EntitySystem.Instance.Get(triggerContext.TriggerEntityId.Value);
				}
				if (triggerContext.OtherEntityId != null)
				{
					EntitySystem.Instance.Get(triggerContext.OtherEntityId.Value);
				}
			}
			ETargetEntityType type = config.Target.Type;
			Entity entity;
			if (type != ETargetEntityType.Triggered)
			{
				if (type != ETargetEntityType.Player)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "EnableSplineMoveModel不接受此对象类型";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", config.Target.Type);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					base.FinishExecute(false);
					return;
				}
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter == null || !baseCharacter.IsValid())
				{
					if (this.DelayExecuteHandle == null)
					{
						this.DelayExecuteHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshBaseCharacter), 500f, 1f, null, null, true);
					}
					return;
				}
				entity = Global.BaseCharacter.GetEntityNoBlueprint();
			}
			else
			{
				TriggerContext triggerContext2 = context as TriggerContext;
				if (triggerContext2 == null)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "EnableSplineMoveModel: Triggered类型必须对应TriggerContext";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", config.Target.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ContextType", context.Type);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					base.FinishExecute(false);
					return;
				}
				entity = EntitySystem.Instance.Get(triggerContext2.OtherEntityId.Value);
				if (entity == null || !entity.Valid)
				{
					global::Log instance3 = global::Log.Instance;
					ELogModule module3 = ELogModule.LevelEvent;
					ELogAuthor author3 = ELogAuthor.LCZ;
					string message3 = "EnableSplineMoveModel: 未找到合法的触发者实体";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Type", config.Target.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ContextType", context.Type);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					base.FinishExecute(false);
					return;
				}
			}
			BaseSplineMoveComponent baseSplineMoveComponent = (entity != null) ? entity.GetComponent<BaseSplineMoveComponent>() : null;
			if (baseSplineMoveComponent == null || !baseSplineMoveComponent.Valid)
			{
				base.FinishExecute(false);
				return;
			}
			if (config.Type == ESplineMoveConfigType.Open)
			{
				IOpenSplineMove openSplineMove = config as IOpenSplineMove;
				if (openSplineMove != null)
				{
					baseSplineMoveComponent.StartSplineMove(config.SplineEntityId, openSplineMove.Pattern, false);
					goto IL_292;
				}
			}
			baseSplineMoveComponent.EndSplineMove(config.SplineEntityId);
			IL_292:
			base.FinishExecute(true);
		}

		// Token: 0x060456E2 RID: 284386 RVA: 0x011376A2 File Offset: 0x011358A2
		private void OnRefreshBaseCharacter(float _)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Remove(this.DelayExecuteHandle);
			base.Execute();
		}

		// Token: 0x040243B2 RID: 148402
		private EnableSplineMoveModel InParams;

		// Token: 0x040243B3 RID: 148403
		private GeneralContext Context;

		// Token: 0x040243B4 RID: 148404
		private TimerHandle DelayExecuteHandle;

		// Token: 0x040243B5 RID: 148405
		private const int CHECK_BASE_CHARACTER_INTERVAL = 500;
	}
}
