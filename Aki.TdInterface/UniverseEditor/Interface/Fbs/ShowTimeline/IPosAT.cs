using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA1 RID: 16289
	public class IPosAT
	{
		// Token: 0x17006E2E RID: 28206
		// (get) Token: 0x06016336 RID: 90934 RVA: 0x0032EB66 File Offset: 0x0032CD66
		// (set) Token: 0x06016337 RID: 90935 RVA: 0x0032EB6E File Offset: 0x0032CD6E
		public float X { get; set; }

		// Token: 0x17006E2F RID: 28207
		// (get) Token: 0x06016338 RID: 90936 RVA: 0x0032EB77 File Offset: 0x0032CD77
		// (set) Token: 0x06016339 RID: 90937 RVA: 0x0032EB7F File Offset: 0x0032CD7F
		public float Y { get; set; }

		// Token: 0x17006E30 RID: 28208
		// (get) Token: 0x0601633A RID: 90938 RVA: 0x0032EB88 File Offset: 0x0032CD88
		// (set) Token: 0x0601633B RID: 90939 RVA: 0x0032EB90 File Offset: 0x0032CD90
		public float Z { get; set; }

		// Token: 0x17006E31 RID: 28209
		// (get) Token: 0x0601633C RID: 90940 RVA: 0x0032EB99 File Offset: 0x0032CD99
		// (set) Token: 0x0601633D RID: 90941 RVA: 0x0032EBA1 File Offset: 0x0032CDA1
		public float A { get; set; }

		// Token: 0x17006E32 RID: 28210
		// (get) Token: 0x0601633E RID: 90942 RVA: 0x0032EBAA File Offset: 0x0032CDAA
		// (set) Token: 0x0601633F RID: 90943 RVA: 0x0032EBB2 File Offset: 0x0032CDB2
		public byte NullMask { get; set; }

		// Token: 0x06016340 RID: 90944 RVA: 0x0032EBBB File Offset: 0x0032CDBB
		public IPosAT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.NullMask = 0;
		}
	}
}
