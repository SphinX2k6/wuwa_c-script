using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E0 RID: 28896
	public class ILinearOverRangeCameraShakeT
	{
		// Token: 0x1700D3A2 RID: 54178
		// (get) Token: 0x060322EC RID: 205548 RVA: 0x006CA044 File Offset: 0x006C8244
		// (set) Token: 0x060322ED RID: 205549 RVA: 0x006CA04C File Offset: 0x006C824C
		public ECameraShakeType Type { get; set; }

		// Token: 0x1700D3A3 RID: 54179
		// (get) Token: 0x060322EE RID: 205550 RVA: 0x006CA055 File Offset: 0x006C8255
		// (set) Token: 0x060322EF RID: 205551 RVA: 0x006CA05D File Offset: 0x006C825D
		public int CenterEntityId { get; set; }

		// Token: 0x1700D3A4 RID: 54180
		// (get) Token: 0x060322F0 RID: 205552 RVA: 0x006CA066 File Offset: 0x006C8266
		// (set) Token: 0x060322F1 RID: 205553 RVA: 0x006CA06E File Offset: 0x006C826E
		public int MinRange { get; set; }

		// Token: 0x1700D3A5 RID: 54181
		// (get) Token: 0x060322F2 RID: 205554 RVA: 0x006CA077 File Offset: 0x006C8277
		// (set) Token: 0x060322F3 RID: 205555 RVA: 0x006CA07F File Offset: 0x006C827F
		public int MaxRange { get; set; }

		// Token: 0x060322F4 RID: 205556 RVA: 0x006CA088 File Offset: 0x006C8288
		public ILinearOverRangeCameraShakeT()
		{
			this.Type = ECameraShakeType.Constant;
			this.CenterEntityId = 0;
			this.MinRange = 0;
			this.MaxRange = 0;
		}
	}
}
