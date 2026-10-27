using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DAC RID: 23980
	public class RewardListView : BattleVisibleChildView
	{
		// Token: 0x0603CE5F RID: 249439 RVA: 0x00EA11AC File Offset: 0x00E9F3AC
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClosed), false);
			this.AddEvents();
		}

		// Token: 0x0603CE60 RID: 249440 RVA: 0x00EA11FE File Offset: 0x00E9F3FE
		[NullableContext(2)]
		protected override UniTask InitializeAsync(object param = null)
		{
			this.CreateItemLayout();
			return UniTask.CompletedTask;
		}

		// Token: 0x0603CE61 RID: 249441 RVA: 0x00EA120B File Offset: 0x00E9F40B
		public override void Reset()
		{
			this.RemoveEvents();
			this.SequencePlayer = null;
			GenericLayout<TreasureChestCountItem, TreasureChestRowData> itemLayout = this.ItemLayout;
			if (itemLayout != null)
			{
				itemLayout.ClearChildren();
			}
			this.ItemLayout = null;
			base.Reset();
		}

		// Token: 0x0603CE62 RID: 249442 RVA: 0x00EA1238 File Offset: 0x00E9F438
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleRewardList));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603CE63 RID: 249443 RVA: 0x00EA1320 File Offset: 0x00E9F520
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			this.CollapseToDefault();
			base.ShowBattleVisibleChildView(checkVisible);
		}

		// Token: 0x0603CE64 RID: 249444 RVA: 0x00EA132F File Offset: 0x00E9F52F
		public void SetSilentAreaHide(bool hide)
		{
			base.SetVisible(2, !hide);
		}

		// Token: 0x0603CE65 RID: 249445 RVA: 0x00EA133C File Offset: 0x00E9F53C
		public void CollapseToDefault()
		{
			this.PoppedStatType = null;
			this.StopSequences();
			this.CollapseTips();
			this.RefreshRows(null);
			this.UpdateVisible(false);
		}

		// Token: 0x0603CE66 RID: 249446 RVA: 0x00EA1377 File Offset: 0x00E9F577
		protected override void OnHideBattleChildView()
		{
			this.CollapseToDefault();
		}

		// Token: 0x0603CE67 RID: 249447 RVA: 0x00EA1380 File Offset: 0x00E9F580
		private void AddEvents()
		{
			EventSystem.Instance.Add<TreasureChestStatType?>(EEventName.OnTreasureChestCountChanged, new Action<TreasureChestStatType?>(this.OnTreasureChestCountChanged));
			EventSystem.Instance.Add<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
			UUIItem item = base.GetItem(1);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor == null)
			{
				return;
			}
			auibaseActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
		}

		// Token: 0x0603CE68 RID: 249448 RVA: 0x00EA13F8 File Offset: 0x00E9F5F8
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<TreasureChestStatType?>(EEventName.OnTreasureChestCountChanged, new Action<TreasureChestStatType?>(this.OnTreasureChestCountChanged));
			EventSystem.Instance.Remove<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
			UUIItem item = base.GetItem(1);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor == null)
			{
				return;
			}
			auibaseActor.OnSequencePlayEvent.Unbind();
		}

		// Token: 0x0603CE69 RID: 249449 RVA: 0x00EA1464 File Offset: 0x00E9F664
		private void OnChangeArea(int? preAreaId, int areaId)
		{
			this.CollapseToDefault();
		}

		// Token: 0x0603CE6A RID: 249450 RVA: 0x00EA146C File Offset: 0x00E9F66C
		private void CreateItemLayout()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(2);
			UUIItem item = base.GetItem(3);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (verticalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.ItemLayout = new GenericLayout<TreasureChestCountItem, TreasureChestRowData>(verticalLayout, () => new TreasureChestCountItem(), auibaseActor, false, true);
		}

		// Token: 0x0603CE6B RID: 249451 RVA: 0x00EA14D0 File Offset: 0x00E9F6D0
		private void RefreshRows(TreasureChestStatType? gainedStatType = null)
		{
			List<TreasureChestCountData> countList = MapModel.Instance.GetCurTreasureChestCountList();
			List<TreasureChestRowData> data = countList.Select(delegate(TreasureChestCountData info, int index)
			{
				bool isLast = index == countList.Count - 1;
				TreasureChestStatType statType = info.StatType;
				TreasureChestStatType? gainedStatType2 = gainedStatType;
				return new TreasureChestRowData(info, isLast, statType == gainedStatType2.GetValueOrDefault() & gainedStatType2 != null);
			}).ToList<TreasureChestRowData>();
			GenericLayout<TreasureChestCountItem, TreasureChestRowData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0603CE6C RID: 249452 RVA: 0x00EA152C File Offset: 0x00E9F72C
		private void UpdateVisible(bool keepVisible = false)
		{
			List<TreasureChestCountData> curTreasureChestCountList = MapModel.Instance.GetCurTreasureChestCountList();
			bool flag = curTreasureChestCountList.Any((TreasureChestCountData info) => info.CurrentCount < info.TotalCount);
			base.SetVisible(1, curTreasureChestCountList.Count > 0 && (keepVisible || flag));
		}

		// Token: 0x0603CE6D RID: 249453 RVA: 0x00EA1580 File Offset: 0x00E9F780
		private void OnTreasureChestCountChanged(TreasureChestStatType? gainedStatType)
		{
			bool flag = gainedStatType != null && this.IsEnable && this.BaseVisible;
			this.UpdateVisible(flag);
			if (!flag)
			{
				this.RefreshRows(null);
				return;
			}
			this.PoppedStatType = gainedStatType;
			this.PlayShow();
		}

		// Token: 0x0603CE6E RID: 249454 RVA: 0x00EA15D0 File Offset: 0x00E9F7D0
		private void PlayShow()
		{
			this.StopSequences();
			this.ExpandTips();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
		}

		// Token: 0x0603CE6F RID: 249455 RVA: 0x00EA160C File Offset: 0x00E9F80C
		private void PlayHide()
		{
			this.StopSequences();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Hide", false, null, false);
		}

		// Token: 0x0603CE70 RID: 249456 RVA: 0x00EA163F File Offset: 0x00E9F83F
		private void StopSequences()
		{
			this.StopSequence("Show");
			this.StopSequence("Hide");
		}

		// Token: 0x0603CE71 RID: 249457 RVA: 0x00EA1657 File Offset: 0x00E9F857
		[NullableContext(1)]
		private void StopSequence(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null || !sequencePlayer.IsPlayingSequence(sequenceName))
			{
				return;
			}
			this.SequencePlayer.StopSequenceByKey(sequenceName, false, false);
		}

		// Token: 0x0603CE72 RID: 249458 RVA: 0x00EA1680 File Offset: 0x00E9F880
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (sequenceName != "Show" || eventName != "NumChange")
			{
				return;
			}
			this.RefreshRows(this.PoppedStatType);
		}

		// Token: 0x0603CE73 RID: 249459 RVA: 0x00EA16A9 File Offset: 0x00E9F8A9
		[NullableContext(1)]
		private void OnSequenceClosed(string sequenceName)
		{
			if (sequenceName == "Show")
			{
				if (this.PoppedStatType != null)
				{
					this.PlayHide();
				}
				return;
			}
			if (sequenceName != "Hide")
			{
				return;
			}
			this.CollapseToDefault();
		}

		// Token: 0x0603CE74 RID: 249460 RVA: 0x00EA16E0 File Offset: 0x00E9F8E0
		private void OnToggleRewardList(EToggleState toggleState)
		{
			if (toggleState != EToggleState.ETT_Checked)
			{
				this.PlayHide();
				return;
			}
			this.PoppedStatType = null;
			this.PlayShow();
		}

		// Token: 0x0603CE75 RID: 249461 RVA: 0x00EA16FF File Offset: 0x00E9F8FF
		private void ExpandTips()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.SetToggleState(EToggleState.ETT_Checked);
		}

		// Token: 0x0603CE76 RID: 249462 RVA: 0x00EA171B File Offset: 0x00E9F91B
		private void CollapseTips()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.SetToggleState(EToggleState.ETT_UnChecked);
		}

		// Token: 0x0603CE77 RID: 249463 RVA: 0x00EA1738 File Offset: 0x00E9F938
		private void SetToggleState(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null || extendToggle.GetToggleState() == state)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0401FB81 RID: 129921
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TreasureChestCountItem, TreasureChestRowData> ItemLayout;

		// Token: 0x0401FB82 RID: 129922
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401FB83 RID: 129923
		private TreasureChestStatType? PoppedStatType;

		// Token: 0x0200C08A RID: 49290
		private enum EVisibleReason
		{
			// Token: 0x0403A1A4 RID: 237988
			NoCount = 1,
			// Token: 0x0403A1A5 RID: 237989
			SilentArea
		}

		// Token: 0x0200C08B RID: 49291
		private enum EChildComponent
		{
			// Token: 0x0403A1A7 RID: 237991
			TogRewardList,
			// Token: 0x0403A1A8 RID: 237992
			PnlTips,
			// Token: 0x0403A1A9 RID: 237993
			PnlLayout,
			// Token: 0x0403A1AA RID: 237994
			PnlItem
		}
	}
}
