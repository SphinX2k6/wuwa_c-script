using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B19 RID: 27417
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventEnableSplineMoveModel : LevelEventBase
	{
		// Token: 0x060440AC RID: 278700 RVA: 0x010B99B5 File Offset: 0x010B7BB5
		public LevelEventEnableSplineMoveModel(int Id) : base(Id)
		{
		}

		// Token: 0x060440AD RID: 278701 RVA: 0x010B99CC File Offset: 0x010B7BCC
		[NullableContext(1)]
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.InParams = (inParams as EnableSplineMoveModel);
			ISplineMoveConfig config = this.InParams.Config;
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
			bool allowInherit = false;
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
					base.FinishExecute(false, false, true);
					return;
				}
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter == null || !baseCharacter.IsValid())
				{
					this.DelayExecuteList.Add(new ValueTuple<ActionParams, GeneralContext>(inParams, context));
					if (this.DelayExecuteHandle == null)
					{
						this.DelayExecuteHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnRefreshBaseCharacter), 500f, 1f, null, null, true);
					}
					return;
				}
				entity = Global.BaseCharacter.GetEntityNoBlueprint();
				allowInherit = (((IPlayerEntity)config.Target).PlayerTargetType.GetValueOrDefault() == EPlayerTargetType.CurrentTeam);
			}
			else
			{
				if (triggerContext == null)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "EnableSplineMoveModel: Triggered类型必须对应TriggerContext";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", config.Target.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ContextType", context.Type);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					base.FinishExecute(false, false, true);
					return;
				}
				entity = EntitySystem.Instance.Get(triggerContext.OtherEntityId.Value);
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
					base.FinishExecute(false, false, true);
					return;
				}
			}
			BaseSplineMoveComponent baseSplineMoveComponent = (entity != null) ? entity.GetComponent<BaseSplineMoveComponent>() : null;
			if (baseSplineMoveComponent == null || !baseSplineMoveComponent.Valid)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			if (config.Type == ESplineMoveConfigType.Open)
			{
				baseSplineMoveComponent.StartSplineMove(config.SplineEntityId, ((IOpenSplineMove)config).Pattern, allowInherit);
			}
			else
			{
				baseSplineMoveComponent.EndSplineMove(config.SplineEntityId);
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060440AE RID: 278702 RVA: 0x010B9CB0 File Offset: 0x010B7EB0
		private void OnRefreshBaseCharacter(float _)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return;
			}
			TimerSystem.Instance.Remove(this.DelayExecuteHandle);
			this.DelayExecuteHandle = null;
			foreach (ValueTuple<ActionParams, GeneralContext> valueTuple in this.DelayExecuteList)
			{
				ActionParams item = valueTuple.Item1;
				GeneralContext item2 = valueTuple.Item2;
				this.ExecuteNew(item, item2, null);
			}
			this.DelayExecuteList.Clear();
		}

		// Token: 0x060440AF RID: 278703 RVA: 0x010B9D54 File Offset: 0x010B7F54
		protected override void OnReset()
		{
			this.InParams = null;
		}

		// Token: 0x060440B0 RID: 278704 RVA: 0x010B9D60 File Offset: 0x010B7F60
		protected override void OnUpdateGuarantee()
		{
			if (this.InParams == null)
			{
				return;
			}
			EnableSplineMoveModel @params = new EnableSplineMoveModel
			{
				Config = new ICloseSplineMove
				{
					Type = ESplineMoveConfigType.Close,
					Target = this.InParams.Config.Target,
					SplineEntityId = this.InParams.Config.SplineEntityId
				}
			};
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.DisableSplineMoveModel,
				Params = @params
			};
			ESplineMoveConfigType type = this.InParams.Config.Type;
			if (type == ESplineMoveConfigType.Open)
			{
				EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, new bool?(true));
				return;
			}
			if (type != ESplineMoveConfigType.Close)
			{
				return;
			}
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p, new bool?(true));
		}

		// Token: 0x040238E6 RID: 145638
		private const int CHECK_BASE_CHARACTER_INTERVAL = 500;

		// Token: 0x040238E7 RID: 145639
		private EnableSplineMoveModel InParams;

		// Token: 0x040238E8 RID: 145640
		private TimerHandle DelayExecuteHandle;

		// Token: 0x040238E9 RID: 145641
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly List<ValueTuple<ActionParams, GeneralContext>> DelayExecuteList = new List<ValueTuple<ActionParams, GeneralContext>>();
	}
}
