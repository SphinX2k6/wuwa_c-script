using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.HotPatchProcedure
{
	// Token: 0x020001D7 RID: 471
	public interface IHotPatchProcedure
	{
		// Token: 0x06000C98 RID: 3224
		UniTask<bool> Start();

		// Token: 0x06000C99 RID: 3225
		UniTask<bool> GetRemoteVersionConfig();

		// Token: 0x06000C9A RID: 3226
		UniTask<bool> IsAppVersionChange();

		// Token: 0x06000C9B RID: 3227
		UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] params ResourceUpdate[] updates);

		// Token: 0x06000C9C RID: 3228
		[NullableContext(1)]
		bool NeedRestart(params ResourceUpdate[] updates);

		// Token: 0x06000C9D RID: 3229
		UniTask<bool> MountPak([Nullable(1)] params ResourceUpdate[] updates);

		// Token: 0x06000C9E RID: 3230
		void PreComplete();

		// Token: 0x06000C9F RID: 3231
		UniTask<bool> Complete();
	}
}
