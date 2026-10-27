using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000088 RID: 136
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceVersionMisc : AppVersionMisc
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x0002EFC5 File Offset: 0x0002D1C5
		protected override string GetUpdateVersionKey()
		{
			return "ResourceVersion";
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0002EFCC File Offset: 0x0002D1CC
		protected override string GetSaveUpdateVersionKey()
		{
			return "SavedResourceVersion";
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0002EFD3 File Offset: 0x0002D1D3
		protected override string GetIndexFilePrefix()
		{
			return "PatchList_";
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0002EFDA File Offset: 0x0002D1DA
		protected override string GetMountFileName()
		{
			return "ResourceMount.txt";
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0002EFE1 File Offset: 0x0002D1E1
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString();
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0002EFE9 File Offset: 0x0002D1E9
		protected override string GetRemoteVersion()
		{
			return RemoteInfo.Instance.Config.ResourceVersion;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0002EFFA File Offset: 0x0002D1FA
		protected override Dictionary<string, string> GetRemoteSha1Map()
		{
			return RemoteInfo.Instance.Config.ResourceIndexSha1;
		}
	}
}
