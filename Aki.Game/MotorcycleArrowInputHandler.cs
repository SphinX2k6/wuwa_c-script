using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x02000342 RID: 834
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowInputHandler : IInputHandler
{
	// Token: 0x06002EDB RID: 11995 RVA: 0x00112AF8 File Offset: 0x00110CF8
	public void Init()
	{
		this.InputGroup = new InputFilter(InputFilterManager.CharacterActions, null, InputFilterManager.CharacterAxes, null);
	}

	// Token: 0x06002EDC RID: 11996 RVA: 0x00112B11 File Offset: 0x00110D11
	public int GetPriority()
	{
		return 100;
	}

	// Token: 0x06002EDD RID: 11997 RVA: 0x00112B15 File Offset: 0x00110D15
	public InputFilter GetInputFilter()
	{
		if (this.InputGroup == null)
		{
			this.Init();
		}
		return this.InputGroup;
	}

	// Token: 0x06002EDE RID: 11998 RVA: 0x00112B2C File Offset: 0x00110D2C
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

	// Token: 0x06002EDF RID: 11999 RVA: 0x00112B82 File Offset: 0x00110D82
	public void HandleReleaseEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
	}

	// Token: 0x06002EE0 RID: 12000 RVA: 0x00112B84 File Offset: 0x00110D84
	public void HandleHoldEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
	}

	// Token: 0x06002EE1 RID: 12001 RVA: 0x00112B86 File Offset: 0x00110D86
	public void HandleInputAxis(EInputAxis axis, float value)
	{
		if (axis == EInputAxis.MoveRight)
		{
			this.AxisValues[axis] = value;
		}
	}

	// Token: 0x06002EE2 RID: 12002 RVA: 0x00112BA2 File Offset: 0x00110DA2
	public void ClearInputAxis(bool nextFrame)
	{
		this.AxisValues.Clear();
	}

	// Token: 0x06002EE3 RID: 12003 RVA: 0x00112BAF File Offset: 0x00110DAF
	public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
	{
		if (this.AxisValues.ContainsKey(axis))
		{
			this.AxisValues.Remove(axis);
		}
	}

	// Token: 0x06002EE4 RID: 12004 RVA: 0x00112BCC File Offset: 0x00110DCC
	public void PreProcessInput(float deltaTime, bool gamePaused)
	{
	}

	// Token: 0x06002EE5 RID: 12005 RVA: 0x00112BD0 File Offset: 0x00110DD0
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

	// Token: 0x06002EE6 RID: 12006 RVA: 0x00112C70 File Offset: 0x00110E70
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

	// Token: 0x04002A48 RID: 10824
	private const int MOTORARROW_PRIORITY = 100;

	// Token: 0x04002A49 RID: 10825
	[Nullable(2)]
	protected InputFilter InputGroup;

	// Token: 0x04002A4A RID: 10826
	protected readonly Dictionary<EInputAxis, float> AxisValues = new Dictionary<EInputAxis, float>();

	// Token: 0x04002A4B RID: 10827
	private readonly List<InputEvent> InputEvents = new List<InputEvent>();

	// Token: 0x04002A4C RID: 10828
	private int InputEventIdCounter;
}
