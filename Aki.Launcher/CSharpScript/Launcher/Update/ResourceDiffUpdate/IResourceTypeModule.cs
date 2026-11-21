using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A2 RID: 162
	[NullableContext(1)]
	public interface IResourceTypeModule
	{
		// Token: 0x06000599 RID: 1433
		[NullableContext(0)]
		UniTask<bool> PrepareManifests();

		// Token: 0x0600059A RID: 1434
		PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false);

		// Token: 0x0600059B RID: 1435
		long GetLocalSize(IReadOnlyList<string> pakNames);

		// Token: 0x0600059C RID: 1436
		void Delete(IReadOnlyList<string> pakNames);
	}
}
