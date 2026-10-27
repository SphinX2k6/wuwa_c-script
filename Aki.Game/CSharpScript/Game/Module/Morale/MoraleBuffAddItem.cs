using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053A8 RID: 21416
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleBuffAddItem : GridProxyAbstract<IMoraleBuffAddItemData>
	{
		// Token: 0x06036B9B RID: 224155 RVA: 0x00CF39A4 File Offset: 0x00CF1BA4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06036B9C RID: 224156 RVA: 0x00CF39FE File Offset: 0x00CF1BFE
		public override void Refresh(IMoraleBuffAddItemData data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x06036B9D RID: 224157 RVA: 0x00CF3A08 File Offset: 0x00CF1C08
		public void Refresh(IMoraleBuffAddItemData data)
		{
			this.ItemData = data;
			UUITexture texture = base.GetTexture(0);
			base.SetTextureByPath(data.IconPath, texture, null, null);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(data.NameKey);
			}
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(data.Value, true);
		}

		// Token: 0x0401CE56 RID: 118358
		public IMoraleBuffAddItemData ItemData;

		// Token: 0x0200B638 RID: 46648
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403732D RID: 226093
			public const int TextureIcon = 0;

			// Token: 0x0403732E RID: 226094
			public const int TxtName = 1;

			// Token: 0x0403732F RID: 226095
			public const int TxtValue = 2;
		}
	}
}
