using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200613C RID: 24892
	public class RoverlikeLootTipsStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x0603EED7 RID: 257751 RVA: 0x00F332C0 File Offset: 0x00F314C0
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

		// Token: 0x0603EED8 RID: 257752 RVA: 0x00F33329 File Offset: 0x00F31529
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

		// Token: 0x0200C398 RID: 50072
		private class EComponents
		{
			// Token: 0x0403B05F RID: 241759
			public const int ImgStar = 0;

			// Token: 0x0403B060 RID: 241760
			public const int ImgStarOff = 1;
		}
	}
}
