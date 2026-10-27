using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007500 RID: 29952
	public class IVehicleCruisingParamsT
	{
		// Token: 0x1700E340 RID: 58176
		// (get) Token: 0x0603676B RID: 223083 RVA: 0x007660C4 File Offset: 0x007642C4
		// (set) Token: 0x0603676C RID: 223084 RVA: 0x007660CC File Offset: 0x007642CC
		public float ForwardSpeed { get; set; }

		// Token: 0x1700E341 RID: 58177
		// (get) Token: 0x0603676D RID: 223085 RVA: 0x007660D5 File Offset: 0x007642D5
		// (set) Token: 0x0603676E RID: 223086 RVA: 0x007660DD File Offset: 0x007642DD
		public float ForwardAcceleration { get; set; }

		// Token: 0x1700E342 RID: 58178
		// (get) Token: 0x0603676F RID: 223087 RVA: 0x007660E6 File Offset: 0x007642E6
		// (set) Token: 0x06036770 RID: 223088 RVA: 0x007660EE File Offset: 0x007642EE
		public bool DisableSprint { get; set; }

		// Token: 0x1700E343 RID: 58179
		// (get) Token: 0x06036771 RID: 223089 RVA: 0x007660F7 File Offset: 0x007642F7
		// (set) Token: 0x06036772 RID: 223090 RVA: 0x007660FF File Offset: 0x007642FF
		public byte NullMask { get; set; }

		// Token: 0x06036773 RID: 223091 RVA: 0x00766108 File Offset: 0x00764308
		public IVehicleCruisingParamsT()
		{
			this.ForwardSpeed = 0f;
			this.ForwardAcceleration = 0f;
			this.DisableSprint = false;
			this.NullMask = 0;
		}
	}
}
