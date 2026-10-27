using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AEC RID: 27372
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LevelEventAddBuffClientPrePerformance : LevelEventBase
	{
		// Token: 0x06043FCB RID: 278475 RVA: 0x010ADDF4 File Offset: 0x010ABFF4
		protected LevelEventAddBuffClientPrePerformance(int id) : base(id)
		{
		}

		// Token: 0x06043FCC RID: 278476
		[return: Nullable(2)]
		protected abstract EntityHandle GetTargetEntity(TriggerContext context);

		// Token: 0x06043FCD RID: 278477
		protected abstract List<long> GetBuffIds(ActionParams inParams);

		// Token: 0x06043FCE RID: 278478 RVA: 0x010ADDFD File Offset: 0x010ABFFD
		[return: Nullable(2)]
		protected EntityHandle GetTriggerEntity(TriggerContext context)
		{
			return CreatureModel.Instance.GetEntityById(context.TriggerEntityId.Value);
		}

		// Token: 0x06043FCF RID: 278479 RVA: 0x010ADE14 File Offset: 0x010AC014
		[return: Nullable(2)]
		protected EntityHandle GetOtherEntity(TriggerContext context)
		{
			return CreatureModel.Instance.GetEntityById(context.OtherEntityId.Value);
		}

		// Token: 0x06043FD0 RID: 278480 RVA: 0x010ADE2B File Offset: 0x010AC02B
		protected string GetDebugName()
		{
			return base.GetType().Name;
		}

		// Token: 0x06043FD1 RID: 278481 RVA: 0x010ADE38 File Offset: 0x010AC038
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

		// Token: 0x06043FD2 RID: 278482 RVA: 0x010ADED0 File Offset: 0x010AC0D0
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
