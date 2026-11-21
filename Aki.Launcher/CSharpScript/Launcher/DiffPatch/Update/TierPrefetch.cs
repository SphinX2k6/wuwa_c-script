using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x0200020C RID: 524
	public static class TierPrefetch
	{
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00054134 File Offset: 0x00052334
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<RemoteVersionConfig> FetchTierConfig(string tierLabel)
		{
			TierPrefetch.<FetchTierConfig>d__0 <FetchTierConfig>d__;
			<FetchTierConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<RemoteVersionConfig>.Create();
			<FetchTierConfig>d__.tierLabel = tierLabel;
			<FetchTierConfig>d__.<>1__state = -1;
			<FetchTierConfig>d__.<>t__builder.Start<TierPrefetch.<FetchTierConfig>d__0>(ref <FetchTierConfig>d__);
			return <FetchTierConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00054178 File Offset: 0x00052378
		public static UniTask<long> CalcTierDownloadSize([Nullable(2)] string tierLabel)
		{
			TierPrefetch.<CalcTierDownloadSize>d__1 <CalcTierDownloadSize>d__;
			<CalcTierDownloadSize>d__.<>t__builder = AsyncUniTaskMethodBuilder<long>.Create();
			<CalcTierDownloadSize>d__.tierLabel = tierLabel;
			<CalcTierDownloadSize>d__.<>1__state = -1;
			<CalcTierDownloadSize>d__.<>t__builder.Start<TierPrefetch.<CalcTierDownloadSize>d__1>(ref <CalcTierDownloadSize>d__);
			return <CalcTierDownloadSize>d__.<>t__builder.Task;
		}
	}
}
