using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02004258 RID: 16984
	[NullableContext(1)]
	public interface ISkillInteractMainInterface
	{
		// Token: 0x0602AF55 RID: 175957
		UniTask StartSkillInteract();

		// Token: 0x0602AF56 RID: 175958
		void CancelSkillInteract();

		// Token: 0x0602AF57 RID: 175959
		ISkillTriggerInfo GetData();

		// Token: 0x0602AF58 RID: 175960
		void FinishSkillInteract();
	}
}
