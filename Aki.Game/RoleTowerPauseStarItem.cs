using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CE2 RID: 7394
public class RoleTowerPauseStarItem : GridProxyAbstract<bool>
{
	// Token: 0x060124CE RID: 74958 RVA: 0x005659D4 File Offset: 0x00563BD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x060124CF RID: 74959 RVA: 0x00565A2E File Offset: 0x00563C2E
	public override void Refresh(bool isActive, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(isActive);
		}
		UUISprite sprite2 = base.GetSprite(1);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(!isActive);
		}
		UUISprite sprite3 = base.GetSprite(2);
		if (sprite3 == null)
		{
			return;
		}
		sprite3.SetUIActive(false);
	}

	// Token: 0x060124D0 RID: 74960 RVA: 0x00565A6B File Offset: 0x00563C6B
	[NullableContext(1)]
	public override object GetKey(bool isActive, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x02007FE0 RID: 32736
	private static class EChildType
	{
		// Token: 0x040295EA RID: 169450
		public const int SprOn = 0;

		// Token: 0x040295EB RID: 169451
		public const int SprOff = 1;

		// Token: 0x040295EC RID: 169452
		public const int SprNext = 2;
	}
}
