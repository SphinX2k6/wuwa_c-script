using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance
{
	// Token: 0x02006E52 RID: 28242
	[NullableContext(1)]
	public interface ISunSpiritOriginInfo
	{
		// Token: 0x17009A36 RID: 39478
		// (get) Token: 0x06044D59 RID: 281945
		// (set) Token: 0x06044D5A RID: 281946
		EntityHandle EntityHandle { get; set; }

		// Token: 0x17009A37 RID: 39479
		// (get) Token: 0x06044D5B RID: 281947
		// (set) Token: 0x06044D5C RID: 281948
		Transform Transform { get; set; }

		// Token: 0x17009A38 RID: 39480
		// (get) Token: 0x06044D5D RID: 281949
		// (set) Token: 0x06044D5E RID: 281950
		int DisableMoveHandle { get; set; }

		// Token: 0x17009A39 RID: 39481
		// (get) Token: 0x06044D5F RID: 281951
		// (set) Token: 0x06044D60 RID: 281952
		int DisableMoveTickHandle { get; set; }
	}
}
