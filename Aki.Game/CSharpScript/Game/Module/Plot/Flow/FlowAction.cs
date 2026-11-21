using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.FlowActions;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004061 RID: 16481
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowAction
	{
		// Token: 0x06029C66 RID: 171110 RVA: 0x00BCD0CC File Offset: 0x00BCB2CC
		public void Init(EAction type, Func<FlowActionBase> actionFactory, bool isAutoFinished = false)
		{
			this.Type = type;
			this.ActionFactory = actionFactory;
			this.IsAutoFinish = isAutoFinished;
			this.ActionInstanceList = new Stack<FlowActionBase>();
			FlowActionBase element = this.CreateAction();
			this.ActionInstanceList.Push(element);
		}

		// Token: 0x06029C67 RID: 171111 RVA: 0x00BCD10C File Offset: 0x00BCB30C
		private FlowActionBase CreateAction()
		{
			FlowActionBase flowActionBase = this.ActionFactory();
			flowActionBase.Type = this.Type;
			return flowActionBase;
		}

		// Token: 0x06029C68 RID: 171112 RVA: 0x00BCD125 File Offset: 0x00BCB325
		public FlowActionBase GetAction()
		{
			FlowActionBase actionInner = this.GetActionInner();
			actionInner.Owner = this;
			return actionInner;
		}

		// Token: 0x06029C69 RID: 171113 RVA: 0x00BCD134 File Offset: 0x00BCB334
		private FlowActionBase GetActionInner()
		{
			if (this.IsAutoFinish)
			{
				return this.ActionInstanceList.Peek();
			}
			if (this.ActionInstanceList.Size <= 0)
			{
				return this.CreateAction();
			}
			return this.ActionInstanceList.Pop();
		}

		// Token: 0x06029C6A RID: 171114 RVA: 0x00BCD16A File Offset: 0x00BCB36A
		public void RecycleAction(FlowActionBase action)
		{
			action.Owner = null;
			if (this.IsAutoFinish)
			{
				return;
			}
			this.ActionInstanceList.Push(action);
		}

		// Token: 0x04016C99 RID: 93337
		public EAction Type;

		// Token: 0x04016C9A RID: 93338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<FlowActionBase> ActionFactory;

		// Token: 0x04016C9B RID: 93339
		public bool IsAutoFinish;

		// Token: 0x04016C9C RID: 93340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Stack<FlowActionBase> ActionInstanceList;
	}
}
