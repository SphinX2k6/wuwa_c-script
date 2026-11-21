using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000630 RID: 1584
public class BabelTowerQuestTabItem : GridProxyAbstract<int>
{
	// Token: 0x060049E9 RID: 18921 RVA: 0x00191F44 File Offset: 0x00190144
	protected unsafe override void OnRegisterComponent()
	{
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060049EA RID: 18922 RVA: 0x0019200B File Offset: 0x0019020B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x060049EB RID: 18923 RVA: 0x00192029 File Offset: 0x00190229
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x060049EC RID: 18924 RVA: 0x00192048 File Offset: 0x00190248
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TabIndex = data;
		int num = 4 + data;
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		base.GetItem(2).SetUIActive(babelTowerData.GetQuestTabRedDot(this.TabIndex));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BabelTowerTaskType_" + num.ToString(), Array.Empty<object>());
	}

	// Token: 0x060049ED RID: 18925 RVA: 0x001920AA File Offset: 0x001902AA
	private void OnClickToggle(EToggleState state)
	{
		Action<UUIExtendToggle, int> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(base.GetExtendToggle(0), this.TabIndex);
	}

	// Token: 0x060049EE RID: 18926 RVA: 0x001920C9 File Offset: 0x001902C9
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		Action<UUIExtendToggle, int> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(base.GetExtendToggle(0), this.TabIndex);
	}

	// Token: 0x060049EF RID: 18927 RVA: 0x001920FC File Offset: 0x001902FC
	private void BabelTowerRefreshQuestState()
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		base.GetItem(2).SetUIActive(babelTowerData.GetQuestTabRedDot(this.TabIndex));
	}

	// Token: 0x040036D8 RID: 14040
	private int TabIndex;

	// Token: 0x040036D9 RID: 14041
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickToggleCallBack;

	// Token: 0x020068DC RID: 26844
	private class EComponentDefine
	{
		// Token: 0x040228FB RID: 141563
		public const int Toggle = 0;

		// Token: 0x040228FC RID: 141564
		public const int TitleText = 1;

		// Token: 0x040228FD RID: 141565
		public const int RedDotItem = 2;
	}
}
