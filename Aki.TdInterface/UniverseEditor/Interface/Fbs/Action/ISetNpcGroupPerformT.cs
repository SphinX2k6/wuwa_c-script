using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F8 RID: 30712
	public class ISetNpcGroupPerformT
	{
		// Token: 0x1700E118 RID: 57624
		// (get) Token: 0x06035F4D RID: 221005 RVA: 0x0073A5D3 File Offset: 0x007387D3
		// (set) Token: 0x06035F4E RID: 221006 RVA: 0x0073A5DB File Offset: 0x007387DB
		public string Key { get; set; }

		// Token: 0x1700E119 RID: 57625
		// (get) Token: 0x06035F4F RID: 221007 RVA: 0x0073A5E4 File Offset: 0x007387E4
		// (set) Token: 0x06035F50 RID: 221008 RVA: 0x0073A5EC File Offset: 0x007387EC
		public TSetNpcGroupPerformTypeUnion PerformType { get; set; }

		// Token: 0x1700E11A RID: 57626
		// (get) Token: 0x06035F51 RID: 221009 RVA: 0x0073A5F5 File Offset: 0x007387F5
		// (set) Token: 0x06035F52 RID: 221010 RVA: 0x0073A5FD File Offset: 0x007387FD
		public bool IsWaitActionFinish { get; set; }

		// Token: 0x1700E11B RID: 57627
		// (get) Token: 0x06035F53 RID: 221011 RVA: 0x0073A606 File Offset: 0x00738806
		// (set) Token: 0x06035F54 RID: 221012 RVA: 0x0073A60E File Offset: 0x0073880E
		public byte NullMask { get; set; }

		// Token: 0x06035F55 RID: 221013 RVA: 0x0073A617 File Offset: 0x00738817
		public ISetNpcGroupPerformT()
		{
			this.Key = null;
			this.PerformType = null;
			this.IsWaitActionFinish = false;
			this.NullMask = 0;
		}
	}
}
