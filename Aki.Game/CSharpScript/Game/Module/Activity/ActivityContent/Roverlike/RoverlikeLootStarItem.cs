using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006167 RID: 24935
	public class RoverlikeLootStarItem : RoverlikeMultiUseGridProxyAbstract<bool>
	{
		// Token: 0x0603F07B RID: 258171 RVA: 0x00F3AFE8 File Offset: 0x00F391E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F07C RID: 258172 RVA: 0x00F3B030 File Offset: 0x00F39230
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(data);
		}

		// Token: 0x0200C3CB RID: 50123
		private class EComponents
		{
			// Token: 0x0403B158 RID: 242008
			public const int SpLight = 0;
		}
	}
}
