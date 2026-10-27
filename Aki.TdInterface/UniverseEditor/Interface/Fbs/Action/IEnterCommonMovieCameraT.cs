using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A9 RID: 26281
	public class IEnterCommonMovieCameraT
	{
		// Token: 0x1700C349 RID: 49993
		// (get) Token: 0x0602DAEB RID: 187115 RVA: 0x006402A3 File Offset: 0x0063E4A3
		// (set) Token: 0x0602DAEC RID: 187116 RVA: 0x006402AB File Offset: 0x0063E4AB
		public EMovieCameraType Type { get; set; }

		// Token: 0x1700C34A RID: 49994
		// (get) Token: 0x0602DAED RID: 187117 RVA: 0x006402B4 File Offset: 0x0063E4B4
		// (set) Token: 0x0602DAEE RID: 187118 RVA: 0x006402BC File Offset: 0x0063E4BC
		public string RowName { get; set; }

		// Token: 0x1700C34B RID: 49995
		// (get) Token: 0x0602DAEF RID: 187119 RVA: 0x006402C5 File Offset: 0x0063E4C5
		// (set) Token: 0x0602DAF0 RID: 187120 RVA: 0x006402CD File Offset: 0x0063E4CD
		public int SpecElementIndex { get; set; }

		// Token: 0x1700C34C RID: 49996
		// (get) Token: 0x0602DAF1 RID: 187121 RVA: 0x006402D6 File Offset: 0x0063E4D6
		// (set) Token: 0x0602DAF2 RID: 187122 RVA: 0x006402DE File Offset: 0x0063E4DE
		public byte NullMask { get; set; }

		// Token: 0x0602DAF3 RID: 187123 RVA: 0x006402E7 File Offset: 0x0063E4E7
		public IEnterCommonMovieCameraT()
		{
			this.Type = EMovieCameraType.Common;
			this.RowName = null;
			this.SpecElementIndex = 0;
			this.NullMask = 0;
		}
	}
}
