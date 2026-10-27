using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B2A RID: 15146
	public class IVectorInfoT
	{
		// Token: 0x170067E6 RID: 26598
		// (get) Token: 0x06014B01 RID: 84737 RVA: 0x00302644 File Offset: 0x00300844
		// (set) Token: 0x06014B02 RID: 84738 RVA: 0x0030264C File Offset: 0x0030084C
		public float X { get; set; }

		// Token: 0x170067E7 RID: 26599
		// (get) Token: 0x06014B03 RID: 84739 RVA: 0x00302655 File Offset: 0x00300855
		// (set) Token: 0x06014B04 RID: 84740 RVA: 0x0030265D File Offset: 0x0030085D
		public float Y { get; set; }

		// Token: 0x170067E8 RID: 26600
		// (get) Token: 0x06014B05 RID: 84741 RVA: 0x00302666 File Offset: 0x00300866
		// (set) Token: 0x06014B06 RID: 84742 RVA: 0x0030266E File Offset: 0x0030086E
		public float Z { get; set; }

		// Token: 0x170067E9 RID: 26601
		// (get) Token: 0x06014B07 RID: 84743 RVA: 0x00302677 File Offset: 0x00300877
		// (set) Token: 0x06014B08 RID: 84744 RVA: 0x0030267F File Offset: 0x0030087F
		public byte NullMask { get; set; }

		// Token: 0x06014B09 RID: 84745 RVA: 0x00302688 File Offset: 0x00300888
		public IVectorInfoT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.NullMask = 0;
		}
	}
}
