using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200612C RID: 24876
	public class LevelFlowWaitSkillEnd : LevelFlowActionBase
	{
		// Token: 0x0603B958 RID: 244056 RVA: 0x010E632C File Offset: 0x010E452C
		[NullableContext(1)]
		public LevelFlowWaitSkillEnd Init(int skillId, int entityId)
		{
			this.SkillId = skillId;
			this.EntityId = entityId;
			return this;
		}

		// Token: 0x0603B959 RID: 244057 RVA: 0x010E633D File Offset: 0x010E453D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		}

		// Token: 0x0603B95A RID: 244058 RVA: 0x010E6358 File Offset: 0x010E4558
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		}

		// Token: 0x0603B95B RID: 244059 RVA: 0x010E6373 File Offset: 0x010E4573
		private void OnSkillEnd(int entityId, int skillId)
		{
			if (skillId != this.SkillId || entityId != this.EntityId)
			{
				return;
			}
			base.FinishExecute(true);
		}

		// Token: 0x0603B95C RID: 244060 RVA: 0x010E6390 File Offset: 0x010E4590
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
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SkillId", this.SkillId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0401F6BC RID: 128700
		private int SkillId;

		// Token: 0x0401F6BD RID: 128701
		private int EntityId;
	}
}
