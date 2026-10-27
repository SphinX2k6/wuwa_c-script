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
	// Token: 0x02005C54 RID: 23636
	public class MoraleOccupiedSuccessView : UiViewBase
	{
		// Token: 0x0603BBE2 RID: 244706 RVA: 0x00E44CAA File Offset: 0x00E42EAA
		[NullableContext(1)]
		public MoraleOccupiedSuccessView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BBE3 RID: 244707 RVA: 0x00E44CB4 File Offset: 0x00E42EB4
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

		// Token: 0x0603BBE4 RID: 244708 RVA: 0x00E44D20 File Offset: 0x00E42F20
		protected override void OnStart()
		{
			this.LevelText = base.GetArtText(0);
			if (this.LevelText != null)
			{
				int moraleIndomitableLevel = MoraleBattleModel.Instance.GetMoraleIndomitableLevel();
				this.LevelText.SetText(moraleIndomitableLevel.ToString());
			}
		}

		// Token: 0x0603BBE5 RID: 244709 RVA: 0x00E44D5F File Offset: 0x00E42F5F
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0603BBE6 RID: 244710 RVA: 0x00E44D61 File Offset: 0x00E42F61
		protected override void OnAfterShow()
		{
			this.DelayClose();
		}

		// Token: 0x0603BBE7 RID: 244711 RVA: 0x00E44D69 File Offset: 0x00E42F69
		protected override void OnBeforeDestroy()
		{
			this.ClearDelayTimer();
		}

		// Token: 0x0603BBE8 RID: 244712 RVA: 0x00E44D71 File Offset: 0x00E42F71
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x0603BBE9 RID: 244713 RVA: 0x00E44D8F File Offset: 0x00E42F8F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
		}

		// Token: 0x0603BBEA RID: 244714 RVA: 0x00E44DAD File Offset: 0x00E42FAD
		[NullableContext(1)]
		private void OnSequenceNetworkStart(PlotInfo plotInfo)
		{
			this.TryCloseMe();
		}

		// Token: 0x0603BBEB RID: 244715 RVA: 0x00E44DB5 File Offset: 0x00E42FB5
		private void TryCloseMe()
		{
			if (!base.IsHideOrHiding)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603BBEC RID: 244716 RVA: 0x00E44DC6 File Offset: 0x00E42FC6
		private void DelayClose()
		{
			this.ClearDelayTimer();
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.TryCloseMe();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0603BBED RID: 244717 RVA: 0x00E44DF7 File Offset: 0x00E42FF7
		private void ClearDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x0401F1B8 RID: 127416
		private const float DELAY_CLOSE_TIME = 2000f;

		// Token: 0x0401F1B9 RID: 127417
		[Nullable(2)]
		private UUIArtText LevelText;

		// Token: 0x0401F1BA RID: 127418
		[Nullable(2)]
		private TimerHandle DelayTimer;

		// Token: 0x0200BE67 RID: 48743
		private enum EChildType
		{
			// Token: 0x040396B4 RID: 235188
			LevelText,
			// Token: 0x040396B5 RID: 235189
			TitleText
		}
	}
}
