using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x02004493 RID: 17555
	public class CreateMarkViewParams
	{
		// Token: 0x04017D70 RID: 97648
		public EMapType MapType = EMapType.WorldMap;

		// Token: 0x04017D71 RID: 97649
		public float MarkScale = 1f;

		// Token: 0x04017D72 RID: 97650
		[Nullable(2)]
		public UUIItem ViewParent;
	}
}
