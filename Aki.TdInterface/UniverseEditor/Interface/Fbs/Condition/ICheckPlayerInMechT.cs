using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FC3 RID: 20419
	public class ICheckPlayerInMechT
	{
		// Token: 0x1700920F RID: 37391
		// (get) Token: 0x0601FD63 RID: 130403 RVA: 0x0046C1F0 File Offset: 0x0046A3F0
		// (set) Token: 0x0601FD64 RID: 130404 RVA: 0x0046C1F8 File Offset: 0x0046A3F8
		public EMechConditionType Type { get; set; }

		// Token: 0x17009210 RID: 37392
		// (get) Token: 0x0601FD65 RID: 130405 RVA: 0x0046C201 File Offset: 0x0046A401
		// (set) Token: 0x0601FD66 RID: 130406 RVA: 0x0046C209 File Offset: 0x0046A409
		public bool IsInMech { get; set; }

		// Token: 0x0601FD67 RID: 130407 RVA: 0x0046C212 File Offset: 0x0046A412
		public ICheckPlayerInMechT()
		{
			this.Type = EMechConditionType.PlayerInMech;
			this.IsInMech = false;
		}
	}
}
