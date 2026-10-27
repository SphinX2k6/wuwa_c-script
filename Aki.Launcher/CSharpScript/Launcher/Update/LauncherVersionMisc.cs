using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherVersionMisc : AppVersionMisc
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x0002EF77 File Offset: 0x0002D177
		protected override string GetUpdateVersionKey()
		{
			return "LauncherVersion";
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0002EF7E File Offset: 0x0002D17E
		protected override string GetSaveUpdateVersionKey()
		{
			return "SavedLauncherVersion";
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0002EF85 File Offset: 0x0002D185
		protected override string GetIndexFilePrefix()
		{
			return "UpdaterPatchList_";
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0002EF8C File Offset: 0x0002D18C
		protected override string GetMountFileName()
		{
			return "LauncherMount.txt";
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0002EF93 File Offset: 0x0002D193
		public override string GetResType()
		{
			return EResType.Launcher.ToEnumString();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0002EF9B File Offset: 0x0002D19B
		protected override string GetRemoteVersion()
		{
			return RemoteInfo.Instance.Config.LauncherVersion;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0002EFAC File Offset: 0x0002D1AC
		protected override Dictionary<string, string> GetRemoteSha1Map()
		{
			return RemoteInfo.Instance.Config.LauncherIndexSha1;
		}
	}
}
