using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x02000113 RID: 275
	[NullableContext(1)]
	public interface IPreDownloadUiEvent
	{
		// Token: 0x060008B3 RID: 2227
		UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal);

		// Token: 0x060008B4 RID: 2228
		UniTask BinPatchProgress(bool bNeedWait, float rate, string textId, params string[] args);

		// Token: 0x060008B5 RID: 2229
		[return: Nullable(0)]
		UniTask<bool> ShowDialog(bool bSelect, string title, string content, [Nullable(2)] string leftBtn, [Nullable(2)] string rightBtn, [Nullable(2)] string middleBtn, params string[] contentArgs);
	}
}
