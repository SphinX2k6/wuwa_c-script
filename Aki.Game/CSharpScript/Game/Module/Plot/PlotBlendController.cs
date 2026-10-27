using System;
using System.Collections.Generic;
using System.Reflection;
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
	// Token: 0x02004FDB RID: 20443
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotBlendController : ControllerBase
	{
		// Token: 0x060344EF RID: 214255 RVA: 0x00C4901E File Offset: 0x00C4721E
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

		// Token: 0x060344F0 RID: 214256 RVA: 0x00C49032 File Offset: 0x00C47232
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

		// Token: 0x060344F1 RID: 214257 RVA: 0x00C49050 File Offset: 0x00C47250
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060344F2 RID: 214258 RVA: 0x00C49054 File Offset: 0x00C47254
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

		// Token: 0x060344F3 RID: 214259 RVA: 0x00C4911C File Offset: 0x00C4731C
		protected override void OnTick(float delta)
		{
			bool isBlendProcessing = PlotModel.Instance.IsBlendProcessing;
		}

		// Token: 0x060344F4 RID: 214260 RVA: 0x00C49129 File Offset: 0x00C47329
		protected override void OnAfterTick(float delta)
		{
		}

		// Token: 0x060344F5 RID: 214261 RVA: 0x00C4912C File Offset: 0x00C4732C
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

		// Token: 0x060344F6 RID: 214262 RVA: 0x00C49198 File Offset: 0x00C47398
		protected override bool OnChangeMode()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] PlotBlendController 改变模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x060344F7 RID: 214263 RVA: 0x00C491C4 File Offset: 0x00C473C4
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

		// Token: 0x060344F8 RID: 214264 RVA: 0x00C49220 File Offset: 0x00C47420
		private void PreloadAnimSequence(IBlendAnimTypeBase blendType)
		{
			PropertyInfo property = blendType.GetType().GetProperty("AnimSequence");
			if (property == null)
			{
				return;
			}
			string animPath = property.GetValue(blendType) as string;
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

		// Token: 0x060344F9 RID: 214265 RVA: 0x00C492E0 File Offset: 0x00C474E0
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

		// Token: 0x060344FA RID: 214266 RVA: 0x00C495F4 File Offset: 0x00C477F4
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

		// Token: 0x060344FB RID: 214267 RVA: 0x00C4978C File Offset: 0x00C4798C
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

		// Token: 0x060344FC RID: 214268 RVA: 0x00C497D8 File Offset: 0x00C479D8
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

		// Token: 0x060344FD RID: 214269 RVA: 0x00C498C5 File Offset: 0x00C47AC5
		private void ClearProtectTime()
		{
			if (this.ProtectTimeTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.ProtectTimeTimerHandle);
				this.ProtectTimeTimerHandle = null;
			}
			this.IsInProtectTime = false;
		}

		// Token: 0x060344FE RID: 214270 RVA: 0x00C498EE File Offset: 0x00C47AEE
		private void ClearAnimEndTimer()
		{
			if (this.AnimEndTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.AnimEndTimerHandle);
				this.AnimEndTimerHandle = null;
			}
		}

		// Token: 0x060344FF RID: 214271 RVA: 0x00C49910 File Offset: 0x00C47B10
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

		// Token: 0x17007FBD RID: 32701
		// (get) Token: 0x06034500 RID: 214272 RVA: 0x00C49994 File Offset: 0x00C47B94
		public bool HasBlendInfo
		{
			get
			{
				return this.CurrentBlendInfo != null;
			}
		}

		// Token: 0x17007FBE RID: 32702
		// (get) Token: 0x06034501 RID: 214273 RVA: 0x00C4999F File Offset: 0x00C47B9F
		public bool HasUnexecutedBlendInfo
		{
			get
			{
				return this.HasBlendInfo && !this.SetupInfoExecuted;
			}
		}

		// Token: 0x06034502 RID: 214274 RVA: 0x00C499B4 File Offset: 0x00C47BB4
		public bool IsAnimationPreloaded(string animPath)
		{
			return this.PreloadedAnimationAssets.ContainsKey(animPath);
		}

		// Token: 0x06034503 RID: 214275 RVA: 0x00C499C4 File Offset: 0x00C47BC4
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

		// Token: 0x06034504 RID: 214276 RVA: 0x00C49A0F File Offset: 0x00C47C0F
		[NullableContext(2)]
		public SetBlendAnim GetCurrentBlendInfo()
		{
			return this.CurrentBlendInfo;
		}

		// Token: 0x06034505 RID: 214277 RVA: 0x00C49A18 File Offset: 0x00C47C18
		public void ClearBlendInfo()
		{
			this.CurrentBlendInfo = null;
			this.TriggerSourceId = null;
			this.SetupInfoExecuted = false;
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[PlotBlend] 手动清理Blend信息", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06034506 RID: 214278 RVA: 0x00C49A58 File Offset: 0x00C47C58
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

		// Token: 0x06034507 RID: 214279 RVA: 0x00C49A90 File Offset: 0x00C47C90
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

		// Token: 0x06034508 RID: 214280 RVA: 0x00C49AC8 File Offset: 0x00C47CC8
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

		// Token: 0x06034509 RID: 214281 RVA: 0x00C49B00 File Offset: 0x00C47D00
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

		// Token: 0x17007FBF RID: 32703
		// (get) Token: 0x0603450A RID: 214282 RVA: 0x00C49B38 File Offset: 0x00C47D38
		public static PlotBlendController Instance
		{
			get
			{
				return PlotBlendController._Instance;
			}
		}

		// Token: 0x0603450B RID: 214283 RVA: 0x00C49B3F File Offset: 0x00C47D3F
		public static PlotBlendController GetOrCreateInstance()
		{
			if (PlotBlendController._Instance == null)
			{
				PlotBlendController.CreateInstance();
			}
			return PlotBlendController._Instance;
		}

		// Token: 0x0603450C RID: 214284 RVA: 0x00C49B53 File Offset: 0x00C47D53
		public static bool CreateInstance()
		{
			if (PlotBlendController._Instance != null)
			{
				return true;
			}
			PlotBlendController._Instance = new PlotBlendController();
			return true;
		}

		// Token: 0x0603450D RID: 214285 RVA: 0x00C49B69 File Offset: 0x00C47D69
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603450E RID: 214286 RVA: 0x00C49B6B File Offset: 0x00C47D6B
		public static void ResetStaticDefaultValue()
		{
			PlotBlendController._Instance = null;
		}

		// Token: 0x0603450F RID: 214287 RVA: 0x00C49B73 File Offset: 0x00C47D73
		static PlotBlendController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotBlendController.CreateStaticDefaultValue), new Action(PlotBlendController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD1C RID: 113948
		private const float BLEND_IN = 0.1f;

		// Token: 0x0401BD1D RID: 113949
		private const float BLEND_OUT = 0.1f;

		// Token: 0x0401BD1E RID: 113950
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

		// Token: 0x0401BD1F RID: 113951
		private readonly string[] blendMonitorAxes = new string[]
		{
			"MoveForward",
			"MoveRight"
		};

		// Token: 0x0401BD20 RID: 113952
		[Nullable(2)]
		private SetBlendAnim CurrentBlendInfo;

		// Token: 0x0401BD21 RID: 113953
		private bool SetupInfoExecuted;

		// Token: 0x0401BD22 RID: 113954
		[Nullable(2)]
		private string TriggerSourceId;

		// Token: 0x0401BD23 RID: 113955
		private readonly Dictionary<string, UAnimSequence> PreloadedAnimationAssets = new Dictionary<string, UAnimSequence>();

		// Token: 0x0401BD24 RID: 113956
		private readonly Dictionary<string, CustomPromise<bool>> PreloadPromises = new Dictionary<string, CustomPromise<bool>>();

		// Token: 0x0401BD25 RID: 113957
		private bool IsInProtectTime;

		// Token: 0x0401BD26 RID: 113958
		[Nullable(2)]
		private TimerHandle ProtectTimeTimerHandle;

		// Token: 0x0401BD27 RID: 113959
		[Nullable(2)]
		private TimerHandle AnimEndTimerHandle;

		// Token: 0x0401BD28 RID: 113960
		[Nullable(2)]
		private static PlotBlendController _Instance;
	}
}
