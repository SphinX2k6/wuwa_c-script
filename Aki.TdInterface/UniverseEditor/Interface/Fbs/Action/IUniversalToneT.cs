using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CB1 RID: 31921
	public class IUniversalToneT
	{
		// Token: 0x1700EF00 RID: 61184
		// (get) Token: 0x06039963 RID: 235875 RVA: 0x007C563E File Offset: 0x007C383E
		// (set) Token: 0x06039964 RID: 235876 RVA: 0x007C5646 File Offset: 0x007C3846
		public int UniversalToneId { get; set; }

		// Token: 0x1700EF01 RID: 61185
		// (get) Token: 0x06039965 RID: 235877 RVA: 0x007C564F File Offset: 0x007C384F
		// (set) Token: 0x06039966 RID: 235878 RVA: 0x007C5657 File Offset: 0x007C3857
		public int TimberId { get; set; }

		// Token: 0x1700EF02 RID: 61186
		// (get) Token: 0x06039967 RID: 235879 RVA: 0x007C5660 File Offset: 0x007C3860
		// (set) Token: 0x06039968 RID: 235880 RVA: 0x007C5668 File Offset: 0x007C3868
		public byte NullMask { get; set; }

		// Token: 0x06039969 RID: 235881 RVA: 0x007C5671 File Offset: 0x007C3871
		public IUniversalToneT()
		{
			this.UniversalToneId = 0;
			this.TimberId = 0;
			this.NullMask = 0;
		}
	}
}
