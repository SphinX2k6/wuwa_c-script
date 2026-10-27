using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005142 RID: 20802
	public class IElementDamageT
	{
		// Token: 0x170097AC RID: 38828
		// (get) Token: 0x06021902 RID: 137474 RVA: 0x004A8D72 File Offset: 0x004A6F72
		// (set) Token: 0x06021903 RID: 137475 RVA: 0x004A8D7A File Offset: 0x004A6F7A
		public int DefaultValue { get; set; }

		// Token: 0x170097AD RID: 38829
		// (get) Token: 0x06021904 RID: 137476 RVA: 0x004A8D83 File Offset: 0x004A6F83
		// (set) Token: 0x06021905 RID: 137477 RVA: 0x004A8D8B File Offset: 0x004A6F8B
		public int Physics { get; set; }

		// Token: 0x170097AE RID: 38830
		// (get) Token: 0x06021906 RID: 137478 RVA: 0x004A8D94 File Offset: 0x004A6F94
		// (set) Token: 0x06021907 RID: 137479 RVA: 0x004A8D9C File Offset: 0x004A6F9C
		public int Ice { get; set; }

		// Token: 0x170097AF RID: 38831
		// (get) Token: 0x06021908 RID: 137480 RVA: 0x004A8DA5 File Offset: 0x004A6FA5
		// (set) Token: 0x06021909 RID: 137481 RVA: 0x004A8DAD File Offset: 0x004A6FAD
		public int Fire { get; set; }

		// Token: 0x170097B0 RID: 38832
		// (get) Token: 0x0602190A RID: 137482 RVA: 0x004A8DB6 File Offset: 0x004A6FB6
		// (set) Token: 0x0602190B RID: 137483 RVA: 0x004A8DBE File Offset: 0x004A6FBE
		public int Thunder { get; set; }

		// Token: 0x170097B1 RID: 38833
		// (get) Token: 0x0602190C RID: 137484 RVA: 0x004A8DC7 File Offset: 0x004A6FC7
		// (set) Token: 0x0602190D RID: 137485 RVA: 0x004A8DCF File Offset: 0x004A6FCF
		public int Wind { get; set; }

		// Token: 0x170097B2 RID: 38834
		// (get) Token: 0x0602190E RID: 137486 RVA: 0x004A8DD8 File Offset: 0x004A6FD8
		// (set) Token: 0x0602190F RID: 137487 RVA: 0x004A8DE0 File Offset: 0x004A6FE0
		public int Light { get; set; }

		// Token: 0x170097B3 RID: 38835
		// (get) Token: 0x06021910 RID: 137488 RVA: 0x004A8DE9 File Offset: 0x004A6FE9
		// (set) Token: 0x06021911 RID: 137489 RVA: 0x004A8DF1 File Offset: 0x004A6FF1
		public int Dark { get; set; }

		// Token: 0x170097B4 RID: 38836
		// (get) Token: 0x06021912 RID: 137490 RVA: 0x004A8DFA File Offset: 0x004A6FFA
		// (set) Token: 0x06021913 RID: 137491 RVA: 0x004A8E02 File Offset: 0x004A7002
		public byte NullMask { get; set; }

		// Token: 0x06021914 RID: 137492 RVA: 0x004A8E0C File Offset: 0x004A700C
		public IElementDamageT()
		{
			this.DefaultValue = 0;
			this.Physics = 0;
			this.Ice = 0;
			this.Fire = 0;
			this.Thunder = 0;
			this.Wind = 0;
			this.Light = 0;
			this.Dark = 0;
			this.NullMask = 0;
		}
	}
}
