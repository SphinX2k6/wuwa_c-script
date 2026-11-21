using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200270D RID: 9997
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillXinyuehu : SpecialSkillMorphBase
{
	// Token: 0x060190F1 RID: 102641 RVA: 0x007A2A54 File Offset: 0x007A0C54
	public override void OnStart()
	{
		base.OnStart();
		Entity ownerEntity = base.GetOwnerEntity();
		this.InputComp = ownerEntity.GetComponent<CharacterInputComponent>();
		this.StateComp = ownerEntity.GetComponent<CharacterUnifiedStateComponent>();
		this.CharAnimComp = ownerEntity.GetComponent<CharacterAnimationComponent>();
		BaseTagComponent tagComp = this.TagComp;
		this.MorphFoxTagListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.变身狐狸"]), new BaseTagComponent.TTagSwitchedCallback(this.OnMorphFoxTagChanged), null) : null);
		base.RegisterCodeFunction(CodeFunctionAnimalFoxGetInputForwardAngle.FunctionName, new CodeFunctionAnimalFoxGetInputForwardAngle(this));
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null && tagComp2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.变身狐狸"]))
		{
			this.EnterFoxMovement();
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe)
		{
			EventSystem.Instance.AddWithTarget<int>(this.SpecialSkillComponent.Entity, EEventName.OnBeforeBeCaughtWithTarget, new Action<int>(this.OnBeforeBeCaught));
		}
	}

	// Token: 0x060190F2 RID: 102642 RVA: 0x007A2B3D File Offset: 0x007A0D3D
	public override void OnActivate()
	{
		base.OnActivate();
		if (this.FoxMoveActive)
		{
			this.RefreshMovementState();
		}
	}

	// Token: 0x060190F3 RID: 102643 RVA: 0x007A2B53 File Offset: 0x007A0D53
	public override void OnEnable()
	{
		base.OnEnable();
		this.MoveInputEnabled = true;
		if (this.FoxMoveActive)
		{
			this.RefreshMovementState();
		}
	}

	// Token: 0x060190F4 RID: 102644 RVA: 0x007A2B70 File Offset: 0x007A0D70
	public override void OnDisable()
	{
		this.MoveInputEnabled = false;
		if (this.FoxMoveActive)
		{
			CharacterInputComponent inputComp = this.InputComp;
			if (inputComp != null)
			{
				inputComp.SetInputAngleRanges(null);
			}
		}
		base.OnDisable();
	}

	// Token: 0x060190F5 RID: 102645 RVA: 0x007A2B9C File Offset: 0x007A0D9C
	public override void OnEnd()
	{
		this.MoveInputEnabled = false;
		this.ExitFoxMovement();
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.变身狐狸"], new BaseTagComponent.TTagSwitchedCallback(this.OnMorphFoxTagChanged));
		}
		ITagTask morphFoxTagListener = this.MorphFoxTagListener;
		if (morphFoxTagListener != null)
		{
			morphFoxTagListener.EndTask();
		}
		this.MorphFoxTagListener = null;
		if (EventSystem.Instance.HasWithTarget<int>(this.SpecialSkillComponent.Entity, EEventName.OnBeforeBeCaughtWithTarget, new Action<int>(this.OnBeforeBeCaught)))
		{
			EventSystem.Instance.RemoveWithTarget<int>(this.SpecialSkillComponent.Entity, EEventName.OnBeforeBeCaughtWithTarget, new Action<int>(this.OnBeforeBeCaught));
		}
		base.OnEnd();
	}

	// Token: 0x060190F6 RID: 102646 RVA: 0x007A2C49 File Offset: 0x007A0E49
	public override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (this.FoxMoveActive)
		{
			this.TickSpeedReduceByAngle();
		}
	}

	// Token: 0x060190F7 RID: 102647 RVA: 0x007A2C60 File Offset: 0x007A0E60
	protected override void OnBeforeResetMorph()
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp != null && morphComp.GetMorphType() == EMorphType.变身形态)
		{
			BaseGameplayCueComponent cueComp = this.CueComp;
			GameplayCueEffect gameplayCueEffect = ((cueComp != null) ? cueComp.GetCueByCueId(1311200001L) : null) as GameplayCueEffect;
			if (gameplayCueEffect != null)
			{
				gameplayCueEffect.IsForceRecycle = true;
			}
		}
	}

	// Token: 0x170027C4 RID: 10180
	// (get) Token: 0x060190F8 RID: 102648 RVA: 0x007A2CAC File Offset: 0x007A0EAC
	protected override string MorphBuffsConfigKey
	{
		get
		{
			return "XinyuehuMorphBuffs";
		}
	}

	// Token: 0x170027C5 RID: 10181
	// (get) Token: 0x060190F9 RID: 102649 RVA: 0x007A2CB3 File Offset: 0x007A0EB3
	protected override string MorphCueIdConfigKey
	{
		get
		{
			return "XinyuehuMorphCues";
		}
	}

	// Token: 0x170027C6 RID: 10182
	// (get) Token: 0x060190FA RID: 102650 RVA: 0x007A2CBA File Offset: 0x007A0EBA
	protected override string ResetMorphSkillsConfigKey
	{
		get
		{
			return "XinyuehuResetMorphSkills";
		}
	}

	// Token: 0x170027C7 RID: 10183
	// (get) Token: 0x060190FB RID: 102651 RVA: 0x007A2CC1 File Offset: 0x007A0EC1
	protected override string NotResetMorphSkillsConfigKey
	{
		get
		{
			return "XinyuehuNotResetMorphSkills";
		}
	}

	// Token: 0x170027C8 RID: 10184
	// (get) Token: 0x060190FC RID: 102652 RVA: 0x007A2CC8 File Offset: 0x007A0EC8
	protected override string ChangeRoleResetMorphTagsConfigKey
	{
		get
		{
			return "XinyuehuChangeRoleResetMorphTags";
		}
	}

	// Token: 0x060190FD RID: 102653 RVA: 0x007A2CCF File Offset: 0x007A0ECF
	protected override string GetSubMeshConfigKey(EMorphType morphType)
	{
		if (morphType == EMorphType.默认形态)
		{
			return "XinyuehuMorph0SubMeshList";
		}
		if (morphType != EMorphType.变身形态)
		{
			return "";
		}
		return "XinyuehuMorph1SubMeshList";
	}

	// Token: 0x060190FE RID: 102654 RVA: 0x007A2CEB File Offset: 0x007A0EEB
	private void OnBeforeBeCaught(int catcherId)
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp != null && morphComp.GetMorphType() == EMorphType.变身形态2)
		{
			base.ResetMorph(true);
		}
	}

	// Token: 0x060190FF RID: 102655 RVA: 0x007A2D0B File Offset: 0x007A0F0B
	private void OnMorphFoxTagChanged(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			this.EnterFoxMovement();
			return;
		}
		this.ExitFoxMovement();
	}

	// Token: 0x06019100 RID: 102656 RVA: 0x007A2D1D File Offset: 0x007A0F1D
	private void EnterFoxMovement()
	{
		if (this.FoxMoveActive)
		{
			return;
		}
		this.FoxMoveActive = true;
		EventSystem.Instance.Add<bool, bool, bool>(EEventName.OnChangeWalkOrRun, new Action<bool, bool, bool>(this.OnWalkRunChanged));
		this.RegisterFoxMovementTagListeners();
		this.RefreshMovementState();
	}

	// Token: 0x06019101 RID: 102657 RVA: 0x007A2D58 File Offset: 0x007A0F58
	private void ExitFoxMovement()
	{
		if (!this.FoxMoveActive)
		{
			return;
		}
		this.FoxMoveActive = false;
		CharacterInputComponent inputComp = this.InputComp;
		if (inputComp != null)
		{
			inputComp.SetInputAngleRanges(null);
		}
		EventSystem.Instance.Remove<bool, bool, bool>(EEventName.OnChangeWalkOrRun, new Action<bool, bool, bool>(this.OnWalkRunChanged));
		this.UnregisterFoxMovementTagListeners();
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.走"]));
		}
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null)
		{
			tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.跑"]));
		}
		this.ResetSpeedReduction();
	}

	// Token: 0x06019102 RID: 102658 RVA: 0x007A2DFC File Offset: 0x007A0FFC
	private void TickSpeedReduceByAngle()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.MoveComp : null) == null)
		{
			return;
		}
		Vector vector = (this.InputComp != null) ? this.InputComp.GetWorldMoveDirectionCache() : this.ActorComp.InputDirectProxy;
		if (!vector.IsNearlyZero(9.999999747378752E-05))
		{
			CharacterAnimationComponent charAnimComp = this.CharAnimComp;
			bool flag;
			if (charAnimComp == null)
			{
				flag = false;
			}
			else
			{
				UAnimInstance mainAnimInstance = charAnimComp.MainAnimInstance;
				flag = ((mainAnimInstance != null) ? new bool?(mainAnimInstance.HasKuroRootMotionAnim()) : null).GetValueOrDefault();
			}
			if (!flag)
			{
				Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
				Vector inN = this.ActorComp.MoveComp.GravityUp ?? Vector.UpVectorProxy;
				float num = Math.Abs((float)MathUtils.Instance.SignedAngleOnPlaneDeg(actorForwardProxy, vector, inN));
				float num2;
				if (num <= 60f)
				{
					num2 = 1f;
				}
				else
				{
					float currentValue = (num - 60f) / 120f;
					num2 = 1f - 0.7f * MathUtils.Instance.Clamp(currentValue, 0f, 1f);
				}
				if (num2 < this.SpeedRatioByAngle)
				{
					this.SpeedRatioByAngle = num2;
				}
				else
				{
					this.SpeedRatioByAngle = (float)MathUtils.Instance.InterpTo((double)this.SpeedRatioByAngle, (double)num2, (double)Time.Instance.DeltaTimeSeconds, 5.0);
				}
				if (this.SpeedRatioByAngle >= 1f)
				{
					this.ResetSpeedReduction();
					return;
				}
				float? baseSpeed = this.GetBaseSpeed();
				if (baseSpeed == null)
				{
					this.ResetSpeedReduction();
					return;
				}
				this.HasSpeedReductionOverride = true;
				this.ActorComp.MoveComp.SetOverrideMaxSpeed(baseSpeed.Value * this.SpeedRatioByAngle);
				return;
			}
		}
		this.ResetSpeedReduction();
	}

	// Token: 0x06019103 RID: 102659 RVA: 0x007A2FA8 File Offset: 0x007A11A8
	private void ResetSpeedReduction()
	{
		this.SpeedRatioByAngle = 1f;
		CharacterActorComponent actorComp = this.ActorComp;
		BaseMoveComponent baseMoveComponent = (actorComp != null) ? actorComp.MoveComp : null;
		if (baseMoveComponent == null || !this.HasSpeedReductionOverride)
		{
			this.HasSpeedReductionOverride = false;
			return;
		}
		this.HasSpeedReductionOverride = false;
		baseMoveComponent.ResetOverrideMaxSpeed();
		BaseMoveComponent baseMoveComponent2 = baseMoveComponent;
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		baseMoveComponent2.ResetMaxSpeed((stateComp != null) ? new ECharMoveState?(stateComp.MoveState) : null);
	}

	// Token: 0x06019104 RID: 102660 RVA: 0x007A3018 File Offset: 0x007A1218
	private float? GetBaseSpeed()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		SMovementSetting smovementSetting;
		if (actorComp == null)
		{
			smovementSetting = null;
		}
		else
		{
			BaseMoveComponent moveComp = actorComp.MoveComp;
			smovementSetting = ((moveComp != null) ? moveComp.CurrentMovementSettings : null);
		}
		SMovementSetting smovementSetting2 = smovementSetting;
		if (smovementSetting2 == null || this.StateComp == null)
		{
			return null;
		}
		ECharMoveState moveState = this.StateComp.MoveState;
		if (moveState == ECharMoveState.Walk)
		{
			return new float?(smovementSetting2.WalkSpeed);
		}
		if (moveState != ECharMoveState.Sprint)
		{
			return new float?(smovementSetting2.RunSpeed);
		}
		return new float?(smovementSetting2.SprintSpeed);
	}

	// Token: 0x06019105 RID: 102661 RVA: 0x007A3098 File Offset: 0x007A1298
	private void RefreshMovementState()
	{
		if (!this.FoxMoveActive)
		{
			return;
		}
		CharacterUnifiedStateComponent stateComp = this.StateComp;
		bool flag = stateComp != null && stateComp.IsWalkMode;
		if (flag)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.跑"]));
			}
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 == null || !tagComp2.HasTag(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.走"]))
			{
				BaseTagComponent tagComp3 = this.TagComp;
				if (tagComp3 != null)
				{
					tagComp3.AddTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.走"]));
				}
			}
		}
		else
		{
			BaseTagComponent tagComp4 = this.TagComp;
			if (tagComp4 != null)
			{
				tagComp4.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.走"]));
			}
			BaseTagComponent tagComp5 = this.TagComp;
			if (tagComp5 == null || !tagComp5.HasTag(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.跑"]))
			{
				BaseTagComponent tagComp6 = this.TagComp;
				if (tagComp6 != null)
				{
					tagComp6.AddTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.移动模式.跑"]));
				}
			}
		}
		if (this.MoveInputEnabled && this.InputComp != null)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (((actorComp != null) ? actorComp.MoveComp : null) != null)
			{
				BaseTagComponent tagComp7 = this.TagComp;
				if (tagComp7 != null && tagComp7.HasTag(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.状态.转身中"]))
				{
					this.InputComp.SetInputAngleRanges(null);
					return;
				}
				if (!flag)
				{
					this.ActorComp.MoveComp.ResetTurnRate();
					this.InputComp.SetInputAngleRanges(new InputAngleRange[]
					{
						new InputAngleRange
						{
							PassRangeStart = 210f,
							PassRangeEnd = 150f,
							ClampRangeStart = 285f,
							ClampRangeEnd = 75f
						},
						new InputAngleRange
						{
							PassRangeStart = 150f,
							PassRangeEnd = 210f,
							ClampRangeStart = 160f,
							ClampRangeEnd = 200f
						}
					});
					return;
				}
				this.InputComp.SetInputAngleRanges(new InputAngleRange[]
				{
					new InputAngleRange
					{
						PassRangeStart = 0f,
						PassRangeEnd = 360f,
						ClampRangeStart = 285f,
						ClampRangeEnd = 75f
					}
				});
				return;
			}
		}
	}

	// Token: 0x06019106 RID: 102662 RVA: 0x007A32FC File Offset: 0x007A14FC
	private void RefreshMovementStateTagCallback(int tagId, bool tagExist)
	{
		this.RefreshMovementState();
	}

	// Token: 0x06019107 RID: 102663 RVA: 0x007A3304 File Offset: 0x007A1504
	private void OnWalkRunChanged(bool lastIsWalk, bool isWalk, bool showUi)
	{
		this.RefreshMovementState();
	}

	// Token: 0x06019108 RID: 102664 RVA: 0x007A330C File Offset: 0x007A150C
	private void RegisterFoxMovementTagListeners()
	{
		BaseTagComponent tagComp = this.TagComp;
		this.TurnTagListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.状态.转身中"]), new BaseTagComponent.TTagSwitchedCallback(this.RefreshMovementStateTagCallback), null) : null);
	}

	// Token: 0x06019109 RID: 102665 RVA: 0x007A3348 File Offset: 0x007A1548
	private void UnregisterFoxMovementTagListeners()
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.状态.转身中"], new BaseTagComponent.TTagSwitchedCallback(this.RefreshMovementStateTagCallback));
		}
		ITagTask turnTagListener = this.TurnTagListener;
		if (turnTagListener != null)
		{
			turnTagListener.EndTask();
		}
		this.TurnTagListener = null;
	}

	// Token: 0x0601910A RID: 102666 RVA: 0x007A3399 File Offset: 0x007A1599
	public SpecialSkillXinyuehu(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0400DACD RID: 56013
	private const float SPEED_REDUCE_ANGLE_THRESHOLD = 60f;

	// Token: 0x0400DACE RID: 56014
	private const float SPEED_REDUCE_MIN_RATIO = 0.3f;

	// Token: 0x0400DACF RID: 56015
	private const float SPEED_REDUCE_INTERP_SPEED = 5f;

	// Token: 0x0400DAD0 RID: 56016
	private const long MORPH_RING_CUE_ID = 1311200001L;

	// Token: 0x0400DAD1 RID: 56017
	[Nullable(2)]
	private CharacterInputComponent InputComp;

	// Token: 0x0400DAD2 RID: 56018
	private bool MoveInputEnabled = true;

	// Token: 0x0400DAD3 RID: 56019
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400DAD4 RID: 56020
	[Nullable(2)]
	private CharacterAnimationComponent CharAnimComp;

	// Token: 0x0400DAD5 RID: 56021
	private bool FoxMoveActive;

	// Token: 0x0400DAD6 RID: 56022
	private float SpeedRatioByAngle = 1f;

	// Token: 0x0400DAD7 RID: 56023
	private bool HasSpeedReductionOverride;

	// Token: 0x0400DAD8 RID: 56024
	[Nullable(2)]
	private ITagTask MorphFoxTagListener;

	// Token: 0x0400DAD9 RID: 56025
	[Nullable(2)]
	private ITagTask TurnTagListener;
}
