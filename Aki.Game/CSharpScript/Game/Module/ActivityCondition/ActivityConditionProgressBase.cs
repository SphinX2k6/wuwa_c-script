using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A85 RID: 23173
	public abstract class ActivityConditionProgressBase : ActivityConditionBase
	{
		// Token: 0x060391E9 RID: 233961
		[NullableContext(1)]
		protected abstract override bool OnInitialize(ConditionParams conditionParams);

		// Token: 0x060391EA RID: 233962
		public abstract int GetCurrent();

		// Token: 0x060391EB RID: 233963
		public abstract int GetTarget();

		// Token: 0x060391EC RID: 233964 RVA: 0x00FFFFF4 File Offset: 0x00FFE1F4
		protected unsafe override bool ValidateInitialized()
		{
			int target = this.GetTarget();
			if (target > 0)
			{
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityCondition;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[ActivityCondition] 进度条件目标值非法";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("conditionId", base.ConditionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionType", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("target", target);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}

		// Token: 0x060391ED RID: 233965 RVA: 0x01000093 File Offset: 0x00FFE293
		protected sealed override bool OnCheck()
		{
			return this.GetCurrent() >= this.GetTarget();
		}
	}
}
