using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020047BF RID: 18367
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapVerticalLayoutItem : GridProxyAbstract<IMapSubViewListItemData>
	{
		// Token: 0x060301D5 RID: 197077 RVA: 0x00B27114 File Offset: 0x00B25314
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnClickCb));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060301D6 RID: 197078 RVA: 0x00B27240 File Offset: 0x00B25440
		[NullableContext(1)]
		public override void Refresh(IMapSubViewListItemData data, bool isSelected, int gridIndex)
		{
			this._data = data;
			if (!string.IsNullOrEmpty(data.LeftText))
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetText(data.LeftText, true);
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.LeftTextId, Array.Empty<object>());
			}
			if (!string.IsNullOrEmpty(data.RightText))
			{
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				UUIText text3 = base.GetText(1);
				if (text3 != null)
				{
					text3.SetText(data.RightText, true);
				}
			}
			else if (!string.IsNullOrEmpty(data.RightTextId))
			{
				UUIText text4 = base.GetText(1);
				if (text4 != null)
				{
					text4.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.RightTextId, Array.Empty<object>());
			}
			else
			{
				UUIText text5 = base.GetText(1);
				if (text5 != null)
				{
					text5.SetUIActive(false);
				}
			}
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(data.ShowBtnHelp);
			}
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(data.ShowIcon);
			}
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(data.ShowSprite);
			}
			UUISprite sprite2 = base.GetSprite(5);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(data.ShowScaleIcon);
			}
			if (data.ShowScaleIcon)
			{
				this.SetSpriteByPath(data.ScaleIconPath, base.GetSprite(5), true, null, null);
			}
		}

		// Token: 0x060301D7 RID: 197079 RVA: 0x00B273B7 File Offset: 0x00B255B7
		private void OnBtnClickCb()
		{
			IMapSubViewListItemData data = this._data;
			if (data == null)
			{
				return;
			}
			Action onBtnClickCb = data.OnBtnClickCb;
			if (onBtnClickCb == null)
			{
				return;
			}
			onBtnClickCb();
		}

		// Token: 0x04019ED3 RID: 106195
		[Nullable(2)]
		private IMapSubViewListItemData _data;

		// Token: 0x0200AA81 RID: 43649
		public static class EComponent
		{
			// Token: 0x04033E0D RID: 212493
			public const int TextLeft = 0;

			// Token: 0x04033E0E RID: 212494
			public const int TextRight = 1;

			// Token: 0x04033E0F RID: 212495
			public const int BtnHelp = 2;

			// Token: 0x04033E10 RID: 212496
			public const int Icon = 3;

			// Token: 0x04033E11 RID: 212497
			public const int Sprite = 4;

			// Token: 0x04033E12 RID: 212498
			public const int SpriteScaleIcon = 5;
		}
	}
}
