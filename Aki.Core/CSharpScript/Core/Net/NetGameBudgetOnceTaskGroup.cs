using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Net
{
	// Token: 0x0200012E RID: 302
	public class NetGameBudgetOnceTaskGroup : IGameBudgetOnceTaskGroup
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00034BF4 File Offset: 0x00032DF4
		public FName GroupId
		{
			get
			{
				return this.GroupIdInternal;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00034BFC File Offset: 0x00032DFC
		public int Priority
		{
			get
			{
				return this.PriorityInternal;
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00034C04 File Offset: 0x00032E04
		public bool IsEmpty()
		{
			Func<bool> isEmptyFuncInternal = this.IsEmptyFuncInternal;
			return isEmptyFuncInternal == null || isEmptyFuncInternal();
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00034C17 File Offset: 0x00032E17
		public void Consume()
		{
			Action consumeAction = this.ConsumeAction;
			if (consumeAction == null)
			{
				return;
			}
			consumeAction();
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00034C29 File Offset: 0x00032E29
		[NullableContext(1)]
		public NetGameBudgetOnceTaskGroup(FName groupId, int priority, Func<bool> isEmptyFunc, Action consumeAction)
		{
			this.GroupIdInternal = groupId;
			this.PriorityInternal = priority;
			this.IsEmptyFuncInternal = isEmptyFunc;
			this.ConsumeAction = consumeAction;
		}

		// Token: 0x040006B4 RID: 1716
		private FName GroupIdInternal;

		// Token: 0x040006B5 RID: 1717
		private int PriorityInternal;

		// Token: 0x040006B6 RID: 1718
		[Nullable(2)]
		private Func<bool> IsEmptyFuncInternal;

		// Token: 0x040006B7 RID: 1719
		[Nullable(2)]
		private Action ConsumeAction;
	}
}
