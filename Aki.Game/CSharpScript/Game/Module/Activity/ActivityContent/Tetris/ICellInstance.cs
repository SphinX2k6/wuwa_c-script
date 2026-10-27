using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD4 RID: 24532
	public interface ICellInstance
	{
		// Token: 0x17009010 RID: 36880
		// (get) Token: 0x0603E296 RID: 254614
		// (set) Token: 0x0603E297 RID: 254615
		int ColorId { get; set; }

		// Token: 0x17009011 RID: 36881
		// (get) Token: 0x0603E298 RID: 254616
		// (set) Token: 0x0603E299 RID: 254617
		EGemType GemType { get; set; }
	}
}
