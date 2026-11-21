using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E5 RID: 20709
	public class RoverlikeLootStarItem : RoverlikeMultiUseGridProxyAbstract<bool>
	{
		// Token: 0x06033D3B RID: 212283 RVA: 0x00E81EBC File Offset: 0x00E800BC
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

		// Token: 0x06033D3C RID: 212284 RVA: 0x00E81F04 File Offset: 0x00E80104
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(data);
		}

		// Token: 0x0200ADB2 RID: 44466
		private class EComponents
		{
			// Token: 0x04035AB9 RID: 219833
			public const int SpLight = 0;
		}
	}
}
