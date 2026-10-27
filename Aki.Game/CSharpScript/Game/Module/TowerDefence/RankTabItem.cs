using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B22 RID: 19234
	public class RankTabItem : GridProxyAbstract<TowerDefenceDefine.ETabType>
	{
		// Token: 0x06031D15 RID: 204053 RVA: 0x00B90980 File Offset: 0x00B8EB80
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

		// Token: 0x06031D16 RID: 204054 RVA: 0x00B90A37 File Offset: 0x00B8EC37
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(() => this.ParentModel.TabItemCanExecuteChange(this.TabType));
		}

		// Token: 0x06031D17 RID: 204055 RVA: 0x00B90A5B File Offset: 0x00B8EC5B
		private void ToggleClick(EToggleState toggleState)
		{
			this.ParentModel.TabItemToggle(this.TabType);
		}

		// Token: 0x06031D18 RID: 204056 RVA: 0x00B90A6E File Offset: 0x00B8EC6E
		[NullableContext(1)]
		public override object GetKey(TowerDefenceDefine.ETabType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06031D19 RID: 204057 RVA: 0x00B90A76 File Offset: 0x00B8EC76
		public override void Refresh(TowerDefenceDefine.ETabType data, bool isSelected, int gridIndex)
		{
			this.TabType = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), TowerDefenceDefine.tabText[data], Array.Empty<object>());
		}

		// Token: 0x06031D1A RID: 204058 RVA: 0x00B90AA0 File Offset: 0x00B8ECA0
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

		// Token: 0x0401A965 RID: 108901
		[Nullable(1)]
		private TowerDefenseRankViewModel ParentModel;

		// Token: 0x0401A966 RID: 108902
		private TowerDefenceDefine.ETabType TabType;

		// Token: 0x0200ACA3 RID: 44195
		private class ERankTabItem
		{
			// Token: 0x04034748 RID: 214856
			public const int Toggle = 0;

			// Token: 0x04034749 RID: 214857
			public const int Text = 1;
		}
	}
}
