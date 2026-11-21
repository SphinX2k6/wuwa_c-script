using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200438B RID: 17291
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleBuffAddItem : GridProxyAbstract<IMoraleBuffAddItemData>
	{
		// Token: 0x0602BAE1 RID: 178913 RVA: 0x00C42A4C File Offset: 0x00C40C4C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602BAE2 RID: 178914 RVA: 0x00C42AA6 File Offset: 0x00C40CA6
		public override void Refresh(IMoraleBuffAddItemData data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x0602BAE3 RID: 178915 RVA: 0x00C42AB0 File Offset: 0x00C40CB0
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

		// Token: 0x040178EE RID: 96494
		public IMoraleBuffAddItemData ItemData;

		// Token: 0x0200A070 RID: 41072
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031D82 RID: 204162
			public const int TextureIcon = 0;

			// Token: 0x04031D83 RID: 204163
			public const int TxtName = 1;

			// Token: 0x04031D84 RID: 204164
			public const int TxtValue = 2;
		}
	}
}
