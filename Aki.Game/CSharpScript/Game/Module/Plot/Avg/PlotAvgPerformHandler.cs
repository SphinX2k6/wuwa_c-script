using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020040B7 RID: 16567
	public class PlotAvgPerformHandler : IPlotAvgPerformHandler
	{
		// Token: 0x06029E95 RID: 171669 RVA: 0x00BD992F File Offset: 0x00BD7B2F
		[NullableContext(1)]
		public UniTask PlayCharacterEnterPerformAsync(AvgTalkerEnterActionContext context)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06029E96 RID: 171670 RVA: 0x00BD9936 File Offset: 0x00BD7B36
		public UniTask PlayCharacterExitPerformAsync(int characterId)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06029E97 RID: 171671 RVA: 0x00BD993D File Offset: 0x00BD7B3D
		[NullableContext(1)]
		public UniTask PlayCharacterMovePerformAsync(AvgTalkerMoveActionContext context)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06029E98 RID: 171672 RVA: 0x00BD9944 File Offset: 0x00BD7B44
		public void ChangeCharacterAnim(int characterId, EAvgRoleAnimationType animationType, bool isLoop)
		{
		}
	}
}
