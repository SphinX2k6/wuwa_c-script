using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200023C RID: 572
	[NullableContext(1)]
	[Nullable(0)]
	public class TsPatchApi
	{
		// Token: 0x06000EA2 RID: 3746 RVA: 0x00058344 File Offset: 0x00056544
		public TsPatchApi()
		{
			this.Patcher = new UKuroBinPatch();
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00058358 File Offset: 0x00056558
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		public UniTask<ValueTuple<int, HashSet<string>>> Patch(string diffFile, string oldDir, string newDir, Action<long> progress)
		{
			TsPatchApi.<Patch>d__2 <Patch>d__;
			<Patch>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<int, HashSet<string>>>.Create();
			<Patch>d__.<>4__this = this;
			<Patch>d__.diffFile = diffFile;
			<Patch>d__.oldDir = oldDir;
			<Patch>d__.newDir = newDir;
			<Patch>d__.progress = progress;
			<Patch>d__.<>1__state = -1;
			<Patch>d__.<>t__builder.Start<TsPatchApi.<Patch>d__2>(ref <Patch>d__);
			return <Patch>d__.<>t__builder.Task;
		}

		// Token: 0x04000966 RID: 2406
		private readonly UKuroBinPatch Patcher;
	}
}
