using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02003F04 RID: 16132
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaViewHandler
	{
		// Token: 0x06028E96 RID: 167574 RVA: 0x00B7B5E8 File Offset: 0x00B797E8
		public QtaViewHandler(QtaViewParam qtaViewParam)
		{
			if (qtaViewParam == null || qtaViewParam.QtaHandleId == 0)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.HWR, "QtaViewParam:参数无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.QtaViewParam = qtaViewParam;
		}

		// Token: 0x06028E97 RID: 167575 RVA: 0x00B7B629 File Offset: 0x00B79829
		public void SetResult(EQtaResult result)
		{
			this.QtaResult = result;
		}

		// Token: 0x06028E98 RID: 167576 RVA: 0x00B7B632 File Offset: 0x00B79832
		public void Finish()
		{
			if (this.QtaViewParam == null)
			{
				return;
			}
			TQtaViewCallback finishCallback = this.QtaViewParam.FinishCallback;
			if (finishCallback == null)
			{
				return;
			}
			finishCallback(this.QtaViewParam.QtaHandleId, this.QtaResult);
		}

		// Token: 0x040163D2 RID: 91090
		private EQtaResult QtaResult;

		// Token: 0x040163D3 RID: 91091
		public QtaViewParam QtaViewParam;
	}
}
