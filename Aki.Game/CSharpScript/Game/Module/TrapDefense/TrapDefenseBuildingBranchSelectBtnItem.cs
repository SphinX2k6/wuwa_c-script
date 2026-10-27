using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A99 RID: 19097
	public class TrapDefenseBuildingBranchSelectBtnItem : UiPanelBase
	{
		// Token: 0x060317FB RID: 202747 RVA: 0x00B79730 File Offset: 0x00B77930
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060317FC RID: 202748 RVA: 0x00B79818 File Offset: 0x00B77A18
		private void OnClickedBtn()
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb();
			}
		}

		// Token: 0x060317FD RID: 202749 RVA: 0x00B79830 File Offset: 0x00B77A30
		[NullableContext(1)]
		public void RefreshButton(TrapDefenseBuildingDevelopItemData data)
		{
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(data.Id);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(trapDefenseMachineIdInfo.Branch == 0);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(trapDefenseMachineIdInfo.Branch > 0);
			}
			string textStringId = (trapDefenseMachineIdInfo.Branch > 0) ? data.GetBranchDesc() : "TowerDefense_Building_BranchSelection_Text";
			string[] branchDescArgs = data.GetBranchDescArgs();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, branchDescArgs);
		}

		// Token: 0x0401A765 RID: 108389
		[Nullable(1)]
		public Action OnClickCb;

		// Token: 0x0200ABF2 RID: 44018
		private class EBranchSelect
		{
			// Token: 0x04034403 RID: 214019
			public const int Btn = 0;

			// Token: 0x04034404 RID: 214020
			public const int UpgradeState = 1;

			// Token: 0x04034405 RID: 214021
			public const int TxtTitle = 2;

			// Token: 0x04034406 RID: 214022
			public const int RedDot = 3;
		}
	}
}
