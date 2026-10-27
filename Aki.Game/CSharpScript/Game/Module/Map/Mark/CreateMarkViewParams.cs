using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054B0 RID: 21680
	public class CreateMarkViewParams
	{
		// Token: 0x0401D2D4 RID: 119508
		public EMapType MapType = EMapType.WorldMap;

		// Token: 0x0401D2D5 RID: 119509
		public float MarkScale = 1f;

		// Token: 0x0401D2D6 RID: 119510
		[Nullable(2)]
		public UUIItem ViewParent;
	}
}
