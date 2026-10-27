using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006697 RID: 26263
	public class IEnableTakePhotoClipT
	{
		// Token: 0x1700C330 RID: 49968
		// (get) Token: 0x0602DA65 RID: 186981 RVA: 0x0063F606 File Offset: 0x0063D806
		// (set) Token: 0x0602DA66 RID: 186982 RVA: 0x0063F60E File Offset: 0x0063D80E
		public bool Enable { get; set; }

		// Token: 0x0602DA67 RID: 186983 RVA: 0x0063F617 File Offset: 0x0063D817
		public IEnableTakePhotoClipT()
		{
			this.Enable = false;
		}
	}
}
