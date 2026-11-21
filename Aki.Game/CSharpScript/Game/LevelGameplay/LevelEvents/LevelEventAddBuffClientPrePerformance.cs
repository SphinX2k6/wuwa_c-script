using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C64 RID: 23652
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LevelEventAddBuffClientPrePerformance : LevelEventBase
	{
		// Token: 0x0603A11D RID: 237853 RVA: 0x01057670 File Offset: 0x01055870
		protected LevelEventAddBuffClientPrePerformance(int id) : base(id)
		{
		}

		// Token: 0x0603A11E RID: 237854
		[return: Nullable(2)]
		protected abstract EntityHandle GetTargetEntity(TriggerContext context);

		// Token: 0x0603A11F RID: 237855
		protected abstract List<long> GetBuffIds(ActionParams inParams);

		// Token: 0x0603A120 RID: 237856 RVA: 0x01057679 File Offset: 0x01055879
		[return: Nullable(2)]
		protected EntityHandle GetTriggerEntity(TriggerContext context)
		{
			return CreatureModel.Instance.GetEntityById(context.TriggerEntityId.Value);
		}

		// Token: 0x0603A121 RID: 237857 RVA: 0x01057690 File Offset: 0x01055890
		[return: Nullable(2)]
		protected EntityHandle GetOtherEntity(TriggerContext context)
		{
			return CreatureModel.Instance.GetEntityById(context.OtherEntityId.Value);
		}

		// Token: 0x0603A122 RID: 237858 RVA: 0x010576A7 File Offset: 0x010558A7
		protected string GetDebugName()
		{
			return base.GetType().Name;
		}

		// Token: 0x0603A123 RID: 237859 RVA: 0x010576B4 File Offset: 0x010558B4
		protected unsafe long GetPreMessageId(EntityHandle entityHandle)
		{
			ClientTriggerComponent component = entityHandle.Entity.GetComponent<ClientTriggerComponent>();
			if (component == null || !component.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[" + this.GetDebugName() + "] 触发器所属实体获取ClientTriggerComponent失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityHandle", entityHandle);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("clientTriggerComponent", component);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return 0L;
			}
			return component.ClientPrePerformancePreMessageId;
		}

		// Token: 0x0603A124 RID: 237860 RVA: 0x0105774C File Offset: 0x0105594C
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (!(context.Type != EGeneralContextType.Trigger))
			{
				EntityHandle targetEntity = this.GetTargetEntity(context as TriggerContext);
				if (targetEntity == null || !targetEntity.Valid)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "[" + this.GetDebugName() + "] 加Buff的目标实体不存在或者无效";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetEntityHandle", targetEntity);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				EntityHandle triggerEntity = this.GetTriggerEntity(context as TriggerContext);
				if (triggerEntity == null || !triggerEntity.Valid)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.XDW;
					string message2 = "[" + this.GetDebugName() + "] 触发器组件所属实体不存在或者无效";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("triggerEntityHandle", triggerEntity);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				long preMessageId = this.GetPreMessageId(triggerEntity);
				if (preMessageId == 0L)
				{
					global::Log instance3 = global::Log.Instance;
					ELogModule module3 = ELogModule.LevelEvent;
					ELogAuthor author3 = ELogAuthor.XDW;
					string message3 = "[" + this.GetDebugName() + "] 获取PreMessageId失败";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("preMessageId", preMessageId);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return;
				}
				BaseBuffComponent component = targetEntity.Entity.GetComponent<BaseBuffComponent>();
				if (component == null || !component.Valid)
				{
					global::Log instance4 = global::Log.Instance;
					ELogModule module4 = ELogModule.LevelEvent;
					ELogAuthor author4 = ELogAuthor.XDW;
					string message4 = "[" + this.GetDebugName() + "] 获取 BuffComponent失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffComponent", component);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetEntityHandle", targetEntity);
					instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				using (List<long>.Enumerator enumerator = this.GetBuffIds(inParams).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						long buffId = enumerator.Current;
						component.AddBuff(buffId, new AddBuffParam
						{
							InstigatorId = triggerEntity.CreatureDataId,
							Level = new int?(1),
							PreMessageId = new long?(preMessageId),
							Reason = "[" + this.GetDebugName() + "] ExecuteNew"
						});
					}
					return;
				}
			}
			global::Log instance5 = global::Log.Instance;
			ELogModule module5 = ELogModule.LevelEvent;
			ELogAuthor author5 = ELogAuthor.XDW;
			string message5 = "[" + this.GetDebugName() + "] 未支持的context.Type";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("context", context);
			instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		}
	}
}
