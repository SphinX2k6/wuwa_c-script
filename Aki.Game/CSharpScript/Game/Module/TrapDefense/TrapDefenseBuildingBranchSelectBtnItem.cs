using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A41 RID: 14913
	public class TrapDefenseBuildingBranchSelectBtnItem : UiPanelBase
	{
		// Token: 0x0602658B RID: 157067 RVA: 0x00ABD6E4 File Offset: 0x00ABB8E4
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

		// Token: 0x0602658C RID: 157068 RVA: 0x00ABD7CC File Offset: 0x00ABB9CC
		private void OnClickedBtn()
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb();
			}
		}

		// Token: 0x0602658D RID: 157069 RVA: 0x00ABD7E4 File Offset: 0x00ABB9E4
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

		// Token: 0x040150B7 RID: 86199
		[Nullable(1)]
		public Action OnClickCb;

		// Token: 0x02009612 RID: 38418
		private class EBranchSelect
		{
			// Token: 0x0402EDB4 RID: 191924
			public const int Btn = 0;

			// Token: 0x0402EDB5 RID: 191925
			public const int UpgradeState = 1;

			// Token: 0x0402EDB6 RID: 191926
			public const int TxtTitle = 2;

			// Token: 0x0402EDB7 RID: 191927
			public const int RedDot = 3;
		}
	}
}
