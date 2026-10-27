using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x0200475F RID: 18271
	public interface IAttackSession
	{
		// Token: 0x17007751 RID: 30545
		// (get) Token: 0x0602FC4E RID: 195662
		UniTask HitOrFinished { get; }

		// Token: 0x17007752 RID: 30546
		// (get) Token: 0x0602FC4F RID: 195663
		UniTask Finished { get; }
	}
}
