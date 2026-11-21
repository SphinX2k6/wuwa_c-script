using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200360B RID: 13835
	[NullableContext(1)]
	[Nullable(0)]
	public class UiResourceHandle
	{
		// Token: 0x060233DC RID: 144348 RVA: 0x00A02FFB File Offset: 0x00A011FB
		public UiResourceHandle(UObject obj)
		{
			this.Object = obj;
		}

		// Token: 0x060233DD RID: 144349 RVA: 0x00A03011 File Offset: 0x00A01211
		public void CancelResource()
		{
			if (this.ResourceId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.ResourceId);
			}
		}

		// Token: 0x04013DE9 RID: 81385
		public UObject Object;

		// Token: 0x04013DEA RID: 81386
		public int ResourceId = -1;
	}
}
