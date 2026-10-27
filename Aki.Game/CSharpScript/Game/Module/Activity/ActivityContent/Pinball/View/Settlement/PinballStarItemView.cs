using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062FC RID: 25340
	public class PinballStarItemView : GridProxyAbstract<bool>
	{
		// Token: 0x0603FC4C RID: 261196 RVA: 0x00F6E084 File Offset: 0x00F6C284
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

		// Token: 0x0603FC4D RID: 261197 RVA: 0x00F6E0CC File Offset: 0x00F6C2CC
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x0603FC4E RID: 261198 RVA: 0x00F6E0D5 File Offset: 0x00F6C2D5
		public void Refresh(bool isActive)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isActive);
		}

		// Token: 0x0200C4F6 RID: 50422
		private enum EStarItemComponent
		{
			// Token: 0x0403B70A RID: 243466
			SpriteStar
		}
	}
}
