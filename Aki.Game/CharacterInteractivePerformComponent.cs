using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02003076 RID: 12406
[NullableContext(1)]
[Nullable(0)]
public class CharacterInteractivePerformComponent : EntityComponent
{
	// Token: 0x0601A76F RID: 108399 RVA: 0x007116FC File Offset: 0x0070F8FC
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x0601A770 RID: 108400 RVA: 0x00711732 File Offset: 0x0070F932
	protected override bool OnEnd()
	{
		this.FinishRequest();
		return true;
	}

	// Token: 0x0601A771 RID: 108401 RVA: 0x0071173B File Offset: 0x0070F93B
	protected void AddGlobalEvents()
	{
		EventSystem.Instance.Add(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotBegin));
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleBegin));
	}

	// Token: 0x0601A772 RID: 108402 RVA: 0x00711778 File Offset: 0x0070F978
	protected void AddEntityEvents(Entity entity)
	{
		EventSystem.Instance.AddWithTarget<int, int, bool>(entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.AddWithTarget(entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange));
		EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChange));
	}

	// Token: 0x0601A773 RID: 108403 RVA: 0x007117F6 File Offset: 0x0070F9F6
	protected void RemoveGlobalEvents()
	{
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotBegin));
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleBegin));
	}

	// Token: 0x0601A774 RID: 108404 RVA: 0x00711830 File Offset: 0x0070FA30
	protected void RemoveEntityEvents(Entity entity)
	{
		EventSystem.Instance.RemoveWithTarget<int, int, bool>(entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChange));
		EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChange));
	}

	// Token: 0x0601A775 RID: 108405 RVA: 0x007118AE File Offset: 0x0070FAAE
	protected void OnPlotBegin(PlotInfo plotInfo)
	{
		this.TryInterruptResponse("剧情开始");
	}

	// Token: 0x0601A776 RID: 108406 RVA: 0x007118BC File Offset: 0x0070FABC
	protected void OnBattleBegin(bool isInBattleState)
	{
		if (!isInBattleState)
		{
			return;
		}
		this.TryInterruptResponse("战斗开始");
	}

	// Token: 0x0601A777 RID: 108407 RVA: 0x007118CE File Offset: 0x0070FACE
	protected void OnUseSkill(int entityId, int skillId, bool IsAutonomousProxy)
	{
		this.TryInterruptResponse("使用技能");
	}

	// Token: 0x0601A778 RID: 108408 RVA: 0x007118DC File Offset: 0x0070FADC
	protected void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.TryInterruptResponse("实体移除");
	}

	// Token: 0x0601A779 RID: 108409 RVA: 0x007118EA File Offset: 0x0070FAEA
	protected void OnPositionStateChange(global::ECharPositionState oldMoveState, global::ECharPositionState newMoveState)
	{
		if (newMoveState == global::ECharPositionState.Ground)
		{
			return;
		}
		this.TryInterruptResponse("位置模式改变");
	}

	// Token: 0x0601A77A RID: 108410 RVA: 0x007118FC File Offset: 0x0070FAFC
	protected void OnMoveStateChange(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		if (newMoveState == global::ECharMoveState.Stand)
		{
			return;
		}
		this.TryInterruptResponse("移动模式改变");
	}

	// Token: 0x0601A77B RID: 108411 RVA: 0x00711910 File Offset: 0x0070FB10
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

	// Token: 0x0601A77C RID: 108412 RVA: 0x007119C8 File Offset: 0x0070FBC8
	protected void AddConditionEvents(Entity entity, string type)
	{
		if (type == "HandInSeat")
		{
			this.ListenCharActionType = new ECharacterActionType?(ECharacterActionType.Sit);
			EventSystem.Instance.AddWithTarget(entity, EEventName.CharActionStateChange, new Action<ECharacterActionType, bool>(this.OnCharActionStateChange));
			EventSystem.Instance.AddWithTarget<int, bool, EHoldingHandsRoleState, EHandType>(entity, EEventName.CharHoldingHandsChanged, new Action<int, bool, EHoldingHandsRoleState, EHandType>(this.OnCharHoldingHandsChange));
		}
	}

	// Token: 0x0601A77D RID: 108413 RVA: 0x00711A28 File Offset: 0x0070FC28
	protected void RemoveConditionEvents(Entity entity, string type)
	{
		if (type == "HandInSeat")
		{
			EventSystem.Instance.RemoveWithTarget<int, bool, EHoldingHandsRoleState, EHandType>(entity, EEventName.CharHoldingHandsChanged, new Action<int, bool, EHoldingHandsRoleState, EHandType>(this.OnCharHoldingHandsChange));
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharActionStateChange, new Action<ECharacterActionType, bool>(this.OnCharActionStateChange));
			this.ListenCharActionType = null;
		}
	}

	// Token: 0x0601A77E RID: 108414 RVA: 0x00711A88 File Offset: 0x0070FC88
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

	// Token: 0x0601A77F RID: 108415 RVA: 0x00711AC8 File Offset: 0x0070FCC8
	protected void OnCharHoldingHandsChange(int _1, bool _2, EHoldingHandsRoleState _3, EHandType _4)
	{
		this.TryInterruptResponse("牵手状态改变");
	}

	// Token: 0x0601A780 RID: 108416 RVA: 0x00711AD8 File Offset: 0x0070FCD8
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

	// Token: 0x0601A781 RID: 108417 RVA: 0x00711B13 File Offset: 0x0070FD13
	public void AddRequestSignal(IRequestPerformParams request)
	{
		this.RequestCacheList[request.Signal] = request;
		this.TryResponse(request.Signal);
	}

	// Token: 0x0601A782 RID: 108418 RVA: 0x00711B34 File Offset: 0x0070FD34
	public void RemoveRequestSignal(int signal)
	{
		this.RequestCacheList.Remove(signal);
	}

	// Token: 0x0601A783 RID: 108419 RVA: 0x00711B43 File Offset: 0x0070FD43
	public void AddResponseSignal(int signal, string context = "")
	{
		this.ResponseCacheList.Add(signal);
		this.TryResponse(signal);
	}

	// Token: 0x0601A784 RID: 108420 RVA: 0x00711B5A File Offset: 0x0070FD5A
	public void RemoveResponseSignal(int signal)
	{
		this.ResponseCacheList.Remove(signal);
	}

	// Token: 0x0601A785 RID: 108421 RVA: 0x00711B6C File Offset: 0x0070FD6C
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

	// Token: 0x0601A786 RID: 108422 RVA: 0x00711BED File Offset: 0x0070FDED
	protected bool RequestConditionCheck(IRequestPerformParams request, AnsPerform config)
	{
		return config.Condition == "HandInSeat" && this.CanResponseForHandInSeat();
	}

	// Token: 0x0601A787 RID: 108423 RVA: 0x00711C0C File Offset: 0x0070FE0C
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

	// Token: 0x0601A788 RID: 108424 RVA: 0x00711C80 File Offset: 0x0070FE80
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

	// Token: 0x0601A789 RID: 108425 RVA: 0x00711CFB File Offset: 0x0070FEFB
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

	// Token: 0x0601A78A RID: 108426 RVA: 0x00711D2B File Offset: 0x0070FF2B
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

	// Token: 0x0601A78B RID: 108427 RVA: 0x00711D44 File Offset: 0x0070FF44
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

	// Token: 0x0601A78C RID: 108428 RVA: 0x00711DB0 File Offset: 0x0070FFB0
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

	// Token: 0x0601A78D RID: 108429 RVA: 0x00711E68 File Offset: 0x00710068
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

	// Token: 0x0601A78E RID: 108430 RVA: 0x00711F08 File Offset: 0x00710108
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

	// Token: 0x0601A78F RID: 108431 RVA: 0x00711FA0 File Offset: 0x007101A0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterInteractivePerformComponent characterInteractivePerformComponent = (CharacterInteractivePerformComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterInteractivePerformComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterInteractivePerformComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterInteractivePerformComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("RequestCacheList"))
		{
			if (characterInteractivePerformComponent.RequestCacheList == null)
			{
				this.RequestCacheList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, IRequestPerformParams>>(this.RequestCacheList), "RequestCacheList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ResponseCacheList"))
		{
			if (characterInteractivePerformComponent.ResponseCacheList == null)
			{
				this.ResponseCacheList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ResponseCacheList), "ResponseCacheList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurHandleRequest"))
		{
			if (characterInteractivePerformComponent.CurHandleRequest == null)
			{
				this.CurHandleRequest = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IRequestPerformParams>(this.CurHandleRequest), "CurHandleRequest"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurHandleConfig"))
		{
			this.CurHandleConfig = characterInteractivePerformComponent.CurHandleConfig;
		}
		if (base.CanResetComponentProperty("ListenCharActionType"))
		{
			this.ListenCharActionType = characterInteractivePerformComponent.ListenCharActionType;
		}
		if (base.CanResetComponentProperty("CurResponseMontage"))
		{
			if (characterInteractivePerformComponent.CurResponseMontage == null)
			{
				this.CurResponseMontage = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UAnimMontage>(this.CurResponseMontage), "CurResponseMontage"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CB0B RID: 51979
	public static readonly string[] animationList = new string[]
	{
		"/Game/Aki/Character/Role/MaleM/BaseAnim/AM_Sit_1_Stand.AM_Sit_1_Stand",
		"/Game/Aki/Character/Role/FemaleM/BaseAnim/AM_Sit_1_Stand.AM_Sit_1_Stand"
	};

	// Token: 0x0400CB0C RID: 51980
	[Nullable(2)]
	protected CharacterActorComponent ActorComp;

	// Token: 0x0400CB0D RID: 51981
	[Nullable(2)]
	protected CharacterAnimationComponent AnimComp;

	// Token: 0x0400CB0E RID: 51982
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400CB0F RID: 51983
	protected Dictionary<int, IRequestPerformParams> RequestCacheList = new Dictionary<int, IRequestPerformParams>();

	// Token: 0x0400CB10 RID: 51984
	protected HashSet<int> ResponseCacheList = new HashSet<int>();

	// Token: 0x0400CB11 RID: 51985
	[Nullable(2)]
	protected IRequestPerformParams CurHandleRequest;

	// Token: 0x0400CB12 RID: 51986
	protected AnsPerform? CurHandleConfig;

	// Token: 0x0400CB13 RID: 51987
	protected ECharacterActionType? ListenCharActionType;

	// Token: 0x0400CB14 RID: 51988
	[Nullable(2)]
	protected UAnimMontage CurResponseMontage;
}
