using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F98 RID: 28568
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowRemoveBuffAction : LevelFlowActionBase
	{
		// Token: 0x0604575A RID: 284506 RVA: 0x0113A5E9 File Offset: 0x011387E9
		public LevelFlowRemoveBuffAction Init(int entityId, List<long> buffIds)
		{
			this.EntityId = entityId;
			this.BuffIds = buffIds;
			return this;
		}

		// Token: 0x0604575B RID: 284507 RVA: 0x0113A5FA File Offset: 0x011387FA
		protected override void OnExecute()
		{
			LevelFlowController.Instance.LevelFlowRemoveBuffRequest(this.BuffIds);
			base.FinishExecute(true);
		}

		// Token: 0x0604575C RID: 284508 RVA: 0x0113A614 File Offset: 0x01138814
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

		// Token: 0x040243E3 RID: 148451
		private int EntityId;

		// Token: 0x040243E4 RID: 148452
		private List<long> BuffIds = new List<long>();
	}
}
