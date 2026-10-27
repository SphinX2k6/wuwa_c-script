using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.FlowActions;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02005091 RID: 20625
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowAction
	{
		// Token: 0x06034D6D RID: 216429 RVA: 0x00C7FB1C File Offset: 0x00C7DD1C
		public void Init(EAction type, Func<FlowActionBase> actionFactory, bool isAutoFinished = false)
		{
			this.Type = type;
			this.ActionFactory = actionFactory;
			this.IsAutoFinish = isAutoFinished;
			this.ActionInstanceList = new Stack<FlowActionBase>();
			FlowActionBase element = this.CreateAction();
			this.ActionInstanceList.Push(element);
		}

		// Token: 0x06034D6E RID: 216430 RVA: 0x00C7FB5C File Offset: 0x00C7DD5C
		private FlowActionBase CreateAction()
		{
			FlowActionBase flowActionBase = this.ActionFactory();
			flowActionBase.Type = this.Type;
			return flowActionBase;
		}

		// Token: 0x06034D6F RID: 216431 RVA: 0x00C7FB75 File Offset: 0x00C7DD75
		public FlowActionBase GetAction()
		{
			FlowActionBase actionInner = this.GetActionInner();
			actionInner.Owner = this;
			return actionInner;
		}

		// Token: 0x06034D70 RID: 216432 RVA: 0x00C7FB84 File Offset: 0x00C7DD84
		private FlowActionBase GetActionInner()
		{
			if (this.IsAutoFinish)
			{
				return this.ActionInstanceList.Last<FlowActionBase>();
			}
			if (this.ActionInstanceList.Size <= 0)
			{
				return this.CreateAction();
			}
			return this.ActionInstanceList.Pop();
		}

		// Token: 0x06034D71 RID: 216433 RVA: 0x00C7FBBA File Offset: 0x00C7DDBA
		public void RecycleAction(FlowActionBase action)
		{
			action.Owner = null;
			if (this.IsAutoFinish)
			{
				return;
			}
			this.ActionInstanceList.Push(action);
		}

		// Token: 0x0401C26A RID: 115306
		public EAction Type;

		// Token: 0x0401C26B RID: 115307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<FlowActionBase> ActionFactory;

		// Token: 0x0401C26C RID: 115308
		public bool IsAutoFinish;

		// Token: 0x0401C26D RID: 115309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Stack<FlowActionBase> ActionInstanceList;
	}
}
