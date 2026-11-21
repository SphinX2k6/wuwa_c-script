using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200460A RID: 17930
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfoItem : GridProxyAbstract<IItemInfoData>
	{
		// Token: 0x0602D0E9 RID: 184553 RVA: 0x00C9907B File Offset: 0x00C9727B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602D0EA RID: 184554 RVA: 0x00C990B4 File Offset: 0x00C972B4
		public override void Refresh(IItemInfoData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			UUIText text2 = base.GetText(1);
			UUIItem uuiitem = text2;
			bool valueChangeColor = data.ValueChangeColor;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(valueChangeColor, fcolor);
			LguiUtil.Instance.SetLocalTextNew(text, data.TitleId, Array.Empty<object>());
			text2.SetText(data.Value, true);
		}
	}
}
