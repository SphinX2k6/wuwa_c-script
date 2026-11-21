using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02003764 RID: 14180
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupListItemPanel : UiPanelBase
	{
		// Token: 0x06024DD2 RID: 150994 RVA: 0x00A6B2AC File Offset: 0x00A694AC
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
		}

		// Token: 0x06024DD3 RID: 150995 RVA: 0x00A6B378 File Offset: 0x00A69578
		public void SetTxtLActive(bool active)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(active);
		}

		// Token: 0x06024DD4 RID: 150996 RVA: 0x00A6B38C File Offset: 0x00A6958C
		public void SetTxtLNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x06024DD5 RID: 150997 RVA: 0x00A6B3A5 File Offset: 0x00A695A5
		public void SetTxtRActive(bool active)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(active);
		}

		// Token: 0x06024DD6 RID: 150998 RVA: 0x00A6B3B9 File Offset: 0x00A695B9
		public void SetTxtRNewTxt(string newTxtId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), newTxtId, args);
		}

		// Token: 0x06024DD7 RID: 150999 RVA: 0x00A6B3CE File Offset: 0x00A695CE
		public void SetTxtRTxt(string txt)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x06024DD8 RID: 151000 RVA: 0x00A6B3E3 File Offset: 0x00A695E3
		public void SetTxtRTxtColor(string hexColor)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x06024DD9 RID: 151001 RVA: 0x00A6B3FC File Offset: 0x00A695FC
		public void SetBtnHelpA2Active(bool active)
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x06024DDA RID: 151002 RVA: 0x00A6B428 File Offset: 0x00A69628
		public void SetTexIconActive(bool active)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x06024DDB RID: 151003 RVA: 0x00A6B43C File Offset: 0x00A6963C
		public void SetTexIcon(string assetName)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(assetName);
			base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
		}

		// Token: 0x06024DDC RID: 151004 RVA: 0x00A6B46D File Offset: 0x00A6966D
		public void SetIconActive(bool active)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(active);
		}

		// Token: 0x06024DDD RID: 151005 RVA: 0x00A6B484 File Offset: 0x00A69684
		public void SetIconSprite(string assetName)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(assetName);
			this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
		}

		// Token: 0x020094BE RID: 38078
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E754 RID: 190292
			public const int TxtL = 0;

			// Token: 0x0402E755 RID: 190293
			public const int TxtR = 1;

			// Token: 0x0402E756 RID: 190294
			public const int BtnHelpA2 = 2;

			// Token: 0x0402E757 RID: 190295
			public const int TexIcon = 3;

			// Token: 0x0402E758 RID: 190296
			public const int Icon = 4;
		}
	}
}
