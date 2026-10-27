using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.DiffPatch.Procedure
{
	// Token: 0x02000213 RID: 531
	public interface IDiffPatchProcedure
	{
		// Token: 0x06000DC6 RID: 3526
		UniTask<bool> Start();

		// Token: 0x06000DC7 RID: 3527
		UniTask<bool> GetRemoteVersionConfig();

		// Token: 0x06000DC8 RID: 3528
		UniTask<bool> IsAppVersionChange();

		// Token: 0x06000DC9 RID: 3529
		UniTask<bool> IsPostUpdateAppVersionChange();

		// Token: 0x06000DCA RID: 3530
		UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] DiffUpdate update, bool bIsLauncher);

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000DCB RID: 3531
		// (set) Token: 0x06000DCC RID: 3532
		[Nullable(1)]
		Func<DiffUpdate, HotFixManager, UniTask> RegistryExtraPack { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x06000DCD RID: 3533
		void PreComplete();

		// Token: 0x06000DCE RID: 3534
		UniTask<bool> Complete();

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000DCF RID: 3535
		bool HadOldResCleaned { get; }
	}
}
