using System;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005843 RID: 22595
	public interface ILongPressInteractRestriction
	{
		// Token: 0x060396FF RID: 235263
		void Enter(EInputAction? triggerAction);

		// Token: 0x06039700 RID: 235264
		void Press(EInputAction? triggerAction);

		// Token: 0x06039701 RID: 235265
		void Release(EInputAction? triggerAction);

		// Token: 0x06039702 RID: 235266
		void Exit(EInputAction? triggerAction);
	}
}
