using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFD RID: 28413
	public class IFrequencyDetectT
	{
		// Token: 0x1700D062 RID: 53346
		// (get) Token: 0x060312B3 RID: 201395 RVA: 0x006AA0A0 File Offset: 0x006A82A0
		// (set) Token: 0x060312B4 RID: 201396 RVA: 0x006AA0A8 File Offset: 0x006A82A8
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D063 RID: 53347
		// (get) Token: 0x060312B5 RID: 201397 RVA: 0x006AA0B1 File Offset: 0x006A82B1
		// (set) Token: 0x060312B6 RID: 201398 RVA: 0x006AA0B9 File Offset: 0x006A82B9
		public int Id { get; set; }

		// Token: 0x060312B7 RID: 201399 RVA: 0x006AA0C2 File Offset: 0x006A82C2
		public IFrequencyDetectT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
		}
	}
}
