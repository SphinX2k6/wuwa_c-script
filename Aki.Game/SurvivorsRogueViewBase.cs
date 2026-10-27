using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B69 RID: 11113
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueViewBase : UiPanelBase
{
	// Token: 0x0601706A RID: 94314 RVA: 0x005D88D0 File Offset: 0x005D6AD0
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

	// Token: 0x0601706B RID: 94315 RVA: 0x005D8990 File Offset: 0x005D6B90
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueViewBase.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueViewBase.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601706C RID: 94316 RVA: 0x005D89D3 File Offset: 0x005D6BD3
	private void OnBtnHelp()
	{
		SurvivorsRogueController.Instance.OpenRogueHelp();
	}

	// Token: 0x0601706D RID: 94317 RVA: 0x005D89DF File Offset: 0x005D6BDF
	private void OnBackBtnClick()
	{
		SurvivorsRogueController.Instance.OpenLeaveInstanceView();
	}

	// Token: 0x0601706E RID: 94318 RVA: 0x005D89EC File Offset: 0x005D6BEC
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

	// Token: 0x0601706F RID: 94319 RVA: 0x005D8A29 File Offset: 0x005D6C29
	public void SetMainTitleVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0400AC27 RID: 44071
	public PopupCaptionItem CaptionItem;

	// Token: 0x0400AC28 RID: 44072
	private SurvivorsRogueResidentWaveTipsPanel WaveTips;

	// Token: 0x0400AC29 RID: 44073
	public SurvivorsRogueRoleStatePanel RoleStatePanel;

	// Token: 0x0400AC2A RID: 44074
	private SurvivorsRogueCurrencyItem CurrencyItem;
}
