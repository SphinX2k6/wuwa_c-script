using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200549B RID: 21659
	public class SwapJob : IJob
	{
		// Token: 0x06035B7A RID: 220026 RVA: 0x00F02AFE File Offset: 0x00F00CFE
		public void Set(GridPosition a, GridPosition b)
		{
			this.A = a;
			this.B = b;
		}

		// Token: 0x1700687F RID: 26751
		// (get) Token: 0x06035B7B RID: 220027 RVA: 0x00F02B0E File Offset: 0x00F00D0E
		public int ExecutionOrder
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06035B7C RID: 220028 RVA: 0x00F02B11 File Offset: 0x00F00D11
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlaySwapAsync(this.A, this.B);
		}

		// Token: 0x0401C70B RID: 116491
		private GridPosition A;

		// Token: 0x0401C70C RID: 116492
		private GridPosition B;
	}
}
