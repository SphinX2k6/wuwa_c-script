using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020040B6 RID: 16566
	[NullableContext(1)]
	public interface IPlotAvgPerformHandler
	{
		// Token: 0x06029E91 RID: 171665
		UniTask PlayCharacterEnterPerformAsync(AvgTalkerEnterActionContext context);

		// Token: 0x06029E92 RID: 171666
		UniTask PlayCharacterExitPerformAsync(int characterId);

		// Token: 0x06029E93 RID: 171667
		UniTask PlayCharacterMovePerformAsync(AvgTalkerMoveActionContext context);

		// Token: 0x06029E94 RID: 171668
		void ChangeCharacterAnim(int characterId, EAvgRoleAnimationType animationType, bool isLoop);
	}
}
