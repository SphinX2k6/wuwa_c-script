using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FEF RID: 20463
	public class TabItem : GridProxyAbstract<int>
	{
		// Token: 0x060333C9 RID: 209865 RVA: 0x00E5C8D0 File Offset: 0x00E5AAD0
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060333CA RID: 209866 RVA: 0x00E5C998 File Offset: 0x00E5AB98
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.TabIndex = data;
			SpringFestivalRewardTab? rewardTabConfigById = SpringManorConfig.Instance.GetRewardTabConfigById(data);
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(rewardTabConfigById.Value.Name);
			}
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(SpringManorModel.Instance.ActivityData.IsTabHasAnyClaimable(data));
		}

		// Token: 0x060333CB RID: 209867 RVA: 0x00E5C9FA File Offset: 0x00E5ABFA
		private void OnClickToggle(EToggleState state)
		{
			Action<int> onTabClickCallBack = this.OnTabClickCallBack;
			if (onTabClickCallBack == null)
			{
				return;
			}
			onTabClickCallBack(this.TabIndex);
		}

		// Token: 0x060333CC RID: 209868 RVA: 0x00E5CA12 File Offset: 0x00E5AC12
		[NullableContext(1)]
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x060333CD RID: 209869 RVA: 0x00E5CA1B File Offset: 0x00E5AC1B
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x060333CE RID: 209870 RVA: 0x00E5CA25 File Offset: 0x00E5AC25
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401B376 RID: 111478
		private int TabIndex = -1;

		// Token: 0x0401B377 RID: 111479
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;
	}
}
