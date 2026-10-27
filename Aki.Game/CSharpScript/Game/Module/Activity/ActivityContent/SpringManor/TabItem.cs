using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006071 RID: 24689
	public class TabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603E705 RID: 255749 RVA: 0x00F15B0C File Offset: 0x00F13D0C
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

		// Token: 0x0603E706 RID: 255750 RVA: 0x00F15BD4 File Offset: 0x00F13DD4
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

		// Token: 0x0603E707 RID: 255751 RVA: 0x00F15C36 File Offset: 0x00F13E36
		private void OnClickToggle(EToggleState state)
		{
			Action<int> onTabClickCallBack = this.OnTabClickCallBack;
			if (onTabClickCallBack == null)
			{
				return;
			}
			onTabClickCallBack(this.TabIndex);
		}

		// Token: 0x0603E708 RID: 255752 RVA: 0x00F15C4E File Offset: 0x00F13E4E
		[NullableContext(1)]
		public void SetTabClickCallback(Action<int> callback)
		{
			this.OnTabClickCallBack = callback;
		}

		// Token: 0x0603E709 RID: 255753 RVA: 0x00F15C57 File Offset: 0x00F13E57
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x0603E70A RID: 255754 RVA: 0x00F15C61 File Offset: 0x00F13E61
		public void SetToggleSelect(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x04020A49 RID: 133705
		private int TabIndex = -1;

		// Token: 0x04020A4A RID: 133706
		[Nullable(2)]
		private Action<int> OnTabClickCallBack;
	}
}
