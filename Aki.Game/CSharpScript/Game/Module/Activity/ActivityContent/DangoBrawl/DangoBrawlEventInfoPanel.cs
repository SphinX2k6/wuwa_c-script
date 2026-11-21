using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005764 RID: 22372
	public class DangoBrawlEventInfoPanel : UiPanelBase
	{
		// Token: 0x060372DF RID: 226015 RVA: 0x00F6748C File Offset: 0x00F6568C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClickEventInfo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060372E0 RID: 226016 RVA: 0x00F67574 File Offset: 0x00F65774
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlEventInfoPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlEventInfoPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060372E1 RID: 226017 RVA: 0x00F675B8 File Offset: 0x00F657B8
		protected override void OnBeforeDestroy()
		{
			this.CancelHoverTipsHideTimer();
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointEnterCallBack.Unbind();
			}
			if (button != null)
			{
				button.OnPointExitCallBack.Unbind();
			}
			if (this.EventTips != null)
			{
				this.EventTips.OnTipsClosed = null;
			}
		}

		// Token: 0x060372E2 RID: 226018 RVA: 0x00F67608 File Offset: 0x00F65808
		[NullableContext(1)]
		public UniTask Refresh(IReadOnlyList<int> eventIds)
		{
			DangoBrawlEventInfoPanel.<Refresh>d__8 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.eventIds = eventIds;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<DangoBrawlEventInfoPanel.<Refresh>d__8>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x060372E3 RID: 226019 RVA: 0x00F67654 File Offset: 0x00F65854
		public FVector? GetLatestEventIconAbsPos(int selectedEventId, out int iconIndex)
		{
			iconIndex = -1;
			if (this.ShowingEventIds.Count != 0)
			{
				List<int> showingEventIds = this.ShowingEventIds;
				if (showingEventIds[showingEventIds.Count - 1] == selectedEventId)
				{
					iconIndex = this.ShowingEventIds.Count - 1;
					int num = iconIndex;
					UUITexture uuitexture;
					if (num != 0)
					{
						if (num != 1)
						{
							uuitexture = null;
						}
						else
						{
							uuitexture = base.GetTexture(2);
						}
					}
					else
					{
						uuitexture = base.GetTexture(1);
					}
					UUITexture uuitexture2 = uuitexture;
					if (uuitexture2 == null || !uuitexture2.IsValid())
					{
						iconIndex = -1;
						return null;
					}
					return new FVector?(uuitexture2.GetLGUISpaceAbsolutePosition());
				}
			}
			return null;
		}

		// Token: 0x060372E4 RID: 226020 RVA: 0x00F676E7 File Offset: 0x00F658E7
		public void HideTips()
		{
			this.CancelHoverTipsHideTimer();
			this.IsLocked = false;
			DangoBrawlEventTips eventTips = this.EventTips;
			if (eventTips != null && eventTips.GetActive())
			{
				this.EventTips.Hide();
			}
		}

		// Token: 0x060372E5 RID: 226021 RVA: 0x00F67715 File Offset: 0x00F65915
		private static bool CanHoverTips()
		{
			return !Info.Instance.IsMobileInputModel();
		}

		// Token: 0x060372E6 RID: 226022 RVA: 0x00F67724 File Offset: 0x00F65924
		private void OnPointEnter()
		{
			if (!DangoBrawlEventInfoPanel.CanHoverTips() || this.IsLocked)
			{
				return;
			}
			this.CancelHoverTipsHideTimer();
			DangoBrawlEventTips eventTips = this.EventTips;
			if (eventTips == null)
			{
				return;
			}
			eventTips.Show(false);
		}

		// Token: 0x060372E7 RID: 226023 RVA: 0x00F6774D File Offset: 0x00F6594D
		private void OnPointExit()
		{
			if (!DangoBrawlEventInfoPanel.CanHoverTips() || this.IsLocked)
			{
				return;
			}
			this.ScheduleHideHoverTips();
		}

		// Token: 0x060372E8 RID: 226024 RVA: 0x00F67765 File Offset: 0x00F65965
		private void ScheduleHideHoverTips()
		{
			this.CancelHoverTipsHideTimer();
			this.HoverTipsHideTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.HoverTipsHideTimer = null;
				if (!this.IsLocked)
				{
					DangoBrawlEventTips eventTips = this.EventTips;
					if (eventTips == null)
					{
						return;
					}
					eventTips.Hide();
				}
			}, 50f, null, null, true, 1f);
		}

		// Token: 0x060372E9 RID: 226025 RVA: 0x00F67796 File Offset: 0x00F65996
		private void CancelHoverTipsHideTimer()
		{
			TimerHandle hoverTipsHideTimer = this.HoverTipsHideTimer;
			if (hoverTipsHideTimer != null)
			{
				hoverTipsHideTimer.Remove();
			}
			this.HoverTipsHideTimer = null;
		}

		// Token: 0x060372EA RID: 226026 RVA: 0x00F677B1 File Offset: 0x00F659B1
		private void OnBtnClickEventInfo()
		{
			this.CancelHoverTipsHideTimer();
			if (this.IsLocked)
			{
				this.IsLocked = false;
				DangoBrawlEventTips eventTips = this.EventTips;
				if (eventTips == null)
				{
					return;
				}
				eventTips.Hide();
				return;
			}
			else
			{
				this.IsLocked = true;
				DangoBrawlEventTips eventTips2 = this.EventTips;
				if (eventTips2 == null)
				{
					return;
				}
				eventTips2.Show(true);
				return;
			}
		}

		// Token: 0x060372EB RID: 226027 RVA: 0x00F677F1 File Offset: 0x00F659F1
		private void OnEventTipsClosed()
		{
			this.IsLocked = false;
			this.CancelHoverTipsHideTimer();
		}

		// Token: 0x0401D295 RID: 119445
		[Nullable(2)]
		private DangoBrawlEventTips EventTips;

		// Token: 0x0401D296 RID: 119446
		private bool IsLocked;

		// Token: 0x0401D297 RID: 119447
		[Nullable(2)]
		private TimerHandle HoverTipsHideTimer;

		// Token: 0x0401D298 RID: 119448
		[Nullable(1)]
		private readonly List<int> ShowingEventIds = new List<int>();

		// Token: 0x0200B36D RID: 45933
		private enum EComponents
		{
			// Token: 0x04037749 RID: 227145
			BtnEventInfo,
			// Token: 0x0403774A RID: 227146
			TexIconEvent1,
			// Token: 0x0403774B RID: 227147
			TexIconEvent2,
			// Token: 0x0403774C RID: 227148
			EventTipsItem
		}
	}
}
