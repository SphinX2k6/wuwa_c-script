using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Module
{
	// Token: 0x020000AE RID: 174
	public abstract class BaseResourceModule : IResourceTypeModule
	{
		// Token: 0x060005F6 RID: 1526
		public abstract UniTask<bool> PrepareManifests();

		// Token: 0x060005F7 RID: 1527
		[NullableContext(1)]
		public abstract PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false);

		// Token: 0x060005F8 RID: 1528
		[NullableContext(1)]
		public abstract long GetLocalSize(IReadOnlyList<string> pakNames);

		// Token: 0x060005F9 RID: 1529
		[NullableContext(1)]
		public abstract void Delete(IReadOnlyList<string> pakNames);

		// Token: 0x060005FA RID: 1530 RVA: 0x0003538C File Offset: 0x0003358C
		protected void DegradeToMinPack(ETier tier)
		{
			LauncherLog.Instance.Info("Optional package 玩家执行了资源清理，包体选择记录退化为精简包", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!LauncherPackageStateLib.SetSavedPackageType(tier, EResUpdateType.Min))
			{
				LauncherLog.Instance.Error("Optional package 包体选择记录退化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (Platform.Instance.IsWindowsOnlyPlatform() && !LauncherPackageStateLib.SetPackageType(tier, EResUpdateType.Min))
			{
				LauncherLog.Instance.Error("Optional package 同步启动器包体类型失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
	}
}
