using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005634 RID: 22068
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfoItem : GridProxyAbstract<IItemInfoData>
	{
		// Token: 0x060381EB RID: 229867 RVA: 0x00D4B333 File Offset: 0x00D49533
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x060381EC RID: 229868 RVA: 0x00D4B36C File Offset: 0x00D4956C
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
