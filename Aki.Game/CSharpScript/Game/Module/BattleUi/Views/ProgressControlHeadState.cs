using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D30 RID: 19760
	[NullableContext(1)]
	[Nullable(0)]
	public class ProgressControlHeadState : HeadStateViewBase
	{
		// Token: 0x060319AA RID: 203178 RVA: 0x00DDE6F0 File Offset: 0x00DDC8F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060319AB RID: 203179 RVA: 0x00DDE759 File Offset: 0x00DDC959
		protected override string GetResourceId()
		{
			return "UiItem_BarInteractive";
		}

		// Token: 0x060319AC RID: 203180 RVA: 0x00DDE760 File Offset: 0x00DDC960
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			UUISprite sprite = base.GetSprite(0);
			UUIText text = base.GetText(1);
			float stretchLeft = sprite.GetStretchLeft();
			float width = sprite.GetParentAsUIItem().GetWidth();
			this.BarFullWidth = width - 2f * stretchLeft;
			sprite.SetUIActive(true);
			text.SetUIActive(true);
			SceneItemProgressControlComponent.TProgressData progressControlData = headStateData.GetProgressControlData();
			EProgressBarControlType progressCtrlType = progressControlData.ProgressCtrlType;
			if (progressCtrlType <= EProgressBarControlType.ChargingDevice)
			{
				this.SetProgress(progressControlData.CurrentValue / progressControlData.MaxValue);
			}
		}

		// Token: 0x060319AD RID: 203181 RVA: 0x00DDE7DA File Offset: 0x00DDC9DA
		protected override void BindCallback()
		{
			base.BindCallback();
			this.HeadStateData.BindOnProgressControlDataChange(new Action<SceneItemProgressControlComponent.TProgressData>(this.OnProgressControlDataChange));
		}

		// Token: 0x060319AE RID: 203182 RVA: 0x00DDE7FC File Offset: 0x00DDC9FC
		public void OnProgressControlDataChange(SceneItemProgressControlComponent.TProgressData progressData)
		{
			EProgressBarControlType progressCtrlType = progressData.ProgressCtrlType;
			if (progressCtrlType <= EProgressBarControlType.ChargingDevice)
			{
				this.SetProgress(progressData.CurrentValue / progressData.MaxValue);
			}
		}

		// Token: 0x060319AF RID: 203183 RVA: 0x00DDE828 File Offset: 0x00DDCA28
		private void SetProgress(float progress)
		{
			float width = MathUtils.Instance.Clamp(progress, 0f, 1f) * this.BarFullWidth;
			base.GetSprite(0).SetWidth(width);
			int num = (int)Math.Round((double)MathUtils.Instance.RangeClamp(progress, 0f, 1f, 0f, 100f));
			base.GetText(1).SetText(num.ToString() + "%", true);
		}

		// Token: 0x0401A41E RID: 107550
		private float BarFullWidth;

		// Token: 0x0200A9F7 RID: 43511
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034893 RID: 215187
			BarProgress,
			// Token: 0x04034894 RID: 215188
			TxtProgress
		}
	}
}
