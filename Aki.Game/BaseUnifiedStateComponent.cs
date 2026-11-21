using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020027E6 RID: 10214
[NullableContext(2)]
[Nullable(0)]
public class BaseUnifiedStateComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06019B1E RID: 105246 RVA: 0x007E9B3E File Offset: 0x007E7D3E
	static BaseUnifiedStateComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseUnifiedStateComponent.CreateStaticDefaultValue), new Action(BaseUnifiedStateComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700292D RID: 10541
	// (get) Token: 0x06019B1F RID: 105247 RVA: 0x007E9B5D File Offset: 0x007E7D5D
	// (set) Token: 0x06019B20 RID: 105248 RVA: 0x007E9B65 File Offset: 0x007E7D65
	protected virtual ECharPositionState CachedPositionState { get; set; }

	// Token: 0x1700292E RID: 10542
	// (get) Token: 0x06019B21 RID: 105249 RVA: 0x007E9B6E File Offset: 0x007E7D6E
	// (set) Token: 0x06019B22 RID: 105250 RVA: 0x007E9B76 File Offset: 0x007E7D76
	protected virtual ECharMoveState CachedMoveState { get; set; } = ECharMoveState.Stand;

	// Token: 0x1700292F RID: 10543
	// (get) Token: 0x06019B23 RID: 105251 RVA: 0x007E9B7F File Offset: 0x007E7D7F
	// (set) Token: 0x06019B24 RID: 105252 RVA: 0x007E9B87 File Offset: 0x007E7D87
	protected virtual ECharDirectionState CachedDirectionState { get; set; } = ECharDirectionState.FaceDirection;

	// Token: 0x06019B25 RID: 105253 RVA: 0x007E9B90 File Offset: 0x007E7D90
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.GetComponent<BaseActorComponent>();
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		this.IsInGameInternal = new bool?(false);
		this.InitCharState();
		EventSystem.Instance.AddWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnMovementModeChanged));
		return true;
	}

	// Token: 0x06019B26 RID: 105254 RVA: 0x007E9BF4 File Offset: 0x007E7DF4
	private void OnMovementModeChanged(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		switch (newMovementMode)
		{
		case EMovementMode.MOVE_None:
			this.SetPositionState(ECharPositionState.Ground);
			this.SetMoveState(ECharMoveState.Other);
			return;
		case EMovementMode.MOVE_Walking:
		case EMovementMode.MOVE_NavWalking:
			this.SetPositionState(ECharPositionState.Ground);
			return;
		case EMovementMode.MOVE_Falling:
			this.SetPositionState(ECharPositionState.Air);
			if (this.MoveState != ECharMoveState.KnockUp && this.MoveState != ECharMoveState.Captured)
			{
				this.SetMoveState(ECharMoveState.Other);
				return;
			}
			break;
		case EMovementMode.MOVE_Swimming:
			break;
		case EMovementMode.MOVE_Flying:
			this.SetPositionState(ECharPositionState.Air);
			if (this.MoveState != ECharMoveState.Captured)
			{
				this.SetMoveState(ECharMoveState.Flying);
				return;
			}
			break;
		case EMovementMode.MOVE_Custom:
			switch (newCustomMode)
			{
			case 0:
			case 13:
				this.SetPositionState(ECharPositionState.Climb);
				return;
			case 1:
				this.SetPositionState(ECharPositionState.Water);
				return;
			case 2:
				this.SetPositionState(ECharPositionState.Air);
				this.SetMoveState(ECharMoveState.Glide);
				return;
			case 5:
				this.SetPositionState(ECharPositionState.Ground);
				return;
			case 8:
				this.SetPositionState(ECharPositionState.Ski);
				return;
			case 11:
				this.SetPositionState(ECharPositionState.Ride);
				return;
			case 12:
				this.SetPositionState(ECharPositionState.RailSlide);
				return;
			}
			this.SetPositionState(ECharPositionState.Air);
			break;
		default:
			return;
		}
	}

	// Token: 0x06019B27 RID: 105255 RVA: 0x007E9D09 File Offset: 0x007E7F09
	protected override void OnActivate()
	{
		this.SetIsInGame(base.Entity.Active);
	}

	// Token: 0x06019B28 RID: 105256 RVA: 0x007E9D1C File Offset: 0x007E7F1C
	protected override bool OnInit()
	{
		BaseUnifiedStateComponent.Load();
		return true;
	}

	// Token: 0x06019B29 RID: 105257 RVA: 0x007E9D24 File Offset: 0x007E7F24
	protected override void OnEnable()
	{
		this.SetIsInGame(true);
	}

	// Token: 0x06019B2A RID: 105258 RVA: 0x007E9D2D File Offset: 0x007E7F2D
	[NullableContext(1)]
	protected override void OnDisable(string reason)
	{
		this.SetIsInGame(false);
	}

	// Token: 0x06019B2B RID: 105259 RVA: 0x007E9D36 File Offset: 0x007E7F36
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnMovementModeChanged));
		return true;
	}

	// Token: 0x17002930 RID: 10544
	// (get) Token: 0x06019B2C RID: 105260 RVA: 0x007E9D5B File Offset: 0x007E7F5B
	public bool? IsInGame
	{
		get
		{
			return this.IsInGameInternal;
		}
	}

	// Token: 0x06019B2D RID: 105261 RVA: 0x007E9D63 File Offset: 0x007E7F63
	public void SetIsInGame(bool isInGame)
	{
		this.IsInGameInternal = new bool?(isInGame);
	}

	// Token: 0x06019B2E RID: 105262 RVA: 0x007E9D74 File Offset: 0x007E7F74
	public unsafe static void Load()
	{
		if (BaseUnifiedStateComponent.BaseNeedLoad)
		{
			BaseUnifiedStateComponent.PositionTagIdList = new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.滑雪"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.载具"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.滑轨"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.悬浮"]
			};
			BaseUnifiedStateComponent.MoveTagIdList = new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.其他"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.站立"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走停止"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.跑步"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.跑步停止"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺停止"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.闪避"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.落地翻滚"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.击倒"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被弹反"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.轻击"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.重击"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.正常攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.快速攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑翔"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.击飞"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.加速游泳"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.正常游泳"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.摇荡"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑坡.普通滑坡"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.特殊飞行"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.攀爬.进入攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.攀爬.退出攀爬"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑雪.正常滑雪"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.倒地起身"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.特殊滚动"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.风筝"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.贡多拉"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.NPC载具"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.空中步行"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被破弱"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.上升"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.下降"],
				GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.常规移动"]
			};
			BaseUnifiedStateComponent.DirectionTagIdList = new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.注视方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.瞄准方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.面朝方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.看向方向"],
				GameplayTagDefine.EGameplayTagId["行为状态.方向状态.相机方向"]
			};
			BaseUnifiedStateComponent.PositionEnumToTagId = new Dictionary<ECharPositionState, int>();
			BaseUnifiedStateComponent.PositionEnumToTagIdInverse = new Dictionary<int, ECharPositionState>();
			Array enumValuesAsUnderlyingType = typeof(ECharPositionState).GetEnumValuesAsUnderlyingType();
			foreach (ECharPositionState echarPositionState in *Unsafe.As<Array, ECharPositionState[]>(ref enumValuesAsUnderlyingType))
			{
				if (echarPositionState >= ECharPositionState.Ground && echarPositionState < (ECharPositionState)BaseUnifiedStateComponent.PositionTagIdList.Length)
				{
					BaseUnifiedStateComponent.PositionEnumToTagId[echarPositionState] = BaseUnifiedStateComponent.PositionTagIdList[(int)echarPositionState];
					BaseUnifiedStateComponent.PositionEnumToTagIdInverse[BaseUnifiedStateComponent.PositionTagIdList[(int)echarPositionState]] = echarPositionState;
				}
			}
			BaseUnifiedStateComponent.MoveEnumToTagId = new Dictionary<ECharMoveState, int>();
			BaseUnifiedStateComponent.MoveEnumToTagIdInverse = new Dictionary<int, ECharMoveState>();
			Array enumValuesAsUnderlyingType2 = typeof(ECharMoveState).GetEnumValuesAsUnderlyingType();
			foreach (ECharMoveState echarMoveState in *Unsafe.As<Array, ECharMoveState[]>(ref enumValuesAsUnderlyingType2))
			{
				if (echarMoveState >= ECharMoveState.Other && echarMoveState < (ECharMoveState)BaseUnifiedStateComponent.MoveTagIdList.Length)
				{
					BaseUnifiedStateComponent.MoveEnumToTagId[echarMoveState] = BaseUnifiedStateComponent.MoveTagIdList[(int)echarMoveState];
					BaseUnifiedStateComponent.MoveEnumToTagIdInverse[BaseUnifiedStateComponent.MoveTagIdList[(int)echarMoveState]] = echarMoveState;
				}
			}
			BaseUnifiedStateComponent.DirectionEnumToTagId = new Dictionary<ECharDirectionState, int>();
			BaseUnifiedStateComponent.DirectionEnumToTagIdInverse = new Dictionary<int, ECharDirectionState>();
			Array enumValuesAsUnderlyingType3 = typeof(ECharDirectionState).GetEnumValuesAsUnderlyingType();
			foreach (ECharDirectionState echarDirectionState in *Unsafe.As<Array, ECharDirectionState[]>(ref enumValuesAsUnderlyingType3))
			{
				BaseUnifiedStateComponent.DirectionEnumToTagId[echarDirectionState] = BaseUnifiedStateComponent.DirectionTagIdList[(int)echarDirectionState];
				BaseUnifiedStateComponent.DirectionEnumToTagIdInverse[BaseUnifiedStateComponent.DirectionTagIdList[(int)echarDirectionState]] = echarDirectionState;
			}
			BaseUnifiedStateComponent.BaseNeedLoad = false;
		}
	}

	// Token: 0x06019B2F RID: 105263 RVA: 0x007EA2E8 File Offset: 0x007E84E8
	public virtual void InitCharState()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.AddTag(new int?(BaseUnifiedStateComponent.PositionEnumToTagId[ECharPositionState.Ground]));
		}
		BaseTagComponent tagComponent2 = this.TagComponent;
		if (tagComponent2 != null)
		{
			tagComponent2.AddTag(new int?(BaseUnifiedStateComponent.MoveEnumToTagId[ECharMoveState.Stand]));
		}
		BaseTagComponent tagComponent3 = this.TagComponent;
		if (tagComponent3 == null)
		{
			return;
		}
		tagComponent3.AddTag(new int?(BaseUnifiedStateComponent.DirectionEnumToTagId[ECharDirectionState.FaceDirection]));
	}

	// Token: 0x06019B30 RID: 105264 RVA: 0x007EA357 File Offset: 0x007E8557
	public virtual void ResetCharState()
	{
		this.SetMoveState(ECharMoveState.Stand);
		this.SetDirectionState(ECharDirectionState.FaceDirection);
	}

	// Token: 0x06019B31 RID: 105265 RVA: 0x007EA368 File Offset: 0x007E8568
	public virtual void SetPositionState(ECharPositionState newPositionState)
	{
		ECharPositionState echarPositionState = this.PositionState;
		if (!this.ActorComponent.IsAutonomousProxy)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态"]));
			}
			int value;
			if (BaseUnifiedStateComponent.PositionEnumToTagId.TryGetValue(newPositionState, out value))
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null)
				{
					tagComponent2.AddTag(new int?(value));
				}
			}
			echarPositionState = this.CachedPositionState;
			this.CachedPositionState = newPositionState;
			this.OnPositionStateChange(echarPositionState, newPositionState);
			return;
		}
		if (echarPositionState == newPositionState)
		{
			return;
		}
		BaseTagComponent tagComponent3 = this.TagComponent;
		if (tagComponent3 != null)
		{
			tagComponent3.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态"]));
		}
		int value2;
		if (BaseUnifiedStateComponent.PositionEnumToTagId.TryGetValue(newPositionState, out value2))
		{
			BaseTagComponent tagComponent4 = this.TagComponent;
			if (tagComponent4 != null)
			{
				tagComponent4.AddTag(new int?(value2));
			}
		}
		this.CachedPositionState = newPositionState;
		this.OnPositionStateChange(echarPositionState, newPositionState);
	}

	// Token: 0x17002931 RID: 10545
	// (get) Token: 0x06019B32 RID: 105266 RVA: 0x007EA44C File Offset: 0x007E864C
	public virtual ECharPositionState PositionState
	{
		get
		{
			if (!this.ActorComponent.IsAutonomousProxy)
			{
				foreach (int num in BaseUnifiedStateComponent.PositionTagIdList)
				{
					BaseTagComponent tagComponent = this.TagComponent;
					if (tagComponent != null && tagComponent.HasTag(num))
					{
						return BaseUnifiedStateComponent.PositionEnumToTagIdInverse[num];
					}
				}
			}
			return this.CachedPositionState;
		}
	}

	// Token: 0x06019B33 RID: 105267 RVA: 0x007EA4A5 File Offset: 0x007E86A5
	protected virtual void OnPositionStateChange(ECharPositionState oldState, ECharPositionState newState)
	{
		if (newState == ECharPositionState.Ground)
		{
			this.OnLand();
		}
		else if (this.DirectionState == ECharDirectionState.AimDirection)
		{
			this.SetDirectionState(ECharDirectionState.FaceDirection);
		}
		EventSystem.Instance.EmitWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, oldState, newState);
	}

	// Token: 0x06019B34 RID: 105268 RVA: 0x007EA4DA File Offset: 0x007E86DA
	protected virtual void OnLand()
	{
		this.SetMoveState(ECharMoveState.Other);
	}

	// Token: 0x06019B35 RID: 105269 RVA: 0x007EA4E4 File Offset: 0x007E86E4
	public virtual void SetMoveState(ECharMoveState newMoveState)
	{
		if (!this.ActorComponent.IsAutonomousProxy)
		{
			return;
		}
		ECharMoveState moveState = this.MoveState;
		if (moveState == newMoveState)
		{
			return;
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态"]));
		}
		int value;
		if (BaseUnifiedStateComponent.MoveEnumToTagId.TryGetValue(newMoveState, out value))
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.AddTag(new int?(value));
			}
		}
		this.CachedMoveState = newMoveState;
		EventSystem.Instance.EmitWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, moveState, newMoveState);
	}

	// Token: 0x17002932 RID: 10546
	// (get) Token: 0x06019B36 RID: 105270 RVA: 0x007EA578 File Offset: 0x007E8778
	public virtual ECharMoveState MoveState
	{
		get
		{
			if (!this.ActorComponent.IsAutonomousProxy)
			{
				foreach (int num in BaseUnifiedStateComponent.MoveTagIdList)
				{
					BaseTagComponent tagComponent = this.TagComponent;
					if (tagComponent != null && tagComponent.HasTag(num))
					{
						return BaseUnifiedStateComponent.MoveEnumToTagIdInverse[num];
					}
				}
			}
			return this.CachedMoveState;
		}
	}

	// Token: 0x06019B37 RID: 105271 RVA: 0x007EA5D4 File Offset: 0x007E87D4
	public virtual void SetDirectionState(ECharDirectionState newDirectionState)
	{
		if (!this.ActorComponent.IsAutonomousProxy)
		{
			return;
		}
		ECharDirectionState directionState = this.DirectionState;
		if (!this.SetDirectionStateInternal(newDirectionState))
		{
			return;
		}
		EventSystem.Instance.EmitWithTarget<ECharDirectionState, ECharDirectionState>(base.Entity, EEventName.CharOnDirectionStateChanged, directionState, newDirectionState);
	}

	// Token: 0x06019B38 RID: 105272 RVA: 0x007EA618 File Offset: 0x007E8818
	protected bool SetDirectionStateInternal(ECharDirectionState newDirectionState)
	{
		ECharDirectionState directionState = this.DirectionState;
		if (directionState == newDirectionState)
		{
			return false;
		}
		this.UpdateDirectionTag(directionState, newDirectionState);
		return true;
	}

	// Token: 0x17002933 RID: 10547
	// (get) Token: 0x06019B39 RID: 105273 RVA: 0x007EA63C File Offset: 0x007E883C
	public virtual ECharDirectionState DirectionState
	{
		get
		{
			if (!this.ActorComponent.IsAutonomousProxy)
			{
				foreach (int num in BaseUnifiedStateComponent.DirectionTagIdList)
				{
					BaseTagComponent tagComponent = this.TagComponent;
					if (tagComponent != null && tagComponent.HasTag(num))
					{
						return BaseUnifiedStateComponent.DirectionEnumToTagIdInverse[num];
					}
				}
			}
			return this.CachedDirectionState;
		}
	}

	// Token: 0x06019B3A RID: 105274 RVA: 0x007EA695 File Offset: 0x007E8895
	protected virtual void UpdateDirectionTag(ECharDirectionState oldDirectionState, ECharDirectionState newDirectionState)
	{
		this.CachedDirectionState = newDirectionState;
		this.ClearDirectionTag(oldDirectionState);
		this.AddDirectionTag(newDirectionState);
	}

	// Token: 0x06019B3B RID: 105275 RVA: 0x007EA6AC File Offset: 0x007E88AC
	protected virtual void ClearDirectionTag(ECharDirectionState oldDirectionState)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.方向状态"]));
	}

	// Token: 0x06019B3C RID: 105276 RVA: 0x007EA6D3 File Offset: 0x007E88D3
	protected virtual void AddDirectionTag(ECharDirectionState charDirectionState)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.AddTag(new int?(BaseUnifiedStateComponent.DirectionEnumToTagId[charDirectionState]));
	}

	// Token: 0x06019B3D RID: 105277 RVA: 0x007EA6F5 File Offset: 0x007E88F5
	public static void CreateStaticDefaultValue()
	{
		BaseUnifiedStateComponent.BaseNeedLoad = true;
	}

	// Token: 0x06019B3E RID: 105278 RVA: 0x007EA700 File Offset: 0x007E8900
	public static void ResetStaticDefaultValue()
	{
		BaseUnifiedStateComponent.BaseNeedLoad = false;
		BaseUnifiedStateComponent.PositionTagIdList = null;
		BaseUnifiedStateComponent.MoveTagIdList = null;
		BaseUnifiedStateComponent.SubStateTagIdList = null;
		BaseUnifiedStateComponent.DirectionTagIdList = null;
		BaseUnifiedStateComponent.MoveEnumToTagId = null;
		BaseUnifiedStateComponent.MoveEnumToTagIdInverse = null;
		BaseUnifiedStateComponent.PositionEnumToTagId = null;
		BaseUnifiedStateComponent.PositionEnumToTagIdInverse = null;
		BaseUnifiedStateComponent.DirectionEnumToTagId = null;
		BaseUnifiedStateComponent.DirectionEnumToTagIdInverse = null;
	}

	// Token: 0x06019B3F RID: 105279 RVA: 0x007EA750 File Offset: 0x007E8950
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseUnifiedStateComponent baseUnifiedStateComponent = (BaseUnifiedStateComponent)componentTemplate;
		if (baseUnifiedStateComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (baseUnifiedStateComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		this.CachedPositionState = baseUnifiedStateComponent.CachedPositionState;
		this.CachedMoveState = baseUnifiedStateComponent.CachedMoveState;
		this.CachedDirectionState = baseUnifiedStateComponent.CachedDirectionState;
		this.IsInFighting = baseUnifiedStateComponent.IsInFighting;
		this.IsInGameInternal = baseUnifiedStateComponent.IsInGameInternal;
		return true;
	}

	// Token: 0x17002934 RID: 10548
	// (get) Token: 0x06019B40 RID: 105280 RVA: 0x007EA802 File Offset: 0x007E8A02
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002935 RID: 10549
	// (get) Token: 0x06019B41 RID: 105281 RVA: 0x007EA805 File Offset: 0x007E8A05
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002936 RID: 10550
	// (get) Token: 0x06019B42 RID: 105282 RVA: 0x007EA808 File Offset: 0x007E8A08
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002937 RID: 10551
	// (get) Token: 0x06019B43 RID: 105283 RVA: 0x007EA80B File Offset: 0x007E8A0B
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002938 RID: 10552
	// (get) Token: 0x06019B44 RID: 105284 RVA: 0x007EA80E File Offset: 0x007E8A0E
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002939 RID: 10553
	// (get) Token: 0x06019B45 RID: 105285 RVA: 0x007EA811 File Offset: 0x007E8A11
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E16C RID: 57708
	protected static int[] PositionTagIdList;

	// Token: 0x0400E16D RID: 57709
	protected static int[] MoveTagIdList;

	// Token: 0x0400E16E RID: 57710
	protected static int[] SubStateTagIdList;

	// Token: 0x0400E16F RID: 57711
	protected static int[] DirectionTagIdList;

	// Token: 0x0400E170 RID: 57712
	protected static Dictionary<ECharMoveState, int> MoveEnumToTagId;

	// Token: 0x0400E171 RID: 57713
	protected static Dictionary<int, ECharMoveState> MoveEnumToTagIdInverse;

	// Token: 0x0400E172 RID: 57714
	protected static Dictionary<ECharPositionState, int> PositionEnumToTagId;

	// Token: 0x0400E173 RID: 57715
	protected static Dictionary<int, ECharPositionState> PositionEnumToTagIdInverse;

	// Token: 0x0400E174 RID: 57716
	protected static Dictionary<ECharDirectionState, int> DirectionEnumToTagId;

	// Token: 0x0400E175 RID: 57717
	protected static Dictionary<int, ECharDirectionState> DirectionEnumToTagIdInverse;

	// Token: 0x0400E176 RID: 57718
	protected BaseTagComponent TagComponent;

	// Token: 0x0400E177 RID: 57719
	protected BaseActorComponent ActorComponent;

	// Token: 0x0400E17B RID: 57723
	public bool IsInFighting;

	// Token: 0x0400E17C RID: 57724
	protected bool? IsInGameInternal;

	// Token: 0x0400E17D RID: 57725
	protected static bool BaseNeedLoad;
}
