using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D7 RID: 215
	public class HotFixLayoutItem : IHotFixLayoutItem
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x00039EA5 File Offset: 0x000380A5
		[NullableContext(1)]
		public virtual void SetRootActor(AActor actor)
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00039EA7 File Offset: 0x000380A7
		[NullableContext(1)]
		public virtual void Refresh(IHotFixLayoutData data)
		{
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00039EA9 File Offset: 0x000380A9
		public virtual void SetActive(bool active)
		{
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00039EAB File Offset: 0x000380AB
		public virtual void Destroy()
		{
		}
	}
}
