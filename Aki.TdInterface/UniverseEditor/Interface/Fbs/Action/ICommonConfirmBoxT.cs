using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE3 RID: 27363
	public class ICommonConfirmBoxT
	{
		// Token: 0x1700C8EF RID: 51439
		// (get) Token: 0x0602F061 RID: 192609 RVA: 0x00669FB4 File Offset: 0x006681B4
		// (set) Token: 0x0602F062 RID: 192610 RVA: 0x00669FBC File Offset: 0x006681BC
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x1700C8F0 RID: 51440
		// (get) Token: 0x0602F063 RID: 192611 RVA: 0x00669FC5 File Offset: 0x006681C5
		// (set) Token: 0x0602F064 RID: 192612 RVA: 0x00669FCD File Offset: 0x006681CD
		public int Id { get; set; }

		// Token: 0x0602F065 RID: 192613 RVA: 0x00669FD6 File Offset: 0x006681D6
		public ICommonConfirmBoxT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
			this.Id = 0;
		}
	}
}
