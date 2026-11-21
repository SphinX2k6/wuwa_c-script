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
	// Token: 0x02004C31 RID: 19505
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleIndomitableLevelView : UiViewBase
	{
		// Token: 0x06030B07 RID: 199431 RVA: 0x00D9480C File Offset: 0x00D92A0C
		[NullableContext(1)]
		public MoraleIndomitableLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030B08 RID: 199432 RVA: 0x00D94818 File Offset: 0x00D92A18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030B09 RID: 199433 RVA: 0x00D94860 File Offset: 0x00D92A60
		protected override void OnStart()
		{
			this.LevelText = base.GetArtText(0);
			if (this.LevelText != null)
			{
				int moraleIndomitableLevel = MoraleBattleModel.Instance.GetMoraleIndomitableLevel();
				this.LevelText.SetText(moraleIndomitableLevel.ToString());
			}
		}

		// Token: 0x06030B0A RID: 199434 RVA: 0x00D9489F File Offset: 0x00D92A9F
		protected override void OnBeforeShow()
		{
			this.DelayRefresh();
		}

		// Token: 0x06030B0B RID: 199435 RVA: 0x00D948A7 File Offset: 0x00D92AA7
		protected override void OnAfterShow()
		{
			this.DelayClose();
		}

		// Token: 0x06030B0C RID: 199436 RVA: 0x00D948AF File Offset: 0x00D92AAF
		protected override void OnBeforeDestroy()
		{
			this.ClearDelayTimer();
			this.ClearRefreshTimer();
		}

		// Token: 0x06030B0D RID: 199437 RVA: 0x00D948BD File Offset: 0x00D92ABD
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x06030B0E RID: 199438 RVA: 0x00D948DB File Offset: 0x00D92ADB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x06030B0F RID: 199439 RVA: 0x00D948F9 File Offset: 0x00D92AF9
		[NullableContext(1)]
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x06030B10 RID: 199440 RVA: 0x00D94901 File Offset: 0x00D92B01
		private void TryCloseMe()
		{
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06030B11 RID: 199441 RVA: 0x00D94912 File Offset: 0x00D92B12
		private void DelayClose()
		{
			this.ClearDelayTimer();
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.TryCloseMe();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x06030B12 RID: 199442 RVA: 0x00D94943 File Offset: 0x00D92B43
		private void DelayRefresh()
		{
			this.ClearRefreshTimer();
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RefreshTimer = null;
				EventSystem.Instance.Emit(EEventName.OnMoralePlayIndomitableLevelAnim);
			}, 1500f, null, null, true, 1f);
		}

		// Token: 0x06030B13 RID: 199443 RVA: 0x00D94974 File Offset: 0x00D92B74
		private void ClearDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x06030B14 RID: 199444 RVA: 0x00D94996 File Offset: 0x00D92B96
		private void ClearRefreshTimer()
		{
			if (this.RefreshTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x04019C4C RID: 105548
		private const float DELAY_CLOSE_TIME = 2000f;

		// Token: 0x04019C4D RID: 105549
		private const float DELAY_EVENT_TIME = 1500f;

		// Token: 0x04019C4E RID: 105550
		private UUIArtText LevelText;

		// Token: 0x04019C4F RID: 105551
		private TimerHandle DelayTimer;

		// Token: 0x04019C50 RID: 105552
		private TimerHandle RefreshTimer;

		// Token: 0x0200A867 RID: 43111
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403405F RID: 213087
			LevelText
		}
	}
}
