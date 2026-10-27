using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE1 RID: 19169
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopBranchSelectItem : GridProxyAbstract<ITrapDefenseDevelopBranchSelectInfo>
	{
		// Token: 0x06031A6A RID: 203370 RVA: 0x00B854E8 File Offset: 0x00B836E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickedToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031A6B RID: 203371 RVA: 0x00B855B0 File Offset: 0x00B837B0
		public override void Refresh(ITrapDefenseDevelopBranchSelectInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(data.Id);
			string branchName = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetBranchName(trapDefenseMachineIdInfo.Branch);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), branchName, Array.Empty<object>());
			if (trapDefenseMachineIdInfo.MachineType == ETrapDefenseMachineType.Building)
			{
				TrapDefenseBuilding? buildingById = TrapDefenseConfig.Instance.GetBuildingById(data.Id);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), buildingById.Value.DescDetail, buildingById.Value.DescArgs());
			}
			else
			{
				TrapDefenseAuxiliary? auxiliaryById = TrapDefenseConfig.Instance.GetAuxiliaryById(data.Id);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), auxiliaryById.Value.DescDetail, auxiliaryById.Value.DescArgs());
			}
			if (data.IsSelected)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(1);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			else
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
				if (extendToggle2 == null)
				{
					return;
				}
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
		}

		// Token: 0x06031A6C RID: 203372 RVA: 0x00B856C5 File Offset: 0x00B838C5
		public void UpdateSelected()
		{
			if (this.Data.IsSelected)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(1);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			else
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
				if (extendToggle2 == null)
				{
					return;
				}
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
		}

		// Token: 0x06031A6D RID: 203373 RVA: 0x00B85701 File Offset: 0x00B83901
		private void OnClickedToggle(EToggleState state)
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb(this.Data.Id);
			}
		}

		// Token: 0x0401A841 RID: 108609
		protected ITrapDefenseDevelopBranchSelectInfo Data;

		// Token: 0x0401A842 RID: 108610
		public Action<int> OnClickCb;

		// Token: 0x0200AC6A RID: 44138
		[NullableContext(0)]
		internal class EItem
		{
			// Token: 0x04034663 RID: 214627
			public const int Desc = 0;

			// Token: 0x04034664 RID: 214628
			public const int Toggle = 1;

			// Token: 0x04034665 RID: 214629
			public const int Title = 2;
		}
	}
}
