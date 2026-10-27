using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B27 RID: 19239
	public class TowerDefenseRankTabItemV2 : GridProxyAbstract<TowerDefenceDefine.ETabType>
	{
		// Token: 0x06031D4B RID: 204107 RVA: 0x00B916E0 File Offset: 0x00B8F8E0
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

		// Token: 0x06031D4C RID: 204108 RVA: 0x00B917B8 File Offset: 0x00B8F9B8
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

		// Token: 0x06031D4D RID: 204109 RVA: 0x00B917EF File Offset: 0x00B8F9EF
		private void ToggleClick(EToggleState toggleState)
		{
			this.ParentModel.TabItemToggle(this.TabType);
		}

		// Token: 0x06031D4E RID: 204110 RVA: 0x00B91802 File Offset: 0x00B8FA02
		[NullableContext(1)]
		public override object GetKey(TowerDefenceDefine.ETabType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06031D4F RID: 204111 RVA: 0x00B9180A File Offset: 0x00B8FA0A
		public override void Refresh(TowerDefenceDefine.ETabType data, bool isSelected, int gridIndex)
		{
			this.TabType = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), TowerDefenceDefine.tabText[data], Array.Empty<object>());
		}

		// Token: 0x06031D50 RID: 204112 RVA: 0x00B91834 File Offset: 0x00B8FA34
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

		// Token: 0x0401A979 RID: 108921
		private TowerDefenceDefine.ETabType TabType;

		// Token: 0x0401A97A RID: 108922
		[Nullable(1)]
		private TowerDefenseRankViewModelV2 ParentModel;

		// Token: 0x0200ACB6 RID: 44214
		private class ETabItemComponent
		{
			// Token: 0x04034794 RID: 214932
			public const int Toggle = 0;

			// Token: 0x04034795 RID: 214933
			public const int TitleTxt = 1;

			// Token: 0x04034796 RID: 214934
			public const int RedDotItem = 2;
		}
	}
}
