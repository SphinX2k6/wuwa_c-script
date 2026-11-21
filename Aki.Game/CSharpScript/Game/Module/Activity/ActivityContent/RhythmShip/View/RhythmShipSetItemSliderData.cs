using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051C7 RID: 20935
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipSetItemSliderData : MultiTemplateGridDataBase<RhythmShipSetData, RhythmShipSetItemSlider>
	{
		// Token: 0x06034305 RID: 213765 RVA: 0x00E9A358 File Offset: 0x00E98558
		public RhythmShipSetItemSliderData(RhythmShipSetData data)
		{
			base.Data = data;
		}

		// Token: 0x06034306 RID: 213766 RVA: 0x00E9A367 File Offset: 0x00E98567
		public override int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x06034307 RID: 213767 RVA: 0x00E9A36A File Offset: 0x00E9856A
		public override RhythmShipSetItemSlider CreateProxy()
		{
			return new RhythmShipSetItemSlider
			{
				OnSliderValueChangeCallBack = this.OnSliderValueChangeCallBack
			};
		}

		// Token: 0x0401BAE4 RID: 113380
		[Nullable(2)]
		public Action<int> OnSliderValueChangeCallBack;
	}
}
