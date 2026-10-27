using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046DB RID: 18139
	[NullableContext(1)]
	[Nullable(0)]
	public class UiResourceHandle
	{
		// Token: 0x0602ECA2 RID: 191650 RVA: 0x00AD5557 File Offset: 0x00AD3757
		public UiResourceHandle(UObject obj)
		{
			this.Object = obj;
		}

		// Token: 0x0602ECA3 RID: 191651 RVA: 0x00AD556D File Offset: 0x00AD376D
		public void CancelResource()
		{
			if (this.ResourceId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.ResourceId);
			}
		}

		// Token: 0x0401974B RID: 104267
		public UObject Object;

		// Token: 0x0401974C RID: 104268
		public int ResourceId = -1;
	}
}
