using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051C5 RID: 20933
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipSetItemBtnData : MultiTemplateGridDataBase<RhythmShipSetData, RhythmShipSetItemBtn>
	{
		// Token: 0x060342FC RID: 213756 RVA: 0x00E9A1F6 File Offset: 0x00E983F6
		public RhythmShipSetItemBtnData(RhythmShipSetData data)
		{
			base.Data = data;
		}

		// Token: 0x060342FD RID: 213757 RVA: 0x00E9A205 File Offset: 0x00E98405
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060342FE RID: 213758 RVA: 0x00E9A208 File Offset: 0x00E98408
		public override RhythmShipSetItemBtn CreateProxy()
		{
			return new RhythmShipSetItemBtn();
		}
	}
}
