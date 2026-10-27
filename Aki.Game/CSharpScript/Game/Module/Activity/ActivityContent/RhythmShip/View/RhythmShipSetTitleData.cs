using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006245 RID: 25157
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipSetTitleData : MultiTemplateGridDataBase<RhythmShipSetData, RhythmShipSetTitle>
	{
		// Token: 0x0603F634 RID: 259636 RVA: 0x00F531B0 File Offset: 0x00F513B0
		public RhythmShipSetTitleData(RhythmShipSetData data)
		{
			base.Data = data;
		}

		// Token: 0x0603F635 RID: 259637 RVA: 0x00F531BF File Offset: 0x00F513BF
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603F636 RID: 259638 RVA: 0x00F531C2 File Offset: 0x00F513C2
		public override RhythmShipSetTitle CreateProxy()
		{
			return new RhythmShipSetTitle();
		}
	}
}
