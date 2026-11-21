using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005785 RID: 22405
	public class IFaceToTargetMotorInteractConstraintT
	{
		// Token: 0x1700A1F2 RID: 41458
		// (get) Token: 0x06024237 RID: 148023 RVA: 0x004F8249 File Offset: 0x004F6449
		// (set) Token: 0x06024238 RID: 148024 RVA: 0x004F8251 File Offset: 0x004F6451
		public EMotorInteractConstraintType Type { get; set; }

		// Token: 0x1700A1F3 RID: 41459
		// (get) Token: 0x06024239 RID: 148025 RVA: 0x004F825A File Offset: 0x004F645A
		// (set) Token: 0x0602423A RID: 148026 RVA: 0x004F8262 File Offset: 0x004F6462
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700A1F4 RID: 41460
		// (get) Token: 0x0602423B RID: 148027 RVA: 0x004F826B File Offset: 0x004F646B
		// (set) Token: 0x0602423C RID: 148028 RVA: 0x004F8273 File Offset: 0x004F6473
		public float Angle { get; set; }

		// Token: 0x0602423D RID: 148029 RVA: 0x004F827C File Offset: 0x004F647C
		public IFaceToTargetMotorInteractConstraintT()
		{
			this.Type = EMotorInteractConstraintType.FaceToTarget;
			this.Target = null;
			this.Angle = 0f;
		}
	}
}
