using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Calabash.New.VisionRefine
{
	// Token: 0x02005BF7 RID: 23543
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VisionRefineMainAttributeItem : GridProxyAbstract<VisionRefineAttributeItemData>
	{
		// Token: 0x0603B7F9 RID: 243705 RVA: 0x00E309C4 File Offset: 0x00E2EBC4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture))
			};
		}

		// Token: 0x0603B7FA RID: 243706 RVA: 0x00E30A20 File Offset: 0x00E2EC20
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

		// Token: 0x0200BDE2 RID: 48610
		private enum EComp
		{
			// Token: 0x04039413 RID: 234515
			Name,
			// Token: 0x04039414 RID: 234516
			Num,
			// Token: 0x04039415 RID: 234517
			Icon
		}
	}
}
