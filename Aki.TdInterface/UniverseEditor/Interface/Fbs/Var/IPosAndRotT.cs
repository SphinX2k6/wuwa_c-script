using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EB7 RID: 16055
	public class IPosAndRotT
	{
		// Token: 0x17006CB2 RID: 27826
		// (get) Token: 0x06015B92 RID: 88978 RVA: 0x0032097A File Offset: 0x0031EB7A
		// (set) Token: 0x06015B93 RID: 88979 RVA: 0x00320982 File Offset: 0x0031EB82
		public float X { get; set; }

		// Token: 0x17006CB3 RID: 27827
		// (get) Token: 0x06015B94 RID: 88980 RVA: 0x0032098B File Offset: 0x0031EB8B
		// (set) Token: 0x06015B95 RID: 88981 RVA: 0x00320993 File Offset: 0x0031EB93
		public float Y { get; set; }

		// Token: 0x17006CB4 RID: 27828
		// (get) Token: 0x06015B96 RID: 88982 RVA: 0x0032099C File Offset: 0x0031EB9C
		// (set) Token: 0x06015B97 RID: 88983 RVA: 0x003209A4 File Offset: 0x0031EBA4
		public float Z { get; set; }

		// Token: 0x17006CB5 RID: 27829
		// (get) Token: 0x06015B98 RID: 88984 RVA: 0x003209AD File Offset: 0x0031EBAD
		// (set) Token: 0x06015B99 RID: 88985 RVA: 0x003209B5 File Offset: 0x0031EBB5
		public float A { get; set; }

		// Token: 0x17006CB6 RID: 27830
		// (get) Token: 0x06015B9A RID: 88986 RVA: 0x003209BE File Offset: 0x0031EBBE
		// (set) Token: 0x06015B9B RID: 88987 RVA: 0x003209C6 File Offset: 0x0031EBC6
		public float Roll { get; set; }

		// Token: 0x17006CB7 RID: 27831
		// (get) Token: 0x06015B9C RID: 88988 RVA: 0x003209CF File Offset: 0x0031EBCF
		// (set) Token: 0x06015B9D RID: 88989 RVA: 0x003209D7 File Offset: 0x0031EBD7
		public float Pitch { get; set; }

		// Token: 0x17006CB8 RID: 27832
		// (get) Token: 0x06015B9E RID: 88990 RVA: 0x003209E0 File Offset: 0x0031EBE0
		// (set) Token: 0x06015B9F RID: 88991 RVA: 0x003209E8 File Offset: 0x0031EBE8
		public byte NullMask { get; set; }

		// Token: 0x06015BA0 RID: 88992 RVA: 0x003209F4 File Offset: 0x0031EBF4
		public IPosAndRotT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.Roll = 0f;
			this.Pitch = 0f;
			this.NullMask = 0;
		}
	}
}
