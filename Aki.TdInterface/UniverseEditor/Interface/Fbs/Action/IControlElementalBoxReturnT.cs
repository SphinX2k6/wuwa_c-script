using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3A RID: 27450
	public class IControlElementalBoxReturnT
	{
		// Token: 0x1700C99D RID: 51613
		// (get) Token: 0x0602F3D4 RID: 193492 RVA: 0x006733F3 File Offset: 0x006715F3
		// (set) Token: 0x0602F3D5 RID: 193493 RVA: 0x006733FB File Offset: 0x006715FB
		public EControlElementalBoxType Type { get; set; }

		// Token: 0x1700C99E RID: 51614
		// (get) Token: 0x0602F3D6 RID: 193494 RVA: 0x00673404 File Offset: 0x00671604
		// (set) Token: 0x0602F3D7 RID: 193495 RVA: 0x0067340C File Offset: 0x0067160C
		public string ReturnBeforeMoveSeq { get; set; }

		// Token: 0x0602F3D8 RID: 193496 RVA: 0x00673415 File Offset: 0x00671615
		public IControlElementalBoxReturnT()
		{
			this.Type = EControlElementalBoxType.Capture;
			this.ReturnBeforeMoveSeq = null;
		}
	}
}
