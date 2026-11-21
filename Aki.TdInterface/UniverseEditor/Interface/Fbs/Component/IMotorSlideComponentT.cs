using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B68 RID: 23400
	public class IMotorSlideComponentT
	{
		// Token: 0x1700AAE7 RID: 43751
		// (get) Token: 0x0602686C RID: 157804 RVA: 0x00546AB9 File Offset: 0x00544CB9
		// (set) Token: 0x0602686D RID: 157805 RVA: 0x00546AC1 File Offset: 0x00544CC1
		public bool Disabled { get; set; }

		// Token: 0x1700AAE8 RID: 43752
		// (get) Token: 0x0602686E RID: 157806 RVA: 0x00546ACA File Offset: 0x00544CCA
		// (set) Token: 0x0602686F RID: 157807 RVA: 0x00546AD2 File Offset: 0x00544CD2
		public IConditionGroupT EnableConditions { get; set; }

		// Token: 0x1700AAE9 RID: 43753
		// (get) Token: 0x06026870 RID: 157808 RVA: 0x00546ADB File Offset: 0x00544CDB
		// (set) Token: 0x06026871 RID: 157809 RVA: 0x00546AE3 File Offset: 0x00544CE3
		public float MaxAngle { get; set; }

		// Token: 0x1700AAEA RID: 43754
		// (get) Token: 0x06026872 RID: 157810 RVA: 0x00546AEC File Offset: 0x00544CEC
		// (set) Token: 0x06026873 RID: 157811 RVA: 0x00546AF4 File Offset: 0x00544CF4
		public string MotorSlideDtName { get; set; }

		// Token: 0x1700AAEB RID: 43755
		// (get) Token: 0x06026874 RID: 157812 RVA: 0x00546AFD File Offset: 0x00544CFD
		// (set) Token: 0x06026875 RID: 157813 RVA: 0x00546B05 File Offset: 0x00544D05
		public byte NullMask { get; set; }

		// Token: 0x06026876 RID: 157814 RVA: 0x00546B0E File Offset: 0x00544D0E
		public IMotorSlideComponentT()
		{
			this.Disabled = false;
			this.EnableConditions = null;
			this.MaxAngle = 0f;
			this.MotorSlideDtName = null;
			this.NullMask = 0;
		}
	}
}
