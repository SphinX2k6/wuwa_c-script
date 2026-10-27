using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006254 RID: 25172
	internal class RhythmShipSettlementItem : GridProxyAbstract<ValueTuple<int, int>>
	{
		// Token: 0x0603F66B RID: 259691 RVA: 0x00F53CAE File Offset: 0x00F51EAE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603F66C RID: 259692 RVA: 0x00F53CE7 File Offset: 0x00F51EE7
		public override void Refresh(ValueTuple<int, int> data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(RhythmShipDefine.rhythmShipSettlementText[data.Item1], true);
			base.GetText(1).SetText(data.Item2.ToString(), true);
		}
	}
}
