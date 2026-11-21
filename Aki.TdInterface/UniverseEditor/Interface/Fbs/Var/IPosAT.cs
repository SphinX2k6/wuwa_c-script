using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EB4 RID: 16052
	public class IPosAT
	{
		// Token: 0x17006CA5 RID: 27813
		// (get) Token: 0x06015B6C RID: 88940 RVA: 0x00320496 File Offset: 0x0031E696
		// (set) Token: 0x06015B6D RID: 88941 RVA: 0x0032049E File Offset: 0x0031E69E
		public float X { get; set; }

		// Token: 0x17006CA6 RID: 27814
		// (get) Token: 0x06015B6E RID: 88942 RVA: 0x003204A7 File Offset: 0x0031E6A7
		// (set) Token: 0x06015B6F RID: 88943 RVA: 0x003204AF File Offset: 0x0031E6AF
		public float Y { get; set; }

		// Token: 0x17006CA7 RID: 27815
		// (get) Token: 0x06015B70 RID: 88944 RVA: 0x003204B8 File Offset: 0x0031E6B8
		// (set) Token: 0x06015B71 RID: 88945 RVA: 0x003204C0 File Offset: 0x0031E6C0
		public float Z { get; set; }

		// Token: 0x17006CA8 RID: 27816
		// (get) Token: 0x06015B72 RID: 88946 RVA: 0x003204C9 File Offset: 0x0031E6C9
		// (set) Token: 0x06015B73 RID: 88947 RVA: 0x003204D1 File Offset: 0x0031E6D1
		public float A { get; set; }

		// Token: 0x17006CA9 RID: 27817
		// (get) Token: 0x06015B74 RID: 88948 RVA: 0x003204DA File Offset: 0x0031E6DA
		// (set) Token: 0x06015B75 RID: 88949 RVA: 0x003204E2 File Offset: 0x0031E6E2
		public byte NullMask { get; set; }

		// Token: 0x06015B76 RID: 88950 RVA: 0x003204EB File Offset: 0x0031E6EB
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
