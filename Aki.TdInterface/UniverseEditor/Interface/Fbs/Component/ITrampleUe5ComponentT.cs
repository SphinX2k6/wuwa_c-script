using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD6 RID: 23254
	public class ITrampleUe5ComponentT
	{
		// Token: 0x1700AF40 RID: 44864
		// (get) Token: 0x06027A8E RID: 162446 RVA: 0x00574A14 File Offset: 0x00572C14
		// (set) Token: 0x06027A8F RID: 162447 RVA: 0x00574A1C File Offset: 0x00572C1C
		public bool Disabled { get; set; }

		// Token: 0x1700AF41 RID: 44865
		// (get) Token: 0x06027A90 RID: 162448 RVA: 0x00574A25 File Offset: 0x00572C25
		// (set) Token: 0x06027A91 RID: 162449 RVA: 0x00574A2D File Offset: 0x00572C2D
		public bool IsDisposable { get; set; }

		// Token: 0x1700AF42 RID: 44866
		// (get) Token: 0x06027A92 RID: 162450 RVA: 0x00574A36 File Offset: 0x00572C36
		// (set) Token: 0x06027A93 RID: 162451 RVA: 0x00574A3E File Offset: 0x00572C3E
		public List<IActionInfoT> TriggerActions { get; set; }

		// Token: 0x1700AF43 RID: 44867
		// (get) Token: 0x06027A94 RID: 162452 RVA: 0x00574A47 File Offset: 0x00572C47
		// (set) Token: 0x06027A95 RID: 162453 RVA: 0x00574A4F File Offset: 0x00572C4F
		public List<IActionInfoT> RecoveryActions { get; set; }

		// Token: 0x1700AF44 RID: 44868
		// (get) Token: 0x06027A96 RID: 162454 RVA: 0x00574A58 File Offset: 0x00572C58
		// (set) Token: 0x06027A97 RID: 162455 RVA: 0x00574A60 File Offset: 0x00572C60
		public byte NullMask { get; set; }

		// Token: 0x06027A98 RID: 162456 RVA: 0x00574A69 File Offset: 0x00572C69
		public ITrampleUe5ComponentT()
		{
			this.Disabled = false;
			this.IsDisposable = false;
			this.TriggerActions = null;
			this.RecoveryActions = null;
			this.NullMask = 0;
		}
	}
}
