using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200651D RID: 25885
	public class SwapJob : IJob
	{
		// Token: 0x06040EB6 RID: 265910 RVA: 0x00FBBACE File Offset: 0x00FB9CCE
		public void Set(GridPosition a, GridPosition b)
		{
			this.A = a;
			this.B = b;
		}

		// Token: 0x1700951D RID: 38173
		// (get) Token: 0x06040EB7 RID: 265911 RVA: 0x00FBBADE File Offset: 0x00FB9CDE
		public int ExecutionOrder
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06040EB8 RID: 265912 RVA: 0x00FBBAE1 File Offset: 0x00FB9CE1
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlaySwapAsync(this.A, this.B);
		}

		// Token: 0x04021DDA RID: 138714
		private GridPosition A;

		// Token: 0x04021DDB RID: 138715
		private GridPosition B;
	}
}
