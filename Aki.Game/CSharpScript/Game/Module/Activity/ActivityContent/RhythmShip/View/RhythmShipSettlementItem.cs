using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051D2 RID: 20946
	internal class RhythmShipSettlementItem : GridProxyAbstract<ValueTuple<int, int>>
	{
		// Token: 0x0603432C RID: 213804 RVA: 0x00E9AC0A File Offset: 0x00E98E0A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603432D RID: 213805 RVA: 0x00E9AC43 File Offset: 0x00E98E43
		public override void Refresh(ValueTuple<int, int> data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(RhythmShipDefine.rhythmShipSettlementText[data.Item1], true);
			base.GetText(1).SetText(data.Item2.ToString(), true);
		}
	}
}
