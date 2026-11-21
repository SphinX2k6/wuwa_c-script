using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FCF RID: 12239
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisTargetItemPanel : GridProxyAbstract<TetrisTargetData>
	{
		// Token: 0x0601D0C3 RID: 118979 RVA: 0x008DFAE0 File Offset: 0x008DDCE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D0C4 RID: 118980 RVA: 0x008DFB6C File Offset: 0x008DDD6C
		public override void Refresh(TetrisTargetData data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(0);
			if (data.Icon.Length != 0)
			{
				sprite.SetUIActive(true);
				this.SetSpriteByPath(data.Icon, sprite, false, null, null);
			}
			else
			{
				sprite.SetUIActive(false);
			}
			UUIText text = base.GetText(1);
			if (data.Num > 0)
			{
				text.SetUIActive(true);
				text.SetText(data.Num.ToString(), true);
			}
			else
			{
				text.SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Tip, Array.Empty<object>());
		}
	}
}
