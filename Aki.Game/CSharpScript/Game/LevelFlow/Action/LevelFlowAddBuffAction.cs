using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F7A RID: 28538
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowAddBuffAction : LevelFlowActionBase
	{
		// Token: 0x060456BA RID: 284346 RVA: 0x0113528B File Offset: 0x0113348B
		public LevelFlowAddBuffAction Init(int entityId, List<long> buffIds)
		{
			this.EntityId = entityId;
			this.BuffIds = buffIds;
			return this;
		}

		// Token: 0x060456BB RID: 284347 RVA: 0x0113529C File Offset: 0x0113349C
		protected override void OnExecute()
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.EntityId);
			if (entityById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Entity加载超时或已被移除";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false);
				return;
			}
			WorldEntity entity = entityById.Entity;
			if (entity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelFlow;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "未找到实体";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			if (entity.GetComponent<CharacterBuffComponent>() == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LevelFlow;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "实体没有BuffComponent";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("EntityId", this.EntityId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				base.FinishExecute(false);
				return;
			}
			LevelFlowController.Instance.LevelFlowAddBuffRequest(this.BuffIds);
			base.FinishExecute(true);
		}

		// Token: 0x060456BC RID: 284348 RVA: 0x0113539C File Offset: 0x0113359C
		protected unsafe override void LogExecuteInfo()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", this.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BuffIds", string.Join<long>(",", this.BuffIds));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x04024399 RID: 148377
		private int EntityId;

		// Token: 0x0402439A RID: 148378
		private List<long> BuffIds = new List<long>();
	}
}
