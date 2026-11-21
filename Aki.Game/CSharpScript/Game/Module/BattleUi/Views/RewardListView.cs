using System;
using System.Collections.Generic;
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
	// Token: 0x02004D90 RID: 19856
	public class RewardListView : BattleVisibleChildView
	{
		// Token: 0x06031DD6 RID: 204246 RVA: 0x00DF2058 File Offset: 0x00DF0258
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

		// Token: 0x06031DD7 RID: 204247 RVA: 0x00DF20AA File Offset: 0x00DF02AA
		[NullableContext(2)]
		protected override UniTask InitializeAsync(object param = null)
		{
			this.CreateItemLayout();
			return UniTask.CompletedTask;
		}

		// Token: 0x06031DD8 RID: 204248 RVA: 0x00DF20B7 File Offset: 0x00DF02B7
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

		// Token: 0x06031DD9 RID: 204249 RVA: 0x00DF20E4 File Offset: 0x00DF02E4
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

		// Token: 0x06031DDA RID: 204250 RVA: 0x00DF21CC File Offset: 0x00DF03CC
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			this.CollapseToDefault();
			base.ShowBattleVisibleChildView(checkVisible);
		}

		// Token: 0x06031DDB RID: 204251 RVA: 0x00DF21DB File Offset: 0x00DF03DB
		public void SetSilentAreaHide(bool hide)
		{
			base.SetVisible(2, !hide);
		}

		// Token: 0x06031DDC RID: 204252 RVA: 0x00DF21E8 File Offset: 0x00DF03E8
		public void CollapseToDefault()
		{
			this.PoppedStatType = null;
			this.StopSequences();
			this.CollapseTips();
			this.RefreshRows(null);
			this.UpdateVisible(false);
		}

		// Token: 0x06031DDD RID: 204253 RVA: 0x00DF2223 File Offset: 0x00DF0423
		protected override void OnHideBattleChildView()
		{
			this.CollapseToDefault();
		}

		// Token: 0x06031DDE RID: 204254 RVA: 0x00DF222C File Offset: 0x00DF042C
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

		// Token: 0x06031DDF RID: 204255 RVA: 0x00DF22A4 File Offset: 0x00DF04A4
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

		// Token: 0x06031DE0 RID: 204256 RVA: 0x00DF2310 File Offset: 0x00DF0510
		private void OnChangeArea(int? preAreaId, int areaId)
		{
			this.CollapseToDefault();
		}

		// Token: 0x06031DE1 RID: 204257 RVA: 0x00DF2318 File Offset: 0x00DF0518
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

		// Token: 0x06031DE2 RID: 204258 RVA: 0x00DF237C File Offset: 0x00DF057C
		private void RefreshRows(TreasureChestStatType? gainedStatType = null)
		{
			List<TreasureChestCountData> curTreasureChestCountList = MapModel.Instance.GetCurTreasureChestCountList();
			List<TreasureChestRowData> list = new List<TreasureChestRowData>(curTreasureChestCountList.Count);
			for (int i = 0; i < curTreasureChestCountList.Count; i++)
			{
				TreasureChestCountData treasureChestCountData = curTreasureChestCountList[i];
				List<TreasureChestRowData> list2 = list;
				TreasureChestCountData count = treasureChestCountData;
				bool isLast = i == curTreasureChestCountList.Count - 1;
				TreasureChestStatType statType = treasureChestCountData.StatType;
				TreasureChestStatType? treasureChestStatType = gainedStatType;
				list2.Add(new TreasureChestRowData(count, isLast, statType == treasureChestStatType.GetValueOrDefault() & treasureChestStatType != null));
			}
			GenericLayout<TreasureChestCountItem, TreasureChestRowData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06031DE3 RID: 204259 RVA: 0x00DF2400 File Offset: 0x00DF0600
		private void UpdateVisible(bool keepVisible = false)
		{
			List<TreasureChestCountData> curTreasureChestCountList = MapModel.Instance.GetCurTreasureChestCountList();
			bool flag = curTreasureChestCountList.Exists((TreasureChestCountData info) => info.CurrentCount < info.TotalCount);
			base.SetVisible(1, curTreasureChestCountList.Count > 0 && (keepVisible || flag));
		}

		// Token: 0x06031DE4 RID: 204260 RVA: 0x00DF2454 File Offset: 0x00DF0654
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

		// Token: 0x06031DE5 RID: 204261 RVA: 0x00DF24A4 File Offset: 0x00DF06A4
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

		// Token: 0x06031DE6 RID: 204262 RVA: 0x00DF24E0 File Offset: 0x00DF06E0
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

		// Token: 0x06031DE7 RID: 204263 RVA: 0x00DF2513 File Offset: 0x00DF0713
		private void StopSequences()
		{
			this.StopSequence("Show");
			this.StopSequence("Hide");
		}

		// Token: 0x06031DE8 RID: 204264 RVA: 0x00DF252B File Offset: 0x00DF072B
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

		// Token: 0x06031DE9 RID: 204265 RVA: 0x00DF2554 File Offset: 0x00DF0754
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (sequenceName != "Show" || eventName != "NumChange")
			{
				return;
			}
			this.RefreshRows(this.PoppedStatType);
		}

		// Token: 0x06031DEA RID: 204266 RVA: 0x00DF257D File Offset: 0x00DF077D
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

		// Token: 0x06031DEB RID: 204267 RVA: 0x00DF25B4 File Offset: 0x00DF07B4
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

		// Token: 0x06031DEC RID: 204268 RVA: 0x00DF25D3 File Offset: 0x00DF07D3
		private void ExpandTips()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.SetToggleState(EToggleState.ETT_Checked);
		}

		// Token: 0x06031DED RID: 204269 RVA: 0x00DF25EF File Offset: 0x00DF07EF
		private void CollapseTips()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.SetToggleState(EToggleState.ETT_UnChecked);
		}

		// Token: 0x06031DEE RID: 204270 RVA: 0x00DF260C File Offset: 0x00DF080C
		private void SetToggleState(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null || extendToggle.GetToggleState() == state)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0401A63E RID: 108094
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TreasureChestCountItem, TreasureChestRowData> ItemLayout;

		// Token: 0x0401A63F RID: 108095
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401A640 RID: 108096
		private TreasureChestStatType? PoppedStatType;

		// Token: 0x0200AA94 RID: 43668
		private enum EVisibleReason
		{
			// Token: 0x04034B78 RID: 215928
			NoCount = 1,
			// Token: 0x04034B79 RID: 215929
			SilentArea
		}

		// Token: 0x0200AA95 RID: 43669
		private enum EChildComponent
		{
			// Token: 0x04034B7B RID: 215931
			TogRewardList,
			// Token: 0x04034B7C RID: 215932
			PnlTips,
			// Token: 0x04034B7D RID: 215933
			PnlLayout,
			// Token: 0x04034B7E RID: 215934
			PnlItem
		}
	}
}
