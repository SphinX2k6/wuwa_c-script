using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x02006F6E RID: 28526
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceLoadCallbackHandle
	{
		// Token: 0x06045651 RID: 284241 RVA: 0x0112E44C File Offset: 0x0112C64C
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

		// Token: 0x0402434A RID: 148298
		public string Path;

		// Token: 0x0402434B RID: 148299
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		public Action<UObject, string> Callback;

		// Token: 0x0402434C RID: 148300
		public int ResourceSystemId = -1;

		// Token: 0x0402434D RID: 148301
		[Nullable(2)]
		public UObject Asset;

		// Token: 0x0402434E RID: 148302
		public bool LoadAsyncFinished;
	}
}
