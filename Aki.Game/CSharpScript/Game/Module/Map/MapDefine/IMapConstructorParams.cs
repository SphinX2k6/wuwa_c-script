using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005574 RID: 21876
	public interface IMapConstructorParams
	{
		// Token: 0x17008625 RID: 34341
		// (get) Token: 0x06037C42 RID: 228418
		// (set) Token: 0x06037C43 RID: 228419
		int InstanceId { get; set; }

		// Token: 0x17008626 RID: 34342
		// (get) Token: 0x06037C44 RID: 228420
		// (set) Token: 0x06037C45 RID: 228421
		EMapType MapType { get; set; }

		// Token: 0x17008627 RID: 34343
		// (get) Token: 0x06037C46 RID: 228422
		// (set) Token: 0x06037C47 RID: 228423
		float MapDefaultScale { get; set; }

		// Token: 0x17008628 RID: 34344
		// (get) Token: 0x06037C48 RID: 228424
		// (set) Token: 0x06037C49 RID: 228425
		EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17008629 RID: 34345
		// (get) Token: 0x06037C4A RID: 228426
		// (set) Token: 0x06037C4B RID: 228427
		float? MarkScale { get; set; }

		// Token: 0x1700862A RID: 34346
		// (get) Token: 0x06037C4C RID: 228428
		// (set) Token: 0x06037C4D RID: 228429
		float? ClickRange { get; set; }

		// Token: 0x1700862B RID: 34347
		// (get) Token: 0x06037C4E RID: 228430
		// (set) Token: 0x06037C4F RID: 228431
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		Dictionary<string, UTexture> PreloadTiles { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }
	}
}
