using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02001168 RID: 4456
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetController : ControllerBase
{
	// Token: 0x17001224 RID: 4644
	// (get) Token: 0x0600B197 RID: 45463 RVA: 0x003484E7 File Offset: 0x003466E7
	[Nullable(2)]
	private GameBudgetMode CurrentMode
	{
		[NullableContext(2)]
		get
		{
			if (this.ModeStack.Count <= 0)
			{
				return null;
			}
			return this.ModeStack[this.ModeStack.Count - 1];
		}
	}

	// Token: 0x0600B198 RID: 45464 RVA: 0x00348514 File Offset: 0x00346714
	protected override bool OnInit()
	{
		this.GameBudgetModes.Add(EGameBudgetMode.Normal, new GameBudgetNormalMode());
		this.GameBudgetModes.Add(EGameBudgetMode.Plot, new GameBudgetPlotMode());
		this.GameBudgetModes.Add(EGameBudgetMode.StreamingSource, new GameBudgetStreamingSourceMode());
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleRefreshGameBudgetCenterRole));
		EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnCameraModelChange));
		return base.OnInit();
	}

	// Token: 0x0600B199 RID: 45465 RVA: 0x00348594 File Offset: 0x00346794
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleRefreshGameBudgetCenterRole));
		EventSystem.Instance.Remove<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnCameraModelChange));
		this.ClearStack();
		this.GameBudgetModes.Clear();
		return base.OnClear();
	}

	// Token: 0x0600B19A RID: 45466 RVA: 0x003485F0 File Offset: 0x003467F0
	protected override bool OnLeaveLevel()
	{
		this.ClearStack();
		return base.OnLeaveLevel();
	}

	// Token: 0x0600B19B RID: 45467 RVA: 0x00348600 File Offset: 0x00346800
	private void ClearStack()
	{
		for (int i = this.ModeStack.Count - 1; i >= 0; i--)
		{
			this.ModeStack[i].TerminateMode();
			this.ModeStack[i].LatestTokenId = 0L;
		}
		this.ModeStack.Clear();
		this.PlotModeToken = default(GameBudgetModeToken);
	}

	// Token: 0x0600B19C RID: 45468 RVA: 0x00348660 File Offset: 0x00346860
	private void OnChangeRoleRefreshGameBudgetCenterRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		this.SetCenterRole(Global.BaseCharacter);
	}

	// Token: 0x0600B19D RID: 45469 RVA: 0x00348670 File Offset: 0x00346870
	private void OnCameraModelChange(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName)
	{
		if (cameraName != "MainCamera")
		{
			return;
		}
		if (newMode == ECustomCameraMode.Sequence && PlotModel.Instance.IsInPlot)
		{
			this.PlotModeToken = this.EnterMode(EGameBudgetMode.Plot);
			return;
		}
		this.ExitMode(this.PlotModeToken);
		this.PlotModeToken = default(GameBudgetModeToken);
		this.EnsureBaseMode();
	}

	// Token: 0x0600B19E RID: 45470 RVA: 0x003486C7 File Offset: 0x003468C7
	private void EnsureBaseMode()
	{
		if (this.ModeStack.Count == 0)
		{
			this.EnterMode(EGameBudgetMode.Normal);
		}
	}

	// Token: 0x0600B19F RID: 45471 RVA: 0x003486E0 File Offset: 0x003468E0
	[NullableContext(2)]
	private GameBudgetMode GetMode(EGameBudgetMode modelEnum)
	{
		GameBudgetMode result;
		if (!this.GameBudgetModes.TryGetValue(modelEnum, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LC;
			string message = "[GameBudget]未初始化模式对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ModelEnum", modelEnum);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x0600B1A0 RID: 45472 RVA: 0x0034872C File Offset: 0x0034692C
	public GameBudgetModeToken EnterMode(EGameBudgetMode modelEnum)
	{
		GameBudgetMode mode = this.GetMode(modelEnum);
		if (mode == null)
		{
			return default(GameBudgetModeToken);
		}
		this.PushOrPromote(mode);
		GameBudgetMode gameBudgetMode = mode;
		long num = this.NextTokenId + 1L;
		this.NextTokenId = num;
		gameBudgetMode.LatestTokenId = num;
		return new GameBudgetModeToken(modelEnum, mode.LatestTokenId);
	}

	// Token: 0x0600B1A1 RID: 45473 RVA: 0x0034877C File Offset: 0x0034697C
	private unsafe void PushOrPromote(GameBudgetMode mode)
	{
		int num = this.ModeStack.IndexOf(mode);
		if (num == this.ModeStack.Count - 1 && num >= 0)
		{
			return;
		}
		if (num >= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LC;
			string message = "[GameBudget]模式重入，抽到栈顶";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Mode", mode.GameBudgetModeName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Index", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Depth", this.ModeStack.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.CurrentMode.SuspendMode();
			this.ModeStack.RemoveAt(num);
			this.ModeStack.Add(mode);
			mode.ResumeMode();
			GameBudgetInterfaceController.Instance.OnBudgetModelChange(mode);
			return;
		}
		if (mode.Mode != EGameBudgetMode.Normal)
		{
			this.EnsureBaseMode();
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Game;
		ELogAuthor author2 = ELogAuthor.LC;
		string message2 = "[GameBudget]压入模式";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Mode", mode.GameBudgetModeName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Depth", this.ModeStack.Count);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		GameBudgetMode currentMode = this.CurrentMode;
		if (currentMode != null)
		{
			currentMode.SuspendMode();
		}
		this.ModeStack.Add(mode);
		mode.EnterMode();
		GameBudgetInterfaceController.Instance.OnBudgetModelChange(mode);
	}

	// Token: 0x0600B1A2 RID: 45474 RVA: 0x00348910 File Offset: 0x00346B10
	public unsafe void ExitMode(GameBudgetModeToken token)
	{
		if (!token.IsValid)
		{
			return;
		}
		GameBudgetMode mode = this.GetMode(token.Mode);
		if (mode == null)
		{
			return;
		}
		if (mode.LatestTokenId != token.Id)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LC;
			string message = "[GameBudget]忽略过期token的退出";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Mode", mode.GameBudgetModeName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TokenId", token.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("LatestTokenId", mode.LatestTokenId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		int num = this.ModeStack.IndexOf(mode);
		if (num < 0)
		{
			mode.LatestTokenId = 0L;
			return;
		}
		if (mode.Mode == EGameBudgetMode.Normal && this.ModeStack.Count == 1)
		{
			return;
		}
		bool flag = num == this.ModeStack.Count - 1;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Game;
		ELogAuthor author2 = ELogAuthor.LC;
		string message2 = flag ? "[GameBudget]弹出栈顶模式" : "[GameBudget]从栈中间移除模式";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Mode", mode.GameBudgetModeName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Index", num);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		mode.TerminateMode();
		mode.LatestTokenId = 0L;
		this.ModeStack.RemoveAt(num);
		if (!flag)
		{
			return;
		}
		GameBudgetMode currentMode = this.CurrentMode;
		if (currentMode == null)
		{
			this.EnsureBaseMode();
			return;
		}
		currentMode.ResumeMode();
		GameBudgetInterfaceController.Instance.OnBudgetModelChange(currentMode);
	}

	// Token: 0x0600B1A3 RID: 45475 RVA: 0x00348AB8 File Offset: 0x00346CB8
	private unsafe bool CheckAllowExternalCenter(string api)
	{
		GameBudgetMode currentMode = this.CurrentMode;
		if (currentMode == null || currentMode.AllowExternalCenter)
		{
			return true;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Game;
		ELogAuthor author = ELogAuthor.LC;
		string message = "[GameBudget]栈顶模式不允许外部设置中心，已忽略";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Api", api);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Mode", currentMode.GameBudgetModeName);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return false;
	}

	// Token: 0x0600B1A4 RID: 45476 RVA: 0x00348B32 File Offset: 0x00346D32
	public void SetCenterRole(AActor centerActor)
	{
		if (!this.CheckAllowExternalCenter("SetCenterRole"))
		{
			return;
		}
		this.ApplyCenterRole(centerActor);
	}

	// Token: 0x0600B1A5 RID: 45477 RVA: 0x00348B49 File Offset: 0x00346D49
	public void SetCenterOffset(FVectorDouble offset)
	{
		if (!this.CheckAllowExternalCenter("SetCenterOffset"))
		{
			return;
		}
		GameBudgetInterfaceController.Instance.OnChangeCenterRole(null, new FVectorDouble?(offset));
	}

	// Token: 0x0600B1A6 RID: 45478 RVA: 0x00348B6C File Offset: 0x00346D6C
	[NullableContext(2)]
	internal void ApplyCenterRole(AActor centerActor)
	{
		if (centerActor == null)
		{
			return;
		}
		FVectorDouble? offset = null;
		if (centerActor is TsBaseCharacter)
		{
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityById = instance.GetEntityById(((TsBaseCharacter)centerActor).EntityId);
				worldEntity = ((entityById != null) ? entityById.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 != null)
			{
				CharacterMorphComponent component = worldEntity2.GetComponent<CharacterMorphComponent>();
				offset = ((component != null) ? component.GetCenterActorLocationOffset() : null);
			}
		}
		GameBudgetInterfaceController.Instance.OnChangeCenterRole(centerActor, offset);
	}

	// Token: 0x17001225 RID: 4645
	// (get) Token: 0x0600B1A7 RID: 45479 RVA: 0x00348BE0 File Offset: 0x00346DE0
	public static GameBudgetController Instance
	{
		get
		{
			return GameBudgetController._Instance;
		}
	}

	// Token: 0x0600B1A8 RID: 45480 RVA: 0x00348BE7 File Offset: 0x00346DE7
	public static GameBudgetController GetOrCreateInstance()
	{
		if (GameBudgetController._Instance == null)
		{
			GameBudgetController.CreateInstance();
		}
		return GameBudgetController._Instance;
	}

	// Token: 0x0600B1A9 RID: 45481 RVA: 0x00348BFB File Offset: 0x00346DFB
	public static bool CreateInstance()
	{
		if (GameBudgetController._Instance != null)
		{
			return true;
		}
		GameBudgetController._Instance = new GameBudgetController();
		return true;
	}

	// Token: 0x0600B1AA RID: 45482 RVA: 0x00348C11 File Offset: 0x00346E11
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B1AB RID: 45483 RVA: 0x00348C13 File Offset: 0x00346E13
	public static void ResetStaticDefaultValue()
	{
		GameBudgetController._Instance = null;
	}

	// Token: 0x0600B1AC RID: 45484 RVA: 0x00348C1B File Offset: 0x00346E1B
	static GameBudgetController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameBudgetController.CreateStaticDefaultValue), new Action(GameBudgetController.ResetStaticDefaultValue));
	}

	// Token: 0x0400668D RID: 26253
	private readonly Dictionary<EGameBudgetMode, GameBudgetMode> GameBudgetModes = new Dictionary<EGameBudgetMode, GameBudgetMode>();

	// Token: 0x0400668E RID: 26254
	private readonly List<GameBudgetMode> ModeStack = new List<GameBudgetMode>();

	// Token: 0x0400668F RID: 26255
	private long NextTokenId;

	// Token: 0x04006690 RID: 26256
	private GameBudgetModeToken PlotModeToken;

	// Token: 0x04006691 RID: 26257
	[Nullable(2)]
	private static GameBudgetController _Instance;
}
