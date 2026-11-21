using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BA4 RID: 7076
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeDetailTipsItem : UiPanelBase
{
	// Token: 0x06011A08 RID: 72200 RVA: 0x00532CDF File Offset: 0x00530EDF
	public QuestTreeNodeDetailTipsItem(QuestTreeNodeData Data)
	{
	}

	// Token: 0x06011A09 RID: 72201 RVA: 0x00532CF0 File Offset: 0x00530EF0
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

	// Token: 0x06011A0A RID: 72202 RVA: 0x00532DB7 File Offset: 0x00530FB7
	public void SetLocalText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x06011A0B RID: 72203 RVA: 0x00532DD0 File Offset: 0x00530FD0
	public void SetBtnActive(bool active)
	{
		base.GetButton(2).GetRootComponent().SetUIActive(active);
	}

	// Token: 0x06011A0C RID: 72204 RVA: 0x00532DE4 File Offset: 0x00530FE4
	public void UpdateData(QuestTreeNodeData data)
	{
		this.Data = data;
	}

	// Token: 0x06011A0D RID: 72205 RVA: 0x00532DF0 File Offset: 0x00530FF0
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

	// Token: 0x04009A28 RID: 39464
	private QuestTreeNodeData Data = Data;

	// Token: 0x02007E9A RID: 32410
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028FA6 RID: 167846
		public const int SpriteLock = 0;

		// Token: 0x04028FA7 RID: 167847
		public const int TextContent = 1;

		// Token: 0x04028FA8 RID: 167848
		public const int BtnTips = 2;
	}
}
