using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200052D RID: 1325
public class GuessJokerSkillItem : UiPanelBase
{
	// Token: 0x0600408B RID: 16523 RVA: 0x00169B91 File Offset: 0x00167D91
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600408C RID: 16524 RVA: 0x00169BB4 File Offset: 0x00167DB4
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerSkillItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerSkillItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600408D RID: 16525 RVA: 0x00169BF7 File Offset: 0x00167DF7
	protected override void OnStart()
	{
		this.ActionItem.SetFunction(delegate(bool? b)
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		});
	}

	// Token: 0x0600408E RID: 16526 RVA: 0x00169C10 File Offset: 0x00167E10
	[NullableContext(1)]
	public void BindClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0600408F RID: 16527 RVA: 0x00169C19 File Offset: 0x00167E19
	[NullableContext(1)]
	public void SetText(string text)
	{
		this.ActionItem.SetToggleText(text);
	}

	// Token: 0x0400330D RID: 13069
	[Nullable(2)]
	private ToggleActionItem ActionItem;

	// Token: 0x0400330E RID: 13070
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x02006808 RID: 26632
	private static class EComponentDefine
	{
		// Token: 0x040224CE RID: 140494
		public const int Interaction = 0;
	}
}
