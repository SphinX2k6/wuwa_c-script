using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02003690 RID: 13968
	public interface IAttackSession
	{
		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x06024418 RID: 148504
		UniTask HitOrFinished { get; }

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x06024419 RID: 148505
		UniTask Finished { get; }
	}
}
