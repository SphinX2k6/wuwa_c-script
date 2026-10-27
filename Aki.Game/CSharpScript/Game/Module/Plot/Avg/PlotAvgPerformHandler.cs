using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020050E7 RID: 20711
	public class PlotAvgPerformHandler : IPlotAvgPerformHandler
	{
		// Token: 0x06034F9C RID: 216988 RVA: 0x00C8C647 File Offset: 0x00C8A847
		[NullableContext(1)]
		public UniTask PlayCharacterEnterPerformAsync(AvgTalkerEnterActionContext context)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06034F9D RID: 216989 RVA: 0x00C8C64E File Offset: 0x00C8A84E
		public UniTask PlayCharacterExitPerformAsync(int characterId)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06034F9E RID: 216990 RVA: 0x00C8C655 File Offset: 0x00C8A855
		[NullableContext(1)]
		public UniTask PlayCharacterMovePerformAsync(AvgTalkerMoveActionContext context)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06034F9F RID: 216991 RVA: 0x00C8C65C File Offset: 0x00C8A85C
		public void ChangeCharacterAnim(int characterId, EAvgRoleAnimationType animationType, bool isLoop)
		{
		}
	}
}
