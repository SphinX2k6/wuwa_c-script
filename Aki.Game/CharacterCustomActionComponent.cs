using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02002EBC RID: 11964
[NullableContext(2)]
[Nullable(0)]
public class CharacterCustomActionComponent : EntityComponent
{
	// Token: 0x060198A5 RID: 104613 RVA: 0x0069A41C File Offset: 0x0069861C
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.SkillComp = base.Entity.GetComponent<CharacterSkillComponent>();
		this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.InputComp = base.Entity.GetComponent<CharacterInputComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x060198A6 RID: 104614 RVA: 0x0069A4A4 File Offset: 0x006986A4
	protected override void OnTick(float delta)
	{
		while (this.ActionQueue.Size > 0)
		{
			CustomActionBase front = this.ActionQueue.Front;
			if (front == null)
			{
				this.ActionQueue.Pop();
			}
			else
			{
				if (!front.CheckStart())
				{
					front.RunAction();
				}
				if (!front.CheckFinish(delta))
				{
					break;
				}
				this.ActionQueue.Pop();
			}
		}
	}

	// Token: 0x060198A7 RID: 104615 RVA: 0x0069A504 File Offset: 0x00698704
	public void AbortAllAction(bool success)
	{
		while (this.ActionQueue.Size > 0)
		{
			CustomActionBase front = this.ActionQueue.Front;
			if (front == null)
			{
				this.ActionQueue.Pop();
			}
			else
			{
				if (!front.CheckStart())
				{
					front.RunAction();
				}
				front.Abort(success);
				this.ActionQueue.Pop();
			}
		}
	}

	// Token: 0x060198A8 RID: 104616 RVA: 0x0069A55F File Offset: 0x0069875F
	protected override bool OnEnd()
	{
		if (this.PlayerControlForbidCount > 0)
		{
			this.PlayerControlForbidCount = 0;
			this.RegainPlayerActivity();
		}
		return true;
	}

	// Token: 0x060198A9 RID: 104617 RVA: 0x0069A57C File Offset: 0x0069877C
	private bool ApplyPlayerControl(bool forbid)
	{
		if (forbid)
		{
			this.PlayerControlForbidCount++;
			if (this.PlayerControlForbidCount > 1)
			{
				return true;
			}
			if (this.StopPlayerActivity())
			{
				return true;
			}
			this.PlayerControlForbidCount = 0;
			return false;
		}
		else
		{
			if (this.PlayerControlForbidCount <= 0)
			{
				this.PlayerControlForbidCount = 0;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[CustomAction][SetPlayerControl] 禁控计数重复释放";
				string item = "EntityId";
				CharacterActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.Entity.Id) : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.PlayerControlForbidCount--;
			return this.PlayerControlForbidCount > 0 || this.RegainPlayerActivity();
		}
	}

	// Token: 0x060198AA RID: 104618 RVA: 0x0069A638 File Offset: 0x00698838
	private bool RegainPlayerActivity()
	{
		CharacterInputComponent inputComp = this.InputComp;
		if (inputComp != null)
		{
			inputComp.ClearMoveVectorCache();
		}
		CharacterInputComponent inputComp2 = this.InputComp;
		if (inputComp2 != null)
		{
			inputComp2.SetActive(true);
		}
		this.UpdatePlayerInputLimitTags(-1);
		InputDistributeController.Instance.RefreshInputTag();
		return true;
	}

