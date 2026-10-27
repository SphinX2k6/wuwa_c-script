using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006109 RID: 24841
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeActionViewBase : UiViewBase
	{
		// Token: 0x0603ECCD RID: 257229 RVA: 0x00F2A72D File Offset: 0x00F2892D
		protected RoverlikeActionViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603ECCE RID: 257230 RVA: 0x00F2A736 File Offset: 0x00F28936
		protected override void OnBeforeCreateImplementImplement()
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			if (actionStack == null)
			{
				return;
			}
			actionStack.Push(this);
		}

		// Token: 0x0603ECCF RID: 257231 RVA: 0x00F2A749 File Offset: 0x00F28949
		protected override void OnBeforeDestroyImplement()
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			if (actionStack == null)
			{
				return;
			}
			actionStack.Pop(this);
		}

		// Token: 0x0603ECD0 RID: 257232 RVA: 0x00F2A75C File Offset: 0x00F2895C
		protected bool TryInteractAction(Action action)
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			return actionStack != null && actionStack.TryAction(this, action);
		}

		// Token: 0x0603ECD1 RID: 257233 RVA: 0x00F2A77D File Offset: 0x00F2897D
		[NullableContext(2)]
		private RoverlikeActionStack GetActionStack()
		{
			RoverlikeModel instance = RoverlikeModel.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.ActionStack;
		}
	}
}
