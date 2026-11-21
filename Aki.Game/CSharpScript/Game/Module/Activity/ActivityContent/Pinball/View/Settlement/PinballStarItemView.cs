using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x0200527A RID: 21114
	public class PinballStarItemView : GridProxyAbstract<bool>
	{
		// Token: 0x0603490D RID: 215309 RVA: 0x00EB4FE0 File Offset: 0x00EB31E0
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

		// Token: 0x0603490E RID: 215310 RVA: 0x00EB5028 File Offset: 0x00EB3228
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x0603490F RID: 215311 RVA: 0x00EB5031 File Offset: 0x00EB3231
		public void Refresh(bool isActive)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isActive);
		}

		// Token: 0x0200AEDD RID: 44765
		private enum EStarItemComponent
		{
			// Token: 0x0403606C RID: 221292
			SpriteStar
		}
	}
}
