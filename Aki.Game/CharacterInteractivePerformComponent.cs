using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x020025CD RID: 9677
[NullableContext(1)]
[Nullable(0)]
public class CharacterInteractivePerformComponent : EntityComponent
{
	// Token: 0x06018130 RID: 98608 RVA: 0x00737CF8 File Offset: 0x00735EF8
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x06018131 RID: 98609 RVA: 0x00737D2E File Offset: 0x00735F2E
	protected override bool OnEnd()
	{
		this.FinishRequest();
		return true;
	}

	// Token: 0x06018132 RID: 98610 RVA: 0x00737D37 File Offset: 0x00735F37
	protected void AddGlobalEvents()
	{
		EventSystem.Instance.Add(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotBegin));
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleBegin));
	}

	// Token: 0x06018133 RID: 98611 RVA: 0x00737D74 File Offset: 0x00735F74
	protected void AddEntityEvents(Entity entity)
	{
		EventSystem.Instance.AddWithTarget<int, int, bool>(entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.AddWithTarget(entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange));
		EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChange));
	}

	// Token: 0x06018134 RID: 98612 RVA: 0x00737DF2 File Offset: 0x00735FF2
	protected void RemoveGlobalEvents()
	{
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotBegin));
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleBegin));
	}

	// Token: 0x06018135 RID: 98613 RVA: 0x00737E2C File Offset: 0x0073602C
	protected void RemoveEntityEvents(Entity entity)
	{
		EventSystem.Instance.RemoveWithTarget<int, int, bool>(entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChange));
	}

	// Token: 0x06018136 RID: 98614 RVA: 0x00737EAA File Offset: 0x007360AA
	protected void OnPlotBegin(PlotInfo plotInfo)
	{
		this.TryInterruptResponse("剧情开始");
	}

	// Token: 0x06018137 RID: 98615 RVA: 0x00737EB8 File Offset: 0x007360B8
	protected void OnBattleBegin(bool isInBattleState)
	{
		if (!isInBattleState)
		{
			return;
		}
		this.TryInterruptResponse("战斗开始");
	}

	// Token: 0x06018138 RID: 98616 RVA: 0x00737ECA File Offset: 0x007360CA
	protected void OnUseSkill(int entityId, int skillId, bool IsAutonomousProxy)
	{
		this.TryInterruptResponse("使用技能");
	}

	// Token: 0x06018139 RID: 98617 RVA: 0x00737ED8 File Offset: 0x007360D8
	protected void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.TryInterruptResponse("实体移除");
	}

	// Token: 0x0601813A RID: 98618 RVA: 0x00737EE6 File Offset: 0x007360E6
	protected void OnPositionStateChange(global::ECharPositionState oldMoveState, global::ECharPositionState newMoveState)
	{
		if (newMoveState == global::ECharPositionState.Ground)
		{
			return;
		}
		this.TryInterruptResponse("位置模式改变");
	}

	// Token: 0x0601813B RID: 98619 RVA: 0x00737EF8 File Offset: 0x007360F8
	protected void OnMoveStateChange(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		if (newMoveState == global::ECharMoveState.Stand)
		{
			return;
		}
		this.TryInterruptResponse("移动模式改变");
	}

	// Token: 0x0601813C RID: 98620 RVA: 0x00737F0C File Offset: 0x0073610C
	public bool CanResponse()
	{
		if (this.TagComp == null)
		{
			return false;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		bool flag;
		if (actorComp == null)
		{
			flag = false;
		}
		else
		{
			BaseMoveComponent moveComp = actorComp.MoveComp;
			flag = ((moveComp != null) ? new bool?(moveComp.HasMoveInput) : null).GetValueOrDefault();
		}
		return !flag && !PlotModel.Instance.IsInPlot && this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]) && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]) && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]);
	}

	// Token: 0x0601813D RID: 98621 RVA: 0x00737FC4 File Offset: 0x007361C4
	protected void AddConditionEvents(Entity entity, string type)
	{
		if (type == "HandInSeat")
		{
			this.ListenCharActionType = new ECharacterActionType?(ECharacterActionType.Sit);
			EventSystem.Instance.AddWithTarget(entity, EEventName.CharActionStateChange, new Action<ECharacterActionType, bool>(this.OnCharActionStateChange));
			EventSystem.Instance.AddWithTarget<int, bool, EHoldingHandsRoleState, EHandType>(entity, EEventName.CharHoldingHandsChanged, new Action<int, bool, EHoldingHandsRoleState, EHandType>(this.OnCharHoldingHandsChange));
		}
	}

	// Token: 0x0601813E RID: 98622 RVA: 0x00738024 File Offset: 0x00736224
	protected void RemoveConditionEvents(Entity entity, string type)
	{
		if (type == "HandInSeat")
		{
			EventSystem.Instance.RemoveWithTarget<int, bool, EHoldingHandsRoleState, EHandType>(entity, EEventName.CharHoldingHandsChanged, new Action<int, bool, EHoldingHandsRoleState, EHandType>(this.OnCharHoldingHandsChange));
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharActionStateChange, new Action<ECharacterActionType, bool>(this.OnCharActionStateChange));
			this.ListenCharActionType = null;
		}
	}

	// Token: 0x0601813F RID: 98623 RVA: 0x00738084 File Offset: 0x00736284
	protected bool CanResponseForHandInSeat()
	{
		CharacterActionComponent component = base.Entity.GetComponent<CharacterActionComponent>();
		if (component == null || !component.IsSitDown)
		{
			return false;
		}
		CharacterHoldingHandsComponent component2 = base.Entity.GetComponent<CharacterHoldingHandsComponent>();
		return component2 != null && component2.IsSitDownWithHoldingHands();
	}

	// Token: 0x06018140 RID: 98624 RVA: 0x007380C4 File Offset: 0x007362C4
	protected void OnCharHoldingHandsChange(int _1, bool _2, EHoldingHandsRoleState _3, EHandType _4)
	{
		this.TryInterruptResponse("牵手状态改变");
	}

	// Token: 0x06018141 RID: 98625 RVA: 0x007380D4 File Offset: 0x007362D4
	protected void OnCharActionStateChange(ECharacterActionType action, bool state)
	{
		ECharacterActionType? listenCharActionType = this.ListenCharActionType;
		if (!(listenCharActionType.GetValueOrDefault() == action & listenCharActionType != null))
		{
			return;
		}
		if (state)
		{
			return;
		}
		this.TryInterruptResponse("角色交互行为状态改变");
	}

	// Token: 0x06018142 RID: 98626 RVA: 0x0073810F File Offset: 0x0073630F
	public void AddRequestSignal(IRequestPerformParams request)
	{
		this.RequestCacheList[request.Signal] = request;
		this.TryResponse(request.Signal);
	}

	// Token: 0x06018143 RID: 98627 RVA: 0x00738130 File Offset: 0x00736330
	public void RemoveRequestSignal(int signal)
	{
		this.RequestCacheList.Remove(signal);
	}

	// Token: 0x06018144 RID: 98628 RVA: 0x0073813F File Offset: 0x0073633F
	public void AddResponseSignal(int signal, string context = "")
	{
		this.ResponseCacheList.Add(signal);
		this.TryResponse(signal);
	}

	// Token: 0x06018145 RID: 98629 RVA: 0x00738156 File Offset: 0x00736356
	public void RemoveResponseSignal(int signal)
	{
		this.ResponseCacheList.Remove(signal);
	}

	// Token: 0x06018146 RID: 98630 RVA: 0x00738168 File Offset: 0x00736368
	protected bool TryResponse(int signal)
	{
		if (!this.CanResponse())
		{
			return false;
		}
		if (this.CurHandleRequest != null)
		{
			return false;
		}
		if (!this.ResponseCacheList.Contains(signal))
		{
			return false;
		}
		IRequestPerformParams requestPerformParams;
		if (!this.RequestCacheList.TryGetValue(signal, out requestPerformParams) || requestPerformParams == null)
		{
			return false;
		}
		AnsPerform? configData = AnsPerformConfig.Instance.GetConfigData(requestPerformParams.Signal);
		if (configData == null || !this.RequestConditionCheck(requestPerformParams, configData.Value))
		{
			return false;
		}
		this.ResponseToRequest(requestPerformParams, configData.Value);
		return true;
	}

	// Token: 0x06018147 RID: 98631 RVA: 0x007381E9 File Offset: 0x007363E9
	protected bool RequestConditionCheck(IRequestPerformParams request, AnsPerform config)
	{
		return config.Condition == "HandInSeat" && this.CanResponseForHandInSeat();
	}

	// Token: 0x06018148 RID: 98632 RVA: 0x00738208 File Offset: 0x00736408
	protected void ResponseToRequest(IRequestPerformParams request, AnsPerform config)
	{
		if (!this.ResponseActionStart(config))
		{
			return;
		}
		this.CurHandleRequest = request;
		this.CurHandleConfig = new AnsPerform?(config);
		this.RemoveRequestSignal(request.Signal);
		this.RemoveResponseSignal(request.Signal);
		this.AddGlobalEvents();
		this.AddEntityEvents(base.Entity);
		this.AddEntityEvents(request.Source);
		this.AddConditionEvents(base.Entity, config.Condition);
	}

	// Token: 0x06018149 RID: 98633 RVA: 0x0073827C File Offset: 0x0073647C
	protected unsafe bool ResponseActionStart(AnsPerform config)
	{
		if (this.AnimComp == null)
		{
			return false;
		}
		string path = this.GetRoleMontagePathFromName(config.Action);
		if (path == "")
		{
			return false;
		}
		ResourceSystem.Instance.LoadAsync<UAnimMontage>(path, delegate([Nullable(2)] UAnimMontage montage, string _)
		{
			if (montage == null || !montage.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BasePerform;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[InteractivePerform] 加载响应Montage失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId";
				CharacterActorComponent actorComp = this.ActorComp;
				ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Signal", config.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Path", path);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.FinishRequest();
				return;
			}
			this.PlayResponseMontage(montage);
		}, 100, "js_undefined");
		return true;
	}

	// Token: 0x0601814A RID: 98634 RVA: 0x007382F7 File Offset: 0x007364F7
	protected void ResponseActionAbort()
	{
		if (this.CurResponseMontage == null)
		{
			return;
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
		if (mainAnimInstance == null)
		{
			return;
		}
		mainAnimInstance.Montage_Stop(0f, this.CurResponseMontage);
	}

	// Token: 0x0601814B RID: 98635 RVA: 0x00738327 File Offset: 0x00736527
	protected bool TryInterruptResponse(string context)
	{
		if (this.CurHandleRequest == null)
		{
			return false;
		}
		this.ResponseActionAbort();
		this.FinishRequest();
		return true;
	}

	// Token: 0x0601814C RID: 98636 RVA: 0x00738340 File Offset: 0x00736540
	protected void FinishRequest()
	{
		if (this.CurHandleRequest == null)
		{
			return;
		}
		this.RemoveGlobalEvents();
		this.RemoveEntityEvents(base.Entity);
		this.RemoveEntityEvents(this.CurHandleRequest.Source);
		this.RemoveConditionEvents(base.Entity, this.CurHandleConfig.Value.Condition);
		this.CurHandleRequest = null;
		this.CurHandleConfig = null;
	}

	// Token: 0x0601814D RID: 98637 RVA: 0x007383AC File Offset: 0x007365AC
	protected void PlayResponseMontage(UAnimMontage montage)
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.Montage_Play(montage, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
			}
		}
		CharacterAnimationComponent animComp2 = this.AnimComp;
		if (animComp2 != null)
		{
			UAnimInstance mainAnimInstance2 = animComp2.MainAnimInstance;
			if (mainAnimInstance2 != null)
			{
				mainAnimInstance2.OnMontageEnded.Add(new Action<UAnimMontage, bool>(this.OnResponseMontageEnd));
			}
		}
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.通用过程标识.强制更新源姿势"]));
		}
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null)
		{
			tagComp2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.通用过程标识.强制关闭IK"]));
		}
		this.CurResponseMontage = montage;
	}

	// Token: 0x0601814E RID: 98638 RVA: 0x00738464 File Offset: 0x00736664
	[NullableContext(2)]
	protected void OnResponseMontageEnd(UAnimMontage montage, bool bInterrupt)
	{
		if (montage != this.CurResponseMontage)
		{
			return;
		}
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.通用过程标识.强制关闭IK"]));
		}
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null)
		{
			tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.通用过程标识.强制更新源姿势"]));
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnResponseMontageEnd));
			}
		}
		this.CurResponseMontage = null;
		this.FinishRequest();
	}

	// Token: 0x0601814F RID: 98639 RVA: 0x00738504 File Offset: 0x00736704
	protected string GetRoleMontagePathFromName(string name)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		string text = (actorComp != null) ? actorComp.CreatureData.GetModelConfig().蓝图.ToAssetPathName() : null;
		if (text == null || text == "" || text == "None")
		{
			return "";
		}
		int num = text.LastIndexOf('/');
		int length = text.LastIndexOf('/', num - 1);
		string text2 = text.Substring(0, length);
		return string.Concat(new string[]
		{
			text2,
			"/BaseAnim/",
			name,
			".",
			name
		});
	}

	// Token: 0x06018150 RID: 98640 RVA: 0x0073859C File Offset: 0x0073679C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterInteractivePerformComponent characterInteractivePerformComponent = (CharacterInteractivePerformComponent)componentTemplate;
		if (characterInteractivePerformComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterInteractivePerformComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterInteractivePerformComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterInteractivePerformComponent.RequestCacheList == null)
		{
			this.RequestCacheList = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RequestCacheList), "RequestCacheList"))
		{
			return false;
		}
		if (characterInteractivePerformComponent.ResponseCacheList == null)
		{
			this.ResponseCacheList = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ResponseCacheList), "ResponseCacheList"))
		{
			return false;
		}
		if (characterInteractivePerformComponent.CurHandleRequest == null)
		{
			this.CurHandleRequest = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurHandleRequest), "CurHandleRequest"))
		{
			return false;
		}
		this.CurHandleConfig = characterInteractivePerformComponent.CurHandleConfig;
		this.ListenCharActionType = characterInteractivePerformComponent.ListenCharActionType;
		if (characterInteractivePerformComponent.CurResponseMontage == null)
		{
			this.CurResponseMontage = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurResponseMontage), "CurResponseMontage"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170025A8 RID: 9640
	// (get) Token: 0x06018151 RID: 98641 RVA: 0x00738701 File Offset: 0x00736901
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025A9 RID: 9641
	// (get) Token: 0x06018152 RID: 98642 RVA: 0x00738704 File Offset: 0x00736904
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CEE6 RID: 52966
	public static readonly string[] animationList = new string[]
	{
		"/Game/Aki/Character/Role/MaleM/BaseAnim/AM_Sit_1_Stand.AM_Sit_1_Stand",
		"/Game/Aki/Character/Role/FemaleM/BaseAnim/AM_Sit_1_Stand.AM_Sit_1_Stand"
	};

	// Token: 0x0400CEE7 RID: 52967
	[Nullable(2)]
	protected CharacterActorComponent ActorComp;

	// Token: 0x0400CEE8 RID: 52968
	[Nullable(2)]
	protected CharacterAnimationComponent AnimComp;

	// Token: 0x0400CEE9 RID: 52969
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400CEEA RID: 52970
	protected Dictionary<int, IRequestPerformParams> RequestCacheList = new Dictionary<int, IRequestPerformParams>();

	// Token: 0x0400CEEB RID: 52971
	protected HashSet<int> ResponseCacheList = new HashSet<int>();

	// Token: 0x0400CEEC RID: 52972
	[Nullable(2)]
	protected IRequestPerformParams CurHandleRequest;

	// Token: 0x0400CEED RID: 52973
	protected AnsPerform? CurHandleConfig;

	// Token: 0x0400CEEE RID: 52974
	protected ECharacterActionType? ListenCharActionType;

	// Token: 0x0400CEEF RID: 52975
	[Nullable(2)]
	protected UAnimMontage CurResponseMontage;
}
