using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Canvas
{
	// Token: 0x02004296 RID: 17046
	[NullableContext(1)]
	public interface IAreaCanvas
	{
		// Token: 0x0602B235 RID: 176693
		bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo);

		// Token: 0x0602B236 RID: 176694
		void HandleSortOrder();

		// Token: 0x0602B237 RID: 176695
		void CancelSortOrder();

		// Token: 0x0602B238 RID: 176696
		[NullableContext(2)]
		void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract);
	}
}
