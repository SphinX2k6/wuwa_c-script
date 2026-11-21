using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D7 RID: 28887
	public class ILimitPlayerOptionT
	{
		// Token: 0x1700D397 RID: 54167
		// (get) Token: 0x060322AA RID: 205482 RVA: 0x006C99A2 File Offset: 0x006C7BA2
		// (set) Token: 0x060322AB RID: 205483 RVA: 0x006C99AA File Offset: 0x006C7BAA
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x060322AC RID: 205484 RVA: 0x006C99B3 File Offset: 0x006C7BB3
		public ILimitPlayerOptionT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
