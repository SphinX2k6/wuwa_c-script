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
	// Token: 0x02005C51 RID: 23633
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleIndomitableLevelView : UiViewBase
	{
		// Token: 0x0603BBBC RID: 244668 RVA: 0x00E44440 File Offset: 0x00E42640
		[NullableContext(1)]
		public MoraleIndomitableLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BBBD RID: 244669 RVA: 0x00E4444C File Offset: 0x00E4264C
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

		// Token: 0x0603BBBE RID: 244670 RVA: 0x00E44494 File Offset: 0x00E42694
		protected override void OnStart()
		{
			this.LevelText = base.GetArtText(0);
			if (this.LevelText != null)
			{
				int moraleIndomitableLevel = MoraleBattleModel.Instance.GetMoraleIndomitableLevel();
				this.LevelText.SetText(moraleIndomitableLevel.ToString());
			}
		}

		// Token: 0x0603BBBF RID: 244671 RVA: 0x00E444D3 File Offset: 0x00E426D3
		protected override void OnBeforeShow()
		{
			this.DelayRefresh();
		}

		// Token: 0x0603BBC0 RID: 244672 RVA: 0x00E444DB File Offset: 0x00E426DB
		protected override void OnAfterShow()
		{
			this.DelayClose();
		}

		// Token: 0x0603BBC1 RID: 244673 RVA: 0x00E444E3 File Offset: 0x00E426E3
		protected override void OnBeforeDestroy()
		{
			this.ClearDelayTimer();
			this.ClearRefreshTimer();
		}

		// Token: 0x0603BBC2 RID: 244674 RVA: 0x00E444F1 File Offset: 0x00E426F1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x0603BBC3 RID: 244675 RVA: 0x00E4450F File Offset: 0x00E4270F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x0603BBC4 RID: 244676 RVA: 0x00E4452D File Offset: 0x00E4272D
		[NullableContext(1)]
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x0603BBC5 RID: 244677 RVA: 0x00E44535 File Offset: 0x00E42735
		private void TryCloseMe()
		{
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603BBC6 RID: 244678 RVA: 0x00E44546 File Offset: 0x00E42746
		private void DelayClose()
		{
			this.ClearDelayTimer();
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.TryCloseMe();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0603BBC7 RID: 244679 RVA: 0x00E44577 File Offset: 0x00E42777
		private void DelayRefresh()
		{
			this.ClearRefreshTimer();
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RefreshTimer = null;
				EventSystem.Instance.Emit(EEventName.OnMoralePlayIndomitableLevelAnim);
			}, 1500f, null, null, true, 1f);
		}

		// Token: 0x0603BBC8 RID: 244680 RVA: 0x00E445A8 File Offset: 0x00E427A8
		private void ClearDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x0603BBC9 RID: 244681 RVA: 0x00E445CA File Offset: 0x00E427CA
		private void ClearRefreshTimer()
		{
			if (this.RefreshTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x0401F19B RID: 127387
		private const float DELAY_CLOSE_TIME = 2000f;

		// Token: 0x0401F19C RID: 127388
		private const float DELAY_EVENT_TIME = 1500f;

		// Token: 0x0401F19D RID: 127389
		private UUIArtText LevelText;

		// Token: 0x0401F19E RID: 127390
		private TimerHandle DelayTimer;

		// Token: 0x0401F19F RID: 127391
		private TimerHandle RefreshTimer;

		// Token: 0x0200BE61 RID: 48737
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403969E RID: 235166
			LevelText
		}
	}
}