	// Token: 0x060198AB RID: 104619 RVA: 0x0069A670 File Offset: 0x00698870
	private bool StopPlayerActivity()
	{
		EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, this.Reason);
		if (this.StateComp == null || this.ActorComp == null)
		{
			return false;
		}
		if (this.StateComp.DirectionState == ECharDirectionState.AimDirection)
		{
			this.StateComp.ExitAimStatus();
		}
		else
		{
			this.StateComp.SetDirectionState(this.StateComp.DirectionState);
		}
		CharacterSkillComponent skillComp = this.SkillComp;
		if (((skillComp != null) ? skillComp.CurrentSkill : null) != null)
		{
			this.SkillComp.EndOwnerAndFollowSkills();
		}
		this.ActorComp.ClearInput(false, true);
		CharacterInputComponent inputComp = this.InputComp;
		if (inputComp != null)
		{
			inputComp.ClearMoveVectorCache();
		}
		CharacterInputComponent inputComp2 = this.InputComp;
		if (inputComp2 != null)
		{
			inputComp2.SetActive(false);
		}
		this.UpdatePlayerInputLimitTags(1);
		InputDistributeController.Instance.RefreshInputTag();
		return true;
	}

	// Token: 0x060198AC RID: 104620 RVA: 0x0069A738 File Offset: 0x00698938
	private void UpdatePlayerInputLimitTags(int deltaCount)
	{
		foreach (int tagId in CharacterCustomActionComponent.PlayerInputLimitTagList)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.TagContainer.UpdateExactTag(ETagChannel.Common, tagId, deltaCount);
			}
		}
	}

	// Token: 0x060198AD RID: 104621 RVA: 0x0069A798 File Offset: 0x00698998
	[NullableContext(1)]
	public void AddCustomMoveToLocation(global::Vector loc, Action callback, [Nullable(2)] Action onStart = null)
	{
		if (this.MoveComp == null || this.AnimComp == null)
		{
			return;
		}
		global::Vector targetLocation = global::Vector.Create(loc);
		CustomMoveToLocation element = new CustomMoveToLocation(this.MoveComp, this.AnimComp, targetLocation, callback, onStart, 200);
		this.ActionQueue.Push(element);
	}

	// Token: 0x060198AE RID: 104622 RVA: 0x0069A7E4 File Offset: 0x006989E4
	[NullableContext(1)]
	public void AddCustomSetCollision(BaseActorComponent target, bool ignore, [Nullable(2)] Action callback = null)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		CustomSetCollision element = new CustomSetCollision(this.ActorComp, target, ignore, callback);
		this.ActionQueue.Push(element);
	}

	// Token: 0x060198AF RID: 104623 RVA: 0x0069A818 File Offset: 0x00698A18
	public CustomSetActorRotation AddCustomSetTurnToTarget([Nullable(1)] BaseActorComponent target, double angle = 0.0, ECustomSetRotationType type = ECustomSetRotationType.FaceToTarget, Action callback = null, int? time = null)
	{
		if (this.ActorComp == null || this.AnimComp == null)
		{
			return null;
		}
		CustomSetActorRotation customSetActorRotation = new CustomSetActorRotation(this.ActorComp, target, this.AnimComp, angle, type, callback, time.GetValueOrDefault(200));
		this.ActionQueue.Push(customSetActorRotation);
		return customSetActorRotation;
	}

	// Token: 0x060198B0 RID: 104624 RVA: 0x0069A868 File Offset: 0x00698A68
	public void AddCustomPlayMontage([Nullable(1)] string path, int? montageId = null, Action onPlayMontage = null, Action onStopMontage = null, Action callback = null)
	{
		if (this.AnimComp == null)
		{
			return;
		}
		AbpMontageData? abpMontageData = (montageId != null) ? ConfigAbpMontageDataById.GetConfig(montageId.Value, true) : null;
		object obj;
		if (abpMontageData == null || abpMontageData.Value.InitState.Length <= 0)
		{
			obj = null;
		}
		else
		{
			(obj = new IAnimStateParam()).InitStateName = abpMontageData.Value.InitState;
		}
		IAnimStateParam state = obj;
		CustomPlayMontage element = new CustomPlayMontage(base.Entity.GetComponent<BasePerformComponent>(), this.AnimComp, path, state, onPlayMontage, onStopMontage, callback);
		this.ActionQueue.Push(element);
	}

	// Token: 0x060198B1 RID: 104625 RVA: 0x0069A90C File Offset: 0x00698B0C
	public void AddCustomSetPlayerControl(bool forbid, Action callback = null)
	{
		CustomSetPlayerControl element = new CustomSetPlayerControl(forbid, new Func<bool, bool>(this.ApplyPlayerControl), callback);
		this.ActionQueue.Push(element);
	}

	// Token: 0x060198B2 RID: 104626 RVA: 0x0069A939 File Offset: 0x00698B39
	public void SetPlayerControlImmediately(bool forbid, Action callback = null)
	{
		new CustomSetPlayerControl(forbid, new Func<bool, bool>(this.ApplyPlayerControl), callback).RunAction();
	}

	// Token: 0x060198B3 RID: 104627 RVA: 0x0069A954 File Offset: 0x00698B54
	public void AddCustomWaitMontageEnd(bool waitEnd, bool waitLoop, Action callback = null)
	{
		BasePerformComponent component = base.Entity.GetComponent<BasePerformComponent>();
		if (this.AnimComp == null || component == null)
		{
			return;
		}
		CustomWaitMontageEnd element = new CustomWaitMontageEnd(component, this.AnimComp, waitEnd, waitLoop, callback);
		this.ActionQueue.Push(element);
	}

	// Token: 0x060198B4 RID: 104628 RVA: 0x0069A998 File Offset: 0x00698B98
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCustomActionComponent characterCustomActionComponent = (CharacterCustomActionComponent)componentTemplate;
		if (base.CanResetComponentProperty("PlayerControlForbidCount"))
		{
			this.PlayerControlForbidCount = characterCustomActionComponent.PlayerControlForbidCount;
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterCustomActionComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterCustomActionComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterCustomActionComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterCustomActionComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StateComp"))
		{
			if (characterCustomActionComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InputComp"))
		{
			if (characterCustomActionComponent.InputComp == null)
			{
				this.InputComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterInputComponent>(this.InputComp), "InputComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterCustomActionComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("ActionQueue") || characterCustomActionComponent.ActionQueue == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Queue<CustomActionBase>>(this.ActionQueue), "ActionQueue");
	}

	// Token: 0x0400BECF RID: 48847
	protected const int MODEL_BUFFER_TIME = 200;

	// Token: 0x0400BED0 RID: 48848
	protected const float MAX_ROTATION_TIME = 1000f;

	// Token: 0x0400BED1 RID: 48849
	protected const float ROTATION_ANGLE_TOLERANCE = 10f;

	// Token: 0x0400BED2 RID: 48850
	[Nullable(1)]
	private static readonly IReadOnlyList<int> PlayerInputLimitTagList = new <>z__ReadOnlyArray<int>(new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止跳跃"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攀爬"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止闪避"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象1"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象2"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止锁定目标"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止瞄准开镜"]
	});

	// Token: 0x0400BED3 RID: 48851
	[Nullable(1)]
	private readonly string Reason = "[CharacterCustomActionComponent] Input Limited Action";

	// Token: 0x0400BED4 RID: 48852
	private int PlayerControlForbidCount;

	// Token: 0x0400BED5 RID: 48853
	private CharacterActorComponent ActorComp;

	// Token: 0x0400BED6 RID: 48854
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400BED7 RID: 48855
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400BED8 RID: 48856
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400BED9 RID: 48857
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400BEDA RID: 48858
	private CharacterInputComponent InputComp;

	// Token: 0x0400BEDB RID: 48859
	private BaseTagComponent TagComp;

	// Token: 0x0400BEDC RID: 48860
	[Nullable(1)]
	private readonly Queue<CustomActionBase> ActionQueue = new Queue<CustomActionBase>(4);
}
