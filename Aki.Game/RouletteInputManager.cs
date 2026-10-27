using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002930 RID: 10544
public class RouletteInputManager : IStaticVariableResetter
{
	// Token: 0x06015C1C RID: 89116 RVA: 0x0057CF17 File Offset: 0x0057B117
	static RouletteInputManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteInputManager.CreateStaticDefaultValue), new Action(RouletteInputManager.ResetStaticDefaultValue));
	}

	// Token: 0x06015C1D RID: 89117 RVA: 0x0057CF38 File Offset: 0x0057B138
	public static void CreateStaticDefaultValue()
	{
		Dictionary<EInputControllerMainType, Func<Vector2D, ERouletteViewType?, int?, float?, RouletteInputBase>> dictionary = new Dictionary<EInputControllerMainType, Func<Vector2D, ERouletteViewType?, int?, float?, RouletteInputBase>>();
		dictionary.Add(EInputControllerMainType.None, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputKeyboard(beginPos, viewType, touchId, deadLimit));
		dictionary.Add(EInputControllerMainType.Keyboard, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputKeyboard(beginPos, viewType, touchId, deadLimit));
		dictionary.Add(EInputControllerMainType.Gamepad, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputGamepad(beginPos, viewType, touchId, deadLimit));
		dictionary.Add(EInputControllerMainType.Touch, ([Nullable(2)] Vector2D beginPos, ERouletteViewType? viewType, int? touchId, float? deadLimit) => new RouletteInputTouch(beginPos, viewType, touchId, deadLimit));
		RouletteInputManager.InputManagerFactory = dictionary;
	}

	// Token: 0x06015C1E RID: 89118 RVA: 0x0057CFE7 File Offset: 0x0057B1E7
	public static void ResetStaticDefaultValue()
	{
		RouletteInputManager.InputManagerFactory = null;
	}

	// Token: 0x06015C1F RID: 89119 RVA: 0x0057CFF0 File Offset: 0x0057B1F0
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

	// Token: 0x0400A20F RID: 41487
	public const int KEYBOARD_DEAD_LIMIT = 100;

	// Token: 0x0400A210 RID: 41488
	[Nullable(new byte[]
	{
		1,
		1,
		2,
		1
	})]
	private static Dictionary<EInputControllerMainType, Func<Vector2D, ERouletteViewType?, int?, float?, RouletteInputBase>> InputManagerFactory;
}
