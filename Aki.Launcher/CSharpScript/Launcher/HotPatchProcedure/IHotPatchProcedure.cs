using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.HotPatchProcedure
{
	// Token: 0x020001D3 RID: 467
	public interface IHotPatchProcedure
	{
		// Token: 0x06000C61 RID: 3169
		UniTask<bool> Start();

		// Token: 0x06000C62 RID: 3170
		UniTask<bool> GetRemoteVersionConfig();

		// Token: 0x06000C63 RID: 3171
		UniTask<bool> IsAppVersionChange();

		// Token: 0x06000C64 RID: 3172
		UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] params ResourceUpdate[] updates);

		// Token: 0x06000C65 RID: 3173
		[NullableContext(1)]
		bool NeedRestart(params ResourceUpdate[] updates);

		// Token: 0x06000C66 RID: 3174
		UniTask<bool> MountPak([Nullable(1)] params ResourceUpdate[] updates);

		// Token: 0x06000C67 RID: 3175
		void PreComplete();

		// Token: 0x06000C68 RID: 3176
		UniTask<bool> Complete();
	}
}
