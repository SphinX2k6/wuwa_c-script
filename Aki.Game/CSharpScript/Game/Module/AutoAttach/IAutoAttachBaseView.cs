using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AutoAttach
{
	// Token: 0x02005E7E RID: 24190
	[NullableContext(2)]
	public interface IAutoAttachBaseView<T>
	{
		// Token: 0x0603D86F RID: 252015
		int GetDataLength();

		// Token: 0x0603D870 RID: 252016
		int GetShowItemNum();

		// Token: 0x0603D871 RID: 252017
		float GetItemSize();

		// Token: 0x0603D872 RID: 252018
		float GetGap();

		// Token: 0x0603D873 RID: 252019
		bool GetIfCircle();

		// Token: 0x0603D874 RID: 252020
		float GetViewSize();

		// Token: 0x0603D875 RID: 252021
		EAttachDirection? GetCurrentMoveDirection();

		// Token: 0x0603D876 RID: 252022
		float GetTrueBoundary();

		// Token: 0x0603D877 RID: 252023
		int GetCurrentSelectIndex();
	}
}
