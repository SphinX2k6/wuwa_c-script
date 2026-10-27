using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200616B RID: 24939
	public class IAdjustPlayerCameraGravityT
	{
		// Token: 0x1700B99D RID: 47517
		// (get) Token: 0x0602AE7E RID: 175742 RVA: 0x005EB3F1 File Offset: 0x005E95F1
		// (set) Token: 0x0602AE7F RID: 175743 RVA: 0x005EB3F9 File Offset: 0x005E95F9
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700B99E RID: 47518
		// (get) Token: 0x0602AE80 RID: 175744 RVA: 0x005EB402 File Offset: 0x005E9602
		// (set) Token: 0x0602AE81 RID: 175745 RVA: 0x005EB40A File Offset: 0x005E960A
		public float LerpTime { get; set; }

		// Token: 0x1700B99F RID: 47519
		// (get) Token: 0x0602AE82 RID: 175746 RVA: 0x005EB413 File Offset: 0x005E9613
		// (set) Token: 0x0602AE83 RID: 175747 RVA: 0x005EB41B File Offset: 0x005E961B
		public string LerpCurve { get; set; }

		// Token: 0x0602AE84 RID: 175748 RVA: 0x005EB424 File Offset: 0x005E9624
		public IAdjustPlayerCameraGravityT()
		{
			this.GravityDirection = null;
			this.LerpTime = 0f;
			this.LerpCurve = null;
		}
	}
}
