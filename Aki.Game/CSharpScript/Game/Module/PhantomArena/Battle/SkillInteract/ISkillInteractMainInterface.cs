using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02005288 RID: 21128
	[NullableContext(1)]
	public interface ISkillInteractMainInterface
	{
		// Token: 0x0603605A RID: 221274
		UniTask StartSkillInteract();

		// Token: 0x0603605B RID: 221275
		void CancelSkillInteract();

		// Token: 0x0603605C RID: 221276
		ISkillTriggerInfo GetData();

		// Token: 0x0603605D RID: 221277
		void FinishSkillInteract();
	}
}
