using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020E5 RID: 8421
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueViewBase : UiPanelBase
{
	// Token: 0x06014A9B RID: 84635 RVA: 0x00605438 File Offset: 0x00603638
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnBackBtnClick))
		};
	}

	// Token: 0x06014A9C RID: 84636 RVA: 0x006054F8 File Offset: 0x006036F8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueViewBase.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueViewBase.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A9D RID: 84637 RVA: 0x0060553B File Offset: 0x0060373B
	private void OnBtnHelp()
	{
		SurvivorsRogueController.Instance.OpenRogueHelp();
	}

	// Token: 0x06014A9E RID: 84638 RVA: 0x00605547 File Offset: 0x00603747
	private void OnBackBtnClick()
	{
		SurvivorsRogueController.Instance.OpenLeaveInstanceView();
	}

	// Token: 0x06014A9F RID: 84639 RVA: 0x00605554 File Offset: 0x00603754
	[NullableContext(1)]
	public void SetMainTitle(string txtId, params string[] args)
	{
		object[] array = new object[args.Length];
		for (int i = 0; i < args.Length; i++)
		{
			array[i] = args[i];
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), txtId, array);
	}

	// Token: 0x06014AA0 RID: 84640 RVA: 0x00605591 File Offset: 0x00603791
	public void SetMainTitleVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0400B02D RID: 45101
	public PopupCaptionItem CaptionItem;

	// Token: 0x0400B02E RID: 45102
	private SurvivorsRogueResidentWaveTipsPanel WaveTips;

	// Token: 0x0400B02F RID: 45103
	public SurvivorsRogueRoleStatePanel RoleStatePanel;

	// Token: 0x0400B030 RID: 45104
	private SurvivorsRogueCurrencyItem CurrencyItem;
}
