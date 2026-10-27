using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02005289 RID: 21129
	[NullableContext(1)]
	public interface ISkillInteractMainUiInteract
	{
		// Token: 0x0603605E RID: 221278
		bool ReceiveClickData(ESkillInteractMainUiInteractType type, params object[] data);
	}
}
