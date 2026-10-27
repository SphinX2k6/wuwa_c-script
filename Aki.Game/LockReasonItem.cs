using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200265B RID: 9819
[NullableContext(1)]
[Nullable(0)]
public class LockReasonItem : UiPanelBase
{
	// Token: 0x06014176 RID: 82294 RVA: 0x0051080C File Offset: 0x0050EA0C
	public LockReasonItem(IOccupationInfo occupationInfo)
	{
		this.QuestName = GeneralLogicTreeModel.Instance.GetBehaviorTreeName(occupationInfo.TreeIncId);
		this.ResourceName = QuestNewConfig.Instance.GetOccupationResourceName(occupationInfo.ResourceName);
		this.OccupationType = QuestNewConfig.Instance.GetOccupationType(occupationInfo.ResourceName);
		this.TreeIncId = occupationInfo.TreeIncId;
	}

	// Token: 0x06014177 RID: 82295 RVA: 0x00510890 File Offset: 0x0050EA90
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

	// Token: 0x06014178 RID: 82296 RVA: 0x00510957 File Offset: 0x0050EB57
	protected override void OnStart()
	{
		this.UpdateItem();
	}

	// Token: 0x06014179 RID: 82297 RVA: 0x00510960 File Offset: 0x0050EB60
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

	// Token: 0x0601417A RID: 82298 RVA: 0x005109F0 File Offset: 0x0050EBF0
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

	// Token: 0x04009777 RID: 38775
	private readonly string QuestName = string.Empty;

	// Token: 0x04009778 RID: 38776
	private readonly string ResourceName = string.Empty;

	// Token: 0x04009779 RID: 38777
	private readonly string OccupationType = string.Empty;

	// Token: 0x0400977A RID: 38778
	private readonly long TreeIncId;

	// Token: 0x02008C96 RID: 35990
	[NullableContext(0)]
	private class EChildComponent
	{
		// Token: 0x0402DA13 RID: 186899
		public const int QuestNameText = 0;

		// Token: 0x0402DA14 RID: 186900
		public const int OccupationSourceText = 1;

		// Token: 0x0402DA15 RID: 186901
		public const int GoToTaskBtn = 2;
	}
}
