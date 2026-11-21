using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F29 RID: 16169
	public class IVector2T
	{
		// Token: 0x17006D79 RID: 28025
		// (get) Token: 0x06015F8F RID: 89999 RVA: 0x003285B6 File Offset: 0x003267B6
		// (set) Token: 0x06015F90 RID: 90000 RVA: 0x003285BE File Offset: 0x003267BE
		public float X { get; set; }

		// Token: 0x17006D7A RID: 28026
		// (get) Token: 0x06015F91 RID: 90001 RVA: 0x003285C7 File Offset: 0x003267C7
		// (set) Token: 0x06015F92 RID: 90002 RVA: 0x003285CF File Offset: 0x003267CF
		public float Y { get; set; }

		// Token: 0x17006D7B RID: 28027
		// (get) Token: 0x06015F93 RID: 90003 RVA: 0x003285D8 File Offset: 0x003267D8
		// (set) Token: 0x06015F94 RID: 90004 RVA: 0x003285E0 File Offset: 0x003267E0
		public byte NullMask { get; set; }

		// Token: 0x06015F95 RID: 90005 RVA: 0x003285E9 File Offset: 0x003267E9
		public IVector2T()
		{
			this.X = 0f;
			this.Y = 0f;
			this.NullMask = 0;
		}
	}
}
