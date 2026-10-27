using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001079 RID: 4217
public class GuessJokerSkillItem : UiPanelBase
{
	// Token: 0x06006CF6 RID: 27894 RVA: 0x0016125D File Offset: 0x0015F45D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06006CF7 RID: 27895 RVA: 0x00161280 File Offset: 0x0015F480
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerSkillItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerSkillItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006CF8 RID: 27896 RVA: 0x001612C3 File Offset: 0x0015F4C3
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

	// Token: 0x06006CF9 RID: 27897 RVA: 0x001612DC File Offset: 0x0015F4DC
	[NullableContext(1)]
	public void BindClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06006CFA RID: 27898 RVA: 0x001612E5 File Offset: 0x0015F4E5
	[NullableContext(1)]
	public void SetText(string text)
	{
		this.ActionItem.SetToggleText(text);
	}

	// Token: 0x04003274 RID: 12916
	[Nullable(2)]
	private ToggleActionItem ActionItem;

	// Token: 0x04003275 RID: 12917
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x02007674 RID: 30324
	private static class EComponentDefine
	{
		// Token: 0x04027183 RID: 160131
		public const int Interaction = 0;
	}
}
