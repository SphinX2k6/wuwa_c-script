using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Core.Net
{
	// Token: 0x02000040 RID: 64
	public static class NetHostInfoExtensions
	{
		// Token: 0x06000244 RID: 580 RVA: 0x0000B524 File Offset: 0x00009724
		[NullableContext(1)]
		public static string FormatNetHostInfo([Nullable(new byte[]
		{
			2,
			1
		})] this List<NetHostInfo> hostInfos)
		{
			if (hostInfos == null || hostInfos.Count == 0)
			{
				return string.Empty;
			}
			if (hostInfos.Count == 1)
			{
				NetHostInfo netHostInfo = hostInfos[0];
				return netHostInfo.host + ":" + netHostInfo.port;
			}
			StringBuilder stringBuilder = new StringBuilder(hostInfos.Count * 20);
			for (int i = 0; i < hostInfos.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(hostInfos[i].host).Append(':').Append(hostInfos[i].port);
			}
			return stringBuilder.ToString();
		}
	}
}
