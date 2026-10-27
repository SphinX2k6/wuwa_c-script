using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B0 RID: 26032
	public class ListItem : GridProxyAbstract<int>
	{
		// Token: 0x060414A3 RID: 267427 RVA: 0x00FD2C1C File Offset: 0x00FD0E1C
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

		// Token: 0x060414A4 RID: 267428 RVA: 0x00FD2C64 File Offset: 0x00FD0E64
		protected override void OnStart()
		{
			this.Sprite = base.GetSprite(0);
		}

		// Token: 0x060414A5 RID: 267429 RVA: 0x00FD2C73 File Offset: 0x00FD0E73
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.IsActive = (data == 1);
			this.Sprite.SetAlpha((float)data);
		}

		// Token: 0x060414A6 RID: 267430 RVA: 0x00FD2C8C File Offset: 0x00FD0E8C
		[NullableContext(1)]
		public void SetSpriteByQuality(string gridColor)
		{
			if (this.IsActive)
			{
				this.Sprite.SetColor(FColor.FromHex(gridColor));
			}
		}

		// Token: 0x04021FC6 RID: 139206
		protected bool IsActive;

		// Token: 0x04021FC7 RID: 139207
		[Nullable(1)]
		private UUISprite Sprite;

		// Token: 0x0200C7B7 RID: 51127
		private class EListItem
		{
			// Token: 0x0403C53E RID: 247102
			public const int BgSprite = 0;
		}
	}
}
