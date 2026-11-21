using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000DA RID: 218
	public class HotFixLayoutItem : IHotFixLayoutItem
	{
		// Token: 0x0600071F RID: 1823 RVA: 0x0003B9D5 File Offset: 0x00039BD5
		[NullableContext(1)]
		public virtual void SetRootActor(AActor actor)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0003B9D7 File Offset: 0x00039BD7
		[NullableContext(1)]
		public virtual void Refresh(IHotFixLayoutData data)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0003B9D9 File Offset: 0x00039BD9
		public virtual void SetActive(bool active)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0003B9DB File Offset: 0x00039BDB
		public virtual void Destroy()
		{
		}
	}
}
