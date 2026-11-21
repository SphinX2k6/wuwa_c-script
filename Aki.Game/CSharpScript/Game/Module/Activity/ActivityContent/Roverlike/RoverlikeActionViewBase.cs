using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005087 RID: 20615
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeActionViewBase : UiViewBase
	{
		// Token: 0x0603398F RID: 211343 RVA: 0x00E71541 File Offset: 0x00E6F741
		protected RoverlikeActionViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033990 RID: 211344 RVA: 0x00E7154A File Offset: 0x00E6F74A
		protected override void OnBeforeCreateImplementImplement()
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			if (actionStack == null)
			{
				return;
			}
			actionStack.Push(this);
		}

		// Token: 0x06033991 RID: 211345 RVA: 0x00E7155D File Offset: 0x00E6F75D
		protected override void OnBeforeDestroyImplement()
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			if (actionStack == null)
			{
				return;
			}
			actionStack.Pop(this);
		}

		// Token: 0x06033992 RID: 211346 RVA: 0x00E71570 File Offset: 0x00E6F770
		protected bool TryInteractAction(Action action)
		{
			RoverlikeActionStack actionStack = this.GetActionStack();
			return actionStack != null && actionStack.TryAction(this, action);
		}

		// Token: 0x06033993 RID: 211347 RVA: 0x00E71591 File Offset: 0x00E6F791
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
