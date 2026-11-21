using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005107 RID: 20743
	public class RoverlikePropItemData : IRoverlikePropItemData
	{
		// Token: 0x17006539 RID: 25913
		// (get) Token: 0x06033E54 RID: 212564 RVA: 0x00E8601A File Offset: 0x00E8421A
		// (set) Token: 0x06033E55 RID: 212565 RVA: 0x00E86022 File Offset: 0x00E84222
		public int ConfigId { get; set; }

		// Token: 0x1700653A RID: 25914
		// (get) Token: 0x06033E56 RID: 212566 RVA: 0x00E8602B File Offset: 0x00E8422B
		// (set) Token: 0x06033E57 RID: 212567 RVA: 0x00E86033 File Offset: 0x00E84233
		public bool IsInGame { get; set; }

		// Token: 0x1700653B RID: 25915
		// (get) Token: 0x06033E58 RID: 212568 RVA: 0x00E8603C File Offset: 0x00E8423C
		// (set) Token: 0x06033E59 RID: 212569 RVA: 0x00E86044 File Offset: 0x00E84244
		public int? IncId { get; set; }
	}
}
