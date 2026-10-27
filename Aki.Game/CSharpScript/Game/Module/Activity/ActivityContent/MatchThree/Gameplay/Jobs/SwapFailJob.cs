using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200651E RID: 25886
	public class SwapFailJob : IJob
	{
		// Token: 0x06040EBA RID: 265914 RVA: 0x00FBBAFD File Offset: 0x00FB9CFD
		public void Set(GridPosition a, GridPosition b)
		{
			this.A = a;
			this.B = b;
		}

		// Token: 0x1700951E RID: 38174
		// (get) Token: 0x06040EBB RID: 265915 RVA: 0x00FBBB0D File Offset: 0x00FB9D0D
		public int ExecutionOrder
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06040EBC RID: 265916 RVA: 0x00FBBB10 File Offset: 0x00FB9D10
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlaySwapFailAsync(this.A, this.B);
		}

		// Token: 0x04021DDC RID: 138716
		private GridPosition A;

		// Token: 0x04021DDD RID: 138717
		private GridPosition B;
	}
}
