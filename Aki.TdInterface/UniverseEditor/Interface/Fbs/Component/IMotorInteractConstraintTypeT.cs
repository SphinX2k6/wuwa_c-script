using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C1 RID: 21953
	public class IMotorInteractConstraintTypeT
	{
		// Token: 0x1700A23F RID: 41535
		// (get) Token: 0x060245EB RID: 148971 RVA: 0x005053DE File Offset: 0x005035DE
		// (set) Token: 0x060245EC RID: 148972 RVA: 0x005053E6 File Offset: 0x005035E6
		public EMotorInteractConstraintType Type { get; set; }

		// Token: 0x060245ED RID: 148973 RVA: 0x005053EF File Offset: 0x005035EF
		public IMotorInteractConstraintTypeT()
		{
			this.Type = EMotorInteractConstraintType.FaceToTarget;
		}
	}
}
