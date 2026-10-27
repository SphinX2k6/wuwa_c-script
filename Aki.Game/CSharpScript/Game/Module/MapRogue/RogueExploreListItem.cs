using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055EB RID: 21995
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueExploreListItem : GridProxyAbstract<IExploreData>
	{
		// Token: 0x0603804A RID: 229450 RVA: 0x00D449F0 File Offset: 0x00D42BF0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x0603804B RID: 229451 RVA: 0x00D44A60 File Offset: 0x00D42C60
		public override void Refresh(IExploreData data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(1);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = gridIndex % 2 != 0;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.TitleId, Array.Empty<object>());
			base.GetText(3).SetText(data.ValueTxt, true);
		}
	}
}
