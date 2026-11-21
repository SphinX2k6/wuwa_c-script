using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BCD RID: 31693
	public class ITimeLimitOptionGroupDefaultT
	{
		// Token: 0x1700ED70 RID: 60784
		// (get) Token: 0x06039202 RID: 233986 RVA: 0x007B83FA File Offset: 0x007B65FA
		// (set) Token: 0x06039203 RID: 233987 RVA: 0x007B8402 File Offset: 0x007B6602
		public ETimeLimitOptionGroupStyle Type { get; set; }

		// Token: 0x1700ED71 RID: 60785
		// (get) Token: 0x06039204 RID: 233988 RVA: 0x007B840B File Offset: 0x007B660B
		// (set) Token: 0x06039205 RID: 233989 RVA: 0x007B8413 File Offset: 0x007B6613
		public int TimeoutOptionIndex { get; set; }

		// Token: 0x1700ED72 RID: 60786
		// (get) Token: 0x06039206 RID: 233990 RVA: 0x007B841C File Offset: 0x007B661C
		// (set) Token: 0x06039207 RID: 233991 RVA: 0x007B8424 File Offset: 0x007B6624
		public float TimeLimit { get; set; }

		// Token: 0x06039208 RID: 233992 RVA: 0x007B842D File Offset: 0x007B662D
		public ITimeLimitOptionGroupDefaultT()
		{
			this.Type = ETimeLimitOptionGroupStyle.Default;
			this.TimeoutOptionIndex = 0;
			this.TimeLimit = 0f;
		}
	}
}
