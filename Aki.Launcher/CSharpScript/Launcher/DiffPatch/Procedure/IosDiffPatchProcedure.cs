using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Procedure
{
	// Token: 0x02000216 RID: 534
	public class IosDiffPatchProcedure : MobileDiffPatchProcedure
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00053DE6 File Offset: 0x00051FE6
		[NullableContext(1)]
		public IosDiffPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00053DF0 File Offset: 0x00051FF0
		protected override UniTask<bool> PromptDownload(long updateSize, [Nullable(1)] DiffUpdate update)
		{
			IosDiffPatchProcedure.<PromptDownload>d__1 <PromptDownload>d__;
			<PromptDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PromptDownload>d__.<>4__this = this;
			<PromptDownload>d__.updateSize = updateSize;
			<PromptDownload>d__.update = update;
			<PromptDownload>d__.<>1__state = -1;
			<PromptDownload>d__.<>t__builder.Start<IosDiffPatchProcedure.<PromptDownload>d__1>(ref <PromptDownload>d__);
			return <PromptDownload>d__.<>t__builder.Task;
		}
	}
}
