using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02001CA9 RID: 7337
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetController : ControllerBase
{
	// Token: 0x0600DD81 RID: 56705 RVA: 0x0033D030 File Offset: 0x0033B230
	protected override bool OnInit()
	{
		this.GameBudgetModes.Add(EGameBudgetMode.Normal, new GameBudgetNormalMode());
		this.GameBudgetModes.Add(EGameBudgetMode.Plot, new GameBudgetPlotMode());
		this.GameBudgetModes.Add(EGameBudgetMode.StreamingSource, new GameBudgetStreamingSourceMode());
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleRefreshGameBudgetCenterRole));
		EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnCameraModelChange));
		return base.OnInit();
	}

	// Token: 0x0600DD82 RID: 56706 RVA: 0x0033D0B0 File Offset: 0x0033B2B0
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleRefreshGameBudgetCenterRole));
		EventSystem.Instance.Remove<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnCameraModelChange));
		this.CurrentMode = null;
		this.GameBudgetModes.Clear();
		return base.OnClear();
	}

	// Token: 0x0600DD83 RID: 56707 RVA: 0x0033D10D File Offset: 0x0033B30D
	private void OnChangeRoleRefreshGameBudgetCenterRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		this.SetCenterRole(Global.BaseCharacter);
	}

	// Token: 0x0600DD84 RID: 56708 RVA: 0x0033D11A File Offset: 0x0033B31A
	private void OnCameraModelChange(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName)
	{
		if (cameraName != "MainCamera")
		{
			return;
		}
		if (newMode == ECustomCameraMode.Sequence && PlotModel.Instance.IsInPlot)
		{
			this.SetModel(EGameBudgetMode.Plot);
			return;
		}
		this.SetModel(EGameBudgetMode.Normal);
	}

	// Token: 0x0600DD85 RID: 56709 RVA: 0x0033D14C File Offset: 0x0033B34C
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

	// Token: 0x0600DD86 RID: 56710 RVA: 0x0033D198 File Offset: 0x0033B398
	public void OpenStreamingSourceMode()
	{
		GameBudgetMode mode = this.GetMode(EGameBudgetMode.StreamingSource);
		if (mode != null)
		{
			Log.Instance.Info(ELogModule.Game, ELogAuthor.LC, "[GameBudget]开启流送源模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CurrentMode = mode;
			GameBudgetInterfaceController.Instance.OnBudgetModelChange(mode);
		}
	}

	// Token: 0x0600DD87 RID: 56711 RVA: 0x0033D1E0 File Offset: 0x0033B3E0
	public void CloseStreamingSourceMode()
	{
		GameBudgetMode gameBudgetMode;
		if (this.GameBudgetModes.TryGetValue(EGameBudgetMode.Normal, out gameBudgetMode))
		{
			Log.Instance.Info(ELogModule.Game, ELogAuthor.LC, "[GameBudget]关闭流送源模式, 切回普通模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CurrentMode = gameBudgetMode;
			GameBudgetInterfaceController.Instance.OnBudgetModelChange(gameBudgetMode);
		}
	}

	// Token: 0x0600DD88 RID: 56712 RVA: 0x0033D22B File Offset: 0x0033B42B
	private bool CheckCanSwitchMode()
	{
		return this.CurrentMode == null || this.CurrentMode.AllowSwitchMode();
	}

	// Token: 0x0600DD89 RID: 56713 RVA: 0x0033D242 File Offset: 0x0033B442
	private bool CheckCanSetCenterActor()
	{
		return this.CurrentMode == null || this.CurrentMode.AllowSetCenterActor();
	}

	// Token: 0x0600DD8A RID: 56714 RVA: 0x0033D259 File Offset: 0x0033B459
	private bool CheckCanSetCenterOffset()
	{
		return this.CurrentMode == null || this.CurrentMode.AllowSetCenterOffset();
	}

	// Token: 0x0600DD8B RID: 56715 RVA: 0x0033D270 File Offset: 0x0033B470
	public void SetCenterRole(AActor centerActor)
	{
		if (centerActor == null)
		{
			return;
		}
		if (!this.CheckCanSetCenterActor())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LC;
			string message = "[GameBudget]当前模式不允许自由设置CenterActor";
			string item = "CurrentMode";
			GameBudgetMode currentMode = this.CurrentMode;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentMode != null) ? currentMode.GameBudgetModeName : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FVectorDouble? offset = null;
		if (centerActor is TsBaseCharacter)
		{
			CreatureModel instance2 = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance2 == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityById = instance2.GetEntityById(((TsBaseCharacter)centerActor).EntityId);
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

	// Token: 0x0600DD8C RID: 56716 RVA: 0x0033D328 File Offset: 0x0033B528
	private void SetModel(EGameBudgetMode newModel)
	{
		if (!this.CheckCanSwitchMode())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LC;
			string message = "[GameBudget]当前模式不允许自由切换其他模式";
			string item = "CurrentMode";
			GameBudgetMode currentMode = this.CurrentMode;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentMode != null) ? currentMode.GameBudgetModeName : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		GameBudgetMode gameBudgetMode;
		if (this.GameBudgetModes.TryGetValue(newModel, out gameBudgetMode))
		{
			GameBudgetInterfaceController.Instance.OnBudgetModelChange(gameBudgetMode);
			this.CurrentMode = gameBudgetMode;
		}
	}

	// Token: 0x0600DD8D RID: 56717 RVA: 0x0033D398 File Offset: 0x0033B598
	public void SetCenterOffset(FVectorDouble offset)
	{
		if (!this.CheckCanSetCenterOffset())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LC;
			string message = "[GameBudget]当前模式不允许自由设置CenterOffset";
			string item = "CurrentMode";
			GameBudgetMode currentMode = this.CurrentMode;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentMode != null) ? currentMode.GameBudgetModeName : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		GameBudgetInterfaceController.Instance.OnChangeCenterRole(null, new FVectorDouble?(offset));
	}

	// Token: 0x170011FE RID: 4606
	// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x0033D3F7 File Offset: 0x0033B5F7
	public static GameBudgetController Instance
	{
		get
		{
			return GameBudgetController._Instance;
		}
	}

	// Token: 0x0600DD8F RID: 56719 RVA: 0x0033D3FE File Offset: 0x0033B5FE
	public static GameBudgetController GetOrCreateInstance()
	{
		if (GameBudgetController._Instance == null)
		{
			GameBudgetController.CreateInstance();
		}
		return GameBudgetController._Instance;
	}

	// Token: 0x0600DD90 RID: 56720 RVA: 0x0033D412 File Offset: 0x0033B612
	public static bool CreateInstance()
	{
		if (GameBudgetController._Instance != null)
		{
			return true;
		}
		GameBudgetController._Instance = new GameBudgetController();
		return true;
	}

	// Token: 0x0600DD91 RID: 56721 RVA: 0x0033D428 File Offset: 0x0033B628
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DD92 RID: 56722 RVA: 0x0033D42A File Offset: 0x0033B62A
	public static void ResetStaticDefaultValue()
	{
		GameBudgetController._Instance = null;
	}

	// Token: 0x0600DD93 RID: 56723 RVA: 0x0033D432 File Offset: 0x0033B632
	static GameBudgetController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameBudgetController.CreateStaticDefaultValue), new Action(GameBudgetController.ResetStaticDefaultValue));
	}

	// Token: 0x040065BC RID: 26044
	private readonly Dictionary<EGameBudgetMode, GameBudgetMode> GameBudgetModes = new Dictionary<EGameBudgetMode, GameBudgetMode>();

	// Token: 0x040065BD RID: 26045
	[Nullable(2)]
	private GameBudgetMode CurrentMode;

	// Token: 0x040065BE RID: 26046
	[Nullable(2)]
	private static GameBudgetController _Instance;
}
