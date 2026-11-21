using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E35 RID: 7733
public class RoleSkillInputView : UiViewBase
{
	// Token: 0x06013202 RID: 78338 RVA: 0x005971D9 File Offset: 0x005953D9
	[NullableContext(1)]
	public RoleSkillInputView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013203 RID: 78339 RVA: 0x005971E2 File Offset: 0x005953E2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06013204 RID: 78340 RVA: 0x0059721C File Offset: 0x0059541C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillInputView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillInputView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013205 RID: 78341 RVA: 0x0059725F File Offset: 0x0059545F
	private void OnBtnCloseClick()
	{
		UiManager.Instance.CloseView(EUiViewName.RoleSkillInputView, null);
	}

	// Token: 0x0400A426 RID: 42022
	[Nullable(2)]
	private RoleSkillInputPanel SkillInputPanel;

	// Token: 0x0400A427 RID: 42023
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x02008104 RID: 33028
	private enum EComponent
	{
		// Token: 0x04029B93 RID: 170899
		CaptionItem,
		// Token: 0x04029B94 RID: 170900
		RoleSkillInputPanel
	}
}
