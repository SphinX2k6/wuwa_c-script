using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x02000117 RID: 279
	[NullableContext(1)]
	public interface IPreDownloadUiEvent
	{
		// Token: 0x060008E7 RID: 2279
		UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal);

		// Token: 0x060008E8 RID: 2280
		UniTask BinPatchProgress(bool bNeedWait, float rate, string textId, params string[] args);

		// Token: 0x060008E9 RID: 2281
		[return: Nullable(0)]
		UniTask<bool> ShowDialog(bool bSelect, string title, string content, [Nullable(2)] string leftBtn, [Nullable(2)] string rightBtn, [Nullable(2)] string middleBtn, params string[] contentArgs);
	}
}
