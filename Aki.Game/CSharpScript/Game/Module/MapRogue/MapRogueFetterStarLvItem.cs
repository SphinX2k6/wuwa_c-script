using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055DD RID: 21981
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapRogueFetterStarLvItem : GridProxyAbstract<IFetterStarLvData>
	{
		// Token: 0x06038017 RID: 229399 RVA: 0x00D43C10 File Offset: 0x00D41E10
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x06038018 RID: 229400 RVA: 0x00D43C4C File Offset: 0x00D41E4C
		public override void Refresh(IFetterStarLvData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIText text = base.GetText(0);
			text.SetText(data.StageStarLv.ToString(), true);
			UUIItem uuiitem = text;
			bool bUseChangeColor = data.CurrentLv == data.StageLv;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.GetSprite(1).SetUIActive(data.StageLv < data.MaxLv);
		}

		// Token: 0x0401D6BC RID: 120508
		protected IFetterStarLvData Data;
	}
}
