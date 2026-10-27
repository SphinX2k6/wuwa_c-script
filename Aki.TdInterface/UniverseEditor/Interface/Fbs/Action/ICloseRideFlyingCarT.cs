using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200642B RID: 25643
	public class ICloseRideFlyingCarT
	{
		// Token: 0x1700BEF5 RID: 48885
		// (get) Token: 0x0602C609 RID: 181769 RVA: 0x00616B8A File Offset: 0x00614D8A
		// (set) Token: 0x0602C60A RID: 181770 RVA: 0x00616B92 File Offset: 0x00614D92
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x0602C60B RID: 181771 RVA: 0x00616B9B File Offset: 0x00614D9B
		public ICloseRideFlyingCarT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
