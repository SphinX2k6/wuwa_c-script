using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Canvas
{
	// Token: 0x020052C6 RID: 21190
	[NullableContext(1)]
	public interface IAreaCanvas
	{
		// Token: 0x0603633A RID: 222010
		bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo);

		// Token: 0x0603633B RID: 222011
		void HandleSortOrder();

		// Token: 0x0603633C RID: 222012
		void CancelSortOrder();

		// Token: 0x0603633D RID: 222013
		[NullableContext(2)]
		void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract);
	}
}
