using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Net
{
	// Token: 0x0200012F RID: 303
	public class NetGameBudgetOnceTaskGroup : IGameBudgetOnceTaskGroup
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00035668 File Offset: 0x00033868
		public FName GroupId
		{
			get
			{
				return this.GroupIdInternal;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00035670 File Offset: 0x00033870
		public int Priority
		{
			get
			{
				return this.PriorityInternal;
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00035678 File Offset: 0x00033878
		public bool IsEmpty()
		{
			Func<bool> isEmptyFuncInternal = this.IsEmptyFuncInternal;
			return isEmptyFuncInternal == null || isEmptyFuncInternal();
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0003568B File Offset: 0x0003388B
		public void Consume()
		{
			Action consumeAction = this.ConsumeAction;
			if (consumeAction == null)
			{
				return;
			}
			consumeAction();
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0003569D File Offset: 0x0003389D
		[NullableContext(1)]
		public NetGameBudgetOnceTaskGroup(FName groupId, int priority, Func<bool> isEmptyFunc, Action consumeAction)
		{
			this.GroupIdInternal = groupId;
			this.PriorityInternal = priority;
			this.IsEmptyFuncInternal = isEmptyFunc;
			this.ConsumeAction = consumeAction;
		}

		// Token: 0x040006C2 RID: 1730
		private FName GroupIdInternal;

		// Token: 0x040006C3 RID: 1731
		private int PriorityInternal;

		// Token: 0x040006C4 RID: 1732
		[Nullable(2)]
		private Func<bool> IsEmptyFuncInternal;

		// Token: 0x040006C5 RID: 1733
		[Nullable(2)]
		private Action ConsumeAction;
	}
}
