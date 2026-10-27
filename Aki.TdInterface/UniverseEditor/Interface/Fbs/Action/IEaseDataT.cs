using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006625 RID: 26149
	public class IEaseDataT
	{
		// Token: 0x1700C245 RID: 49733
		// (get) Token: 0x0602D687 RID: 185991 RVA: 0x00638A1C File Offset: 0x00636C1C
		// (set) Token: 0x0602D688 RID: 185992 RVA: 0x00638A24 File Offset: 0x00636C24
		public EEaseType Type { get; set; }

		// Token: 0x1700C246 RID: 49734
		// (get) Token: 0x0602D689 RID: 185993 RVA: 0x00638A2D File Offset: 0x00636C2D
		// (set) Token: 0x0602D68A RID: 185994 RVA: 0x00638A35 File Offset: 0x00636C35
		public float Duration { get; set; }

		// Token: 0x0602D68B RID: 185995 RVA: 0x00638A3E File Offset: 0x00636C3E
		public IEaseDataT()
		{
			this.Type = EEaseType.Linear;
			this.Duration = 0f;
		}
	}
}
