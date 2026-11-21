using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F03 RID: 28419
	public class IFrequencyPaintT
	{
		// Token: 0x1700D06B RID: 53355
		// (get) Token: 0x060312DD RID: 201437 RVA: 0x006AA4CA File Offset: 0x006A86CA
		// (set) Token: 0x060312DE RID: 201438 RVA: 0x006AA4D2 File Offset: 0x006A86D2
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x060312DF RID: 201439 RVA: 0x006AA4DB File Offset: 0x006A86DB
		public IFrequencyPaintT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
