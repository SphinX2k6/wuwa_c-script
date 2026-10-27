using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200319F RID: 12703
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillXinyuehu : SpecialSkillMorphBase
{
	// Token: 0x0601B5D1 RID: 112081 RVA: 0x0077A7C8 File Offset: 0x007789C8
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

	// Token: 0x0601B5D2 RID: 112082 RVA: 0x0077A8B1 File Offset: 0x00778AB1
	public override void OnActivate()
	{
		base.OnActivate();
		if (this.FoxMoveActive)
		{
			this.RefreshMovementState();
		}
	}

	// Token: 0x0601B5D3 RID: 112083 RVA: 0x0077A8C7 File Offset: 0x00778AC7
	public override void OnEnable()
	{
		base.OnEnable();
		this.MoveInputEnabled = true;
		if (this.FoxMoveActive)
		{
			this.RefreshMovementState();
		}
	}

	// Token: 0x0601B5D4 RID: 112084 RVA: 0x0077A8E4 File Offset: 0x00778AE4
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

	// Token: 0x0601B5D5 RID: 112085 RVA: 0x0077A910 File Offset: 0x00778B10
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

	// Token: 0x0601B5D6 RID: 112086 RVA: 0x0077A9BD File Offset: 0x00778BBD
	public override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (this.FoxMoveActive)
		{
			this.TickSpeedReduceByAngle();
		}
	}

	// Token: 0x0601B5D7 RID: 112087 RVA: 0x0077A9D4 File Offset: 0x00778BD4
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

	// Token: 0x170025D3 RID: 9683
	// (get) Token: 0x0601B5D8 RID: 112088 RVA: 0x0077AA20 File Offset: 0x00778C20
	protected override string MorphBuffsConfigKey
	{
		get
		{
			return "XinyuehuMorphBuffs";
		}
	}

	// Token: 0x170025D4 RID: 9684
	// (get) Token: 0x0601B5D9 RID: 112089 RVA: 0x0077AA27 File Offset: 0x00778C27
	protected override string MorphCueIdConfigKey
	{
		get
		{
			return "XinyuehuMorphCues";
		}
	}

	// Token: 0x170025D5 RID: 9685
	// (get) Token: 0x0601B5DA RID: 112090 RVA: 0x0077AA2E File Offset: 0x00778C2E
	protected override string ResetMorphSkillsConfigKey
	{
		get
		{
			return "XinyuehuResetMorphSkills";
		}
	}

	// Token: 0x170025D6 RID: 9686
	// (get) Token: 0x0601B5DB RID: 112091 RVA: 0x0077AA35 File Offset: 0x00778C35
	protected override string NotResetMorphSkillsConfigKey
	{
		get
		{
			return "XinyuehuNotResetMorphSkills";
		}
	}

	// Token: 0x170025D7 RID: 9687
	// (get) Token: 0x0601B5DC RID: 112092 RVA: 0x0077AA3C File Offset: 0x00778C3C
	protected override string ChangeRoleResetMorphTagsConfigKey
	{
		get
		{
			return "XinyuehuChangeRoleResetMorphTags";
		}
	}

	// Token: 0x0601B5DD RID: 112093 RVA: 0x0077AA43 File Offset: 0x00778C43
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

	// Token: 0x0601B5DE RID: 112094 RVA: 0x0077AA5F File Offset: 0x00778C5F
	private void OnBeforeBeCaught(int catcherId)
	{
		CharacterMorphComponent morphComp = this.MorphComp;
		if (morphComp != null && morphComp.GetMorphType() == EMorphType.变身形态2)
		{
			base.ResetMorph(true);
		}
	}

	// Token: 0x0601B5DF RID: 112095 RVA: 0x0077AA7F File Offset: 0x00778C7F
	private void OnMorphFoxTagChanged(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			this.EnterFoxMovement();
			return;
		}
		this.ExitFoxMovement();
	}

	// Token: 0x0601B5E0 RID: 112096 RVA: 0x0077AA91 File Offset: 0x00778C91
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

	// Token: 0x0601B5E1 RID: 112097 RVA: 0x0077AACC File Offset: 0x00778CCC
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

	// Token: 0x0601B5E2 RID: 112098 RVA: 0x0077AB70 File Offset: 0x00778D70
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

	// Token: 0x0601B5E3 RID: 112099 RVA: 0x0077AD1C File Offset: 0x00778F1C
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

	// Token: 0x0601B5E4 RID: 112100 RVA: 0x0077AD8C File Offset: 0x00778F8C
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

	// Token: 0x0601B5E5 RID: 112101 RVA: 0x0077AE0C File Offset: 0x0077900C
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

	// Token: 0x0601B5E6 RID: 112102 RVA: 0x0077B070 File Offset: 0x00779270
	private void RefreshMovementStateTagCallback(int tagId, bool tagExist)
	{
		this.RefreshMovementState();
	}

	// Token: 0x0601B5E7 RID: 112103 RVA: 0x0077B078 File Offset: 0x00779278
	private void OnWalkRunChanged(bool lastIsWalk, bool isWalk, bool showUi)
	{
		this.RefreshMovementState();
	}

	// Token: 0x0601B5E8 RID: 112104 RVA: 0x0077B080 File Offset: 0x00779280
	private void RegisterFoxMovementTagListeners()
	{
		BaseTagComponent tagComp = this.TagComp;
		this.TurnTagListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.状态.转身中"]), new BaseTagComponent.TTagSwitchedCallback(this.RefreshMovementStateTagCallback), null) : null);
	}

	// Token: 0x0601B5E9 RID: 112105 RVA: 0x0077B0BC File Offset: 0x007792BC
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

	// Token: 0x0601B5EA RID: 112106 RVA: 0x0077B10D File Offset: 0x0077930D
	public SpecialSkillXinyuehu(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0400D64A RID: 54858
	private const float SPEED_REDUCE_ANGLE_THRESHOLD = 60f;

	// Token: 0x0400D64B RID: 54859
	private const float SPEED_REDUCE_MIN_RATIO = 0.3f;

	// Token: 0x0400D64C RID: 54860
	private const float SPEED_REDUCE_INTERP_SPEED = 5f;

	// Token: 0x0400D64D RID: 54861
	private const long MORPH_RING_CUE_ID = 1311200001L;

	// Token: 0x0400D64E RID: 54862
	[Nullable(2)]
	private CharacterInputComponent InputComp;

	// Token: 0x0400D64F RID: 54863
	private bool MoveInputEnabled = true;

	// Token: 0x0400D650 RID: 54864
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400D651 RID: 54865
	[Nullable(2)]
	private CharacterAnimationComponent CharAnimComp;

	// Token: 0x0400D652 RID: 54866
	private bool FoxMoveActive;

	// Token: 0x0400D653 RID: 54867
	private float SpeedRatioByAngle = 1f;

	// Token: 0x0400D654 RID: 54868
	private bool HasSpeedReductionOverride;

	// Token: 0x0400D655 RID: 54869
	[Nullable(2)]
	private ITagTask MorphFoxTagListener;

	// Token: 0x0400D656 RID: 54870
	[Nullable(2)]
	private ITagTask TurnTagListener;
}
