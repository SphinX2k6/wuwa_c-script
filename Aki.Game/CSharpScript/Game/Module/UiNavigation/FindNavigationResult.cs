using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F4 RID: 18676
	public class FindNavigationResult
	{
		// Token: 0x06030D62 RID: 200034 RVA: 0x00B577E5 File Offset: 0x00B559E5
		public bool IsFindNavigation()
		{
			return this.Result == EFindNavigationResult.CanFocus;
		}

		// Token: 0x06030D63 RID: 200035 RVA: 0x00B577F0 File Offset: 0x00B559F0
		public bool IsInLoopingProcess()
		{
			return this.Result == EFindNavigationResult.LoopOrLayoutAnimation;
		}

		// Token: 0x06030D64 RID: 200036 RVA: 0x00B577FB File Offset: 0x00B559FB
		public bool IsNotFindNavigation()
		{
			return this.Result == EFindNavigationResult.CantFocus;
		}

		// Token: 0x06030D65 RID: 200037 RVA: 0x00B57806 File Offset: 0x00B55A06
		public bool IsFinishFind()
		{
			return this.Result == EFindNavigationResult.CanFocus || this.Result == EFindNavigationResult.CantFocus;
		}

		// Token: 0x0401A3A5 RID: 107429
		public EFindNavigationResult Result;

		// Token: 0x0401A3A6 RID: 107430
		[Nullable(2)]
		public TsUiNavigationBehaviorListener Listener;
	}
}
