using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA5 RID: 16293
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotBlendController : ControllerBase
	{
		// Token: 0x06029378 RID: 168824 RVA: 0x00B93076 File Offset: 0x00B91276
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (!this.IsInProtectTime)
			{
				this.EndBlendOutSwitchPose();
			}
		}

		// Token: 0x06029379 RID: 168825 RVA: 0x00B9308A File Offset: 0x00B9128A
		private void OnInputMoveAxis(string axisName, float axisValue, InputIdentification inputIdentification)
		{
			if (Math.Abs(axisValue) < 0.1f)
			{
				return;
			}
			if (!this.IsInProtectTime)
			{
				this.EndBlendOutSwitchPose();
			}
		}

		// Token: 0x0602937A RID: 168826 RVA: 0x00B930A8 File Offset: 0x00B912A8
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602937B RID: 168827 RVA: 0x00B930AC File Offset: 0x00B912AC
		protected override bool OnClear()
		{
			PlotModel.Instance.IsBlendProcessing = false;
			this.ClearProtectTime();
			this.ClearAnimEndTimer();
			this.CurrentBlendInfo = null;
			this.TriggerSourceId = null;
			this.SetupInfoExecuted = false;
			this.PreloadedAnimationAssets.Clear();
			foreach (KeyValuePair<string, CustomPromise<bool>> keyValuePair in this.PreloadPromises)
			{
				keyValuePair.Value.SetResult(false);
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[PlotBlend] 取消预加载Promise";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", keyValuePair.Key);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.PreloadPromises.Clear();
			return true;
		}

		// Token: 0x0602937C RID: 168828 RVA: 0x00B93174 File Offset: 0x00B91374
		protected override void OnTick(float delta)
		{
			bool isBlendProcessing = PlotModel.Instance.IsBlendProcessing;
		}

		// Token: 0x0602937D RID: 168829 RVA: 0x00B93181 File Offset: 0x00B91381
		protected override void OnAfterTick(float delta)
		{
		}

		// Token: 0x0602937E RID: 168830 RVA: 0x00B93184 File Offset: 0x00B91384
		protected override bool OnLeaveLevel()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] PlotBlendController 离开关卡", default(ReadOnlySpan<ValueTuple<string, object>>));
			PlotModel.Instance.IsBlendProcessing = false;
			this.ClearProtectTime();
			this.ClearAnimEndTimer();
			this.CurrentBlendInfo = null;
			this.TriggerSourceId = null;
			this.SetupInfoExecuted = false;
			this.PreloadedAnimationAssets.Clear();
			this.PreloadPromises.Clear();
			return true;
		}

		// Token: 0x0602937F RID: 168831 RVA: 0x00B931F0 File Offset: 0x00B913F0
		protected override bool OnChangeMode()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] PlotBlendController 改变模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06029380 RID: 168832 RVA: 0x00B9321C File Offset: 0x00B9141C
		public void SetupInfo(SetBlendAnim blendInfo, string sourceId)
		{
			this.CurrentBlendInfo = blendInfo;
			this.TriggerSourceId = sourceId;
			this.SetupInfoExecuted = false;
			IBlendAnimTypeBase blendType = blendInfo.BlendType;
			EBlendAnimType type = blendType.Type;
			if (type != EBlendAnimType.StateMachine)
			{
				if (type == EBlendAnimType.AnimSequence)
				{
					this.PreloadAnimSequence(blendType);
					return;
				}
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] SetupInfo: 未知的BlendType", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06029381 RID: 168833 RVA: 0x00B93278 File Offset: 0x00B91478
		private void PreloadAnimSequence(IBlendAnimTypeBase blendType)
		{
			ISetAnimSequenceBlendAnimType setAnimSequenceBlendAnimType = blendType as ISetAnimSequenceBlendAnimType;
			string animPath2;
			if (setAnimSequenceBlendAnimType != null)
			{
				animPath2 = setAnimSequenceBlendAnimType.AnimSequence;
			}
			else
			{
				animPath2 = null;
			}
			string animPath = animPath2;
			if (animPath == null)
			{
				return;
			}
			if (this.PreloadedAnimationAssets.ContainsKey(animPath))
			{
				return;
			}
			if (this.PreloadPromises.ContainsKey(animPath))
			{
				return;
			}
			CustomPromise<bool> preloadPromise = new CustomPromise<bool>();
			this.PreloadPromises.Add(animPath, preloadPromise);
			ResourceSystem.Instance.LoadAsync<UAnimSequence>(animPath, delegate([Nullable(2)] UAnimSequence animAsset, string _)
			{
				if (animAsset != null && animAsset != null)
				{
					this.PreloadedAnimationAssets.Add(animPath, animAsset);
					preloadPromise.SetResult(true);
					return;
				}
				preloadPromise.SetResult(false);
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[PlotBlend] 动画资源预加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", animPath);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}, 100, "js_undefined");
		}

		// Token: 0x06029382 RID: 168834 RVA: 0x00B93328 File Offset: 0x00B91528
		private void ExecuteStateMachineBlend(WorldEntity entity, CharacterAnimationComponent animComp, EBlendAnimState targetState)
		{
			if (animComp == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] ExecuteStateMachineBlend: animComp不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CharacterMoveComponent component = entity.GetComponent<CharacterMoveComponent>();
			switch (targetState)
			{
			case EBlendAnimState.CombatIdle:
				animComp.EnterBattleIdle(null);
				return;
			case EBlendAnimState.Fall:
				if (((component != null) ? component.ActorComp : null) != null)
				{
					component.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						Context = "[PlotBlendController.ExecuteStateMachineBlend.Fall]"
					});
					return;
				}
				break;
			case EBlendAnimState.Slide:
				if (((component != null) ? component.ActorComp : null) != null)
				{
					component.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Custom,
						CustomMode = 4,
						Context = "[PlotBlendController.ExecuteStateMachineBlend.Slide]"
					});
					CharacterUnifiedStateComponent component2 = entity.GetComponent<CharacterUnifiedStateComponent>();
					if (component2 == null)
					{
						return;
					}
					component2.SetMoveState(ECharMoveState.Slide);
					return;
				}
				break;
			case EBlendAnimState.Run:
				if (((component != null) ? component.MoveController : null) != null && component.ActorComp != null)
				{
					Vector actorLocationProxy = component.ActorComp.ActorLocationProxy;
					Vector actorForwardProxy = component.ActorComp.ActorForwardProxy;
					Vector position = Vector.Create(actorLocationProxy.X + actorForwardProxy.X * 100.0, actorLocationProxy.Y + actorForwardProxy.Y * 100.0, actorLocationProxy.Z + actorForwardProxy.Z * 100.0);
					MoveToPointConfigImpl moveToPointConfigImpl = new MoveToPointConfigImpl();
					moveToPointConfigImpl.Position = position;
					moveToPointConfigImpl.MoveState = new ECharMoveState?(ECharMoveState.Run);
					List<Action<ELevelEventState>> list = new List<Action<ELevelEventState>>();
					list.Add(delegate(ELevelEventState _)
					{
					});
					moveToPointConfigImpl.CallbackList = list;
					MoveToPointConfigImpl moveConfig = moveToPointConfigImpl;
					component.MoveController.NavigateMoveToLocation(moveConfig, null, true, null);
					return;
				}
				break;
			case EBlendAnimState.Walk:
				if (((component != null) ? component.MoveController : null) != null && component.ActorComp != null)
				{
					Vector actorLocationProxy2 = component.ActorComp.ActorLocationProxy;
					Vector actorForwardProxy2 = component.ActorComp.ActorForwardProxy;
					Vector position2 = Vector.Create(actorLocationProxy2.X + actorForwardProxy2.X * 100.0, actorLocationProxy2.Y + actorForwardProxy2.Y * 100.0, actorLocationProxy2.Z + actorForwardProxy2.Z * 100.0);
					CharacterUnifiedStateComponent component3 = entity.GetComponent<CharacterUnifiedStateComponent>();
					if (component3 != null)
					{
						component3.MarkWalkOrRun(true, false, null);
					}
					MoveToPointConfigImpl moveToPointConfigImpl2 = new MoveToPointConfigImpl();
					moveToPointConfigImpl2.Position = position2;
					moveToPointConfigImpl2.MoveState = new ECharMoveState?(ECharMoveState.Walk);
					List<Action<ELevelEventState>> list2 = new List<Action<ELevelEventState>>();
					list2.Add(delegate(ELevelEventState _)
					{
					});
					moveToPointConfigImpl2.CallbackList = list2;
					MoveToPointConfigImpl moveConfig2 = moveToPointConfigImpl2;
					component.MoveController.NavigateMoveToLocation(moveConfig2, null, true, null);
					return;
				}
				break;
			default:
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[PlotBlend] ExecuteStateMachineBlend: 未知的状态";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", targetState);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				break;
			}
			}
		}

		// Token: 0x06029383 RID: 168835 RVA: 0x00B9363C File Offset: 0x00B9183C
		private void ExecuteAnimSequenceBlend(UAnimInstance animInstance, IBlendAnimTypeBase blendType)
		{
			string animSequence = ((ISetAnimSequenceBlendAnimType)blendType).AnimSequence;
			if (string.IsNullOrEmpty(animSequence))
			{
				return;
			}
			UAnimSequence uanimSequence;
			this.PreloadedAnimationAssets.TryGetValue(animSequence, out uanimSequence);
			if (uanimSequence == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[PlotBlend] ExecuteAnimSequenceBlend: 动画资源未预加载";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", animSequence);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (animInstance == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] ExecuteAnimSequenceBlend: AnimInstance不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (animInstance != null)
			{
				animInstance.PlaySlotAnimation(uanimSequence, SequenceDefine.DEFAULT_SEQ_SLOT, 0.1f, 0.25f, 1f, 1);
			}
			float num = uanimSequence.SequenceLength + 0.1f;
			if (this.AnimEndTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.AnimEndTimerHandle);
			}
			this.AnimEndTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.EndBlendOutSwitchPose();
			}, (float)((int)(num * 1000f)), null, null, true, 1f);
			float? protectTime = ((ISetAnimSequenceBlendAnimType)blendType).ProtectTime;
			float? num2 = protectTime;
			float num3 = 0f;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				this.IsInProtectTime = true;
				this.ProtectTimeTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.IsInProtectTime = false;
					this.ProtectTimeTimerHandle = null;
				}, (float)((int)(protectTime * (float)1000).Value), null, null, true, 1f);
			}
			else
			{
				this.IsInProtectTime = false;
			}
			this.BindInputActions(null);
			this.BindInputAxes(null);
		}

		// Token: 0x06029384 RID: 168836 RVA: 0x00B937D4 File Offset: 0x00B919D4
		[NullableContext(0)]
		public UniTask<bool> TryExecuteBlend([Nullable(2)] string sourceId)
		{
			PlotBlendController.<TryExecuteBlend>d__24 <TryExecuteBlend>d__;
			<TryExecuteBlend>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryExecuteBlend>d__.<>4__this = this;
			<TryExecuteBlend>d__.sourceId = sourceId;
			<TryExecuteBlend>d__.<>1__state = -1;
			<TryExecuteBlend>d__.<>t__builder.Start<PlotBlendController.<TryExecuteBlend>d__24>(ref <TryExecuteBlend>d__);
			return <TryExecuteBlend>d__.<>t__builder.Task;
		}

		// Token: 0x06029385 RID: 168837 RVA: 0x00B93820 File Offset: 0x00B91A20
		public void EndBlendOutSwitchPose()
		{
			if (!PlotModel.Instance.IsBlendProcessing)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] 没有正在进行的BlendOut操作", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UnBindInputActions(null);
			this.UnBindInputAxes(null);
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] 结束BlendOut姿势切换", default(ReadOnlySpan<ValueTuple<string, object>>));
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] EndBlendOutSwitchPose: 当前角色不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CharacterAnimationComponent component = worldEntity.GetComponent<CharacterAnimationComponent>();
			UAnimInstance uanimInstance = (component != null) ? component.MainAnimInstance : null;
			if (uanimInstance == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] EndBlendOutSwitchPose: animInstance不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			uanimInstance.StopSlotAnimation(0.1f, SequenceDefine.DEFAULT_SEQ_SLOT);
			this.ClearProtectTime();
			this.ClearAnimEndTimer();
			PlotModel.Instance.IsBlendProcessing = false;
		}

		// Token: 0x06029386 RID: 168838 RVA: 0x00B9390D File Offset: 0x00B91B0D
		private void ClearProtectTime()
		{
			if (this.ProtectTimeTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.ProtectTimeTimerHandle);
				this.ProtectTimeTimerHandle = null;
			}
			this.IsInProtectTime = false;
		}

		// Token: 0x06029387 RID: 168839 RVA: 0x00B93936 File Offset: 0x00B91B36
		private void ClearAnimEndTimer()
		{
			if (this.AnimEndTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.AnimEndTimerHandle);
				this.AnimEndTimerHandle = null;
			}
		}

		// Token: 0x06029388 RID: 168840 RVA: 0x00B93958 File Offset: 0x00B91B58
		private void ClearBlendData()
		{
			this.CurrentBlendInfo = null;
			this.TriggerSourceId = null;
			this.SetupInfoExecuted = false;
			this.PreloadedAnimationAssets.Clear();
			foreach (KeyValuePair<string, CustomPromise<bool>> keyValuePair in this.PreloadPromises)
			{
				keyValuePair.Value.SetResult(false);
			}
			this.PreloadPromises.Clear();
		}

		// Token: 0x17005371 RID: 21361
		// (get) Token: 0x06029389 RID: 168841 RVA: 0x00B939DC File Offset: 0x00B91BDC
		public bool HasBlendInfo
		{
			get
			{
				return this.CurrentBlendInfo != null;
			}
		}

		// Token: 0x17005372 RID: 21362
		// (get) Token: 0x0602938A RID: 168842 RVA: 0x00B939E7 File Offset: 0x00B91BE7
		public bool HasUnexecutedBlendInfo
		{
			get
			{
				return this.HasBlendInfo && !this.SetupInfoExecuted;
			}
		}

		// Token: 0x0602938B RID: 168843 RVA: 0x00B939FC File Offset: 0x00B91BFC
		public bool IsAnimationPreloaded(string animPath)
		{
			return this.PreloadedAnimationAssets.ContainsKey(animPath);
		}

		// Token: 0x0602938C RID: 168844 RVA: 0x00B93A0C File Offset: 0x00B91C0C
		[NullableContext(0)]
		public UniTask<bool> WaitForAnimationPreload([Nullable(1)] string animPath)
		{
			PlotBlendController.<WaitForAnimationPreload>d__34 <WaitForAnimationPreload>d__;
			<WaitForAnimationPreload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WaitForAnimationPreload>d__.<>4__this = this;
			<WaitForAnimationPreload>d__.animPath = animPath;
			<WaitForAnimationPreload>d__.<>1__state = -1;
			<WaitForAnimationPreload>d__.<>t__builder.Start<PlotBlendController.<WaitForAnimationPreload>d__34>(ref <WaitForAnimationPreload>d__);
			return <WaitForAnimationPreload>d__.<>t__builder.Task;
		}

		// Token: 0x0602938D RID: 168845 RVA: 0x00B93A57 File Offset: 0x00B91C57
		[NullableContext(2)]
		public SetBlendAnim GetCurrentBlendInfo()
		{
			return this.CurrentBlendInfo;
		}

		// Token: 0x0602938E RID: 168846 RVA: 0x00B93A60 File Offset: 0x00B91C60
		public void ClearBlendInfo()
		{
			this.CurrentBlendInfo = null;
			this.TriggerSourceId = null;
			this.SetupInfoExecuted = false;
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] 手动清理Blend信息", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602938F RID: 168847 RVA: 0x00B93AA0 File Offset: 0x00B91CA0
		public void BindInputActions([Nullable(new byte[]
		{
			2,
			1
		})] string[] actionNames = null)
		{
			string[] array = actionNames ?? this.blendMonitorActions;
			if (array == null || array.Length == 0)
			{
				return;
			}
			InputDistributeController.Instance.BindActions(array, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06029390 RID: 168848 RVA: 0x00B93AD8 File Offset: 0x00B91CD8
		public void UnBindInputActions([Nullable(new byte[]
		{
			2,
			1
		})] string[] actionNames = null)
		{
			string[] array = actionNames ?? this.blendMonitorActions;
			if (array == null || array.Length == 0)
			{
				return;
			}
			InputDistributeController.Instance.UnBindActions(array, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06029391 RID: 168849 RVA: 0x00B93B10 File Offset: 0x00B91D10
		public void BindInputAxes([Nullable(new byte[]
		{
			2,
			1
		})] string[] axisNames = null)
		{
			string[] array = axisNames ?? this.blendMonitorAxes;
			if (array == null || array.Length == 0)
			{
				return;
			}
			InputDistributeController.Instance.BindAxes(array, new TInputHandle<float>(this.OnInputMoveAxis));
		}

		// Token: 0x06029392 RID: 168850 RVA: 0x00B93B48 File Offset: 0x00B91D48
		public void UnBindInputAxes([Nullable(new byte[]
		{
			2,
			1
		})] string[] axisNames = null)
		{
			string[] array = axisNames ?? this.blendMonitorAxes;
			if (array == null || array.Length == 0)
			{
				return;
			}
			InputDistributeController.Instance.UnBindAxes(array, new TInputHandle<float>(this.OnInputMoveAxis));
		}

		// Token: 0x17005373 RID: 21363
		// (get) Token: 0x06029393 RID: 168851 RVA: 0x00B93B80 File Offset: 0x00B91D80
		public static PlotBlendController Instance
		{
			get
			{
				return PlotBlendController._Instance;
			}
		}

		// Token: 0x06029394 RID: 168852 RVA: 0x00B93B87 File Offset: 0x00B91D87
		public static PlotBlendController GetOrCreateInstance()
		{
			if (PlotBlendController._Instance == null)
			{
				PlotBlendController.CreateInstance();
			}
			return PlotBlendController._Instance;
		}

		// Token: 0x06029395 RID: 168853 RVA: 0x00B93B9B File Offset: 0x00B91D9B
		public static bool CreateInstance()
		{
			if (PlotBlendController._Instance != null)
			{
				return true;
			}
			PlotBlendController._Instance = new PlotBlendController();
			return true;
		}

		// Token: 0x06029396 RID: 168854 RVA: 0x00B93BB1 File Offset: 0x00B91DB1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029397 RID: 168855 RVA: 0x00B93BB3 File Offset: 0x00B91DB3
		public static void ResetStaticDefaultValue()
		{
			PlotBlendController._Instance = null;
		}

		// Token: 0x06029398 RID: 168856 RVA: 0x00B93BBB File Offset: 0x00B91DBB
		static PlotBlendController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotBlendController.CreateStaticDefaultValue), new Action(PlotBlendController.ResetStaticDefaultValue));
		}

		// Token: 0x040166F7 RID: 91895
		private const float BLEND_IN = 0.1f;

		// Token: 0x040166F8 RID: 91896
		private const float BLEND_OUT = 0.1f;

		// Token: 0x040166F9 RID: 91897
		private readonly string[] blendMonitorActions = new string[]
		{
			"跳跃",
			"攀爬",
			"走跑切换",
			"闪避",
			"下降",
			"攻击",
			"技能1",
			"幻象1",
			"大招",
			"幻象2",
			"切换角色1",
			"切换角色2",
			"切换角色3",
			"切换角色4",
			"通用交互",
			"切换交互",
			"环境特性",
			"锁定目标",
			"瞄准"
		};

		// Token: 0x040166FA RID: 91898
		private readonly string[] blendMonitorAxes = new string[]
		{
			"MoveForward",
			"MoveRight"
		};

		// Token: 0x040166FB RID: 91899
		[Nullable(2)]
		private SetBlendAnim CurrentBlendInfo;

		// Token: 0x040166FC RID: 91900
		private bool SetupInfoExecuted;

		// Token: 0x040166FD RID: 91901
		[Nullable(2)]
		private string TriggerSourceId;

		// Token: 0x040166FE RID: 91902
		private readonly Dictionary<string, UAnimSequence> PreloadedAnimationAssets = new Dictionary<string, UAnimSequence>();

		// Token: 0x040166FF RID: 91903
		private readonly Dictionary<string, CustomPromise<bool>> PreloadPromises = new Dictionary<string, CustomPromise<bool>>();

		// Token: 0x04016700 RID: 91904
		private bool IsInProtectTime;

		// Token: 0x04016701 RID: 91905
		[Nullable(2)]
		private TimerHandle ProtectTimeTimerHandle;

		// Token: 0x04016702 RID: 91906
		[Nullable(2)]
		private TimerHandle AnimEndTimerHandle;

		// Token: 0x04016703 RID: 91907
		[Nullable(2)]
		private static PlotBlendController _Instance;
	}
}
