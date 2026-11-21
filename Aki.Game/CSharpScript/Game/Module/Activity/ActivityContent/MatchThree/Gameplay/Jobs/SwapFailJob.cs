using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200549C RID: 21660
	public class SwapFailJob : IJob
	{
		// Token: 0x06035B7E RID: 220030 RVA: 0x00F02B2D File Offset: 0x00F00D2D
		public void Set(GridPosition a, GridPosition b)
		{
			this.A = a;
			this.B = b;
		}

		// Token: 0x17006880 RID: 26752
		// (get) Token: 0x06035B7F RID: 220031 RVA: 0x00F02B3D File Offset: 0x00F00D3D
		public int ExecutionOrder
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06035B80 RID: 220032 RVA: 0x00F02B40 File Offset: 0x00F00D40
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlaySwapFailAsync(this.A, this.B);
		}

		// Token: 0x0401C70D RID: 116493
		private GridPosition A;

		// Token: 0x0401C70E RID: 116494
		private GridPosition B;
	}
}
