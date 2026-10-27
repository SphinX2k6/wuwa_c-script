using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x02000ED0 RID: 3792
[NullableContext(2)]
[Nullable(0)]
public class TowerDefenseInputLayer : InputLayer
{
	// Token: 0x06005E4E RID: 24142 RVA: 0x00116BBE File Offset: 0x00114DBE
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.TowerDefense;
	}

	// Token: 0x06005E4F RID: 24143 RVA: 0x00116BC4 File Offset: 0x00114DC4
	public override SInputCommand HandlePress(CSharpScript.Game.Input.EInputAction action, float time)
	{
		switch (action)
		{
		case 1:
		{
			FGameplayTag tagValue = default(FGameplayTag);
			return new SInputCommand(ECommandType.Jump, 1, tagValue);
		}
		case 3:
			return null;
		case 4:
			this.ExecShootAction(EKSC_OperateType.OnPress, time);
			return InputLayer.GetSwallowCommand();
		case 5:
		{
			FGameplayTag tagValue2 = default(FGameplayTag);
			return new SInputCommand(ECommandType.Sprint, 1, tagValue2);
		}
		case 7:
			this.TriggerUseItemAction();
			return InputLayer.GetSwallowCommand();
		}
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005E50 RID: 24144 RVA: 0x00116C4C File Offset: 0x00114E4C
	public override SInputCommand HandleRelease(CSharpScript.Game.Input.EInputAction action, float time)
	{
		byte b = action;
		if (b == 4)
		{
			this.ExecShootAction(EKSC_OperateType.OnRelease, time);
			return InputLayer.GetSwallowCommand();
		}
		if (b != 7)
		{
			return InputLayer.GetSwallowCommand();
		}
		this.ExecUseItemAction();
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005E51 RID: 24145 RVA: 0x00116C8C File Offset: 0x00114E8C
	public override SInputCommand HandleHold(CSharpScript.Game.Input.EInputAction action, float time)
	{
		byte b = action;
		if (b == 4)
		{
			this.ExecShootAction(EKSC_OperateType.OnHold, time);
			return InputLayer.GetSwallowCommand();
		}
		if (b != 7)
		{
			return InputLayer.GetSwallowCommand();
		}
		this.CancelUseItemAction();
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x06005E52 RID: 24146 RVA: 0x00116CC9 File Offset: 0x00114EC9
	private void ExecShootAction(EKSC_OperateType operateType, float time)
	{
		TowerDefensePlayerController.HandleTowerDefenseCommit(operateType, time);
	}

	// Token: 0x06005E53 RID: 24147 RVA: 0x00116CD2 File Offset: 0x00114ED2
	private void ExecUseItemAction()
	{
		if (!this.IsInLongTimeUseItem)
		{
			TowerDefensePlayerController.HandleUseItem();
		}
		this.IsInLongTimeUseItem = false;
	}

	// Token: 0x06005E54 RID: 24148 RVA: 0x00116CE8 File Offset: 0x00114EE8
	private void TriggerUseItemAction()
	{
		this.IsInLongTimeUseItem = false;
	}

	// Token: 0x06005E55 RID: 24149 RVA: 0x00116CF1 File Offset: 0x00114EF1
	private void CancelUseItemAction()
	{
		if (Info.Instance.IsInTouch())
		{
			this.IsInLongTimeUseItem = true;
		}
	}

	// Token: 0x04002AE1 RID: 10977
	private bool IsInLongTimeUseItem;
}
