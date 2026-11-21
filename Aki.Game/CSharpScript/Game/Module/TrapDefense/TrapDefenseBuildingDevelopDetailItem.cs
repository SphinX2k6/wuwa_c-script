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
	// Token: 0x02003A3D RID: 14909
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopDetailItem : UiPanelBase
	{
		// Token: 0x0602656D RID: 157037 RVA: 0x00ABC946 File Offset: 0x00ABAB46
		public TrapDefenseBuildingDevelopDetailItem(bool IsInDungeon, UiViewBase ParentView)
		{
			this.IsInDungeon = IsInDungeon;
			this.ParentView = ParentView;
		}

		// Token: 0x0602656E RID: 157038 RVA: 0x00ABC964 File Offset: 0x00ABAB64
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

		// Token: 0x0602656F RID: 157039 RVA: 0x00ABCA90 File Offset: 0x00ABAC90
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopDetailItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopDetailItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026570 RID: 157040 RVA: 0x00ABCAD3 File Offset: 0x00ABACD3
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!this.IsInDungeon);
		}

		// Token: 0x06026571 RID: 157041 RVA: 0x00ABCAEF File Offset: 0x00ABACEF
		protected override void OnBeforeDestroy()
		{
			this.InfoItem = null;
			this.BtnUpgrade = null;
			this.BtnSelect = null;
		}

		// Token: 0x06026572 RID: 157042 RVA: 0x00ABCB08 File Offset: 0x00ABAD08
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

		// Token: 0x06026573 RID: 157043 RVA: 0x00ABCBE8 File Offset: 0x00ABADE8
		private void OnClickedBranchSelect()
		{
			ITrapDefenseSelectBranchData param = new TrapDefenseSelectBranchData
			{
				IsInDungeon = this.IsInDungeon,
				Data = this.CurData
			};
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingDevelopBranchSelectView, param, null);
		}

		// Token: 0x06026574 RID: 157044 RVA: 0x00ABCC24 File Offset: 0x00ABAE24
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

		// Token: 0x06026575 RID: 157045 RVA: 0x00ABCC6B File Offset: 0x00ABAE6B
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

		// Token: 0x040150A8 RID: 86184
		protected TrapDefenseBuildingDevelopDetailInfoItem InfoItem;

		// Token: 0x040150A9 RID: 86185
		protected TrapDefenseBuildingUpgradeItem BtnUpgrade;

		// Token: 0x040150AA RID: 86186
		protected TrapDefenseBuildingBranchSelectBtnItem BtnSelect;

		// Token: 0x040150AB RID: 86187
		protected TrapDefenseBuildingDevelopItemData CurData;

		// Token: 0x040150AC RID: 86188
		protected bool CanLevelUp = true;

		// Token: 0x040150AD RID: 86189
		protected bool IsInDungeon;

		// Token: 0x040150AE RID: 86190
		protected UiViewBase ParentView;

		// Token: 0x0200960A RID: 38410
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x0402ED8D RID: 191885
			public const int BuildingItemInfo = 0;

			// Token: 0x0402ED8E RID: 191886
			public const int PanelSelectLayout = 1;

			// Token: 0x0402ED8F RID: 191887
			public const int BtnBranchSelect = 2;

			// Token: 0x0402ED90 RID: 191888
			public const int PanelBtnLayout = 3;

			// Token: 0x0402ED91 RID: 191889
			public const int BtnFuncA1 = 4;

			// Token: 0x0402ED92 RID: 191890
			public const int BtnUpgrade = 5;
		}
	}
}
