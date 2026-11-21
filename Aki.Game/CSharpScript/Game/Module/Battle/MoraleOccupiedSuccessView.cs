using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C34 RID: 19508
	public class MoraleOccupiedSuccessView : UiViewBase
	{
		// Token: 0x06030B2D RID: 199469 RVA: 0x00D95076 File Offset: 0x00D93276
		[NullableContext(1)]
		public MoraleOccupiedSuccessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030B2E RID: 199470 RVA: 0x00D95080 File Offset: 0x00D93280
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030B2F RID: 199471 RVA: 0x00D950EC File Offset: 0x00D932EC
		protected override void OnStart()
		{
			this.LevelText = base.GetArtText(0);
			if (this.LevelText != null)
			{
				int moraleIndomitableLevel = MoraleBattleModel.Instance.GetMoraleIndomitableLevel();
				this.LevelText.SetText(moraleIndomitableLevel.ToString());
			}
		}

		// Token: 0x06030B30 RID: 199472 RVA: 0x00D9512B File Offset: 0x00D9332B
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06030B31 RID: 199473 RVA: 0x00D9512D File Offset: 0x00D9332D
		protected override void OnAfterShow()
		{
			this.DelayClose();
		}

		// Token: 0x06030B32 RID: 199474 RVA: 0x00D95135 File Offset: 0x00D93335
		protected override void OnBeforeDestroy()
		{
			this.ClearDelayTimer();
		}

		// Token: 0x06030B33 RID: 199475 RVA: 0x00D9513D File Offset: 0x00D9333D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x06030B34 RID: 199476 RVA: 0x00D9515B File Offset: 0x00D9335B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x06030B35 RID: 199477 RVA: 0x00D95179 File Offset: 0x00D93379
		[NullableContext(1)]
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x06030B36 RID: 199478 RVA: 0x00D95181 File Offset: 0x00D93381
		private void TryCloseMe()
		{
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06030B37 RID: 199479 RVA: 0x00D95192 File Offset: 0x00D93392
		private void DelayClose()
		{
			this.ClearDelayTimer();
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.TryCloseMe();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x06030B38 RID: 199480 RVA: 0x00D951C3 File Offset: 0x00D933C3
		private void ClearDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x04019C69 RID: 105577
		private const float DELAY_CLOSE_TIME = 2000f;

		// Token: 0x04019C6A RID: 105578
		[Nullable(2)]
		private UUIArtText LevelText;

		// Token: 0x04019C6B RID: 105579
		[Nullable(2)]
		private TimerHandle DelayTimer;

		// Token: 0x0200A86D RID: 43117
		private enum EChildType
		{
			// Token: 0x04034075 RID: 213109
			LevelText,
			// Token: 0x04034076 RID: 213110
			TitleText
		}
	}
}
