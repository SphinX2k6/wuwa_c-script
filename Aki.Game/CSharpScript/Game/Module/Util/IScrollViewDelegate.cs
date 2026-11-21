using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003857 RID: 14423
	public interface IScrollViewDelegate<out TProxy, [Nullable(2)] out TData> where TProxy : IGridProxy<TData>
	{
		// Token: 0x0602578A RID: 153482
		void SelectGridProxy(int gridIndex, int displayIndex, bool fireEvent);

		// Token: 0x0602578B RID: 153483
		int GetSelectedGridIndex();
	}
}
