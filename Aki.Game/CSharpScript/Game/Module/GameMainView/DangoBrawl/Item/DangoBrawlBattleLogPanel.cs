using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x020049EC RID: 18924
	public class DangoBrawlBattleLogPanel : UiPanelBase
	{
		// Token: 0x0602F6C7 RID: 194247 RVA: 0x00D3A0C4 File Offset: 0x00D382C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleAttack));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleHeal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602F6C8 RID: 194248 RVA: 0x00D3A234 File Offset: 0x00D38434
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBattleLogPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBattleLogPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F6C9 RID: 194249 RVA: 0x00D3A277 File Offset: 0x00D38477
		protected override void OnStart()
		{
			this.ScrollView = new LoopScrollView<DangoBrawlBattleLogItem, DangoBrawlBattleLogInfo>(base.GetLoopScrollViewComponent(3), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<DangoBrawlBattleLogItem>(this.CreateLogItem), false);
		}

		// Token: 0x0602F6CA RID: 194250 RVA: 0x00D3A2A9 File Offset: 0x00D384A9
		public void SetActiveByToggle(bool isShow)
		{
			base.SetUiActive(isShow);
			this.Refresh();
		}

		// Token: 0x0602F6CB RID: 194251 RVA: 0x00D3A2B8 File Offset: 0x00D384B8
		public void OnShowInit()
		{
			this.SetActiveByToggle(false);
			this.IsSelf = true;
			this.IsAttack = true;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
			if (extendToggle2 != null)
			{
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			DangoBrawlBattleLogToggle logPanelToggleSelf = this.LogPanelToggleSelf;
			if (logPanelToggleSelf != null)
			{
				logPanelToggleSelf.SetSelected(true);
			}
			DangoBrawlBattleLogToggle logPanelToggleOpponent = this.LogPanelToggleOpponent;
			if (logPanelToggleOpponent == null)
			{
				return;
			}
			logPanelToggleOpponent.SetSelected(false);
		}

		// Token: 0x0602F6CC RID: 194252 RVA: 0x00D3A32C File Offset: 0x00D3852C
		public void RefreshOnEmit(bool isSelf, bool isHeal)
		{
			bool flag = !isHeal;
			if (isSelf != this.IsSelf || flag != this.IsAttack)
			{
				return;
			}
			this.Refresh();
		}

		// Token: 0x0602F6CD RID: 194253 RVA: 0x00D3A358 File Offset: 0x00D38558
		private void Refresh()
		{
			if (!this.RootItem.IsUIActiveSelf())
			{
				return;
			}
			DangoBrawlBattleLogToggle logPanelToggleSelf = this.LogPanelToggleSelf;
			if (logPanelToggleSelf != null)
			{
				logPanelToggleSelf.Refresh(this.IsSelf);
			}
			DangoBrawlBattleLogToggle logPanelToggleOpponent = this.LogPanelToggleOpponent;
			if (logPanelToggleOpponent != null)
			{
				logPanelToggleOpponent.Refresh(this.IsSelf);
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlBattleLogAggregator dangoBrawlBattleLogAggregator;
			if (battleManager == null)
			{
				dangoBrawlBattleLogAggregator = null;
			}
			else
			{
				DangoBrawlDamageReporter damage = battleManager.Damage;
				dangoBrawlBattleLogAggregator = ((damage != null) ? damage.GetLog() : null);
			}
			DangoBrawlBattleLogAggregator dangoBrawlBattleLogAggregator2 = dangoBrawlBattleLogAggregator;
			if (dangoBrawlBattleLogAggregator2 != null)
			{
				List<DangoBrawlBattleLogInfo> list = NoLinq.OrderByDescendingToList<DangoBrawlBattleLogInfo, int>((this.IsAttack ? dangoBrawlBattleLogAggregator2.GetDamage(this.IsSelf) : dangoBrawlBattleLogAggregator2.GetHeal(this.IsSelf)).Values, (DangoBrawlBattleLogInfo info) => info.Value);
				foreach (DangoBrawlBattleLogInfo dangoBrawlBattleLogInfo in list)
				{
					dangoBrawlBattleLogInfo.IsHeal = !this.IsAttack;
				}
				LoopScrollView<DangoBrawlBattleLogItem, DangoBrawlBattleLogInfo> scrollView = this.ScrollView;
				if (scrollView != null)
				{
					scrollView.RefreshByData(list, false, null, false);
				}
				int num = 0;
				foreach (DangoBrawlBattleLogInfo dangoBrawlBattleLogInfo2 in list)
				{
					num += dangoBrawlBattleLogInfo2.Value;
				}
				string textStringId = this.IsAttack ? "DangoBrawlBattleUIText_011" : "DangoBrawlBattleUIText_029";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, new <>z__ReadOnlySingleElementList<object>(num));
				return;
			}
			LoopScrollView<DangoBrawlBattleLogItem, DangoBrawlBattleLogInfo> scrollView2 = this.ScrollView;
			if (scrollView2 == null)
			{
				return;
			}
			scrollView2.RefreshByData(Array.Empty<DangoBrawlBattleLogInfo>(), false, null, false);
		}

		// Token: 0x0602F6CE RID: 194254 RVA: 0x00D3A500 File Offset: 0x00D38700
		[NullableContext(1)]
		private DangoBrawlBattleLogItem CreateLogItem()
		{
			return new DangoBrawlBattleLogItem();
		}

		// Token: 0x0602F6CF RID: 194255 RVA: 0x00D3A507 File Offset: 0x00D38707
		private void OnToggleAttack(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.IsAttack = true;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.Refresh();
		}

		// Token: 0x0602F6D0 RID: 194256 RVA: 0x00D3A532 File Offset: 0x00D38732
		private void OnToggleHeal(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.IsAttack = false;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.Refresh();
		}

		// Token: 0x0602F6D1 RID: 194257 RVA: 0x00D3A55D File Offset: 0x00D3875D
		private void OnToggleTab1(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.IsSelf = true;
			DangoBrawlBattleLogToggle logPanelToggleOpponent = this.LogPanelToggleOpponent;
			if (logPanelToggleOpponent != null)
			{
				logPanelToggleOpponent.SetSelected(false);
			}
			this.Refresh();
		}

		// Token: 0x0602F6D2 RID: 194258 RVA: 0x00D3A583 File Offset: 0x00D38783
		private void OnToggleTab2(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.IsSelf = false;
			DangoBrawlBattleLogToggle logPanelToggleSelf = this.LogPanelToggleSelf;
			if (logPanelToggleSelf != null)
			{
				logPanelToggleSelf.SetSelected(false);
			}
			this.Refresh();
		}

		// Token: 0x04019210 RID: 102928
		private bool IsSelf = true;

		// Token: 0x04019211 RID: 102929
		private bool IsAttack = true;

		// Token: 0x04019212 RID: 102930
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<DangoBrawlBattleLogItem, DangoBrawlBattleLogInfo> ScrollView;

		// Token: 0x04019213 RID: 102931
		[Nullable(2)]
		private DangoBrawlBattleLogToggle LogPanelToggleSelf;

		// Token: 0x04019214 RID: 102932
		[Nullable(2)]
		private DangoBrawlBattleLogToggle LogPanelToggleOpponent;

		// Token: 0x0200A687 RID: 42631
		private enum EComp
		{
			// Token: 0x040337B6 RID: 210870
			TogAttack,
			// Token: 0x040337B7 RID: 210871
			TogHeal,
			// Token: 0x040337B8 RID: 210872
			TxtItemName,
			// Token: 0x040337B9 RID: 210873
			SvDefault,
			// Token: 0x040337BA RID: 210874
			PanelItem,
			// Token: 0x040337BB RID: 210875
			TogTab1,
			// Token: 0x040337BC RID: 210876
			TogTab2
		}
	}
}
