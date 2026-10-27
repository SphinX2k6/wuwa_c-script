using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200647B RID: 25723
	public class ICommonConfirmBoxT
	{
		// Token: 0x1700BF6D RID: 49005
		// (get) Token: 0x0602C910 RID: 182544 RVA: 0x0061E9A8 File Offset: 0x0061CBA8
		// (set) Token: 0x0602C911 RID: 182545 RVA: 0x0061E9B0 File Offset: 0x0061CBB0
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x1700BF6E RID: 49006
		// (get) Token: 0x0602C912 RID: 182546 RVA: 0x0061E9B9 File Offset: 0x0061CBB9
		// (set) Token: 0x0602C913 RID: 182547 RVA: 0x0061E9C1 File Offset: 0x0061CBC1
		public int Id { get; set; }

		// Token: 0x0602C914 RID: 182548 RVA: 0x0061E9CA File Offset: 0x0061CBCA
		public ICommonConfirmBoxT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
			this.Id = 0;
		}
	}
}
