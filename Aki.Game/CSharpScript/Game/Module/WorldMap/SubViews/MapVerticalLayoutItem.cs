using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020036F0 RID: 14064
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapVerticalLayoutItem : GridProxyAbstract<IMapSubViewListItemData>
	{
		// Token: 0x060249A5 RID: 149925 RVA: 0x00A56F20 File Offset: 0x00A55120
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

		// Token: 0x060249A6 RID: 149926 RVA: 0x00A5704C File Offset: 0x00A5524C
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

		// Token: 0x060249A7 RID: 149927 RVA: 0x00A571C3 File Offset: 0x00A553C3
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

		// Token: 0x04014584 RID: 83332
		[Nullable(2)]
		private IMapSubViewListItemData _data;

		// Token: 0x02009434 RID: 37940
		public static class EComponent
		{
			// Token: 0x0402E596 RID: 189846
			public const int TextLeft = 0;

			// Token: 0x0402E597 RID: 189847
			public const int TextRight = 1;

			// Token: 0x0402E598 RID: 189848
			public const int BtnHelp = 2;

			// Token: 0x0402E599 RID: 189849
			public const int Icon = 3;

			// Token: 0x0402E59A RID: 189850
			public const int Sprite = 4;

			// Token: 0x0402E59B RID: 189851
			public const int SpriteScaleIcon = 5;
		}
	}
}
