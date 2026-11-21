using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006193 RID: 24979
	public class CommonTouchUiEditRootPanel : UiPanelBase
	{
		// Token: 0x0603BEC7 RID: 245447 RVA: 0x011071DD File Offset: 0x011053DD
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x0603BEC8 RID: 245448 RVA: 0x01107216 File Offset: 0x01105416
		[NullableContext(2)]
		public UUIItem GetItemAttachRoot()
		{
			return base.GetItem(0);
		}

		// Token: 0x0603BEC9 RID: 245449 RVA: 0x01107220 File Offset: 0x01105420
		[NullableContext(1)]
		public void SetBackgroundTexture(string texturePath)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture == null || string.IsNullOrEmpty(texturePath))
			{
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				return;
			}
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetTextureByPath(texturePath, texture, null, null);
		}

		// Token: 0x0200B9FE RID: 47614
		private static class EComponent
		{
			// Token: 0x04039542 RID: 234818
			public const int ItemAttachRoot = 0;

			// Token: 0x04039543 RID: 234819
			public const int TexBg = 1;
		}
	}
}
