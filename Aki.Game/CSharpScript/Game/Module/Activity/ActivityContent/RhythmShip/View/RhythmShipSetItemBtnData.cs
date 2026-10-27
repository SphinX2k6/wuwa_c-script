using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006247 RID: 25159
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipSetItemBtnData : MultiTemplateGridDataBase<RhythmShipSetData, RhythmShipSetItemBtn>
	{
		// Token: 0x0603F63B RID: 259643 RVA: 0x00F5329A File Offset: 0x00F5149A
		public RhythmShipSetItemBtnData(RhythmShipSetData data)
		{
			base.Data = data;
		}

		// Token: 0x0603F63C RID: 259644 RVA: 0x00F532A9 File Offset: 0x00F514A9
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603F63D RID: 259645 RVA: 0x00F532AC File Offset: 0x00F514AC
		public override RhythmShipSetItemBtn CreateProxy()
		{
			return new RhythmShipSetItemBtn();
		}
	}
}
