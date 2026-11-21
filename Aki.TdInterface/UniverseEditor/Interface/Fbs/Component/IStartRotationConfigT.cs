using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA6 RID: 24486
	public class IStartRotationConfigT
	{
		// Token: 0x1700B555 RID: 46421
		// (get) Token: 0x060292F8 RID: 168696 RVA: 0x0059F74B File Offset: 0x0059D94B
		// (set) Token: 0x060292F9 RID: 168697 RVA: 0x0059F753 File Offset: 0x0059D953
		public IVectorInfoT TargetRotation { get; set; }

		// Token: 0x1700B556 RID: 46422
		// (get) Token: 0x060292FA RID: 168698 RVA: 0x0059F75C File Offset: 0x0059D95C
		// (set) Token: 0x060292FB RID: 168699 RVA: 0x0059F764 File Offset: 0x0059D964
		public float AngularSpeed { get; set; }

		// Token: 0x060292FC RID: 168700 RVA: 0x0059F76D File Offset: 0x0059D96D
		public IStartRotationConfigT()
		{
			this.TargetRotation = null;
			this.AngularSpeed = 0f;
		}
	}
}
