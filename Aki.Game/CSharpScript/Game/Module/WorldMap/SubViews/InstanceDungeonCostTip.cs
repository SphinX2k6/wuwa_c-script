using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020047C2 RID: 18370
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonCostTip : UiPanelBase
	{
		// Token: 0x060301E6 RID: 197094 RVA: 0x00B27620 File Offset: 0x00B25820
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

		// Token: 0x060301E7 RID: 197095 RVA: 0x00B27729 File Offset: 0x00B25929
		private void OnClickHelp()
		{
			Action onClickDelegate = this.OnClickDelegate;
			if (onClickDelegate == null)
			{
				return;
			}
			onClickDelegate();
		}

		// Token: 0x060301E8 RID: 197096 RVA: 0x00B2773B File Offset: 0x00B2593B
		public void SetClickHelpFunc(Action func)
		{
			this.OnClickDelegate = func;
		}

		// Token: 0x060301E9 RID: 197097 RVA: 0x00B27744 File Offset: 0x00B25944
		public void SetLeftText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x060301EA RID: 197098 RVA: 0x00B27759 File Offset: 0x00B25959
		public void SetLeftTextNew(string textStringId, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, args);
		}

		// Token: 0x060301EB RID: 197099 RVA: 0x00B2776E File Offset: 0x00B2596E
		public void SetRightText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x060301EC RID: 197100 RVA: 0x00B27784 File Offset: 0x00B25984
		public void SetHelpButtonVisible(bool visible)
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(visible);
		}

		// Token: 0x060301ED RID: 197101 RVA: 0x00B277B0 File Offset: 0x00B259B0
		public void SetIconVisible(bool visible)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(visible);
		}

		// Token: 0x060301EE RID: 197102 RVA: 0x00B277C4 File Offset: 0x00B259C4
		public void SetStarVisible(bool visible)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(visible);
		}

		// Token: 0x060301EF RID: 197103 RVA: 0x00B277D8 File Offset: 0x00B259D8
		public void SetIconByPath(string path)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetTextureByPath(path, base.GetTexture(3), null, null);
		}

		// Token: 0x060301F0 RID: 197104 RVA: 0x00B27810 File Offset: 0x00B25A10
		public void SetIconByItemId(int itemId)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x060301F1 RID: 197105 RVA: 0x00B27848 File Offset: 0x00B25A48
		public void SetSprStarByPath(string path)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			this.SetSpriteByPath(path, sprite, false, null, null);
		}

		// Token: 0x060301F2 RID: 197106 RVA: 0x00B2787C File Offset: 0x00B25A7C
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

		// Token: 0x04019ED7 RID: 106199
		[Nullable(2)]
		private Action OnClickDelegate;

		// Token: 0x0200AA83 RID: 43651
		[NullableContext(0)]
		public static class EInstanceDungeonCostTipChildCom
		{
			// Token: 0x04033E16 RID: 212502
			public const int TxtL = 0;

			// Token: 0x04033E17 RID: 212503
			public const int TxtR = 1;

			// Token: 0x04033E18 RID: 212504
			public const int BtnHelp = 2;

			// Token: 0x04033E19 RID: 212505
			public const int Icon = 3;

			// Token: 0x04033E1A RID: 212506
			public const int SprStar = 4;
		}
	}
}
