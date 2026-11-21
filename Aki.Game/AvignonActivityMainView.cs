using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005C4 RID: 1476
[NullableContext(1)]
[Nullable(0)]
public class AvignonActivityMainView : UiViewBase
{
	// Token: 0x060045CF RID: 17871 RVA: 0x0017E49D File Offset: 0x0017C69D
	public AvignonActivityMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060045D0 RID: 17872 RVA: 0x0017E4A8 File Offset: 0x0017C6A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnQuestBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060045D1 RID: 17873 RVA: 0x0017E5B4 File Offset: 0x0017C7B4
	protected override UniTask OnBeforeStartAsync()
	{
		AvignonActivityMainView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AvignonActivityMainView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060045D2 RID: 17874 RVA: 0x0017E5F7 File Offset: 0x0017C7F7
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060045D3 RID: 17875 RVA: 0x0017E600 File Offset: 0x0017C800
	private void OnQuestBtnClick()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName questView = EUiViewName.QuestView;
		AvignonProtocolData avignonProtocolData = this.AvignonProtocolData;
		instance.OpenView(questView, (avignonProtocolData != null) ? avignonProtocolData.GetCurrentLockQuestId() : null, null);
	}

	// Token: 0x04003582 RID: 13698
	protected AvignonProtocolData AvignonProtocolData;

	// Token: 0x04003583 RID: 13699
	private PopupCaptionItem CaptionItem;

	// Token: 0x02006866 RID: 26726
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040226A1 RID: 140961
		public const int ItemCaption = 0;

		// Token: 0x040226A2 RID: 140962
		public const int ItemStage1 = 1;

		// Token: 0x040226A3 RID: 140963
		public const int ItemStage2 = 2;

		// Token: 0x040226A4 RID: 140964
		public const int ItemStage3 = 3;

		// Token: 0x040226A5 RID: 140965
		public const int BtnQuest = 4;
	}
}
