using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A90 RID: 19088
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBottomDragItem : UiPanelBase
	{
		// Token: 0x060317A6 RID: 202662 RVA: 0x00B77CE8 File Offset: 0x00B75EE8
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

		// Token: 0x060317A7 RID: 202663 RVA: 0x00B77D94 File Offset: 0x00B75F94
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

		// Token: 0x060317A8 RID: 202664 RVA: 0x00B77E05 File Offset: 0x00B76005
		public UUIDraggableComponent GetDraggableComp()
		{
			return base.GetDraggable(0);
		}

		// Token: 0x060317A9 RID: 202665 RVA: 0x00B77E0E File Offset: 0x00B7600E
		public void OnStartDrag()
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(true);
		}

		// Token: 0x060317AA RID: 202666 RVA: 0x00B77E22 File Offset: 0x00B76022
		public void OnEndDrag()
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0401A744 RID: 108356
		protected TrapDefenseBuildingDevelopItemData Data;

		// Token: 0x0200ABE2 RID: 44002
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x040343BD RID: 213949
			public const int Item = 0;

			// Token: 0x040343BE RID: 213950
			public const int SpriteBg = 1;

			// Token: 0x040343BF RID: 213951
			public const int TextureIcon = 2;

			// Token: 0x040343C0 RID: 213952
			public const int Txt = 3;
		}
	}
}
