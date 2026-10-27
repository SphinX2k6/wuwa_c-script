using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02003103 RID: 12547
[NullableContext(2)]
[Nullable(0)]
public class MoveToPointConfig : IMoveToPointConfig, IStaticVariableResetter
{
	// Token: 0x0601AEDC RID: 110300 RVA: 0x0074E18C File Offset: 0x0074C38C
	static MoveToPointConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoveToPointConfig.CreateStaticDefaultValue), new Action(MoveToPointConfig.ResetStaticDefaultValue));
	}

	// Token: 0x1700251B RID: 9499
	// (get) Token: 0x0601AEDD RID: 110301 RVA: 0x0074E1AB File Offset: 0x0074C3AB
	// (set) Token: 0x0601AEDE RID: 110302 RVA: 0x0074E1B3 File Offset: 0x0074C3B3
	[Nullable(1)]
	public Vector Position
	{
		[NullableContext(1)]
		get
		{
			return this.PositionInternal;
		}
		[NullableContext(1)]
		set
		{
			this.PositionInternal = value;
		}
	}

	// Token: 0x1700251C RID: 9500
	// (get) Token: 0x0601AEDF RID: 110303 RVA: 0x0074E1BC File Offset: 0x0074C3BC
	// (set) Token: 0x0601AEE0 RID: 110304 RVA: 0x0074E1C4 File Offset: 0x0074C3C4
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<Vector> ReferencePosition { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x0601AEE1 RID: 110305 RVA: 0x0074E1CD File Offset: 0x0074C3CD
	public bool UpdateTargetPosition()
	{
		if (this.ReferencePosition != null && !this.HasNextPoint())
		{
			this.PositionInternal.DeepCopy(this.ReferencePosition());
			return true;
		}
		return false;
	}

	// Token: 0x1700251D RID: 9501
	// (get) Token: 0x0601AEE2 RID: 110306 RVA: 0x0074E1F8 File Offset: 0x0074C3F8
	// (set) Token: 0x0601AEE3 RID: 110307 RVA: 0x0074E200 File Offset: 0x0074C400
	public bool? IsFly { get; set; }

	// Token: 0x1700251E RID: 9502
	// (get) Token: 0x0601AEE4 RID: 110308 RVA: 0x0074E209 File Offset: 0x0074C409
	// (set) Token: 0x0601AEE5 RID: 110309 RVA: 0x0074E211 File Offset: 0x0074C411
	public bool? IsForward { get; set; }

	// Token: 0x1700251F RID: 9503
	// (get) Token: 0x0601AEE6 RID: 110310 RVA: 0x0074E21A File Offset: 0x0074C41A
	// (set) Token: 0x0601AEE7 RID: 110311 RVA: 0x0074E222 File Offset: 0x0074C422
	public float? ReturnTimeoutFailed { get; set; }

	// Token: 0x17002520 RID: 9504
	// (get) Token: 0x0601AEE8 RID: 110312 RVA: 0x0074E22B File Offset: 0x0074C42B
	// (set) Token: 0x0601AEE9 RID: 110313 RVA: 0x0074E233 File Offset: 0x0074C433
	public double? Distance { get; set; } = new double?((double)MoveToPointConfig.DefaultDistance);

	// Token: 0x17002521 RID: 9505
	// (get) Token: 0x0601AEEA RID: 110314 RVA: 0x0074E23C File Offset: 0x0074C43C
	// (set) Token: 0x0601AEEB RID: 110315 RVA: 0x0074E244 File Offset: 0x0074C444
	public float? TurnSpeed { get; set; } = new float?(MoveToPointConfig.DefaultTurnSpeed);

	// Token: 0x17002522 RID: 9506
	// (get) Token: 0x0601AEEC RID: 110316 RVA: 0x0074E24D File Offset: 0x0074C44D
	// (set) Token: 0x0601AEED RID: 110317 RVA: 0x0074E255 File Offset: 0x0074C455
	public ECharMoveState? MoveState { get; set; }

	// Token: 0x17002523 RID: 9507
	// (get) Token: 0x0601AEEE RID: 110318 RVA: 0x0074E25E File Offset: 0x0074C45E
	// (set) Token: 0x0601AEEF RID: 110319 RVA: 0x0074E266 File Offset: 0x0074C466
	public bool? UseNearestDirection { get; set; }

	// Token: 0x17002524 RID: 9508
	// (get) Token: 0x0601AEF0 RID: 110320 RVA: 0x0074E26F File Offset: 0x0074C46F
	// (set) Token: 0x0601AEF1 RID: 110321 RVA: 0x0074E277 File Offset: 0x0074C477
	public float? MoveSpeed { get; set; }

	// Token: 0x17002525 RID: 9509
	// (get) Token: 0x0601AEF2 RID: 110322 RVA: 0x0074E280 File Offset: 0x0074C480
	// (set) Token: 0x0601AEF3 RID: 110323 RVA: 0x0074E288 File Offset: 0x0074C488
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Queue<Vector> NextMovePointConfig { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002526 RID: 9510
	// (get) Token: 0x0601AEF4 RID: 110324 RVA: 0x0074E291 File Offset: 0x0074C491
	// (set) Token: 0x0601AEF5 RID: 110325 RVA: 0x0074E299 File Offset: 0x0074C499
	public Vector FaceToPosition { get; set; }

	// Token: 0x17002527 RID: 9511
	// (get) Token: 0x0601AEF6 RID: 110326 RVA: 0x0074E2A2 File Offset: 0x0074C4A2
	// (set) Token: 0x0601AEF7 RID: 110327 RVA: 0x0074E2AA File Offset: 0x0074C4AA
	public Func<bool> ResetCondition { get; set; }

	// Token: 0x17002528 RID: 9512
	// (get) Token: 0x0601AEF8 RID: 110328 RVA: 0x0074E2B3 File Offset: 0x0074C4B3
	// (set) Token: 0x0601AEF9 RID: 110329 RVA: 0x0074E2BB File Offset: 0x0074C4BB
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELevelEventState>> CallbackList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17002529 RID: 9513
	// (get) Token: 0x0601AEFA RID: 110330 RVA: 0x0074E2C4 File Offset: 0x0074C4C4
	// (set) Token: 0x0601AEFB RID: 110331 RVA: 0x0074E2CC File Offset: 0x0074C4CC
	public bool? ForceResetOnLargeDelta { get; set; } = new bool?(false);

	// Token: 0x1700252A RID: 9514
	// (get) Token: 0x0601AEFC RID: 110332 RVA: 0x0074E2D5 File Offset: 0x0074C4D5
	// (set) Token: 0x0601AEFD RID: 110333 RVA: 0x0074E2DD File Offset: 0x0074C4DD
	public int? LargeDeltaResetMinMove { get; set; } = new int?(120);

	// Token: 0x0601AEFE RID: 110334 RVA: 0x0074E2E8 File Offset: 0x0074C4E8
	[NullableContext(1)]
	public MoveToPointConfig(IMoveToPointConfig config, [Nullable(2)] Vector cacheVector = null)
	{
		if (cacheVector != null)
		{
			this.PositionInternal = cacheVector;
		}
		else
		{
			this.PositionInternal = Vector.Create();
		}
		this.PositionInternal.DeepCopy(config.Position);
		this.NextMovePointConfig = (config.NextMovePointConfig ?? null);
		this.Distance = ((config.Distance.GetValueOrDefault() != 0.0) ? config.Distance : new double?((double)MoveToPointConfig.DefaultDistance));
		this.TurnSpeed = ((config.TurnSpeed.GetValueOrDefault() != 0f) ? config.TurnSpeed : new float?(MoveToPointConfig.DefaultTurnSpeed));
		ECharMoveState? moveState = config.MoveState;
		this.MoveState = ((moveState != null) ? moveState : null);
		this.IsFly = config.IsFly;
		this.IsForward = config.IsForward;
		this.ReturnTimeoutFailed = ((config.ReturnTimeoutFailed.GetValueOrDefault() != 0f) ? config.ReturnTimeoutFailed : new float?(0f));
		this.UseNearestDirection = config.UseNearestDirection;
		float? moveSpeed = config.MoveSpeed;
		this.MoveSpeed = ((moveSpeed != null) ? moveSpeed : null);
		this.FaceToPosition = (config.FaceToPosition ?? null);
		this.CallbackList = new List<Action<ELevelEventState>>();
		if (config.CallbackList != null && config.CallbackList.Count > 0)
		{
			this.CallbackList.AddRange(config.CallbackList);
		}
		if (config.ResetCondition != null)
		{
			this.ResetCondition = config.ResetCondition;
		}
		if (config.ReferencePosition != null)
		{
			this.ReferencePosition = config.ReferencePosition;
		}
		this.ForceResetOnLargeDelta = new bool?(config.ForceResetOnLargeDelta.GetValueOrDefault());
		this.LargeDeltaResetMinMove = new int?(config.LargeDeltaResetMinMove.GetValueOrDefault(120));
	}

	// Token: 0x0601AEFF RID: 110335 RVA: 0x0074E504 File Offset: 0x0074C704
	[NullableContext(1)]
	public void DeepCopy(IMoveToPointConfig config)
	{
		this.PositionInternal.DeepCopy(config.Position);
		this.Distance = ((config.Distance.GetValueOrDefault() != 0.0) ? config.Distance : new double?((double)MoveToPointConfig.DefaultDistance));
		this.TurnSpeed = ((config.TurnSpeed.GetValueOrDefault() != 0f) ? config.TurnSpeed : new float?(MoveToPointConfig.DefaultTurnSpeed));
		ECharMoveState? moveState = config.MoveState;
		this.MoveState = ((moveState != null) ? moveState : null);
		this.IsFly = config.IsFly;
		this.IsForward = config.IsForward;
		this.ReturnTimeoutFailed = ((config.ReturnTimeoutFailed.GetValueOrDefault() != 0f) ? config.ReturnTimeoutFailed : new float?(0f));
		this.UseNearestDirection = config.UseNearestDirection;
		this.MoveSpeed = config.MoveSpeed;
		this.FaceToPosition = config.FaceToPosition;
		this.CallbackList = config.CallbackList;
		this.ResetCondition = config.ResetCondition;
		this.ReferencePosition = config.ReferencePosition;
		this.ForceResetOnLargeDelta = new bool?(config.ForceResetOnLargeDelta.GetValueOrDefault());
		this.LargeDeltaResetMinMove = new int?(config.LargeDeltaResetMinMove.GetValueOrDefault(120));
		this.NextMovePointConfig = config.NextMovePointConfig;
	}

	// Token: 0x0601AF00 RID: 110336 RVA: 0x0074E674 File Offset: 0x0074C874
	public void RunCallbackList(ELevelEventState result)
	{
		if (this.CallbackList == null || this.CallbackList.Count == 0)
		{
			return;
		}
		foreach (Action<ELevelEventState> action in this.CallbackList)
		{
			if (action != null)
			{
				action(result);
			}
		}
	}

	// Token: 0x0601AF01 RID: 110337 RVA: 0x0074E6E0 File Offset: 0x0074C8E0
	public void Clear()
	{
		if (this.CallbackList != null)
		{
			this.CallbackList.Clear();
		}
		this.ResetCondition = null;
		this.NextMovePointConfig = null;
	}

	// Token: 0x0601AF02 RID: 110338 RVA: 0x0074E704 File Offset: 0x0074C904
	public bool UpdateNextPoint()
	{
		if (this.NextMovePointConfig != null && !this.NextMovePointConfig.Empty)
		{
			Vector inV = this.NextMovePointConfig.Pop();
			this.PositionInternal.DeepCopy(inV);
			return true;
		}
		return false;
	}

	// Token: 0x0601AF03 RID: 110339 RVA: 0x0074E741 File Offset: 0x0074C941
	public bool HasNextPoint()
	{
		return this.NextMovePointConfig != null && !this.NextMovePointConfig.Empty;
	}

	// Token: 0x0601AF04 RID: 110340 RVA: 0x0074E75B File Offset: 0x0074C95B
	public static void CreateStaticDefaultValue()
	{
		MoveToPointConfig.DefaultDistance = 30f;
		MoveToPointConfig.DefaultTurnSpeed = 360f;
	}

	// Token: 0x0601AF05 RID: 110341 RVA: 0x0074E771 File Offset: 0x0074C971
	public static void ResetStaticDefaultValue()
	{
		MoveToPointConfig.DefaultDistance = 0f;
		MoveToPointConfig.DefaultTurnSpeed = 0f;
	}

	// Token: 0x0400D0FB RID: 53499
	public static float DefaultDistance;

	// Token: 0x0400D0FC RID: 53500
	public static float DefaultTurnSpeed;

	// Token: 0x0400D0FD RID: 53501
	private Vector PositionInternal;
}
