using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200105E RID: 4190
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchSubDungeonItem : GridProxyAbstract<FloroRanchSubDungeonData>
{
	// Token: 0x0600A69F RID: 42655 RVA: 0x0031115C File Offset: 0x0030F35C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A6A0 RID: 42656 RVA: 0x00311208 File Offset: 0x0030F408
	[NullableContext(1)]
	public override void Refresh(FloroRanchSubDungeonData data, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(3);
		if (sprite != null)
		{
			sprite.SetUIActive(gridIndex != 0);
		}
		UUISprite sprite2 = base.GetSprite(0);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(data.IsFinished);
		}
		UUISprite sprite3 = base.GetSprite(2);
		if (sprite3 != null)
		{
			sprite3.SetUIActive(data.IsFinished && gridIndex != 0);
		}
		UUISprite sprite4 = base.GetSprite(1);
		if (sprite4 == null)
		{
			return;
		}
		sprite4.SetUIActive(!data.IsUnLock);
	}

	// Token: 0x020072C8 RID: 29384
	private class EComponents
	{
		// Token: 0x0402561C RID: 153116
		public const int SpriteFinished = 0;

		// Token: 0x0402561D RID: 153117
		public const int SpriteLock = 1;

		// Token: 0x0402561E RID: 153118
		public const int SpriteFinishedLine = 2;

		// Token: 0x0402561F RID: 153119
		public const int SpriteOriginalLine = 3;
	}
}
