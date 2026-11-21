using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AutoAttach
{
	// Token: 0x02004E63 RID: 20067
	[NullableContext(2)]
	public interface IAutoAttachBaseView<T>
	{
		// Token: 0x060327FF RID: 206847
		int GetDataLength();

		// Token: 0x06032800 RID: 206848
		int GetShowItemNum();

		// Token: 0x06032801 RID: 206849
		float GetItemSize();

		// Token: 0x06032802 RID: 206850
		float GetGap();

		// Token: 0x06032803 RID: 206851
		bool GetIfCircle();

		// Token: 0x06032804 RID: 206852
		float GetViewSize();

		// Token: 0x06032805 RID: 206853
		EAttachDirection? GetCurrentMoveDirection();

		// Token: 0x06032806 RID: 206854
		float GetTrueBoundary();

		// Token: 0x06032807 RID: 206855
		int GetCurrentSelectIndex();
	}
}
