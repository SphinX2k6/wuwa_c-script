using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034DE RID: 13534
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlTextureGroup
	{
		// Token: 0x0602273B RID: 141115 RVA: 0x009C56C0 File Offset: 0x009C38C0
		public CharMaterialControlTextureGroup(UTexture2D end, UTexture2D loop, UTexture2D start)
		{
			this.End = end;
			this.Loop = loop;
			this.Start = start;
		}

		// Token: 0x04012F6D RID: 77677
		public UTexture2D End;

		// Token: 0x04012F6E RID: 77678
		public UTexture2D Loop;

		// Token: 0x04012F6F RID: 77679
		public UTexture2D Start;
	}
}
