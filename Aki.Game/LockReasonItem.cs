using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B46 RID: 6982
[NullableContext(1)]
[Nullable(0)]
public class LockReasonItem : UiPanelBase
{
	// Token: 0x06011658 RID: 71256 RVA: 0x0051F4C4 File Offset: 0x0051D6C4
	public LockReasonItem(IOccupationInfo occupationInfo)
	{
		this.QuestName = GeneralLogicTreeModel.Instance.GetBehaviorTreeName(occupationInfo.TreeIncId);
		this.ResourceName = QuestNewConfig.Instance.GetOccupationResourceName(occupationInfo.ResourceName);
		this.OccupationType = QuestNewConfig.Instance.GetOccupationType(occupationInfo.ResourceName);
		this.TreeIncId = occupationInfo.TreeIncId;
	}

	// Token: 0x06011659 RID: 71257 RVA: 0x0051F548 File Offset: 0x0051D748
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601165A RID: 71258 RVA: 0x0051F60F File Offset: 0x0051D80F
	protected override void OnStart()
	{
		this.UpdateItem();
	}

	// Token: 0x0601165B RID: 71259 RVA: 0x0051F618 File Offset: 0x0051D818
	public void UpdateItem()
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(this.QuestName, true);
		}
		string str = string.Empty;
		if (this.OccupationType == "Area")
		{
			str = (ConfigMultiTextLang.GetLocalTextNew("Text_OccupiedArea", null) ?? string.Empty);
		}
		else
		{
			str = (ConfigMultiTextLang.GetLocalTextNew("Text_OccupiedRole", null) ?? string.Empty);
		}
		string newText = str + ":" + this.ResourceName;
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(newText, true);
	}

	// Token: 0x0601165C RID: 71260 RVA: 0x0051F6A8 File Offset: 0x0051D8A8
	private void OnClickBtn()
	{
		BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.TreeIncId), false);
		if (behaviorTree == null)
		{
			return;
		}
		if (QuestTreeModel.Instance.ViewModelChapter.OverrideLockReasonGoto)
		{
			QuestTreeModel.Instance.ViewModelChapter.SetOverrideLockReasonGoto(false);
			QuestTreeController.Instance.JumpToQuest(behaviorTree.TreeConfigId);
			UiManager.Instance.CloseView(EUiViewName.QuestLockPreview, null);
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.OnNavigationQuest, behaviorTree.TreeConfigId);
		UiManager.Instance.CloseView(EUiViewName.QuestLockPreview, null);
	}

	// Token: 0x040098CF RID: 39119
	private readonly string QuestName = string.Empty;

	// Token: 0x040098D0 RID: 39120
	private readonly string ResourceName = string.Empty;

	// Token: 0x040098D1 RID: 39121
	private readonly string OccupationType = string.Empty;

	// Token: 0x040098D2 RID: 39122
	private readonly long TreeIncId;

	// Token: 0x02007E1F RID: 32287
	[NullableContext(0)]
	private class EChildComponent
	{
		// Token: 0x04028D2A RID: 167210
		public const int QuestNameText = 0;

		// Token: 0x04028D2B RID: 167211
		public const int OccupationSourceText = 1;

		// Token: 0x04028D2C RID: 167212
		public const int GoToTaskBtn = 2;
	}
}
