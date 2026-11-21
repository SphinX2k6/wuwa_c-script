using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000EF1 RID: 3825
[Nullable(new byte[]
{
	0,
	1
})]
internal class TabItem : GridProxyAbstract<TabData>
{
	// Token: 0x06009947 RID: 39239 RVA: 0x002D6D5C File Offset: 0x002D4F5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009948 RID: 39240 RVA: 0x002D6E44 File Offset: 0x002D5044
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.CurrentData.ClickCallBack != null)
		{
			this.CurrentData.ClickCallBack(this.CurrentData.TabId);
		}
	}

	// Token: 0x06009949 RID: 39241 RVA: 0x002D6E70 File Offset: 0x002D5070
	[NullableContext(1)]
	public override void Refresh(TabData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		AbyssRewardTab? abyssRewardTabById = DangoAbyssConfig.Instance.GetAbyssRewardTabById(data.TabId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), abyssRewardTabById.Value.Name, Array.Empty<object>());
		EToggleState state = (data.TabId == data.CurrentSelectTabId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state, false, false, false);
		this.RefreshRedDot();
	}

	// Token: 0x0600994A RID: 39242 RVA: 0x002D6EE8 File Offset: 0x002D50E8
	public void RefreshRedDot()
	{
		if (this.CurrentData == null)
		{
			return;
		}
		IActivityRewardData[] taskActivityRewardDataList = this.CurrentData.ActivityData.GetTaskActivityRewardDataList(2, this.CurrentData.TabId);
		bool uiactive = false;
		IActivityRewardData[] array = taskActivityRewardDataList;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].RewardState == EActivityRewardState.Enable)
			{
				uiactive = true;
				break;
			}
		}
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x04005BBA RID: 23482
	[Nullable(2)]
	private TabData CurrentData;

	// Token: 0x02007108 RID: 28936
	private class ETabComponent
	{
		// Token: 0x04024D0C RID: 150796
		public const int FrameItem = 0;

		// Token: 0x04024D0D RID: 150797
		public const int Text = 1;

		// Token: 0x04024D0E RID: 150798
		public const int Toggle = 2;

		// Token: 0x04024D0F RID: 150799
		public const int RedDot = 3;
	}
}
