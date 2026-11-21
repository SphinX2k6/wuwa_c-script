using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x02000385 RID: 901
[NullableContext(2)]
[Nullable(0)]
public class TowerDefenseInputLayer : InputLayer
{
	// Token: 0x060031E5 RID: 12773 RVA: 0x0011E876 File Offset: 0x0011CA76
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.TowerDefense;
	}

	// Token: 0x060031E6 RID: 12774 RVA: 0x0011E87C File Offset: 0x0011CA7C
	public override SInputCommand HandlePress(CSharpScript.Game.Input.EInputAction action, float time)
	{
		switch (action)
		{
		case 1:
		{
			FGameplayTag tagValue = default(FGameplayTag);
			return new SInputCommand
			{
				CommandType = ECommandType.Jump,
				IntValue = 1,
				TagValue = tagValue
			};
		}
		case 3:
			return null;
		case 4:
			this.ExecShootAction(EKSC_OperateType.OnPress, time);
			return InputLayer.GetSwallowCommand();
		case 5:
		{
			FGameplayTag tagValue2 = default(FGameplayTag);
			return new SInputCommand
			{
				CommandType = ECommandType.Sprint,
				IntValue = 1,
				TagValue = tagValue2
			};
		}
		case 7:
			this.TriggerUseItemAction();
			return InputLayer.GetSwallowCommand();
		}
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x060031E7 RID: 12775 RVA: 0x0011E928 File Offset: 0x0011CB28
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

	// Token: 0x060031E8 RID: 12776 RVA: 0x0011E968 File Offset: 0x0011CB68
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

	// Token: 0x060031E9 RID: 12777 RVA: 0x0011E9A5 File Offset: 0x0011CBA5
	private void ExecShootAction(EKSC_OperateType operateType, float time)
	{
		TowerDefensePlayerController.HandleTowerDefenseCommit(operateType, time);
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x0011E9AE File Offset: 0x0011CBAE
	private void ExecUseItemAction()
	{
		if (!this.IsInLongTimeUseItem)
		{
			TowerDefensePlayerController.HandleUseItem();
		}
		this.IsInLongTimeUseItem = false;
	}

	// Token: 0x060031EB RID: 12779 RVA: 0x0011E9C4 File Offset: 0x0011CBC4
	private void TriggerUseItemAction()
	{
		this.IsInLongTimeUseItem = false;
	}

	// Token: 0x060031EC RID: 12780 RVA: 0x0011E9CD File Offset: 0x0011CBCD
	private void CancelUseItemAction()
	{
		if (Info.Instance.IsInTouch())
		{
			this.IsInLongTimeUseItem = true;
		}
	}

	// Token: 0x04002B7C RID: 11132
	private bool IsInLongTimeUseItem;
}
