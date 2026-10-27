using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A01 RID: 18945
	public class ICheckEntityGravityDirectionT
	{
		// Token: 0x17008914 RID: 35092
		// (get) Token: 0x0601D9F2 RID: 121330 RVA: 0x0042B52D File Offset: 0x0042972D
		// (set) Token: 0x0601D9F3 RID: 121331 RVA: 0x0042B535 File Offset: 0x00429735
		public ECondition Type { get; set; }

		// Token: 0x17008915 RID: 35093
		// (get) Token: 0x0601D9F4 RID: 121332 RVA: 0x0042B53E File Offset: 0x0042973E
		// (set) Token: 0x0601D9F5 RID: 121333 RVA: 0x0042B546 File Offset: 0x00429746
		public TCheckTargetUnion Target { get; set; }

		// Token: 0x17008916 RID: 35094
		// (get) Token: 0x0601D9F6 RID: 121334 RVA: 0x0042B54F File Offset: 0x0042974F
		// (set) Token: 0x0601D9F7 RID: 121335 RVA: 0x0042B557 File Offset: 0x00429757
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17008917 RID: 35095
		// (get) Token: 0x0601D9F8 RID: 121336 RVA: 0x0042B560 File Offset: 0x00429760
		// (set) Token: 0x0601D9F9 RID: 121337 RVA: 0x0042B568 File Offset: 0x00429768
		public bool IsNotInTargetDirection { get; set; }

		// Token: 0x17008918 RID: 35096
		// (get) Token: 0x0601D9FA RID: 121338 RVA: 0x0042B571 File Offset: 0x00429771
		// (set) Token: 0x0601D9FB RID: 121339 RVA: 0x0042B579 File Offset: 0x00429779
		public byte NullMask { get; set; }

		// Token: 0x0601D9FC RID: 121340 RVA: 0x0042B582 File Offset: 0x00429782
		public ICheckEntityGravityDirectionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.GravityDirection = null;
			this.IsNotInTargetDirection = false;
			this.NullMask = 0;
		}
	}
}
