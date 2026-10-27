using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x02000E8D RID: 3725
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowInputHandler : IInputHandler
{
	// Token: 0x06005B44 RID: 23364 RVA: 0x0010AE60 File Offset: 0x00109060
	public void Init()
	{
		this.InputGroup = new InputFilter(InputFilterManager.CharacterActions, null, InputFilterManager.CharacterAxes, null);
	}

	// Token: 0x06005B45 RID: 23365 RVA: 0x0010AE79 File Offset: 0x00109079
	public int GetPriority()
	{
		return 100;
	}

	// Token: 0x06005B46 RID: 23366 RVA: 0x0010AE7D File Offset: 0x0010907D
	public InputFilter GetInputFilter()
	{
		if (this.InputGroup == null)
		{
			this.Init();
		}
		return this.InputGroup;
	}

	// Token: 0x06005B47 RID: 23367 RVA: 0x0010AE94 File Offset: 0x00109094
	public void HandlePressEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		BattleInputModel instance = BattleInputModel.Instance;
		if (instance == null || !instance.GetInputEnable(action))
		{
			return;
		}
		InputEvent inputEvent = new InputEvent(action, EInputState.Press, time, 0f);
		InputEvent inputEvent2 = inputEvent;
		int inputEventIdCounter = this.InputEventIdCounter;
		this.InputEventIdCounter = inputEventIdCounter + 1;
		inputEvent2.Id = inputEventIdCounter;
		this.InputEvents.Add(inputEvent);
	}

	// Token: 0x06005B48 RID: 23368 RVA: 0x0010AEEA File Offset: 0x001090EA
	public void HandleReleaseEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
	}

	// Token: 0x06005B49 RID: 23369 RVA: 0x0010AEEC File Offset: 0x001090EC
	public void HandleHoldEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
	}

	// Token: 0x06005B4A RID: 23370 RVA: 0x0010AEEE File Offset: 0x001090EE
	public void HandleInputAxis(EInputAxis axis, float value)
	{
		if (axis == EInputAxis.MoveRight)
		{
			this.AxisValues[axis] = value;
		}
	}

	// Token: 0x06005B4B RID: 23371 RVA: 0x0010AF0A File Offset: 0x0010910A
	public void ClearInputAxis(bool nextFrame)
	{
		this.AxisValues.Clear();
	}

	// Token: 0x06005B4C RID: 23372 RVA: 0x0010AF17 File Offset: 0x00109117
	public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
	{
		if (this.AxisValues.ContainsKey(axis))
		{
			this.AxisValues.Remove(axis);
		}
	}

	// Token: 0x06005B4D RID: 23373 RVA: 0x0010AF34 File Offset: 0x00109134
	public void PreProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x06005B4E RID: 23374 RVA: 0x0010AF38 File Offset: 0x00109138
	public void PostProcessInput(float deltaTime, bool gamePaused)
	{
		MotorcycleArrowSubController controller = this.GetController();
		if (controller == null)
		{
			return;
		}
		float num;
		float rightInput = this.AxisValues.TryGetValue(EInputAxis.MoveRight, out num) ? num : 0f;
		controller.MoveRight(rightInput, deltaTime);
		using (List<InputEvent>.Enumerator enumerator = this.InputEvents.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Action == CSharpScript.Game.Input.EInputAction.跳跃)
				{
					controller.ExecSkillAction();
				}
			}
		}
		this.InputEvents.Clear();
	}

	// Token: 0x06005B4F RID: 23375 RVA: 0x0010AFD8 File Offset: 0x001091D8
	[NullableContext(2)]
	public MotorcycleArrowSubController GetController()
	{
		KscSubControllerBase curSubController = KuroSimpleCombatController.Instance.CurSubController;
		if (curSubController == null)
		{
			return null;
		}
		return curSubController as MotorcycleArrowSubController;
	}

	// Token: 0x040029AD RID: 10669
	private const int MOTORARROW_PRIORITY = 100;

	// Token: 0x040029AE RID: 10670
	[Nullable(2)]
	protected InputFilter InputGroup;

	// Token: 0x040029AF RID: 10671
	protected readonly Dictionary<EInputAxis, float> AxisValues = new Dictionary<EInputAxis, float>();

	// Token: 0x040029B0 RID: 10672
	private readonly List<InputEvent> InputEvents = new List<InputEvent>();

	// Token: 0x040029B1 RID: 10673
	private int InputEventIdCounter;
}
