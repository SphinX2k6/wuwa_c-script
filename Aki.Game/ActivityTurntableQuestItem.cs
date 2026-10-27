using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001540 RID: 5440
[NullableContext(1)]
[Nullable(0)]
public class ActivityTurntableQuestItem : UiPanelBase
{
	// Token: 0x06009B82 RID: 39810 RVA: 0x0021A9E4 File Offset: 0x00218BE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedQuestJump));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009B83 RID: 39811 RVA: 0x0021AAF0 File Offset: 0x00218CF0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTurntableQuestItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTurntableQuestItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009B84 RID: 39812 RVA: 0x0021AB34 File Offset: 0x00218D34
	public void Refresh(bool isFinished, TItem reward, int questId, int activityId)
	{
		ItemGridData data = new ItemGridData
		{
			Item = reward,
			HasClaimed = isFinished
		};
		this.RewardItemGrid.Refresh(data);
		base.GetButton(3).RootUIComp.Get().SetUIActive(!isFinished);
		this.QuestId = questId;
		this.ActivityId = activityId;
	}

	// Token: 0x06009B85 RID: 39813 RVA: 0x0021AB8D File Offset: 0x00218D8D
	public void SetTitle(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06009B86 RID: 39814 RVA: 0x0021ABA2 File Offset: 0x00218DA2
	public void SetTxtById(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06009B87 RID: 39815 RVA: 0x0021ABB7 File Offset: 0x00218DB7
	public void SetTxt(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06009B88 RID: 39816 RVA: 0x0021ABC7 File Offset: 0x00218DC7
	public void SetRedDot(bool bVisible)
	{
		base.GetItem(4).SetUIActive(bVisible);
	}

	// Token: 0x06009B89 RID: 39817 RVA: 0x0021ABD6 File Offset: 0x00218DD6
	private void OnClickedQuestJump()
	{
		if (this.QuestId != 0)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.QuestId, null);
			ActivityTurntableData turntableData = this.GetTurntableData();
			if (turntableData == null)
			{
				return;
			}
			turntableData.ReadCurrentUnlockQuest();
		}
	}

	// Token: 0x06009B8A RID: 39818 RVA: 0x0021AC0B File Offset: 0x00218E0B
	[NullableContext(2)]
	private ActivityTurntableData GetTurntableData()
	{
		if (this.ActivityId != 0)
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityTurntableData;
		}
		return null;
	}

	// Token: 0x04004454 RID: 17492
	private int QuestId;

	// Token: 0x04004455 RID: 17493
	private int ActivityId;

	// Token: 0x04004456 RID: 17494
	[Nullable(2)]
	private ActivitySmallItemGrid RewardItemGrid;

	// Token: 0x02007B74 RID: 31604
	[NullableContext(0)]
	private class EQuestComponents
	{
		// Token: 0x0402897D RID: 166269
		public const int Title = 0;

		// Token: 0x0402897E RID: 166270
		public const int Txt = 1;

		// Token: 0x0402897F RID: 166271
		public const int ItemGrid = 2;

		// Token: 0x04028980 RID: 166272
		public const int Button = 3;

		// Token: 0x04028981 RID: 166273
		public const int RedDot = 4;
	}
}
