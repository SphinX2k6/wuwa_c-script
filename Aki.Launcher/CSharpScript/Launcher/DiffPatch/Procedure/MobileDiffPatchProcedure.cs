using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Procedure
{
	// Token: 0x02000217 RID: 535
	public class MobileDiffPatchProcedure : BaseDiffPatchProcedure
	{
		// Token: 0x06000DE7 RID: 3559 RVA: 0x00053E4D File Offset: 0x0005204D
		[NullableContext(1)]
		public MobileDiffPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00053E58 File Offset: 0x00052058
		protected virtual UniTask<bool> PromptDownload(long updateSize, [Nullable(1)] DiffUpdate update)
		{
			MobileDiffPatchProcedure.<PromptDownload>d__1 <PromptDownload>d__;
			<PromptDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PromptDownload>d__.updateSize = updateSize;
			<PromptDownload>d__.update = update;
			<PromptDownload>d__.<>1__state = -1;
			<PromptDownload>d__.<>t__builder.Start<MobileDiffPatchProcedure.<PromptDownload>d__1>(ref <PromptDownload>d__);
			return <PromptDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00053EA4 File Offset: 0x000520A4
		public override UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] DiffUpdate update, bool bIsLauncher)
		{
			MobileDiffPatchProcedure.<UpdateResource>d__2 <UpdateResource>d__;
			<UpdateResource>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateResource>d__.<>4__this = this;
			<UpdateResource>d__.bUseBgDownload = bUseBgDownload;
			<UpdateResource>d__.update = update;
			<UpdateResource>d__.bIsLauncher = bIsLauncher;
			<UpdateResource>d__.<>1__state = -1;
			<UpdateResource>d__.<>t__builder.Start<MobileDiffPatchProcedure.<UpdateResource>d__2>(ref <UpdateResource>d__);
			return <UpdateResource>d__.<>t__builder.Task;
		}
	}
}
