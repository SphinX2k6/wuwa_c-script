using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005A10 RID: 23056
	public class DangoBrawlBattleLogPanel : UiPanelBase
	{
		// Token: 0x0603A77E RID: 239486 RVA: 0x00DE9B44 File Offset: 0x00DE7D44
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

		// Token: 0x0603A77F RID: 239487 RVA: 0x00DE9CB4 File Offset: 0x00DE7EB4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBattleLogPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBattleLogPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A780 RID: 239488 RVA: 0x00DE9CF7 File Offset: 0x00DE7EF7
		protected override void OnStart()
		{
			this.ScrollView = new LoopScrollView<DangoBrawlBattleLogItem, DangoBrawlBattleLogInfo>(base.GetLoopScrollViewComponent(3), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<DangoBrawlBattleLogItem>(this.CreateLogItem), false);
		}

		// Token: 0x0603A781 RID: 239489 RVA: 0x00DE9D29 File Offset: 0x00DE7F29
		public void SetActiveByToggle(bool isShow)
		{
			base.SetUiActive(isShow);
			this.Refresh();
		}

		// Token: 0x0603A782 RID: 239490 RVA: 0x00DE9D38 File Offset: 0x00DE7F38
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

		// Token: 0x0603A783 RID: 239491 RVA: 0x00DE9DAC File Offset: 0x00DE7FAC
		public void RefreshOnEmit(bool isSelf, bool isHeal)
		{
			bool flag = !isHeal;
			if (isSelf != this.IsSelf || flag != this.IsAttack)
			{
				return;
			}
			this.Refresh();
		}

		// Token: 0x0603A784 RID: 239492 RVA: 0x00DE9DD8 File Offset: 0x00DE7FD8
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
				List<DangoBrawlBattleLogInfo> list = (from info in (this.IsAttack ? dangoBrawlBattleLogAggregator2.GetDamage(this.IsSelf) : dangoBrawlBattleLogAggregator2.GetHeal(this.IsSelf)).Values
				orderby info.Value descending
				select info).ToList<DangoBrawlBattleLogInfo>();
				foreach (DangoBrawlBattleLogInfo dangoBrawlBattleLogInfo in list)
				{
					dangoBrawlBattleLogInfo.IsHeal = !this.IsAttack;
				}
				LoopScrollView<DangoBrawlBattleLogItem, DangoBrawlBattleLogInfo> scrollView = this.ScrollView;
				if (scrollView != null)
				{
					scrollView.RefreshByData(list, false, null, false);
				}
				int num = list.Sum((DangoBrawlBattleLogInfo info) => info.Value);
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

		// Token: 0x0603A785 RID: 239493 RVA: 0x00DE9F68 File Offset: 0x00DE8168
		[NullableContext(1)]
		private DangoBrawlBattleLogItem CreateLogItem()
		{
			return new DangoBrawlBattleLogItem();
		}

		// Token: 0x0603A786 RID: 239494 RVA: 0x00DE9F6F File Offset: 0x00DE816F
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

		// Token: 0x0603A787 RID: 239495 RVA: 0x00DE9F9A File Offset: 0x00DE819A
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

		// Token: 0x0603A788 RID: 239496 RVA: 0x00DE9FC5 File Offset: 0x00DE81C5
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

		// Token: 0x0603A789 RID: 239497 RVA: 0x00DE9FEB File Offset: 0x00DE81EB
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

		// Token: 0x0401E769 RID: 124777
		private bool IsSelf = true;

		// Token: 0x0401E76A RID: 124778
		private bool IsAttack = true;

		// Token: 0x0401E76B RID: 124779
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<DangoBrawlBattleLogItem, DangoBrawlBattleLogInfo> ScrollView;

		// Token: 0x0401E76C RID: 124780
		[Nullable(2)]
		private DangoBrawlBattleLogToggle LogPanelToggleSelf;

		// Token: 0x0401E76D RID: 124781
		[Nullable(2)]
		private DangoBrawlBattleLogToggle LogPanelToggleOpponent;

		// Token: 0x0200BC7E RID: 48254
		private enum EComp
		{
			// Token: 0x04038DEA RID: 232938
			TogAttack,
			// Token: 0x04038DEB RID: 232939
			TogHeal,
			// Token: 0x04038DEC RID: 232940
			TxtItemName,
			// Token: 0x04038DED RID: 232941
			SvDefault,
			// Token: 0x04038DEE RID: 232942
			PanelItem,
			// Token: 0x04038DEF RID: 232943
			TogTab1,
			// Token: 0x04038DF0 RID: 232944
			TogTab2
		}
	}
}
