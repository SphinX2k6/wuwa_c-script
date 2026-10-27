using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005567 RID: 21863
	public class IMonitorComponentT
	{
		// Token: 0x1700A184 RID: 41348
		// (get) Token: 0x060242AF RID: 148143 RVA: 0x004FEE82 File Offset: 0x004FD082
		// (set) Token: 0x060242B0 RID: 148144 RVA: 0x004FEE8A File Offset: 0x004FD08A
		public bool Disabled { get; set; }

		// Token: 0x1700A185 RID: 41349
		// (get) Token: 0x060242B1 RID: 148145 RVA: 0x004FEE93 File Offset: 0x004FD093
		// (set) Token: 0x060242B2 RID: 148146 RVA: 0x004FEE9B File Offset: 0x004FD09B
		public IConeTriggerShapeT Range { get; set; }

		// Token: 0x1700A186 RID: 41350
		// (get) Token: 0x060242B3 RID: 148147 RVA: 0x004FEEA4 File Offset: 0x004FD0A4
		// (set) Token: 0x060242B4 RID: 148148 RVA: 0x004FEEAC File Offset: 0x004FD0AC
		public string AttachPoint { get; set; }

		// Token: 0x1700A187 RID: 41351
		// (get) Token: 0x060242B5 RID: 148149 RVA: 0x004FEEB5 File Offset: 0x004FD0B5
		// (set) Token: 0x060242B6 RID: 148150 RVA: 0x004FEEBD File Offset: 0x004FD0BD
		public List<string> AvailableStates { get; set; }

		// Token: 0x1700A188 RID: 41352
		// (get) Token: 0x060242B7 RID: 148151 RVA: 0x004FEEC6 File Offset: 0x004FD0C6
		// (set) Token: 0x060242B8 RID: 148152 RVA: 0x004FEECE File Offset: 0x004FD0CE
		public string StateAfterTriggered { get; set; }

		// Token: 0x1700A189 RID: 41353
		// (get) Token: 0x060242B9 RID: 148153 RVA: 0x004FEED7 File Offset: 0x004FD0D7
		// (set) Token: 0x060242BA RID: 148154 RVA: 0x004FEEDF File Offset: 0x004FD0DF
		public string StateAfterLeaved { get; set; }

		// Token: 0x1700A18A RID: 41354
		// (get) Token: 0x060242BB RID: 148155 RVA: 0x004FEEE8 File Offset: 0x004FD0E8
		// (set) Token: 0x060242BC RID: 148156 RVA: 0x004FEEF0 File Offset: 0x004FD0F0
		public byte NullMask { get; set; }

		// Token: 0x060242BD RID: 148157 RVA: 0x004FEEF9 File Offset: 0x004FD0F9
		public IMonitorComponentT()
		{
			this.Disabled = false;
			this.Range = null;
			this.AttachPoint = null;
			this.AvailableStates = null;
			this.StateAfterTriggered = null;
			this.StateAfterLeaved = null;
			this.NullMask = 0;
		}
	}
}
