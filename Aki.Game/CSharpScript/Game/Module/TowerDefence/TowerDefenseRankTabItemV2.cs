using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ACF RID: 15055
	public class TowerDefenseRankTabItemV2 : GridProxyAbstract<TowerDefenceDefine.ETabType>
	{
		// Token: 0x06026ADB RID: 158427 RVA: 0x00AD5744 File Offset: 0x00AD3944
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as TowerDefenseRankViewModelV2);
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026ADC RID: 158428 RVA: 0x00AD581C File Offset: 0x00AD3A1C
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(() => this.ParentModel.TabItemCanExecuteChange(this.TabType));
			}
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06026ADD RID: 158429 RVA: 0x00AD5853 File Offset: 0x00AD3A53
		private void ToggleClick(EToggleState toggleState)
		{
			this.ParentModel.TabItemToggle(this.TabType);
		}

		// Token: 0x06026ADE RID: 158430 RVA: 0x00AD5866 File Offset: 0x00AD3A66
		[NullableContext(1)]
		public override object GetKey(TowerDefenceDefine.ETabType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06026ADF RID: 158431 RVA: 0x00AD586E File Offset: 0x00AD3A6E
		public override void Refresh(TowerDefenceDefine.ETabType data, bool isSelected, int gridIndex)
		{
			this.TabType = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), TowerDefenceDefine.tabText[data], Array.Empty<object>());
		}

		// Token: 0x06026AE0 RID: 158432 RVA: 0x00AD5898 File Offset: 0x00AD3A98
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

		// Token: 0x040152CB RID: 86731
		private TowerDefenceDefine.ETabType TabType;

		// Token: 0x040152CC RID: 86732
		[Nullable(1)]
		private TowerDefenseRankViewModelV2 ParentModel;

		// Token: 0x020096D6 RID: 38614
		private class ETabItemComponent
		{
			// Token: 0x0402F145 RID: 192837
			public const int Toggle = 0;

			// Token: 0x0402F146 RID: 192838
			public const int TitleTxt = 1;

			// Token: 0x0402F147 RID: 192839
			public const int RedDotItem = 2;
		}
	}
}
