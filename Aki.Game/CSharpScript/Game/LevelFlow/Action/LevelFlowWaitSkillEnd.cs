using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FAB RID: 28587
	public class LevelFlowWaitSkillEnd : LevelFlowActionBase
	{
		// Token: 0x060457AA RID: 284586 RVA: 0x0113C528 File Offset: 0x0113A728
		[NullableContext(1)]
		public LevelFlowWaitSkillEnd Init(int skillId, int entityId)
		{
			this.SkillId = skillId;
			this.EntityId = entityId;
			return this;
		}

		// Token: 0x060457AB RID: 284587 RVA: 0x0113C539 File Offset: 0x0113A739
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		}

		// Token: 0x060457AC RID: 284588 RVA: 0x0113C554 File Offset: 0x0113A754
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		}

		// Token: 0x060457AD RID: 284589 RVA: 0x0113C56F File Offset: 0x0113A76F
		private void OnSkillEnd(int entityId, int skillId)
		{
			if (skillId != this.SkillId || entityId != this.EntityId)
			{
				return;
			}
			base.FinishExecute(true);
		}

		// Token: 0x060457AE RID: 284590 RVA: 0x0113C58C File Offset: 0x0113A78C
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

		// Token: 0x04024407 RID: 148487
		private int SkillId;

		// Token: 0x04024408 RID: 148488
		private int EntityId;
	}
}
