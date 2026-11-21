using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02005F9C RID: 24476
	[NullableContext(2)]
	public interface IGravityFlipViewOpenParam
	{
		// Token: 0x17006EFE RID: 28414
		// (get) Token: 0x0603ACFD RID: 240893
		// (set) Token: 0x0603ACFE RID: 240894
		Action<int> SelectCallback { get; set; }
	}
}
