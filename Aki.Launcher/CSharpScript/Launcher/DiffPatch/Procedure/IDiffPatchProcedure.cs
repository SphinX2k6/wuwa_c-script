using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.DiffPatch.Procedure
{
	// Token: 0x02000218 RID: 536
	public interface IDiffPatchProcedure
	{
		// Token: 0x06000E07 RID: 3591
		UniTask<bool> Start();

		// Token: 0x06000E08 RID: 3592
		UniTask<bool> GetRemoteVersionConfig();

		// Token: 0x06000E09 RID: 3593
		UniTask<bool> IsAppVersionChange();

		// Token: 0x06000E0A RID: 3594
		UniTask<bool> IsPostUpdateAppVersionChange();

		// Token: 0x06000E0B RID: 3595
		UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] DiffUpdate update, bool bIsLauncher);

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000E0C RID: 3596
		// (set) Token: 0x06000E0D RID: 3597
		[Nullable(1)]
		Func<DiffUpdate, HotFixManager, UniTask> RegistryExtraPack { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x06000E0E RID: 3598
		void PreComplete();

		// Token: 0x06000E0F RID: 3599
		UniTask<bool> Complete();

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000E10 RID: 3600
		bool HadOldResCleaned { get; }
	}
}
