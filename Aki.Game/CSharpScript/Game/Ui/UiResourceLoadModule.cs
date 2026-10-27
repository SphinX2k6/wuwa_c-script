using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046DC RID: 18140
	[NullableContext(1)]
	[Nullable(0)]
	public class UiResourceLoadModule
	{
		// Token: 0x0602ECA4 RID: 191652 RVA: 0x00AD5588 File Offset: 0x00AD3788
		protected void CancelResource(UObject obj)
		{
			UiResourceHandle uiResourceHandle;
			if (!this.ResourceHandleMap.TryGetValue(obj, out uiResourceHandle))
			{
				uiResourceHandle = new UiResourceHandle(obj);
				this.ResourceHandleMap[obj] = uiResourceHandle;
				return;
			}
			uiResourceHandle.CancelResource();
		}

		// Token: 0x0602ECA5 RID: 191653 RVA: 0x00AD55C0 File Offset: 0x00AD37C0
		protected void SetResourceId(UObject obj, int resourceId)
		{
			UiResourceHandle uiResourceHandle;
			if (this.ResourceHandleMap.TryGetValue(obj, out uiResourceHandle))
			{
				uiResourceHandle.ResourceId = resourceId;
			}
		}

		// Token: 0x0602ECA6 RID: 191654 RVA: 0x00AD55E4 File Offset: 0x00AD37E4
		protected void DeleteResourceHandle(UObject obj)
		{
			this.ResourceHandleMap.Remove(obj);
		}

		// Token: 0x0602ECA7 RID: 191655 RVA: 0x00AD55F4 File Offset: 0x00AD37F4
		public virtual void Clear()
		{
			foreach (UiResourceHandle uiResourceHandle in this.ResourceHandleMap.Values)
			{
				uiResourceHandle.CancelResource();
			}
			this.ResourceHandleMap.Clear();
		}

		// Token: 0x0401974D RID: 104269
		private readonly Dictionary<UObject, UiResourceHandle> ResourceHandleMap = new Dictionary<UObject, UiResourceHandle>();
	}
}
