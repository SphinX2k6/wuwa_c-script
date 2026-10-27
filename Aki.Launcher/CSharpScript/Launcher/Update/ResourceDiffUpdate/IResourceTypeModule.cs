using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x0200009F RID: 159
	[NullableContext(1)]
	public interface IResourceTypeModule
	{
		// Token: 0x06000582 RID: 1410
		[NullableContext(0)]
		UniTask<bool> PrepareManifests();

		// Token: 0x06000583 RID: 1411
		PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false);

		// Token: 0x06000584 RID: 1412
		long GetLocalSize(IReadOnlyList<string> pakNames);

		// Token: 0x06000585 RID: 1413
		void Delete(IReadOnlyList<string> pakNames);
	}
}
