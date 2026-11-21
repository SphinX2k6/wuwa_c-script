using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051C3 RID: 20931
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipSetTitleData : MultiTemplateGridDataBase<RhythmShipSetData, RhythmShipSetTitle>
	{
		// Token: 0x060342F5 RID: 213749 RVA: 0x00E9A10C File Offset: 0x00E9830C
		public RhythmShipSetTitleData(RhythmShipSetData data)
		{
			base.Data = data;
		}

		// Token: 0x060342F6 RID: 213750 RVA: 0x00E9A11B File Offset: 0x00E9831B
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x060342F7 RID: 213751 RVA: 0x00E9A11E File Offset: 0x00E9831E
		public override RhythmShipSetTitle CreateProxy()
		{
			return new RhythmShipSetTitle();
		}
	}
}
