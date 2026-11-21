using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051C8 RID: 20936
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipSetItemSlider : SyncGridProxyAbstract<RhythmShipSetData>
	{
		// Token: 0x06034308 RID: 213768 RVA: 0x00E9A380 File Offset: 0x00E98580
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06034309 RID: 213769 RVA: 0x00E9A3DC File Offset: 0x00E985DC
		protected override void OnStart()
		{
			UUISliderComponent slider = base.GetSlider(1);
			slider.SetMinValue(-150f, true, true);
			slider.SetMaxValue(150f, true, true);
			slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
			slider.SetValue((float)RhythmShipModel.Instance.LocalCalibrationValue, true);
			base.GetText(2).SetText(RhythmShipModel.Instance.LocalCalibrationValue.ToString(), true);
		}

		// Token: 0x0603430A RID: 213770 RVA: 0x00E9A450 File Offset: 0x00E98650
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

		// Token: 0x0603430B RID: 213771 RVA: 0x00E9A48C File Offset: 0x00E9868C
		public override void Refresh(RhythmShipSetData data)
		{
			base.GetSlider(1).SetValue((float)RhythmShipModel.Instance.LocalCalibrationValue, true);
			base.GetText(2).SetText(RhythmShipModel.Instance.LocalCalibrationValue.ToString(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Text, Array.Empty<object>());
		}

		// Token: 0x0401BAE5 RID: 113381
		[Nullable(2)]
		public Action<int> OnSliderValueChangeCallBack;
	}
}
