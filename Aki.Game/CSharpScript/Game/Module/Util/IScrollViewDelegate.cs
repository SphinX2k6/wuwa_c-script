using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048E0 RID: 18656
	public interface IScrollViewDelegate<out TProxy, [Nullable(2)] out TData> where TProxy : IGridProxy<TData>
	{
		// Token: 0x06030C5D RID: 199773
		void SelectGridProxy(int gridIndex, int displayIndex, bool fireEvent);

		// Token: 0x06030C5E RID: 199774
		int GetSelectedGridIndex();
	}
}
