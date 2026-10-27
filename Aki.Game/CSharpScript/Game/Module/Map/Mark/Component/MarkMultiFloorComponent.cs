using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054CE RID: 21710
	public class MarkMultiFloorComponent : MapComponent
	{
		// Token: 0x060376D5 RID: 227029 RVA: 0x00D2A31F File Offset: 0x00D2851F
		public MarkMultiFloorComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17008501 RID: 34049
		// (get) Token: 0x060376D6 RID: 227030 RVA: 0x00D2A328 File Offset: 0x00D28528
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkMultiFloor;
			}
		}

		// Token: 0x17008502 RID: 34050
		// (get) Token: 0x060376D8 RID: 227032 RVA: 0x00D2A348 File Offset: 0x00D28548
		// (set) Token: 0x060376D7 RID: 227031 RVA: 0x00D2A32C File Offset: 0x00D2852C
		public bool IsSelectThisFloor
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				return base.PropertyMap.TryGetValue(0, out oneOf) && oneOf.AsT2;
			}
			set
			{
				base.PropertyMap[0] = value;
			}
		}

		// Token: 0x0200B73D RID: 46909
		private enum EPropertyType
		{
			// Token: 0x040377CF RID: 227279
			IsSelectThisFloor
		}
	}
}
