using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200386B RID: 14443
	public class FindNavigationResult
	{
		// Token: 0x0602588F RID: 153743 RVA: 0x00A92655 File Offset: 0x00A90855
		public bool IsFindNavigation()
		{
			return this.Result == EFindNavigationResult.CanFocus;
		}

		// Token: 0x06025890 RID: 153744 RVA: 0x00A92660 File Offset: 0x00A90860
		public bool IsInLoopingProcess()
		{
			return this.Result == EFindNavigationResult.LoopOrLayoutAnimation;
		}

		// Token: 0x06025891 RID: 153745 RVA: 0x00A9266B File Offset: 0x00A9086B
		public bool IsNotFindNavigation()
		{
			return this.Result == EFindNavigationResult.CantFocus;
		}

		// Token: 0x06025892 RID: 153746 RVA: 0x00A92676 File Offset: 0x00A90876
		public bool IsFinishFind()
		{
			return this.Result == EFindNavigationResult.CanFocus || this.Result == EFindNavigationResult.CantFocus;
		}

		// Token: 0x04014C18 RID: 85016
		public EFindNavigationResult Result;

		// Token: 0x04014C19 RID: 85017
		[Nullable(2)]
		public TsUiNavigationBehaviorListener Listener;
	}
}
