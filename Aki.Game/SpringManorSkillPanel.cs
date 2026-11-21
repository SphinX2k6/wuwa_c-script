using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011D9 RID: 4569
public class SpringManorSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600B552 RID: 46418 RVA: 0x00359228 File Offset: 0x00357428
	protected override void OnRegisterComponent()
	{
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		if (!Info.Instance.IsInTouch())
		{
			list.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			list.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		}
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B553 RID: 46419 RVA: 0x003592A8 File Offset: 0x003574A8
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorSkillPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorSkillPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B554 RID: 46420 RVA: 0x003592EC File Offset: 0x003574EC
	protected override void OnStart()
	{
		UUIButtonComponent button = base.GetButton(0);
		button.OnPointDownCallBack.Bind(new Action(this.OnJumpButtonPressed));
		button.OnPointUpCallBack.Bind(new Action(this.OnJumpButtonReleased));
		button.OnPointCancelCallBack.Bind(new Action(this.OnJumpButtonCancel));
		UUIButtonComponent button2 = base.GetButton(1);
		button2.OnPointDownCallBack.Bind(new Action(this.OnRunButtonPressed));
		button2.OnPointUpCallBack.Bind(new Action(this.OnRunButtonReleased));
		button2.OnPointCancelCallBack.Bind(new Action(this.OnRunButtonCancel));
		InputMultiKeyItem jumpKeyItem = this.JumpKeyItem;
		if (jumpKeyItem != null)
		{
			jumpKeyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = "跳跃"
			}, false);
		}
		InputMultiKeyItem jumpKeyItem2 = this.JumpKeyItem;
		if (jumpKeyItem2 != null)
		{
			jumpKeyItem2.SetUiActive(true);
		}
		InputMultiKeyItem runKeyItem = this.RunKeyItem;
		if (runKeyItem != null)
		{
			runKeyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = "闪避"
			}, false);
		}
		InputMultiKeyItem runKeyItem2 = this.RunKeyItem;
		if (runKeyItem2 == null)
		{
			return;
		}
		runKeyItem2.SetUiActive(true);
	}

	// Token: 0x0600B555 RID: 46421 RVA: 0x003593F6 File Offset: 0x003575F6
	private void OnJumpButtonPressed()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Press);
	}

	// Token: 0x0600B556 RID: 46422 RVA: 0x00359408 File Offset: 0x00357608
	private void OnJumpButtonCancel()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Release);
	}

	// Token: 0x0600B557 RID: 46423 RVA: 0x0035941A File Offset: 0x0035761A
	private void OnJumpButtonReleased()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Release);
	}

	// Token: 0x0600B558 RID: 46424 RVA: 0x0035942C File Offset: 0x0035762C
	private void OnRunButtonPressed()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Press);
	}

	// Token: 0x0600B559 RID: 46425 RVA: 0x0035943E File Offset: 0x0035763E
	private void OnRunButtonCancel()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Release);
	}

	// Token: 0x0600B55A RID: 46426 RVA: 0x00359450 File Offset: 0x00357650
	private void OnRunButtonReleased()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Release);
	}

	// Token: 0x040068DE RID: 26846
	[Nullable(2)]
	private InputMultiKeyItem JumpKeyItem;

	// Token: 0x040068DF RID: 26847
	[Nullable(2)]
	private InputMultiKeyItem RunKeyItem;

	// Token: 0x02007490 RID: 29840
	private static class EComp
	{
		// Token: 0x04025EF5 RID: 155381
		public const int BtnJump = 0;

		// Token: 0x04025EF6 RID: 155382
		public const int BtnRun = 1;

		// Token: 0x04025EF7 RID: 155383
		public const int JumpKey = 2;

		// Token: 0x04025EF8 RID: 155384
		public const int RunKey = 3;
	}
}
