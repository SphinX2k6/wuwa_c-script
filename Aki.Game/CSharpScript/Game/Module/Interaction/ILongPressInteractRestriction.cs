using System;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200481B RID: 18459
	public interface ILongPressInteractRestriction
	{
		// Token: 0x0602E616 RID: 189974
		void Enter(EInputAction? triggerAction);

		// Token: 0x0602E617 RID: 189975
		void Press(EInputAction? triggerAction);

		// Token: 0x0602E618 RID: 189976
		void Release(EInputAction? triggerAction);

		// Token: 0x0602E619 RID: 189977
		void Exit(EInputAction? triggerAction);
	}
}
