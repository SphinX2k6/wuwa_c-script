using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009F8 RID: 2552
[NullableContext(1)]
[Nullable(0)]
public class ActivityTurntableQuestItem : UiPanelBase
{
	// Token: 0x06006F60 RID: 28512 RVA: 0x00224794 File Offset: 0x00222994
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

	// Token: 0x06006F61 RID: 28513 RVA: 0x002248A0 File Offset: 0x00222AA0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTurntableQuestItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTurntableQuestItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006F62 RID: 28514 RVA: 0x002248E4 File Offset: 0x00222AE4
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

	// Token: 0x06006F63 RID: 28515 RVA: 0x0022493D File Offset: 0x00222B3D
	public void SetTitle(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06006F64 RID: 28516 RVA: 0x00224952 File Offset: 0x00222B52
	public void SetTxtById(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06006F65 RID: 28517 RVA: 0x00224967 File Offset: 0x00222B67
	public void SetTxt(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06006F66 RID: 28518 RVA: 0x00224977 File Offset: 0x00222B77
	public void SetRedDot(bool bVisible)
	{
		base.GetItem(4).SetUIActive(bVisible);
	}

	// Token: 0x06006F67 RID: 28519 RVA: 0x00224986 File Offset: 0x00222B86
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

	// Token: 0x06006F68 RID: 28520 RVA: 0x002249BB File Offset: 0x00222BBB
	[NullableContext(2)]
	private ActivityTurntableData GetTurntableData()
	{
		if (this.ActivityId != 0)
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityTurntableData;
		}
		return null;
	}

	// Token: 0x040044FA RID: 17658
	private int QuestId;

	// Token: 0x040044FB RID: 17659
	private int ActivityId;

	// Token: 0x040044FC RID: 17660
	[Nullable(2)]
	private ActivitySmallItemGrid RewardItemGrid;

	// Token: 0x02006CFF RID: 27903
	[NullableContext(0)]
	private class EQuestComponents
	{
		// Token: 0x04023CB8 RID: 146616
		public const int Title = 0;

		// Token: 0x04023CB9 RID: 146617
		public const int Txt = 1;

		// Token: 0x04023CBA RID: 146618
		public const int ItemGrid = 2;

		// Token: 0x04023CBB RID: 146619
		public const int Button = 3;

		// Token: 0x04023CBC RID: 146620
		public const int RedDot = 4;
	}
}
