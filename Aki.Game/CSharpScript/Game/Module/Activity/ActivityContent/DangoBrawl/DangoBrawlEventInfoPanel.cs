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
	// Token: 0x02006814 RID: 26644
	public class DangoBrawlEventInfoPanel : UiPanelBase
	{
		// Token: 0x0604278A RID: 272266 RVA: 0x01025F48 File Offset: 0x01024148
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

		// Token: 0x0604278B RID: 272267 RVA: 0x01026030 File Offset: 0x01024230
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlEventInfoPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlEventInfoPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604278C RID: 272268 RVA: 0x01026074 File Offset: 0x01024274
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

		// Token: 0x0604278D RID: 272269 RVA: 0x010260C4 File Offset: 0x010242C4
		[NullableContext(1)]
		public UniTask Refresh(int[] eventIds)
		{
			DangoBrawlEventInfoPanel.<Refresh>d__8 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.eventIds = eventIds;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<DangoBrawlEventInfoPanel.<Refresh>d__8>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0604278E RID: 272270 RVA: 0x01026110 File Offset: 0x01024310
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

		// Token: 0x0604278F RID: 272271 RVA: 0x010261A3 File Offset: 0x010243A3
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

		// Token: 0x06042790 RID: 272272 RVA: 0x010261D1 File Offset: 0x010243D1
		private static bool CanHoverTips()
		{
			return !Info.Instance.IsMobileInputModel();
		}

		// Token: 0x06042791 RID: 272273 RVA: 0x010261E0 File Offset: 0x010243E0
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

		// Token: 0x06042792 RID: 272274 RVA: 0x01026209 File Offset: 0x01024409
		private void OnPointExit()
		{
			if (!DangoBrawlEventInfoPanel.CanHoverTips() || this.IsLocked)
			{
				return;
			}
			this.ScheduleHideHoverTips();
		}

		// Token: 0x06042793 RID: 272275 RVA: 0x01026221 File Offset: 0x01024421
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

		// Token: 0x06042794 RID: 272276 RVA: 0x01026252 File Offset: 0x01024452
		private void CancelHoverTipsHideTimer()
		{
			TimerHandle hoverTipsHideTimer = this.HoverTipsHideTimer;
			if (hoverTipsHideTimer != null)
			{
				hoverTipsHideTimer.Remove();
			}
			this.HoverTipsHideTimer = null;
		}

		// Token: 0x06042795 RID: 272277 RVA: 0x0102626D File Offset: 0x0102446D
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

		// Token: 0x06042796 RID: 272278 RVA: 0x010262AD File Offset: 0x010244AD
		private void OnEventTipsClosed()
		{
			this.IsLocked = false;
			this.CancelHoverTipsHideTimer();
		}

		// Token: 0x04022A38 RID: 141880
		[Nullable(2)]
		private DangoBrawlEventTips EventTips;

		// Token: 0x04022A39 RID: 141881
		private bool IsLocked;

		// Token: 0x04022A3A RID: 141882
		[Nullable(2)]
		private TimerHandle HoverTipsHideTimer;

		// Token: 0x04022A3B RID: 141883
		[Nullable(1)]
		private readonly List<int> ShowingEventIds = new List<int>();

		// Token: 0x0200C9A0 RID: 51616
		private enum EComponents
		{
			// Token: 0x0403CE5C RID: 249436
			BtnEventInfo,
			// Token: 0x0403CE5D RID: 249437
			TexIconEvent1,
			// Token: 0x0403CE5E RID: 249438
			TexIconEvent2,
			// Token: 0x0403CE5F RID: 249439
			EventTipsItem
		}
	}
}
