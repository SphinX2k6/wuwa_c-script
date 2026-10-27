using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028BA RID: 10426
public class RoleSkillInputView : UiViewBase
{
	// Token: 0x06015802 RID: 88066 RVA: 0x0056C391 File Offset: 0x0056A591
	[NullableContext(1)]
	public RoleSkillInputView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015803 RID: 88067 RVA: 0x0056C39A File Offset: 0x0056A59A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06015804 RID: 88068 RVA: 0x0056C3D4 File Offset: 0x0056A5D4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillInputView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillInputView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015805 RID: 88069 RVA: 0x0056C417 File Offset: 0x0056A617
	private void OnBtnCloseClick()
	{
		UiManager.Instance.CloseView(EUiViewName.RoleSkillInputView, null);
	}

	// Token: 0x0400A03D RID: 41021
	[Nullable(2)]
	private RoleSkillInputPanel SkillInputPanel;

	// Token: 0x0400A03E RID: 41022
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x02008EBD RID: 36541
	private enum EComponent
	{
		// Token: 0x0402E496 RID: 189590
		CaptionItem,
		// Token: 0x0402E497 RID: 189591
		RoleSkillInputPanel
	}
}
