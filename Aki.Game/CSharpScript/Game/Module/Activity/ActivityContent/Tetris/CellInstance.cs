using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD5 RID: 24533
	public class CellInstance : ICellInstance
	{
		// Token: 0x17009012 RID: 36882
		// (get) Token: 0x0603E29A RID: 254618 RVA: 0x00F02B78 File Offset: 0x00F00D78
		// (set) Token: 0x0603E29B RID: 254619 RVA: 0x00F02B80 File Offset: 0x00F00D80
		public int ColorId { get; set; }

		// Token: 0x17009013 RID: 36883
		// (get) Token: 0x0603E29C RID: 254620 RVA: 0x00F02B89 File Offset: 0x00F00D89
		// (set) Token: 0x0603E29D RID: 254621 RVA: 0x00F02B91 File Offset: 0x00F00D91
		public EGemType GemType { get; set; }
	}
}
