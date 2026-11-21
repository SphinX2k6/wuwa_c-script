using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063B7 RID: 25527
	public class IConstraintValueMaxT
	{
		// Token: 0x1700BCA3 RID: 48291
		// (get) Token: 0x0602B594 RID: 177556 RVA: 0x005E8514 File Offset: 0x005E6714
		// (set) Token: 0x0602B595 RID: 177557 RVA: 0x005E851C File Offset: 0x005E671C
		public EConstraintValueType Type { get; set; }

		// Token: 0x1700BCA4 RID: 48292
		// (get) Token: 0x0602B596 RID: 177558 RVA: 0x005E8525 File Offset: 0x005E6725
		// (set) Token: 0x0602B597 RID: 177559 RVA: 0x005E852D File Offset: 0x005E672D
		public float MaxValue { get; set; }

		// Token: 0x0602B598 RID: 177560 RVA: 0x005E8536 File Offset: 0x005E6736
		public IConstraintValueMaxT()
		{
			this.Type = EConstraintValueType.Max;
			this.MaxValue = 0f;
		}
	}
}
