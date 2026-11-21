using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02004259 RID: 16985
	[NullableContext(1)]
	public interface ISkillInteractMainUiInteract
	{
		// Token: 0x0602AF59 RID: 175961
		bool ReceiveClickData(ESkillInteractMainUiInteractType type, params object[] data);
	}
}
