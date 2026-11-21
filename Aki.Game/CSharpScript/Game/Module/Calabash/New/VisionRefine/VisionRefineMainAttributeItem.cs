using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Calabash.New.VisionRefine
{
	// Token: 0x02004BD7 RID: 19415
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VisionRefineMainAttributeItem : GridProxyAbstract<VisionRefineAttributeItemData>
	{
		// Token: 0x06030744 RID: 198468 RVA: 0x00D80CC8 File Offset: 0x00D7EEC8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture))
			};
		}

		// Token: 0x06030745 RID: 198469 RVA: 0x00D80D24 File Offset: 0x00D7EF24
		[NullableContext(1)]
		public override void Refresh(VisionRefineAttributeItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(data.NameTextId);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(data.NumberText ?? "", true);
			}
			base.SetTextureByPath(data.IconPath ?? "", base.GetTexture(2), null, null);
		}

		// Token: 0x0200A7EA RID: 42986
		private enum EComp
		{
			// Token: 0x04033DD6 RID: 212438
			Name,
			// Token: 0x04033DD7 RID: 212439
			Num,
			// Token: 0x04033DD8 RID: 212440
			Icon
		}
	}
}
