using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02004833 RID: 18483
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupListItemPanel : UiPanelBase
	{
		// Token: 0x06030602 RID: 198146 RVA: 0x00B3B1E0 File Offset: 0x00B393E0
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

		// Token: 0x06030603 RID: 198147 RVA: 0x00B3B2AC File Offset: 0x00B394AC
		public void SetTxtLActive(bool active)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(active);
		}

		// Token: 0x06030604 RID: 198148 RVA: 0x00B3B2C0 File Offset: 0x00B394C0
		public void SetTxtLNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x06030605 RID: 198149 RVA: 0x00B3B2D9 File Offset: 0x00B394D9
		public void SetTxtRActive(bool active)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(active);
		}

		// Token: 0x06030606 RID: 198150 RVA: 0x00B3B2ED File Offset: 0x00B394ED
		public void SetTxtRNewTxt(string newTxtId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), newTxtId, args);
		}

		// Token: 0x06030607 RID: 198151 RVA: 0x00B3B302 File Offset: 0x00B39502
		public void SetTxtRTxt(string txt)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x06030608 RID: 198152 RVA: 0x00B3B317 File Offset: 0x00B39517
		public void SetTxtRTxtColor(string hexColor)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x06030609 RID: 198153 RVA: 0x00B3B330 File Offset: 0x00B39530
		public void SetBtnHelpA2Active(bool active)
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x0603060A RID: 198154 RVA: 0x00B3B35C File Offset: 0x00B3955C
		public void SetTexIconActive(bool active)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x0603060B RID: 198155 RVA: 0x00B3B370 File Offset: 0x00B39570
		public void SetTexIcon(string assetName)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(assetName);
			base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
		}

		// Token: 0x0603060C RID: 198156 RVA: 0x00B3B3A1 File Offset: 0x00B395A1
		public void SetIconActive(bool active)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(active);
		}

		// Token: 0x0603060D RID: 198157 RVA: 0x00B3B3B8 File Offset: 0x00B395B8
		public void SetIconSprite(string assetName)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(assetName);
			this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
		}

		// Token: 0x0200AB0F RID: 43791
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033FD4 RID: 212948
			public const int TxtL = 0;

			// Token: 0x04033FD5 RID: 212949
			public const int TxtR = 1;

			// Token: 0x04033FD6 RID: 212950
			public const int BtnHelpA2 = 2;

			// Token: 0x04033FD7 RID: 212951
			public const int TexIcon = 3;

			// Token: 0x04033FD8 RID: 212952
			public const int Icon = 4;
		}
	}
}
