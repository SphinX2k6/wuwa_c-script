using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200117C RID: 4476
public class BabelTowerQuestTabItem : GridProxyAbstract<int>
{
	// Token: 0x06007652 RID: 30290 RVA: 0x00189394 File Offset: 0x00187594
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

	// Token: 0x06007653 RID: 30291 RVA: 0x0018945B File Offset: 0x0018765B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x06007654 RID: 30292 RVA: 0x00189479 File Offset: 0x00187679
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x06007655 RID: 30293 RVA: 0x00189498 File Offset: 0x00187698
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TabIndex = data;
		int num = 4 + data;
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		base.GetItem(2).SetUIActive(babelTowerData.GetQuestTabRedDot(this.TabIndex));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BabelTowerTaskType_" + num.ToString(), Array.Empty<object>());
	}

	// Token: 0x06007656 RID: 30294 RVA: 0x001894FA File Offset: 0x001876FA
	private void OnClickToggle(EToggleState state)
	{
		Action<UUIExtendToggle, int> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(base.GetExtendToggle(0), this.TabIndex);
	}

	// Token: 0x06007657 RID: 30295 RVA: 0x00189519 File Offset: 0x00187719
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

	// Token: 0x06007658 RID: 30296 RVA: 0x0018954C File Offset: 0x0018774C
	private void BabelTowerRefreshQuestState()
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		base.GetItem(2).SetUIActive(babelTowerData.GetQuestTabRedDot(this.TabIndex));
	}

	// Token: 0x0400363F RID: 13887
	private int TabIndex;

	// Token: 0x04003640 RID: 13888
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickToggleCallBack;

	// Token: 0x0200774F RID: 30543
	private class EComponentDefine
	{
		// Token: 0x040275C2 RID: 161218
		public const int Toggle = 0;

		// Token: 0x040275C3 RID: 161219
		public const int TitleText = 1;

		// Token: 0x040275C4 RID: 161220
		public const int RedDotItem = 2;
	}
}
