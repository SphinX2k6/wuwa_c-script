using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001EAB RID: 7851
public class RouletteInputManager : IStaticVariableResetter
{
	// Token: 0x06013621 RID: 79393 RVA: 0x005A7F57 File Offset: 0x005A6157
	static RouletteInputManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteInputManager.CreateStaticDefaultValue), new Action(RouletteInputManager.ResetStaticDefaultValue));
	}

	// Token: 0x06013622 RID: 79394 RVA: 0x005A7F78 File Offset: 0x005A6178
	public static void CreateStaticDefaultValue()
	{
		Dictionary<EInputControllerMainType, Func<Vector2D, ERouletteViewType?, int?, float?, RouletteInputBase>> dictionary = new Dictionary<EInputControllerMainType, Func<Vector2D, ERouletteViewType?, int?, float?, RouletteInputBase>>();
		dictionary.Add(EInputControllerMainType.None, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputKeyboard(beginPos, viewType, touchId, deadLimit));
		dictionary.Add(EInputControllerMainType.Keyboard, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputKeyboard(beginPos, viewType, touchId, deadLimit));
		dictionary.Add(EInputControllerMainType.Gamepad, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputGamepad(beginPos, viewType, touchId, deadLimit));
		dictionary.Add(EInputControllerMainType.Touch, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputTouch(beginPos, viewType, touchId, deadLimit));
		RouletteInputManager.InputManagerFactory = dictionary;
	}

	// Token: 0x06013623 RID: 79395 RVA: 0x005A8027 File Offset: 0x005A6227
	public static void ResetStaticDefaultValue()
	{
		RouletteInputManager.InputManagerFactory = null;
	}

	// Token: 0x06013624 RID: 79396 RVA: 0x005A8030 File Offset: 0x005A6230
	[NullableContext(1)]
	public static RouletteInputBase CreateInput(EInputControllerMainType controllerType, [Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? gamepadDeadLimit)
	{
		Func<Vector2D, ERouletteViewType?, int?, float?, RouletteInputBase> func;
		if (RouletteInputManager.InputManagerFactory.TryGetValue(controllerType, out func))
		{
			return func(beginPos, viewType, touchId, gamepadDeadLimit);
		}
		return new RouletteInputKeyboard(beginPos, viewType, touchId, gamepadDeadLimit);
	}

	// Token: 0x0400A5FA RID: 42490
	public const int KEYBOARD_DEAD_LIMIT = 100;

	// Token: 0x0400A5FB RID: 42491
	[Nullable(new byte[]
	{
		1,
		1,
		2,
		1
	})]
	private static Dictionary<EInputControllerMainType, Func<Vector2D, ERouletteViewType?, int?, float?, RouletteInputBase>> InputManagerFactory;
}
