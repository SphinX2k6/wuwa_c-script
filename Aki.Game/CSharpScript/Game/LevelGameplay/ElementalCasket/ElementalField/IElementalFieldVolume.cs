using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006028 RID: 24616
	[NullableContext(1)]
	public interface IElementalFieldVolume
	{
		// Token: 0x0603B1DD RID: 242141
		bool ContainsPoint(Vector point);

		// Token: 0x0603B1DE RID: 242142
		bool IntersectsSegment(Vector a, Vector b);

		// Token: 0x0603B1DF RID: 242143
		void DebugDraw();
	}
}
