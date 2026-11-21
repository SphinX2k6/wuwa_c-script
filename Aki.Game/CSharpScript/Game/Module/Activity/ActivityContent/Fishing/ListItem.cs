using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200552E RID: 21806
	public class ListItem : GridProxyAbstract<int>
	{
		// Token: 0x06036168 RID: 221544 RVA: 0x00F19C20 File Offset: 0x00F17E20
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

		// Token: 0x06036169 RID: 221545 RVA: 0x00F19C68 File Offset: 0x00F17E68
		protected override void OnStart()
		{
			this.Sprite = base.GetSprite(0);
		}

		// Token: 0x0603616A RID: 221546 RVA: 0x00F19C77 File Offset: 0x00F17E77
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.IsActive = (data == 1);
			this.Sprite.SetAlpha((float)data);
		}

		// Token: 0x0603616B RID: 221547 RVA: 0x00F19C90 File Offset: 0x00F17E90
		[NullableContext(1)]
		public void SetSpriteByQuality(string gridColor)
		{
			if (this.IsActive)
			{
				this.Sprite.SetColor(FColor.FromHex(gridColor));
			}
		}

		// Token: 0x0401C8F7 RID: 116983
		protected bool IsActive;

		// Token: 0x0401C8F8 RID: 116984
		[Nullable(1)]
		private UUISprite Sprite;

		// Token: 0x0200B19C RID: 45468
		private class EListItem
		{
			// Token: 0x04036E8F RID: 224911
			public const int BgSprite = 0;
		}
	}
}
