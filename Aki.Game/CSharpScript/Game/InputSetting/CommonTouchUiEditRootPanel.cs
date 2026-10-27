using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007012 RID: 28690
	public class CommonTouchUiEditRootPanel : UiPanelBase
	{
		// Token: 0x06045D11 RID: 285969 RVA: 0x0115CDD1 File Offset: 0x0115AFD1
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x06045D12 RID: 285970 RVA: 0x0115CE0A File Offset: 0x0115B00A
		[NullableContext(2)]
		public UUIItem GetItemAttachRoot()
		{
			return base.GetItem(0);
		}

		// Token: 0x06045D13 RID: 285971 RVA: 0x0115CE14 File Offset: 0x0115B014
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

		// Token: 0x0200CE0C RID: 52748
		private static class EComponent
		{
			// Token: 0x0403E114 RID: 254228
			public const int ItemAttachRoot = 0;

			// Token: 0x0403E115 RID: 254229
			public const int TexBg = 1;
		}
	}
}
