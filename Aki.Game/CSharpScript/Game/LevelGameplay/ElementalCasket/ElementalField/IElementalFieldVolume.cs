using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006EA8 RID: 28328
	[NullableContext(1)]
	public interface IElementalFieldVolume
	{
		// Token: 0x0604503C RID: 282684
		bool ContainsPoint(Vector point);

		// Token: 0x0604503D RID: 282685
		bool IntersectsSegment(Vector a, Vector b);

		// Token: 0x0604503E RID: 282686
		void DebugDraw();
	}
}
