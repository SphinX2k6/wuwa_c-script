using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008A RID: 138
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherVersionMisc : AppVersionMisc
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x000304DF File Offset: 0x0002E6DF
		protected override string GetUpdateVersionKey()
		{
			return "LauncherVersion";
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000304E6 File Offset: 0x0002E6E6
		protected override string GetSaveUpdateVersionKey()
		{
			return "SavedLauncherVersion";
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000304ED File Offset: 0x0002E6ED
		protected override string GetIndexFilePrefix()
		{
			return "UpdaterPatchList_";
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000304F4 File Offset: 0x0002E6F4
		protected override string GetMountFileName()
		{
			return "LauncherMount.txt";
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000304FB File Offset: 0x0002E6FB
		public override string GetResType()
		{
			return EResType.Launcher.ToEnumString();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00030503 File Offset: 0x0002E703
		protected override string GetRemoteVersion()
		{
			return RemoteInfo.Instance.Config.LauncherVersion;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00030514 File Offset: 0x0002E714
		protected override Dictionary<string, string> GetRemoteSha1Map()
		{
			return RemoteInfo.Instance.Config.LauncherIndexSha1;
		}
	}
}
