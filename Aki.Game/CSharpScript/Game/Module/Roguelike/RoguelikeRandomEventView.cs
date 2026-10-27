using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E16 RID: 19990
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeRandomEventView : UiViewBase
	{
		// Token: 0x0603390C RID: 211212 RVA: 0x00C0E052 File Offset: 0x00C0C252
		public RoguelikeRandomEventView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603390D RID: 211213 RVA: 0x00C0E074 File Offset: 0x00C0C274
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603390E RID: 211214 RVA: 0x00C0E15C File Offset: 0x00C0C35C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
		}

		// Token: 0x0603390F RID: 211215 RVA: 0x00C0E17A File Offset: 0x00C0C37A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
		}

		// Token: 0x06033910 RID: 211216 RVA: 0x00C0E198 File Offset: 0x00C0C398
		protected void OnBtnConfirm()
		{
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Event);
		}

		// Token: 0x06033911 RID: 211217 RVA: 0x00C0E1A5 File Offset: 0x00C0C3A5
		protected override void OnStart()
		{
			this.GenericLayout = new GenericLayout<RoguelikeRandomEventItem, RogueGainEntry>(base.GetVerticalLayout(0), new Func<RoguelikeRandomEventItem>(this.CreateElement), null, false, true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06033912 RID: 211218 RVA: 0x00C0E1D9 File Offset: 0x00C0C3D9
		private RoguelikeRandomEventItem CreateElement()
		{
			return new RoguelikeRandomEventItem
			{
				OnSelectHandle = new Action<RoguelikeRandomEventItem, EToggleState>(this.OnSelectHandle)
			};
		}

		// Token: 0x06033913 RID: 211219 RVA: 0x00C0E1F4 File Offset: 0x00C0C3F4
		protected void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
			RoguelikeChooseData data = RoguelikeModel.Instance.GetRoguelikeChooseDataById(-2);
			RoguelikeChooseData data2 = data;
			int? num = (data2 != null) ? new int?(data2.Index) : null;
			if (!(bindId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			Action <>9__1;
			Action <>9__2;
			Action<bool?> action = RoguelikeController.Instance.CreateCloseViewCallBack(response, delegate(bool? _)
			{
				RogueSelectResult rogueSelectResult = new RogueSelectResult(RoguelikeModel.Instance.RogueInfo.PhantomEntry, oldRogueGainEntry, null, false);
				RogueSelectResult rogueSelectResult2 = rogueSelectResult;
				Action callBack;
				if ((callBack = <>9__1) == null)
				{
					callBack = (<>9__1 = delegate()
					{
						this.UpdateEventList(data, false);
					});
				}
				rogueSelectResult2.CallBack = callBack;
				if (rogueSelectResult.GetNewUnlockAffixEntry().Count > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.CommonSelectResultView, rogueSelectResult, null);
					return;
				}
				RoguelikeRandomEventView <>4__this = this;
				Action callback;
				if ((callback = <>9__2) == null)
				{
					callback = (<>9__2 = delegate()
					{
						this.UpdateEventList(data, false);
					});
				}
				if (<>4__this.CheckEventRoleBuff(callback))
				{
					return;
				}
				if (!this.IsEnd)
				{
					this.UpdateEventList(data, false);
				}
			});
			if (action == null)
			{
				return;
			}
			action(null);
		}

		// Token: 0x06033914 RID: 211220 RVA: 0x00C0E288 File Offset: 0x00C0C488
		protected void OnSelectHandle(RoguelikeRandomEventItem item, EToggleState state)
		{
			if (this.LastSelectItem != null && this.LastSelectItem != item && state == EToggleState.ETT_Checked)
			{
				this.LastSelectItem.SetToggleState(false);
			}
			this.LastSelectItem = item;
			bool isSelect = false;
			GenericLayout<RoguelikeRandomEventItem, RogueGainEntry> genericLayout = this.GenericLayout;
			if (genericLayout != null)
			{
				genericLayout.GetLayoutItemList().ForEach(delegate(RoguelikeRandomEventItem eventItem)
				{
					if (eventItem.GetToggleState() == EToggleState.ETT_Checked)
					{
						isSelect = true;
					}
				});
			}
			base.GetButton(2).SetSelfInteractive(isSelect);
		}

		// Token: 0x06033915 RID: 211221 RVA: 0x00C0E300 File Offset: 0x00C0C500
		protected override void OnBeforeShow()
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			base.GetButton(2).SetSelfInteractive(false);
			RoguelikeChooseData data = RoguelikeModel.Instance.GetRoguelikeChooseDataById(-2);
			if (this.CheckEventRoleBuff(delegate
			{
				this.UpdateEventList(data, true);
			}))
			{
				return;
			}
			this.UpdateEventList(data, true);
		}

		// Token: 0x06033916 RID: 211222 RVA: 0x00C0E378 File Offset: 0x00C0C578
		protected override void OnBeforeDestroy()
		{
			this.EventItemList.ForEach(delegate(RoguelikeRandomEventItem item)
			{
				item.Destroy(null);
			});
			if (this.DelayShowTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayShowTimerId);
			}
			this.EventItemList.Clear();
			this.EventActorList.Clear();
			Action<int> selectCallback = ((IRoguelikeRandomEventOpenParam)this.OpenParam).SelectCallback;
			if (selectCallback == null)
			{
				return;
			}
			selectCallback((this.LastSelectItem != null) ? this.LastSelectItem.Data.ConfigId : 0);
		}

		// Token: 0x06033917 RID: 211223 RVA: 0x00C0E414 File Offset: 0x00C0C614
		public void UpdateEventList(RoguelikeChooseData data, bool isPlayPlot = true)
		{
			RoguelikeRandomEventView.<>c__DisplayClass19_0 CS$<>8__locals1 = new RoguelikeRandomEventView.<>c__DisplayClass19_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			bool flag = CS$<>8__locals1.data.RogueGainEntryList.Count == 0;
			this.SetPanelActive(false);
			if (flag)
			{
				base.CloseMe(null);
				return;
			}
			CS$<>8__locals1.<UpdateEventList>g__EventFunc|0().AsTask();
		}

		// Token: 0x06033918 RID: 211224 RVA: 0x00C0E468 File Offset: 0x00C0C668
		private void SetPanelActive(bool isActive)
		{
			base.GetItem(3).SetUIActive(isActive);
			base.GetButton(2).RootUIComp.Get().SetUIActive(isActive);
		}

		// Token: 0x06033919 RID: 211225 RVA: 0x00C0E49C File Offset: 0x00C0C69C
		[NullableContext(2)]
		private bool CheckEventRoleBuff(Action callback = null)
		{
			RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(-3);
			if (roguelikeChooseDataById != null && !roguelikeChooseDataById.IsSelect.GetValueOrDefault())
			{
				int? layer = roguelikeChooseDataById.Layer;
				int curRoomCount = RoguelikeModel.Instance.CurRoomCount;
				if (layer.GetValueOrDefault() == curRoomCount & layer != null)
				{
					roguelikeChooseDataById.CallBack = callback;
					UiManager.Instance.OpenView(EUiViewName.RoleBuffSelectView, roguelikeChooseDataById, null);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0401B599 RID: 112025
		public List<RoguelikeRandomEventItem> EventItemList = new List<RoguelikeRandomEventItem>();

		// Token: 0x0401B59A RID: 112026
		public List<UUIItem> EventActorList = new List<UUIItem>();

		// Token: 0x0401B59B RID: 112027
		public TimerHandle DelayShowTimerId;

		// Token: 0x0401B59C RID: 112028
		public RoguelikeRandomEventItem LastSelectItem;

		// Token: 0x0401B59D RID: 112029
		public GenericLayout<RoguelikeRandomEventItem, RogueGainEntry> GenericLayout;

		// Token: 0x0401B59E RID: 112030
		public LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B59F RID: 112031
		private readonly bool IsEnd;

		// Token: 0x0200AFAE RID: 44974
		[NullableContext(0)]
		private class ERoguelikeRandomEventViewDefine
		{
			// Token: 0x0403555C RID: 218460
			public const int EventContainer = 0;

			// Token: 0x0403555D RID: 218461
			public const int EventItem = 1;

			// Token: 0x0403555E RID: 218462
			public const int BtnConfirm = 2;

			// Token: 0x0403555F RID: 218463
			public const int BgPanel = 3;
		}
	}
}
