using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.HotPatchProcedure
{
	// Token: 0x020001DA RID: 474
	public class IosHotPatchProcedure : MobileHotPatchProcedure
	{
		// Token: 0x06000CB3 RID: 3251 RVA: 0x0004F0FB File Offset: 0x0004D2FB
		[NullableContext(1)]
		public IosHotPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0004F108 File Offset: 0x0004D308
		protected override UniTask<bool> DownloadFiles(bool bUseBgDownload, [Nullable(1)] params ResourceUpdate[] updates)
		{
			IosHotPatchProcedure.<DownloadFiles>d__1 <DownloadFiles>d__;
			<DownloadFiles>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DownloadFiles>d__.<>4__this = this;
			<DownloadFiles>d__.bUseBgDownload = bUseBgDownload;
			<DownloadFiles>d__.updates = updates;
			<DownloadFiles>d__.<>1__state = -1;
			<DownloadFiles>d__.<>t__builder.Start<IosHotPatchProcedure.<DownloadFiles>d__1>(ref <DownloadFiles>d__);
			return <DownloadFiles>d__.<>t__builder.Task;
		}
	}
}
