using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001110 RID: 4368
[NullableContext(1)]
[Nullable(0)]
public class AvignonActivityMainView : UiViewBase
{
	// Token: 0x06007239 RID: 29241 RVA: 0x00175AE1 File Offset: 0x00173CE1
	public AvignonActivityMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600723A RID: 29242 RVA: 0x00175AEC File Offset: 0x00173CEC
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

	// Token: 0x0600723B RID: 29243 RVA: 0x00175BF8 File Offset: 0x00173DF8
	protected override UniTask OnBeforeStartAsync()
	{
		AvignonActivityMainView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AvignonActivityMainView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600723C RID: 29244 RVA: 0x00175C3B File Offset: 0x00173E3B
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600723D RID: 29245 RVA: 0x00175C44 File Offset: 0x00173E44
	private void OnQuestBtnClick()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName questView = EUiViewName.QuestView;
		AvignonProtocolData avignonProtocolData = this.AvignonProtocolData;
		instance.OpenView(questView, (avignonProtocolData != null) ? avignonProtocolData.GetCurrentLockQuestId() : null, null);
	}

	// Token: 0x040034E9 RID: 13545
	protected AvignonProtocolData AvignonProtocolData;

	// Token: 0x040034EA RID: 13546
	private PopupCaptionItem CaptionItem;

	// Token: 0x020076D2 RID: 30418
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027358 RID: 160600
		public const int ItemCaption = 0;

		// Token: 0x04027359 RID: 160601
		public const int ItemStage1 = 1;

		// Token: 0x0402735A RID: 160602
		public const int ItemStage2 = 2;

		// Token: 0x0402735B RID: 160603
		public const int ItemStage3 = 3;

		// Token: 0x0402735C RID: 160604
		public const int BtnQuest = 4;
	}
}
