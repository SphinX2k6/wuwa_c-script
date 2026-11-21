using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ACA RID: 15050
	public class RankTabItem : GridProxyAbstract<TowerDefenceDefine.ETabType>
	{
		// Token: 0x06026AA5 RID: 158373 RVA: 0x00AD49E4 File Offset: 0x00AD2BE4
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as TowerDefenseRankViewModel);
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026AA6 RID: 158374 RVA: 0x00AD4A9B File Offset: 0x00AD2C9B
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(() => this.ParentModel.TabItemCanExecuteChange(this.TabType));
		}

		// Token: 0x06026AA7 RID: 158375 RVA: 0x00AD4ABF File Offset: 0x00AD2CBF
		private void ToggleClick(EToggleState toggleState)
		{
			this.ParentModel.TabItemToggle(this.TabType);
		}

		// Token: 0x06026AA8 RID: 158376 RVA: 0x00AD4AD2 File Offset: 0x00AD2CD2
		[NullableContext(1)]
		public override object GetKey(TowerDefenceDefine.ETabType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06026AA9 RID: 158377 RVA: 0x00AD4ADA File Offset: 0x00AD2CDA
		public override void Refresh(TowerDefenceDefine.ETabType data, bool isSelected, int gridIndex)
		{
			this.TabType = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), TowerDefenceDefine.tabText[data], Array.Empty<object>());
		}

		// Token: 0x06026AAA RID: 158378 RVA: 0x00AD4B04 File Offset: 0x00AD2D04
		public void SetToggleState(bool isActive, bool bFire = false)
		{
			EToggleState state = isActive ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, bFire, false, false);
		}

		// Token: 0x040152B7 RID: 86711
		[Nullable(1)]
		private TowerDefenseRankViewModel ParentModel;

		// Token: 0x040152B8 RID: 86712
		private TowerDefenceDefine.ETabType TabType;

		// Token: 0x020096C3 RID: 38595
		private class ERankTabItem
		{
			// Token: 0x0402F0F9 RID: 192761
			public const int Toggle = 0;

			// Token: 0x0402F0FA RID: 192762
			public const int Text = 1;
		}
	}
}
