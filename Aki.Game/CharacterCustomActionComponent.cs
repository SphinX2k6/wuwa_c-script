using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x0200240F RID: 9231
[NullableContext(2)]
[Nullable(0)]
public class CharacterCustomActionComponent : EntityComponent
{
	// Token: 0x0601718B RID: 94603 RVA: 0x006C06DC File Offset: 0x006BE8DC
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

	// Token: 0x0601718C RID: 94604 RVA: 0x006C0764 File Offset: 0x006BE964
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

	// Token: 0x0601718D RID: 94605 RVA: 0x006C07C4 File Offset: 0x006BE9C4
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

	// Token: 0x0601718E RID: 94606 RVA: 0x006C081F File Offset: 0x006BEA1F
	protected override bool OnEnd()
	{
		if (this.PlayerControlForbidCount > 0)
		{
			this.PlayerControlForbidCount = 0;
			this.RegainPlayerActivity();
		}
		return true;
	}

	// Token: 0x0601718F RID: 94607 RVA: 0x006C083C File Offset: 0x006BEA3C
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

	// Token: 0x06017190 RID: 94608 RVA: 0x006C08F8 File Offset: 0x006BEAF8
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

	// Token: 0x06017191 RID: 94609 RVA: 0x006C0930 File Offset: 0x006BEB30
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

	// Token: 0x06017192 RID: 94610 RVA: 0x006C09F8 File Offset: 0x006BEBF8
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

	// Token: 0x06017193 RID: 94611 RVA: 0x006C0A58 File Offset: 0x006BEC58
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

	// Token: 0x06017194 RID: 94612 RVA: 0x006C0AA4 File Offset: 0x006BECA4
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

	// Token: 0x06017195 RID: 94613 RVA: 0x006C0AD8 File Offset: 0x006BECD8
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

	// Token: 0x06017196 RID: 94614 RVA: 0x006C0B28 File Offset: 0x006BED28
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

	// Token: 0x06017197 RID: 94615 RVA: 0x006C0BCC File Offset: 0x006BEDCC
	public void AddCustomSetPlayerControl(bool forbid, Action callback = null)
	{
		CustomSetPlayerControl element = new CustomSetPlayerControl(forbid, new Func<bool, bool>(this.ApplyPlayerControl), callback);
		this.ActionQueue.Push(element);
	}

	// Token: 0x06017198 RID: 94616 RVA: 0x006C0BF9 File Offset: 0x006BEDF9
	public void SetPlayerControlImmediately(bool forbid, Action callback = null)
	{
		new CustomSetPlayerControl(forbid, new Func<bool, bool>(this.ApplyPlayerControl), callback).RunAction();
	}

	// Token: 0x06017199 RID: 94617 RVA: 0x006C0C14 File Offset: 0x006BEE14
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

	// Token: 0x0601719A RID: 94618 RVA: 0x006C0C58 File Offset: 0x006BEE58
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCustomActionComponent characterCustomActionComponent = (CharacterCustomActionComponent)componentTemplate;
		this.PlayerControlForbidCount = characterCustomActionComponent.PlayerControlForbidCount;
		if (characterCustomActionComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterCustomActionComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterCustomActionComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterCustomActionComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		if (characterCustomActionComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		if (characterCustomActionComponent.InputComp == null)
		{
			this.InputComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
		{
			return false;
		}
		if (characterCustomActionComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		return characterCustomActionComponent.ActionQueue == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActionQueue), "ActionQueue");
	}

	// Token: 0x170023DE RID: 9182
	// (get) Token: 0x0601719B RID: 94619 RVA: 0x006C0DD3 File Offset: 0x006BEFD3
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023DF RID: 9183
	// (get) Token: 0x0601719C RID: 94620 RVA: 0x006C0DD6 File Offset: 0x006BEFD6
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023E0 RID: 9184
	// (get) Token: 0x0601719D RID: 94621 RVA: 0x006C0DD9 File Offset: 0x006BEFD9
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C26A RID: 49770
	protected const int MODEL_BUFFER_TIME = 200;

	// Token: 0x0400C26B RID: 49771
	protected const float MAX_ROTATION_TIME = 1000f;

	// Token: 0x0400C26C RID: 49772
	protected const float ROTATION_ANGLE_TOLERANCE = 10f;

	// Token: 0x0400C26D RID: 49773
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

	// Token: 0x0400C26E RID: 49774
	[Nullable(1)]
	private readonly string Reason = "[CharacterCustomActionComponent] Input Limited Action";

	// Token: 0x0400C26F RID: 49775
	private int PlayerControlForbidCount;

	// Token: 0x0400C270 RID: 49776
	private CharacterActorComponent ActorComp;

	// Token: 0x0400C271 RID: 49777
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400C272 RID: 49778
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400C273 RID: 49779
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400C274 RID: 49780
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400C275 RID: 49781
	private CharacterInputComponent InputComp;

	// Token: 0x0400C276 RID: 49782
	private BaseTagComponent TagComp;

	// Token: 0x0400C277 RID: 49783
	[Nullable(1)]
	private readonly Queue<CustomActionBase> ActionQueue = new Queue<CustomActionBase>(4);
}
