using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006110 RID: 24848
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewEvent : RoverlikeActionSubViewBase
	{
		// Token: 0x1700917C RID: 37244
		// (get) Token: 0x0603ED27 RID: 257319 RVA: 0x00F2C065 File Offset: 0x00F2A265
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.SelectEvent;
			}
		}

		// Token: 0x1700917D RID: 37245
		// (get) Token: 0x0603ED28 RID: 257320 RVA: 0x00F2C068 File Offset: 0x00F2A268
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeGameEvent";
			}
		}

		// Token: 0x0603ED29 RID: 257321 RVA: 0x00F2C070 File Offset: 0x00F2A270
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

		// Token: 0x0603ED2A RID: 257322 RVA: 0x00F2C158 File Offset: 0x00F2A358
		protected override void OnStart()
		{
			this.EventChoiceLayout = new GenericScrollViewNew<RoverlikeEventChoiceItem, IRoverlikeEventChoiceData>(base.GetScrollViewWithScrollbar(3), new Func<RoverlikeEventChoiceItem>(this.CreateEventChoiceItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0603ED2B RID: 257323 RVA: 0x00F2C18B File Offset: 0x00F2A38B
		protected override void OnBeforeDestroy()
		{
			this.ChoiceList.Clear();
			this.SelectedChoiceId = -1;
			this.EventIncId = 0;
		}

		// Token: 0x0603ED2C RID: 257324 RVA: 0x00F2C1A6 File Offset: 0x00F2A3A6
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

		// Token: 0x0603ED2D RID: 257325 RVA: 0x00F2C1BB File Offset: 0x00F2A3BB
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

		// Token: 0x0603ED2E RID: 257326 RVA: 0x00F2C1E4 File Offset: 0x00F2A3E4
		private RoverlikeEventChoiceItem CreateEventChoiceItem()
		{
			RoverlikeEventChoiceItem roverlikeEventChoiceItem = new RoverlikeEventChoiceItem();
			roverlikeEventChoiceItem.BindOnItemSelect(new Action<IRoverlikeEventChoiceData>(this.OnEventChoiceItemSelect));
			return roverlikeEventChoiceItem;
		}

		// Token: 0x0603ED2F RID: 257327 RVA: 0x00F2C200 File Offset: 0x00F2A400
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

		// Token: 0x0603ED30 RID: 257328 RVA: 0x00F2C290 File Offset: 0x00F2A490
		private void OnEventChoiceLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeEvent");
		}

		// Token: 0x0603ED31 RID: 257329 RVA: 0x00F2C2A8 File Offset: 0x00F2A4A8
		private void RefreshEventChoiceSelection()
		{
			int num = this.ChoiceList.IndexOf(this.SelectedChoiceId);
			if (num >= 0)
			{
				this.EventChoiceLayout.SelectGridProxy(num, false);
			}
		}

		// Token: 0x0603ED32 RID: 257330 RVA: 0x00F2C2D8 File Offset: 0x00F2A4D8
		private void RefreshButtonState()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.SelectedChoiceId >= 0);
		}

		// Token: 0x0603ED33 RID: 257331 RVA: 0x00F2C2F8 File Offset: 0x00F2A4F8
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

		// Token: 0x04020D0C RID: 134412
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeEventChoiceItem, IRoverlikeEventChoiceData> EventChoiceLayout;

		// Token: 0x04020D0D RID: 134413
		private int EventIncId;

		// Token: 0x04020D0E RID: 134414
		private List<int> ChoiceList = new List<int>();

		// Token: 0x04020D0F RID: 134415
		private int SelectedChoiceId = -1;

		// Token: 0x0200C368 RID: 50024
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF85 RID: 241541
			public const int TexRole = 0;

			// Token: 0x0403AF86 RID: 241542
			public const int ItemEventChoice = 1;

			// Token: 0x0403AF87 RID: 241543
			public const int BtnConfirm = 2;

			// Token: 0x0403AF88 RID: 241544
			public const int EventScroll = 3;
		}
	}
}
