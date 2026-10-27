using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A3 RID: 25251
	public class ICameraShakeConfigT
	{
		// Token: 0x1700BC80 RID: 48256
		// (get) Token: 0x0602BA1D RID: 178717 RVA: 0x006019CE File Offset: 0x005FFBCE
		// (set) Token: 0x0602BA1E RID: 178718 RVA: 0x006019D6 File Offset: 0x005FFBD6
		public ECameraShakeType Type { get; set; }

		// Token: 0x0602BA1F RID: 178719 RVA: 0x006019DF File Offset: 0x005FFBDF
		public ICameraShakeConfigT()
		{
			this.Type = ECameraShakeType.Constant;
		}
	}
}
