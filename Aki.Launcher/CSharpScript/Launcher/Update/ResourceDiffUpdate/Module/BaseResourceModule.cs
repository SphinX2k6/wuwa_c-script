using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Module
{
	// Token: 0x020000AB RID: 171
	public abstract class BaseResourceModule : IResourceTypeModule
	{
		// Token: 0x060005DE RID: 1502
		public abstract UniTask<bool> PrepareManifests();

		// Token: 0x060005DF RID: 1503
		[NullableContext(1)]
		public abstract PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false);

		// Token: 0x060005E0 RID: 1504
		[NullableContext(1)]
		public abstract long GetLocalSize(IReadOnlyList<string> pakNames);

		// Token: 0x060005E1 RID: 1505
		[NullableContext(1)]
		public abstract void Delete(IReadOnlyList<string> pakNames);

		// Token: 0x060005E2 RID: 1506 RVA: 0x00033CFC File Offset: 0x00031EFC
		protected void DegradeToMinPack()
		{
			LauncherLog.Instance.Info("Optional package 玩家执行了资源清理，包体选择记录退化为精简包", default(ReadOnlySpan<ValueTuple<string, object>>));
			LauncherStorageLib.Instance.SetDeviceSaved<EResUpdateType>(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType, EResUpdateType.Min);
		}
	}
}
