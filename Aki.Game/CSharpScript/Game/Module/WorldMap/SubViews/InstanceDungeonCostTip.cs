using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020036F3 RID: 14067
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonCostTip : UiPanelBase
	{
		// Token: 0x060249B6 RID: 149942 RVA: 0x00A5742C File Offset: 0x00A5562C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelp));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060249B7 RID: 149943 RVA: 0x00A57535 File Offset: 0x00A55735
		private void OnClickHelp()
		{
			Action onClickDelegate = this.OnClickDelegate;
			if (onClickDelegate == null)
			{
				return;
			}
			onClickDelegate();
		}

		// Token: 0x060249B8 RID: 149944 RVA: 0x00A57547 File Offset: 0x00A55747
		public void SetClickHelpFunc(Action func)
		{
			this.OnClickDelegate = func;
		}

		// Token: 0x060249B9 RID: 149945 RVA: 0x00A57550 File Offset: 0x00A55750
		public void SetLeftText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x060249BA RID: 149946 RVA: 0x00A57565 File Offset: 0x00A55765
		public void SetLeftTextNew(string textStringId, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, args);
		}

		// Token: 0x060249BB RID: 149947 RVA: 0x00A5757A File Offset: 0x00A5577A
		public void SetRightText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x060249BC RID: 149948 RVA: 0x00A57590 File Offset: 0x00A55790
		public void SetHelpButtonVisible(bool visible)
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(visible);
		}

		// Token: 0x060249BD RID: 149949 RVA: 0x00A575BC File Offset: 0x00A557BC
		public void SetIconVisible(bool visible)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(visible);
		}

		// Token: 0x060249BE RID: 149950 RVA: 0x00A575D0 File Offset: 0x00A557D0
		public void SetStarVisible(bool visible)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(visible);
		}

		// Token: 0x060249BF RID: 149951 RVA: 0x00A575E4 File Offset: 0x00A557E4
		public void SetIconByPath(string path)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetTextureByPath(path, base.GetTexture(3), null, null);
		}

		// Token: 0x060249C0 RID: 149952 RVA: 0x00A5761C File Offset: 0x00A5581C
		public void SetIconByItemId(int itemId)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x060249C1 RID: 149953 RVA: 0x00A57654 File Offset: 0x00A55854
		public void SetSprStarByPath(string path)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			this.SetSpriteByPath(path, sprite, false, null, null);
		}

		// Token: 0x060249C2 RID: 149954 RVA: 0x00A57688 File Offset: 0x00A55888
		public void SetSprStarChangeColor(bool useChangeColor)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			UUIItem uuiitem = sprite;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x04014588 RID: 83336
		[Nullable(2)]
		private Action OnClickDelegate;

		// Token: 0x02009436 RID: 37942
		[NullableContext(0)]
		public static class EInstanceDungeonCostTipChildCom
		{
			// Token: 0x0402E59F RID: 189855
			public const int TxtL = 0;

			// Token: 0x0402E5A0 RID: 189856
			public const int TxtR = 1;

			// Token: 0x0402E5A1 RID: 189857
			public const int BtnHelp = 2;

			// Token: 0x0402E5A2 RID: 189858
			public const int Icon = 3;

			// Token: 0x0402E5A3 RID: 189859
			public const int SprStar = 4;
		}
	}
}
