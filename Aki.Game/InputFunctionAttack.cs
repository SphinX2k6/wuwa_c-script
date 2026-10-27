using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game;

// Token: 0x020030B1 RID: 12465
[NullableContext(1)]
[Nullable(0)]
public static class InputFunctionAttack
{
	// Token: 0x0601AB50 RID: 109392 RVA: 0x00731C2C File Offset: 0x0072FE2C
	[return: Nullable(2)]
	private static SInputCommand AttackFunction(float time, BP_InputComponent_C bpInputComp)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return null;
		}
		CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			return null;
		}
		BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		bpInputComp.通用_攻击按下 = false;
		InputFunctionCommon.IInputCommandTransformResult inputCommandTransformResult = InputFunctionCommon.CreateInputCommandFromDataTable(entity.Id, EInputAction.攻击, EInputState.Press);
		if (inputCommandTransformResult != null)
		{
			bpInputComp.通用_攻击按下 = true;
			return inputCommandTransformResult.Command;
		}
		return null;
	}

	// Token: 0x0601AB51 RID: 109393 RVA: 0x00731C97 File Offset: 0x0072FE97
	[return: Nullable(2)]
	public static SInputCommand AttackOnPress(float time, BP_InputComponent_C bpInputComp)
	{
		return InputFunctionAttack.AttackFunction(time, bpInputComp);
	}

	// Token: 0x0601AB52 RID: 109394 RVA: 0x00731CA0 File Offset: 0x0072FEA0
	[return: Nullable(2)]
	public static SInputCommand AttackOnRelease(float time, BP_InputComponent_C bpInputComp)
	{
		return null;
	}
}
