using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C4 RID: 21700
	public class IChessmanComponentT
	{
		// Token: 0x17009AE1 RID: 39649
		// (get) Token: 0x0602237F RID: 140159 RVA: 0x004B77F2 File Offset: 0x004B59F2
		// (set) Token: 0x06022380 RID: 140160 RVA: 0x004B77FA File Offset: 0x004B59FA
		public bool Disabled { get; set; }

		// Token: 0x17009AE2 RID: 39650
		// (get) Token: 0x06022381 RID: 140161 RVA: 0x004B7803 File Offset: 0x004B5A03
		// (set) Token: 0x06022382 RID: 140162 RVA: 0x004B780B File Offset: 0x004B5A0B
		public List<IActionInfoT> StartMovingActions { get; set; }

		// Token: 0x17009AE3 RID: 39651
		// (get) Token: 0x06022383 RID: 140163 RVA: 0x004B7814 File Offset: 0x004B5A14
		// (set) Token: 0x06022384 RID: 140164 RVA: 0x004B781C File Offset: 0x004B5A1C
		public List<IActionInfoT> EndMovingActions { get; set; }

		// Token: 0x17009AE4 RID: 39652
		// (get) Token: 0x06022385 RID: 140165 RVA: 0x004B7825 File Offset: 0x004B5A25
		// (set) Token: 0x06022386 RID: 140166 RVA: 0x004B782D File Offset: 0x004B5A2D
		public byte NullMask { get; set; }

		// Token: 0x06022387 RID: 140167 RVA: 0x004B7836 File Offset: 0x004B5A36
		public IChessmanComponentT()
		{
			this.Disabled = false;
			this.StartMovingActions = null;
			this.EndMovingActions = null;
			this.NullMask = 0;
		}
	}
}
