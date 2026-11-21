using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200508E RID: 20622
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewEvent : RoverlikeActionSubViewBase
	{
		// Token: 0x170064DE RID: 25822
		// (get) Token: 0x060339E9 RID: 211433 RVA: 0x00E72E79 File Offset: 0x00E71079
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectEvent;
			}
		}

		// Token: 0x170064DF RID: 25823
		// (get) Token: 0x060339EA RID: 211434 RVA: 0x00E72E7C File Offset: 0x00E7107C
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeGameEvent";
			}
		}

		// Token: 0x060339EB RID: 211435 RVA: 0x00E72E84 File Offset: 0x00E71084
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060339EC RID: 211436 RVA: 0x00E72F6C File Offset: 0x00E7116C
		protected override void OnStart()
		{
			this.EventChoiceLayout = new GenericScrollViewNew<RoverlikeEventChoiceItem, IRoverlikeEventChoiceData>(base.GetScrollViewWithScrollbar(3), new Func<RoverlikeEventChoiceItem>(this.CreateEventChoiceItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x060339ED RID: 211437 RVA: 0x00E72F9F File Offset: 0x00E7119F
		protected override void OnBeforeDestroy()
		{
			this.ChoiceList.Clear();
			this.SelectedChoiceId = -1;
			this.EventIncId = 0;
		}

		// Token: 0x060339EE RID: 211438 RVA: 0x00E72FBA File Offset: 0x00E711BA
		private void OnBtnConfirmClick()
		{
			base.TryInteractAction(delegate
			{
				if (this.SelectedChoiceId < 0)
				{
					return;
				}
				RoverlikeController.Instance.RoverRogueEventSelectRequest(this.EventIncId, this.SelectedChoiceId, delegate(bool isSuccess)
				{
					if (isSuccess)
					{
						RoverlikeController.Instance.FinishActionSubView(this.IncId);
					}
				});
			});
		}

		// Token: 0x060339EF RID: 211439 RVA: 0x00E72FCF File Offset: 0x00E711CF
		private void OnEventChoiceItemSelect(IRoverlikeEventChoiceData data)
		{
			if (data.ConfigId == this.SelectedChoiceId)
			{
				return;
			}
			this.SelectedChoiceId = data.ConfigId;
			this.RefreshEventChoiceSelection();
			this.RefreshButtonState();
		}

		// Token: 0x060339F0 RID: 211440 RVA: 0x00E72FF8 File Offset: 0x00E711F8
		private RoverlikeEventChoiceItem CreateEventChoiceItem()
		{
			RoverlikeEventChoiceItem roverlikeEventChoiceItem = new RoverlikeEventChoiceItem();
			roverlikeEventChoiceItem.BindOnItemSelect(new Action<IRoverlikeEventChoiceData>(this.OnEventChoiceItemSelect));
			return roverlikeEventChoiceItem;
		}

		// Token: 0x060339F1 RID: 211441 RVA: 0x00E73014 File Offset: 0x00E71214
		private void RefreshEventChoiceLayout()
		{
			if (this.ChoiceList.Count == 0)
			{
				return;
			}
			List<IRoverlikeEventChoiceData> list = new List<IRoverlikeEventChoiceData>();
			foreach (int configId in this.ChoiceList)
			{
				RoverlikeEventChoiceData item = new RoverlikeEventChoiceData
				{
					ConfigId = configId
				};
				list.Add(item);
			}
			this.EventChoiceLayout.RefreshByData(list, new Action(this.OnEventChoiceLayoutRefreshed), true);
		}

		// Token: 0x060339F2 RID: 211442 RVA: 0x00E730A4 File Offset: 0x00E712A4
		private void OnEventChoiceLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeEvent");
		}

		// Token: 0x060339F3 RID: 211443 RVA: 0x00E730BC File Offset: 0x00E712BC
		private void RefreshEventChoiceSelection()
		{
			int num = this.ChoiceList.IndexOf(this.SelectedChoiceId);
			if (num >= 0)
			{
				this.EventChoiceLayout.SelectGridProxy(num, false);
			}
		}

		// Token: 0x060339F4 RID: 211444 RVA: 0x00E730EC File Offset: 0x00E712EC
		private void RefreshButtonState()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.SelectedChoiceId >= 0);
		}

		// Token: 0x060339F5 RID: 211445 RVA: 0x00E7310C File Offset: 0x00E7130C
		public override void OnRefreshSubView()
		{
			IRoverlikeEventOpenParam roverlikeEventOpenParam = this.OpenParam as IRoverlikeEventOpenParam;
			if (roverlikeEventOpenParam == null || roverlikeEventOpenParam.ChoiceList.Count == 0)
			{
				return;
			}
			this.EventIncId = roverlikeEventOpenParam.EventIncId;
			this.ChoiceList = roverlikeEventOpenParam.ChoiceList;
			this.SelectedChoiceId = -1;
			this.RefreshEventChoiceLayout();
			this.RefreshButtonState();
		}

		// Token: 0x0401B639 RID: 112185
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeEventChoiceItem, IRoverlikeEventChoiceData> EventChoiceLayout;

		// Token: 0x0401B63A RID: 112186
		private int EventIncId;

		// Token: 0x0401B63B RID: 112187
		private List<int> ChoiceList = new List<int>();

		// Token: 0x0401B63C RID: 112188
		private int SelectedChoiceId = -1;

		// Token: 0x0200AD50 RID: 44368
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358EA RID: 219370
			public const int TexRole = 0;

			// Token: 0x040358EB RID: 219371
			public const int ItemEventChoice = 1;

			// Token: 0x040358EC RID: 219372
			public const int BtnConfirm = 2;

			// Token: 0x040358ED RID: 219373
			public const int EventScroll = 3;
		}
	}
}
