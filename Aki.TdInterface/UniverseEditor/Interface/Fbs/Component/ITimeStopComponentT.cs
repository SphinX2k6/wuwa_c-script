using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C5 RID: 24773
	public class ITimeStopComponentT
	{
		// Token: 0x1700B822 RID: 47138
		// (get) Token: 0x06029EA4 RID: 171684 RVA: 0x005B883D File Offset: 0x005B6A3D
		// (set) Token: 0x06029EA5 RID: 171685 RVA: 0x005B8845 File Offset: 0x005B6A45
		public bool Disabled { get; set; }

		// Token: 0x1700B823 RID: 47139
		// (get) Token: 0x06029EA6 RID: 171686 RVA: 0x005B884E File Offset: 0x005B6A4E
		// (set) Token: 0x06029EA7 RID: 171687 RVA: 0x005B8856 File Offset: 0x005B6A56
		public string ActiveState { get; set; }

		// Token: 0x1700B824 RID: 47140
		// (get) Token: 0x06029EA8 RID: 171688 RVA: 0x005B885F File Offset: 0x005B6A5F
		// (set) Token: 0x06029EA9 RID: 171689 RVA: 0x005B8867 File Offset: 0x005B6A67
		public int StopTime { get; set; }

		// Token: 0x1700B825 RID: 47141
		// (get) Token: 0x06029EAA RID: 171690 RVA: 0x005B8870 File Offset: 0x005B6A70
		// (set) Token: 0x06029EAB RID: 171691 RVA: 0x005B8878 File Offset: 0x005B6A78
		public ITimeStopTargetT Target { get; set; }

		// Token: 0x1700B826 RID: 47142
		// (get) Token: 0x06029EAC RID: 171692 RVA: 0x005B8881 File Offset: 0x005B6A81
		// (set) Token: 0x06029EAD RID: 171693 RVA: 0x005B8889 File Offset: 0x005B6A89
		public byte NullMask { get; set; }

		// Token: 0x06029EAE RID: 171694 RVA: 0x005B8892 File Offset: 0x005B6A92
		public ITimeStopComponentT()
		{
			this.Disabled = false;
			this.ActiveState = null;
			this.StopTime = 0;
			this.Target = null;
			this.NullMask = 0;
		}
	}
}
