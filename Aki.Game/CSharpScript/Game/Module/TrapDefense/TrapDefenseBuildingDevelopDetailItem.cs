using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A95 RID: 19093
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopDetailItem : UiPanelBase
	{
		// Token: 0x060317DD RID: 202717 RVA: 0x00B78992 File Offset: 0x00B76B92
		public TrapDefenseBuildingDevelopDetailItem(bool IsInDungeon, UiViewBase ParentView)
		{
			this.IsInDungeon = IsInDungeon;
			this.ParentView = ParentView;
		}

		// Token: 0x060317DE RID: 202718 RVA: 0x00B789B0 File Offset: 0x00B76BB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedCheckBranch));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060317DF RID: 202719 RVA: 0x00B78ADC File Offset: 0x00B76CDC
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopDetailItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopDetailItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060317E0 RID: 202720 RVA: 0x00B78B1F File Offset: 0x00B76D1F
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!this.IsInDungeon);
		}

		// Token: 0x060317E1 RID: 202721 RVA: 0x00B78B3B File Offset: 0x00B76D3B
		protected override void OnBeforeDestroy()
		{
			this.InfoItem = null;
			this.BtnUpgrade = null;
			this.BtnSelect = null;
		}

		// Token: 0x060317E2 RID: 202722 RVA: 0x00B78B54 File Offset: 0x00B76D54
		public void UpdateDetail(TrapDefenseBuildingDevelopItemData data)
		{
			this.CurData = data;
			this.InfoItem.UpdateDetail(data);
			bool flag = data.GetHasBranch() && data.GetIsUnlock();
			if (!this.IsInDungeon)
			{
				this.CanLevelUp = this.BtnUpgrade.RefreshButton(data);
				UUIItem item = base.GetItem(1);
				if (item != null)
				{
					item.SetUIActive(flag);
				}
				if (flag)
				{
					TrapDefenseBuildingBranchSelectBtnItem btnSelect = this.BtnSelect;
					if (btnSelect != null)
					{
						btnSelect.RefreshButton(data);
					}
				}
			}
			else
			{
				this.CanLevelUp = false;
				ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(data.Id);
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(flag && trapDefenseMachineIdInfo.Branch > 0);
				}
				if (flag && trapDefenseMachineIdInfo.Branch > 0)
				{
					TrapDefenseBuildingBranchSelectBtnItem btnSelect2 = this.BtnSelect;
					if (btnSelect2 != null)
					{
						btnSelect2.RefreshButton(data);
					}
				}
			}
			EventSystem.Instance.Emit<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingDevelopDetailUpdate, data);
		}

		// Token: 0x060317E3 RID: 202723 RVA: 0x00B78C34 File Offset: 0x00B76E34
		private void OnClickedBranchSelect()
		{
			ITrapDefenseSelectBranchData param = new TrapDefenseSelectBranchData
			{
				IsInDungeon = this.IsInDungeon,
				Data = this.CurData
			};
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingDevelopBranchSelectView, param, null);
		}

		// Token: 0x060317E4 RID: 202724 RVA: 0x00B78C70 File Offset: 0x00B76E70
		private void OnClickedCheckBranch()
		{
			ITrapDefenseSelectBranchData param = new TrapDefenseSelectBranchData
			{
				IsInDungeon = this.IsInDungeon,
				Data = this.CurData
			};
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingDevelopPreviewView, param, delegate(bool success, int viewId)
			{
				this.ParentView.AddChildViewById(viewId);
			});
		}

		// Token: 0x060317E5 RID: 202725 RVA: 0x00B78CB7 File Offset: 0x00B76EB7
		private void OnClickedUpgrade()
		{
			if (this.CurData == null)
			{
				return;
			}
			if (!this.CanLevelUp)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Develop_NoEnoughGold", Array.Empty<object>());
				return;
			}
			TrapDefenseController.Instance.RequestTrapDefenseDevelopLevelUp(this.CurData.Id);
		}

		// Token: 0x0401A756 RID: 108374
		protected TrapDefenseBuildingDevelopDetailInfoItem InfoItem;

		// Token: 0x0401A757 RID: 108375
		protected TrapDefenseBuildingUpgradeItem BtnUpgrade;

		// Token: 0x0401A758 RID: 108376
		protected TrapDefenseBuildingBranchSelectBtnItem BtnSelect;

		// Token: 0x0401A759 RID: 108377
		protected TrapDefenseBuildingDevelopItemData CurData;

		// Token: 0x0401A75A RID: 108378
		protected bool CanLevelUp = true;

		// Token: 0x0401A75B RID: 108379
		protected bool IsInDungeon;

		// Token: 0x0401A75C RID: 108380
		protected UiViewBase ParentView;

		// Token: 0x0200ABEA RID: 44010
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x040343DC RID: 213980
			public const int BuildingItemInfo = 0;

			// Token: 0x040343DD RID: 213981
			public const int PanelSelectLayout = 1;

			// Token: 0x040343DE RID: 213982
			public const int BtnBranchSelect = 2;

			// Token: 0x040343DF RID: 213983
			public const int PanelBtnLayout = 3;

			// Token: 0x040343E0 RID: 213984
			public const int BtnFuncA1 = 4;

			// Token: 0x040343E1 RID: 213985
			public const int BtnUpgrade = 5;
		}
	}
}
