using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006249 RID: 25161
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipSetItemSliderData : MultiTemplateGridDataBase<RhythmShipSetData, RhythmShipSetItemSlider>
	{
		// Token: 0x0603F644 RID: 259652 RVA: 0x00F533FC File Offset: 0x00F515FC
		public RhythmShipSetItemSliderData(RhythmShipSetData data)
		{
			base.Data = data;
		}

		// Token: 0x0603F645 RID: 259653 RVA: 0x00F5340B File Offset: 0x00F5160B
		public override int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x0603F646 RID: 259654 RVA: 0x00F5340E File Offset: 0x00F5160E
		public override RhythmShipSetItemSlider CreateProxy()
		{
			return new RhythmShipSetItemSlider
			{
				OnSliderValueChangeCallBack = this.OnSliderValueChangeCallBack
			};
		}

		// Token: 0x040211B5 RID: 135605
		[Nullable(2)]
		public Action<int> OnSliderValueChangeCallBack;
	}
}
