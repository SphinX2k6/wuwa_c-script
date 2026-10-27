using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D4E RID: 23886
	[NullableContext(1)]
	[Nullable(0)]
	public class ProgressControlHeadState : HeadStateViewBase
	{
		// Token: 0x0603CA51 RID: 248401 RVA: 0x00E8DF3C File Offset: 0x00E8C13C
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

		// Token: 0x0603CA52 RID: 248402 RVA: 0x00E8DFA5 File Offset: 0x00E8C1A5
		protected override string GetResourceId()
		{
			return "UiItem_BarInteractive";
		}

		// Token: 0x0603CA53 RID: 248403 RVA: 0x00E8DFAC File Offset: 0x00E8C1AC
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

		// Token: 0x0603CA54 RID: 248404 RVA: 0x00E8E026 File Offset: 0x00E8C226
		protected override void BindCallback()
		{
			base.BindCallback();
			this.HeadStateData.BindOnProgressControlDataChange(new Action<SceneItemProgressControlComponent.TProgressData>(this.OnProgressControlDataChange));
		}

		// Token: 0x0603CA55 RID: 248405 RVA: 0x00E8E048 File Offset: 0x00E8C248
		public void OnProgressControlDataChange(SceneItemProgressControlComponent.TProgressData progressData)
		{
			EProgressBarControlType progressCtrlType = progressData.ProgressCtrlType;
			if (progressCtrlType <= EProgressBarControlType.ChargingDevice)
			{
				this.SetProgress(progressData.CurrentValue / progressData.MaxValue);
			}
		}

		// Token: 0x0603CA56 RID: 248406 RVA: 0x00E8E074 File Offset: 0x00E8C274
		private void SetProgress(float progress)
		{
			float width = MathUtils.Instance.Clamp(progress, 0f, 1f) * this.BarFullWidth;
			base.GetSprite(0).SetWidth(width);
			int num = (int)Math.Round((double)MathUtils.Instance.RangeClamp(progress, 0f, 1f, 0f, 100f));
			base.GetText(1).SetText(num.ToString() + "%", true);
		}

		// Token: 0x0401F965 RID: 129381
		private float BarFullWidth;

		// Token: 0x0200BFF1 RID: 49137
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039ED1 RID: 237265
			BarProgress,
			// Token: 0x04039ED2 RID: 237266
			TxtProgress
		}
	}
}
