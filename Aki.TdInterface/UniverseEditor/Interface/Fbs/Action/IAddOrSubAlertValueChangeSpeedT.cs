using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006132 RID: 24882
	public class IAddOrSubAlertValueChangeSpeedT
	{
		// Token: 0x1700B764 RID: 46948
		// (get) Token: 0x0602A895 RID: 174229 RVA: 0x005DB660 File Offset: 0x005D9860
		// (set) Token: 0x0602A896 RID: 174230 RVA: 0x005DB668 File Offset: 0x005D9868
		public EValueChangeType Type { get; set; }

		// Token: 0x1700B765 RID: 46949
		// (get) Token: 0x0602A897 RID: 174231 RVA: 0x005DB671 File Offset: 0x005D9871
		// (set) Token: 0x0602A898 RID: 174232 RVA: 0x005DB679 File Offset: 0x005D9879
		public float DeltaValue { get; set; }

		// Token: 0x0602A899 RID: 174233 RVA: 0x005DB682 File Offset: 0x005D9882
		public IAddOrSubAlertValueChangeSpeedT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.DeltaValue = 0f;
		}
	}
}
