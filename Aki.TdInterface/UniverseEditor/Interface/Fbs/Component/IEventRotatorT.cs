using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C9 RID: 20937
	public class IEventRotatorT
	{
		// Token: 0x17009939 RID: 39225
		// (get) Token: 0x06021F20 RID: 139040 RVA: 0x004B59AE File Offset: 0x004B3BAE
		// (set) Token: 0x06021F21 RID: 139041 RVA: 0x004B59B6 File Offset: 0x004B3BB6
		public List<IActionInfoT> StartActions { get; set; }

		// Token: 0x1700993A RID: 39226
		// (get) Token: 0x06021F22 RID: 139042 RVA: 0x004B59BF File Offset: 0x004B3BBF
		// (set) Token: 0x06021F23 RID: 139043 RVA: 0x004B59C7 File Offset: 0x004B3BC7
		public List<IActionInfoT> EndActions { get; set; }

		// Token: 0x06021F24 RID: 139044 RVA: 0x004B59D0 File Offset: 0x004B3BD0
		public IEventRotatorT()
		{
			this.StartActions = null;
			this.EndActions = null;
		}
	}
}
