using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020050E6 RID: 20710
	[NullableContext(1)]
	public interface IPlotAvgPerformHandler
	{
		// Token: 0x06034F98 RID: 216984
		UniTask PlayCharacterEnterPerformAsync(AvgTalkerEnterActionContext context);

		// Token: 0x06034F99 RID: 216985
		UniTask PlayCharacterExitPerformAsync(int characterId);

		// Token: 0x06034F9A RID: 216986
		UniTask PlayCharacterMovePerformAsync(AvgTalkerMoveActionContext context);

		// Token: 0x06034F9B RID: 216987
		void ChangeCharacterAnim(int characterId, EAvgRoleAnimationType animationType, bool isLoop);
	}
}
