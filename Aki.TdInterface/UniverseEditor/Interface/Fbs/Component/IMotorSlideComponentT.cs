using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CA RID: 21962
	public class IMotorSlideComponentT
	{
		// Token: 0x1700A25F RID: 41567
		// (get) Token: 0x0602465F RID: 149087 RVA: 0x00506541 File Offset: 0x00504741
		// (set) Token: 0x06024660 RID: 149088 RVA: 0x00506549 File Offset: 0x00504749
		public bool Disabled { get; set; }

		// Token: 0x1700A260 RID: 41568
		// (get) Token: 0x06024661 RID: 149089 RVA: 0x00506552 File Offset: 0x00504752
		// (set) Token: 0x06024662 RID: 149090 RVA: 0x0050655A File Offset: 0x0050475A
		public IConditionGroupT EnableConditions { get; set; }

		// Token: 0x1700A261 RID: 41569
		// (get) Token: 0x06024663 RID: 149091 RVA: 0x00506563 File Offset: 0x00504763
		// (set) Token: 0x06024664 RID: 149092 RVA: 0x0050656B File Offset: 0x0050476B
		public float MaxAngle { get; set; }

		// Token: 0x1700A262 RID: 41570
		// (get) Token: 0x06024665 RID: 149093 RVA: 0x00506574 File Offset: 0x00504774
		// (set) Token: 0x06024666 RID: 149094 RVA: 0x0050657C File Offset: 0x0050477C
		public string MotorSlideDtName { get; set; }

		// Token: 0x1700A263 RID: 41571
		// (get) Token: 0x06024667 RID: 149095 RVA: 0x00506585 File Offset: 0x00504785
		// (set) Token: 0x06024668 RID: 149096 RVA: 0x0050658D File Offset: 0x0050478D
		public byte NullMask { get; set; }

		// Token: 0x06024669 RID: 149097 RVA: 0x00506596 File Offset: 0x00504796
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
