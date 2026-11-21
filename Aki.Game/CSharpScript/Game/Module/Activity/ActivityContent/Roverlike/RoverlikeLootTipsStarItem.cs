using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050BA RID: 20666
	public class RoverlikeLootTipsStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x06033B97 RID: 211863 RVA: 0x00E7A1A0 File Offset: 0x00E783A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033B98 RID: 211864 RVA: 0x00E7A209 File Offset: 0x00E78409
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(data);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(!data);
		}

		// Token: 0x0200AD7F RID: 44415
		private class EComponents
		{
			// Token: 0x040359C0 RID: 219584
			public const int ImgStar = 0;

			// Token: 0x040359C1 RID: 219585
			public const int ImgStarOff = 1;
		}
	}
}
