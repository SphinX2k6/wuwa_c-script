using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200360C RID: 13836
	[NullableContext(1)]
	[Nullable(0)]
	public class UiResourceLoadModule
	{
		// Token: 0x060233DE RID: 144350 RVA: 0x00A0302C File Offset: 0x00A0122C
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

		// Token: 0x060233DF RID: 144351 RVA: 0x00A03064 File Offset: 0x00A01264
		protected void SetResourceId(UObject obj, int resourceId)
		{
			UiResourceHandle uiResourceHandle;
			if (this.ResourceHandleMap.TryGetValue(obj, out uiResourceHandle))
			{
				uiResourceHandle.ResourceId = resourceId;
			}
		}

		// Token: 0x060233E0 RID: 144352 RVA: 0x00A03088 File Offset: 0x00A01288
		protected void DeleteResourceHandle(UObject obj)
		{
			this.ResourceHandleMap.Remove(obj);
		}

		// Token: 0x060233E1 RID: 144353 RVA: 0x00A03098 File Offset: 0x00A01298
		protected bool CancelAndDeleteResource(UObject obj)
		{
			UiResourceHandle uiResourceHandle;
			if (!this.ResourceHandleMap.Remove(obj, out uiResourceHandle))
			{
				return false;
			}
			uiResourceHandle.CancelResource();
			return uiResourceHandle.ResourceId != -1;
		}

		// Token: 0x060233E2 RID: 144354 RVA: 0x00A030CC File Offset: 0x00A012CC
		public virtual void Clear()
		{
			foreach (UiResourceHandle uiResourceHandle in this.ResourceHandleMap.Values)
			{
				uiResourceHandle.CancelResource();
			}
			this.ResourceHandleMap.Clear();
		}

		// Token: 0x04013DEB RID: 81387
		private readonly Dictionary<UObject, UiResourceHandle> ResourceHandleMap = new Dictionary<UObject, UiResourceHandle>();
	}
}
