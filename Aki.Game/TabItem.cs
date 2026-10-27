using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A32 RID: 6706
[Nullable(new byte[]
{
	0,
	1
})]
internal class TabItem : GridProxyAbstract<TabData>
{
	// Token: 0x0600C537 RID: 50487 RVA: 0x002CBC40 File Offset: 0x002C9E40
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

	// Token: 0x0600C538 RID: 50488 RVA: 0x002CBD28 File Offset: 0x002C9F28
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.CurrentData.ClickCallBack != null)
		{
			this.CurrentData.ClickCallBack(this.CurrentData.TabId);
		}
	}

	// Token: 0x0600C539 RID: 50489 RVA: 0x002CBD54 File Offset: 0x002C9F54
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

	// Token: 0x0600C53A RID: 50490 RVA: 0x002CBDCC File Offset: 0x002C9FCC
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

	// Token: 0x04005AEB RID: 23275
	[Nullable(2)]
	private TabData CurrentData;

	// Token: 0x02007F79 RID: 32633
	private class ETabComponent
	{
		// Token: 0x040299CF RID: 170447
		public const int FrameItem = 0;

		// Token: 0x040299D0 RID: 170448
		public const int Text = 1;

		// Token: 0x040299D1 RID: 170449
		public const int Toggle = 2;

		// Token: 0x040299D2 RID: 170450
		public const int RedDot = 3;
	}
}
