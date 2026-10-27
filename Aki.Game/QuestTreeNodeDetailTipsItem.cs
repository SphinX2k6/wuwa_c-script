using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020026B9 RID: 9913
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeDetailTipsItem : UiPanelBase
{
	// Token: 0x06014526 RID: 83238 RVA: 0x00523FA7 File Offset: 0x005221A7
	public QuestTreeNodeDetailTipsItem(QuestTreeNodeData Data)
	{
	}

	// Token: 0x06014527 RID: 83239 RVA: 0x00523FB8 File Offset: 0x005221B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
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
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014528 RID: 83240 RVA: 0x0052407F File Offset: 0x0052227F
	public void SetLocalText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x06014529 RID: 83241 RVA: 0x00524098 File Offset: 0x00522298
	public void SetBtnActive(bool active)
	{
		base.GetButton(2).GetRootComponent().SetUIActive(active);
	}

	// Token: 0x0601452A RID: 83242 RVA: 0x005240AC File Offset: 0x005222AC
	public void UpdateData(QuestTreeNodeData data)
	{
		this.Data = data;
	}

	// Token: 0x0601452B RID: 83243 RVA: 0x005240B8 File Offset: 0x005222B8
	private void OnBtnClick()
	{
		Quest quest = QuestNewModel.Instance.GetQuest(this.Data.QuestId);
		if (quest == null)
		{
			return;
		}
		if (quest.IsSuspend())
		{
			IReadOnlyList<IOccupationInfo> occupations = quest.GetOccupations();
			QuestTreeModel.Instance.ViewModelChapter.SetOverrideLockReasonGoto(true);
			UiManager.Instance.OpenView(EUiViewName.QuestLockPreview, occupations, null);
		}
	}

	// Token: 0x040098D0 RID: 39120
	private QuestTreeNodeData Data = Data;

	// Token: 0x02008D11 RID: 36113
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DC8F RID: 187535
		public const int SpriteLock = 0;

		// Token: 0x0402DC90 RID: 187536
		public const int TextContent = 1;

		// Token: 0x0402DC91 RID: 187537
		public const int BtnTips = 2;
	}
}
