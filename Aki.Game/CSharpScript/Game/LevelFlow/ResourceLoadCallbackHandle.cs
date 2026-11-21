using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x020060EF RID: 24815
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceLoadCallbackHandle
	{
		// Token: 0x0603B7FF RID: 243711 RVA: 0x010D8250 File Offset: 0x010D6450
		public ResourceLoadCallbackHandle(string path, [Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> callback)
		{
			this.Path = path;
			this.Callback = delegate([Nullable(2)] UObject asset, string p)
			{
				callback(asset);
			};
		}

		// Token: 0x0401F5FF RID: 128511
		public string Path;

		// Token: 0x0401F600 RID: 128512
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		public Action<UObject, string> Callback;

		// Token: 0x0401F601 RID: 128513
		public int ResourceSystemId = -1;

		// Token: 0x0401F602 RID: 128514
		[Nullable(2)]
		public UObject Asset;

		// Token: 0x0401F603 RID: 128515
		public bool LoadAsyncFinished;
	}
}
