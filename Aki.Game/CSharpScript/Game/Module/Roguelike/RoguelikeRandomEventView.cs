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
	// Token: 0x02003DDF RID: 15839
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeRandomEventView : UiViewBase
	{
		// Token: 0x06028777 RID: 165751 RVA: 0x00B5755E File Offset: 0x00B5575E
		public RoguelikeRandomEventView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028778 RID: 165752 RVA: 0x00B57580 File Offset: 0x00B55780
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

		// Token: 0x06028779 RID: 165753 RVA: 0x00B57668 File Offset: 0x00B55868
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
		}

		// Token: 0x0602877A RID: 165754 RVA: 0x00B57686 File Offset: 0x00B55886
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
		}

		// Token: 0x0602877B RID: 165755 RVA: 0x00B576A4 File Offset: 0x00B558A4
		protected void OnBtnConfirm()
		{
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Event);
		}

		// Token: 0x0602877C RID: 165756 RVA: 0x00B576B1 File Offset: 0x00B558B1
		protected override void OnStart()
		{
			this.GenericLayout = new GenericLayout<RoguelikeRandomEventItem, RogueGainEntry>(base.GetVerticalLayout(0), new Func<RoguelikeRandomEventItem>(this.CreateElement), null, false, true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602877D RID: 165757 RVA: 0x00B576E5 File Offset: 0x00B558E5
		private RoguelikeRandomEventItem CreateElement()
		{
			return new RoguelikeRandomEventItem
			{
				OnSelectHandle = new Action<RoguelikeRandomEventItem, EToggleState>(this.OnSelectHandle)
			};
		}

		// Token: 0x0602877E RID: 165758 RVA: 0x00B57700 File Offset: 0x00B55900
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

		// Token: 0x0602877F RID: 165759 RVA: 0x00B57794 File Offset: 0x00B55994
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

		// Token: 0x06028780 RID: 165760 RVA: 0x00B5780C File Offset: 0x00B55A0C
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

		// Token: 0x06028781 RID: 165761 RVA: 0x00B57884 File Offset: 0x00B55A84
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

		// Token: 0x06028782 RID: 165762 RVA: 0x00B57920 File Offset: 0x00B55B20
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

		// Token: 0x06028783 RID: 165763 RVA: 0x00B57974 File Offset: 0x00B55B74
		private void SetPanelActive(bool isActive)
		{
			base.GetItem(3).SetUIActive(isActive);
			base.GetButton(2).RootUIComp.Get().SetUIActive(isActive);
		}

		// Token: 0x06028784 RID: 165764 RVA: 0x00B579A8 File Offset: 0x00B55BA8
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

		// Token: 0x04015F6C RID: 89964
		public List<RoguelikeRandomEventItem> EventItemList = new List<RoguelikeRandomEventItem>();

		// Token: 0x04015F6D RID: 89965
		public List<UUIItem> EventActorList = new List<UUIItem>();

		// Token: 0x04015F6E RID: 89966
		public TimerHandle DelayShowTimerId;

		// Token: 0x04015F6F RID: 89967
		public RoguelikeRandomEventItem LastSelectItem;

		// Token: 0x04015F70 RID: 89968
		public GenericLayout<RoguelikeRandomEventItem, RogueGainEntry> GenericLayout;

		// Token: 0x04015F71 RID: 89969
		public LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015F72 RID: 89970
		private readonly bool IsEnd;

		// Token: 0x020099E3 RID: 39395
		[NullableContext(0)]
		private class ERoguelikeRandomEventViewDefine
		{
			// Token: 0x0402FF8F RID: 196495
			public const int EventContainer = 0;

			// Token: 0x0402FF90 RID: 196496
			public const int EventItem = 1;

			// Token: 0x0402FF91 RID: 196497
			public const int BtnConfirm = 2;

			// Token: 0x0402FF92 RID: 196498
			public const int BgPanel = 3;
		}
	}
}
