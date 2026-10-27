using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F82 RID: 28546
	public class ISequenceFrameEventT
	{
		// Token: 0x1700D404 RID: 54276
		// (get) Token: 0x060326FC RID: 206588 RVA: 0x006CECEC File Offset: 0x006CCEEC
		// (set) Token: 0x060326FD RID: 206589 RVA: 0x006CECF4 File Offset: 0x006CCEF4
		public string EventKey { get; set; }

		// Token: 0x1700D405 RID: 54277
		// (get) Token: 0x060326FE RID: 206590 RVA: 0x006CECFD File Offset: 0x006CCEFD
		// (set) Token: 0x060326FF RID: 206591 RVA: 0x006CED05 File Offset: 0x006CCF05
		public List<IActionInfoT> EventActions { get; set; }

		// Token: 0x06032700 RID: 206592 RVA: 0x006CED0E File Offset: 0x006CCF0E
		public ISequenceFrameEventT()
		{
			this.EventKey = null;
			this.EventActions = null;
		}
	}
}
