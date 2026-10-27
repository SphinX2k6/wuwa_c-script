using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7A RID: 23162
	public class ITimelineControlGroupT
	{
		// Token: 0x1700AE73 RID: 44659
		// (get) Token: 0x0602772B RID: 161579 RVA: 0x0056DB43 File Offset: 0x0056BD43
		// (set) Token: 0x0602772C RID: 161580 RVA: 0x0056DB4B File Offset: 0x0056BD4B
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700AE74 RID: 44660
		// (get) Token: 0x0602772D RID: 161581 RVA: 0x0056DB54 File Offset: 0x0056BD54
		// (set) Token: 0x0602772E RID: 161582 RVA: 0x0056DB5C File Offset: 0x0056BD5C
		public string TidContent { get; set; }

		// Token: 0x1700AE75 RID: 44661
		// (get) Token: 0x0602772F RID: 161583 RVA: 0x0056DB65 File Offset: 0x0056BD65
		// (set) Token: 0x06027730 RID: 161584 RVA: 0x0056DB6D File Offset: 0x0056BD6D
		public float SegmentTime { get; set; }

		// Token: 0x1700AE76 RID: 44662
		// (get) Token: 0x06027731 RID: 161585 RVA: 0x0056DB76 File Offset: 0x0056BD76
		// (set) Token: 0x06027732 RID: 161586 RVA: 0x0056DB7E File Offset: 0x0056BD7E
		public List<TTimelineTrackControlConfigUnion> ControlConfigs { get; set; }

		// Token: 0x1700AE77 RID: 44663
		// (get) Token: 0x06027733 RID: 161587 RVA: 0x0056DB87 File Offset: 0x0056BD87
		// (set) Token: 0x06027734 RID: 161588 RVA: 0x0056DB8F File Offset: 0x0056BD8F
		public List<IControlPointEventConfigT> ControlPointEvents { get; set; }

		// Token: 0x1700AE78 RID: 44664
		// (get) Token: 0x06027735 RID: 161589 RVA: 0x0056DB98 File Offset: 0x0056BD98
		// (set) Token: 0x06027736 RID: 161590 RVA: 0x0056DBA0 File Offset: 0x0056BDA0
		public string Description { get; set; }

		// Token: 0x1700AE79 RID: 44665
		// (get) Token: 0x06027737 RID: 161591 RVA: 0x0056DBA9 File Offset: 0x0056BDA9
		// (set) Token: 0x06027738 RID: 161592 RVA: 0x0056DBB1 File Offset: 0x0056BDB1
		public byte NullMask { get; set; }

		// Token: 0x06027739 RID: 161593 RVA: 0x0056DBBA File Offset: 0x0056BDBA
		public ITimelineControlGroupT()
		{
			this.Condition = null;
			this.TidContent = null;
			this.SegmentTime = 0f;
			this.ControlConfigs = null;
			this.ControlPointEvents = null;
			this.Description = null;
			this.NullMask = 0;
		}
	}
}
