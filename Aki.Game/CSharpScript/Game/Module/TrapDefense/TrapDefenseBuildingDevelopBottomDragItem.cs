using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A38 RID: 14904
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBottomDragItem : UiPanelBase
	{
		// Token: 0x06026536 RID: 156982 RVA: 0x00ABBC9C File Offset: 0x00AB9E9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026537 RID: 156983 RVA: 0x00ABBD48 File Offset: 0x00AB9F48
		public void Refresh(TrapDefenseBuildingDevelopItemData data)
		{
			this.Data = data;
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(data != null);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			if (data == null)
			{
				return;
			}
			base.SetTextureByPath(data.GetIconPath(), base.GetTexture(2), null, null);
		}

		// Token: 0x06026538 RID: 156984 RVA: 0x00ABBDB9 File Offset: 0x00AB9FB9
		public UUIDraggableComponent GetDraggableComp()
		{
			return base.GetDraggable(0);
		}

		// Token: 0x06026539 RID: 156985 RVA: 0x00ABBDC2 File Offset: 0x00AB9FC2
		public void OnStartDrag()
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(true);
		}

		// Token: 0x0602653A RID: 156986 RVA: 0x00ABBDD6 File Offset: 0x00AB9FD6
		public void OnEndDrag()
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x04015096 RID: 86166
		protected TrapDefenseBuildingDevelopItemData Data;

		// Token: 0x02009602 RID: 38402
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x0402ED6E RID: 191854
			public const int Item = 0;

			// Token: 0x0402ED6F RID: 191855
			public const int SpriteBg = 1;

			// Token: 0x0402ED70 RID: 191856
			public const int TextureIcon = 2;

			// Token: 0x0402ED71 RID: 191857
			public const int Txt = 3;
		}
	}
}
