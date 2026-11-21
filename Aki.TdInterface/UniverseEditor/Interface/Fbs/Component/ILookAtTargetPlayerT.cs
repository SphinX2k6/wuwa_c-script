using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9F RID: 23199
	public class ILookAtTargetPlayerT
	{
		// Token: 0x1700A90D RID: 43277
		// (get) Token: 0x06026073 RID: 155763 RVA: 0x0053624E File Offset: 0x0053444E
		// (set) Token: 0x06026074 RID: 155764 RVA: 0x00536256 File Offset: 0x00534456
		public ELookAtTargetType Type { get; set; }

		// Token: 0x06026075 RID: 155765 RVA: 0x0053625F File Offset: 0x0053445F
		public ILookAtTargetPlayerT()
		{
			this.Type = ELookAtTargetType.Entity;
		}
	}
}
