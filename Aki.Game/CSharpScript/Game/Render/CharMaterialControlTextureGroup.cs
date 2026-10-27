using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045B6 RID: 17846
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlTextureGroup
	{
		// Token: 0x0602E051 RID: 188497 RVA: 0x00A994A0 File Offset: 0x00A976A0
		public CharMaterialControlTextureGroup(UTexture2D end, UTexture2D loop, UTexture2D start)
		{
			this.End = end;
			this.Loop = loop;
			this.Start = start;
		}

		// Token: 0x04018932 RID: 100658
		public UTexture2D End;

		// Token: 0x04018933 RID: 100659
		public UTexture2D Loop;

		// Token: 0x04018934 RID: 100660
		public UTexture2D Start;
	}
}
