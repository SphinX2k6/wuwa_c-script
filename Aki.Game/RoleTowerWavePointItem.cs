using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D11 RID: 7441
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerWavePointItem : GridProxyAbstract<RoleTowerFloorPointData>
{
	// Token: 0x060126C1 RID: 75457 RVA: 0x00571A97 File Offset: 0x0056FC97
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x060126C2 RID: 75458 RVA: 0x00571AD0 File Offset: 0x0056FCD0
	[NullableContext(1)]
	public override void Refresh(RoleTowerFloorPointData data, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(0);
		UUISprite sprite2 = base.GetSprite(1);
		if (sprite != null)
		{
			UUIItem uuiitem = sprite;
			bool isPassed = data.IsPassed;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(isPassed, fcolor);
		}
		if (sprite2 != null)
		{
			UUIItem uuiitem2 = sprite2;
			bool isPassed2 = data.IsPassed;
			FColor? fcolor = new FColor?(sprite2.changeColor);
			uuiitem2.SetChangeColor(isPassed2, fcolor);
		}
	}

	// Token: 0x0200804C RID: 32844
	private static class EChildType
	{
		// Token: 0x0402983C RID: 170044
		public const int SprPoint = 0;

		// Token: 0x0402983D RID: 170045
		public const int SprPointFrame = 1;
	}
}
