using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02004F3B RID: 20283
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaViewHandler
	{
		// Token: 0x06034028 RID: 213032 RVA: 0x00C31E48 File Offset: 0x00C30048
		public QtaViewHandler(QtaViewParam qtaViewParam)
		{
			if (qtaViewParam == null || qtaViewParam.QtaHandleId == 0)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.HWR, "QtaViewParam:参数无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.QtaViewParam = qtaViewParam;
		}

		// Token: 0x06034029 RID: 213033 RVA: 0x00C31E89 File Offset: 0x00C30089
		public void SetResult(EQtaResult result)
		{
			this.QtaResult = result;
		}

		// Token: 0x0603402A RID: 213034 RVA: 0x00C31E92 File Offset: 0x00C30092
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

		// Token: 0x0401B9FD RID: 113149
		private EQtaResult QtaResult;

		// Token: 0x0401B9FE RID: 113150
		public QtaViewParam QtaViewParam;
	}
}
