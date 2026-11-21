using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008B RID: 139
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceVersionMisc : AppVersionMisc
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x0003052D File Offset: 0x0002E72D
		protected override string GetUpdateVersionKey()
		{
			return "ResourceVersion";
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00030534 File Offset: 0x0002E734
		protected override string GetSaveUpdateVersionKey()
		{
			return "SavedResourceVersion";
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0003053B File Offset: 0x0002E73B
		protected override string GetIndexFilePrefix()
		{
			return "PatchList_";
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00030542 File Offset: 0x0002E742
		protected override string GetMountFileName()
		{
			return "ResourceMount.txt";
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00030549 File Offset: 0x0002E749
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00030551 File Offset: 0x0002E751
		protected override string GetRemoteVersion()
		{
			return RemoteInfo.Instance.Config.ResourceVersion;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00030562 File Offset: 0x0002E762
		protected override Dictionary<string, string> GetRemoteSha1Map()
		{
			return RemoteInfo.Instance.Config.ResourceIndexSha1;
		}
	}
}
