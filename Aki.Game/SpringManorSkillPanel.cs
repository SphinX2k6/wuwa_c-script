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

// Token: 0x02001D17 RID: 7447
public class SpringManorSkillPanel : BattleChildViewPanel
{
	// Token: 0x0600E135 RID: 57653 RVA: 0x0034D7F8 File Offset: 0x0034B9F8
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

	// Token: 0x0600E136 RID: 57654 RVA: 0x0034D878 File Offset: 0x0034BA78
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorSkillPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorSkillPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E137 RID: 57655 RVA: 0x0034D8BC File Offset: 0x0034BABC
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

	// Token: 0x0600E138 RID: 57656 RVA: 0x0034D9C6 File Offset: 0x0034BBC6
	private void OnJumpButtonPressed()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Press);
	}

	// Token: 0x0600E139 RID: 57657 RVA: 0x0034D9D8 File Offset: 0x0034BBD8
	private void OnJumpButtonCancel()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Release);
	}

	// Token: 0x0600E13A RID: 57658 RVA: 0x0034D9EA File Offset: 0x0034BBEA
	private void OnJumpButtonReleased()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.跳跃, EInputState.Release);
	}

	// Token: 0x0600E13B RID: 57659 RVA: 0x0034D9FC File Offset: 0x0034BBFC
	private void OnRunButtonPressed()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Press);
	}

	// Token: 0x0600E13C RID: 57660 RVA: 0x0034DA0E File Offset: 0x0034BC0E
	private void OnRunButtonCancel()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Release);
	}

	// Token: 0x0600E13D RID: 57661 RVA: 0x0034DA20 File Offset: 0x0034BC20
	private void OnRunButtonReleased()
	{
		InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Release);
	}

	// Token: 0x040067FF RID: 26623
	[Nullable(2)]
	private InputMultiKeyItem JumpKeyItem;

	// Token: 0x04006800 RID: 26624
	[Nullable(2)]
	private InputMultiKeyItem RunKeyItem;

	// Token: 0x02008307 RID: 33543
	private static class EComp
	{
		// Token: 0x0402ABCD RID: 175053
		public const int BtnJump = 0;

		// Token: 0x0402ABCE RID: 175054
		public const int BtnRun = 1;

		// Token: 0x0402ABCF RID: 175055
		public const int JumpKey = 2;

		// Token: 0x0402ABD0 RID: 175056
		public const int RunKey = 3;
	}
}
