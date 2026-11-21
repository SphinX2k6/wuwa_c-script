using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045B3 RID: 17843
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapRogueFetterStarLvItem : GridProxyAbstract<IFetterStarLvData>
	{
		// Token: 0x0602CF15 RID: 184085 RVA: 0x00C91958 File Offset: 0x00C8FB58
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0602CF16 RID: 184086 RVA: 0x00C91994 File Offset: 0x00C8FB94
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

		// Token: 0x04018147 RID: 98631
		protected IFetterStarLvData Data;
	}
}
