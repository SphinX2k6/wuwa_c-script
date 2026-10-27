using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200624A RID: 25162
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipSetItemSlider : SyncGridProxyAbstract<RhythmShipSetData>
	{
		// Token: 0x0603F647 RID: 259655 RVA: 0x00F53424 File Offset: 0x00F51624
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0603F648 RID: 259656 RVA: 0x00F53480 File Offset: 0x00F51680
		protected override void OnStart()
		{
			UUISliderComponent slider = base.GetSlider(1);
			slider.SetMinValue(-150f, true, true);
			slider.SetMaxValue(150f, true, true);
			slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
			slider.SetValue((float)RhythmShipModel.Instance.LocalCalibrationValue, true);
			base.GetText(2).SetText(RhythmShipModel.Instance.LocalCalibrationValue.ToString(), true);
		}

		// Token: 0x0603F649 RID: 259657 RVA: 0x00F534F4 File Offset: 0x00F516F4
		private void OnSliderValueChange(float value)
		{
			int obj = (int)Math.Floor((double)value);
			Action<int> onSliderValueChangeCallBack = this.OnSliderValueChangeCallBack;
			if (onSliderValueChangeCallBack != null)
			{
				onSliderValueChangeCallBack(obj);
			}
			base.GetText(2).SetText(obj.ToString(), true);
		}

		// Token: 0x0603F64A RID: 259658 RVA: 0x00F53530 File Offset: 0x00F51730
		public override void Refresh(RhythmShipSetData data)
		{
			base.GetSlider(1).SetValue((float)RhythmShipModel.Instance.LocalCalibrationValue, true);
			base.GetText(2).SetText(RhythmShipModel.Instance.LocalCalibrationValue.ToString(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Text, Array.Empty<object>());
		}

		// Token: 0x040211B6 RID: 135606
		[Nullable(2)]
		public Action<int> OnSliderValueChangeCallBack;
	}
}
