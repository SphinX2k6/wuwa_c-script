using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005052 RID: 20562
	public class ICustomAoizRadiusT
	{
		// Token: 0x17009532 RID: 38194
		// (get) Token: 0x06020F39 RID: 134969 RVA: 0x004948EA File Offset: 0x00492AEA
		// (set) Token: 0x06020F3A RID: 134970 RVA: 0x004948F2 File Offset: 0x00492AF2
		public int Up { get; set; }

		// Token: 0x17009533 RID: 38195
		// (get) Token: 0x06020F3B RID: 134971 RVA: 0x004948FB File Offset: 0x00492AFB
		// (set) Token: 0x06020F3C RID: 134972 RVA: 0x00494903 File Offset: 0x00492B03
		public int Down { get; set; }

		// Token: 0x17009534 RID: 38196
		// (get) Token: 0x06020F3D RID: 134973 RVA: 0x0049490C File Offset: 0x00492B0C
		// (set) Token: 0x06020F3E RID: 134974 RVA: 0x00494914 File Offset: 0x00492B14
		public byte NullMask { get; set; }

		// Token: 0x06020F3F RID: 134975 RVA: 0x0049491D File Offset: 0x00492B1D
		public ICustomAoizRadiusT()
		{
			this.Up = 0;
			this.Down = 0;
			this.NullMask = 0;
		}
	}
}
