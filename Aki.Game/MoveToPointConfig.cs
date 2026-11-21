using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x0200265B RID: 9819
[NullableContext(2)]
[Nullable(0)]
public class MoveToPointConfig : IMoveToPointConfig, IStaticVariableResetter
{
	// Token: 0x0601890E RID: 100622 RVA: 0x00773FCC File Offset: 0x007721CC
	static MoveToPointConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoveToPointConfig.CreateStaticDefaultValue), new Action(MoveToPointConfig.ResetStaticDefaultValue));
	}

	// Token: 0x170026B0 RID: 9904
	// (get) Token: 0x0601890F RID: 100623 RVA: 0x00773FEB File Offset: 0x007721EB
	// (set) Token: 0x06018910 RID: 100624 RVA: 0x00773FF3 File Offset: 0x007721F3
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

	// Token: 0x170026B1 RID: 9905
	// (get) Token: 0x06018911 RID: 100625 RVA: 0x00773FFC File Offset: 0x007721FC
	// (set) Token: 0x06018912 RID: 100626 RVA: 0x00774004 File Offset: 0x00772204
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

	// Token: 0x06018913 RID: 100627 RVA: 0x0077400D File Offset: 0x0077220D
	public bool UpdateTargetPosition()
	{
		if (this.ReferencePosition != null && !this.HasNextPoint())
		{
			this.PositionInternal.DeepCopy(this.ReferencePosition());
			return true;
		}
		return false;
	}

	// Token: 0x170026B2 RID: 9906
	// (get) Token: 0x06018914 RID: 100628 RVA: 0x00774038 File Offset: 0x00772238
	// (set) Token: 0x06018915 RID: 100629 RVA: 0x00774040 File Offset: 0x00772240
	public bool? IsFly { get; set; }

	// Token: 0x170026B3 RID: 9907
	// (get) Token: 0x06018916 RID: 100630 RVA: 0x00774049 File Offset: 0x00772249
	// (set) Token: 0x06018917 RID: 100631 RVA: 0x00774051 File Offset: 0x00772251
	public bool? IsForward { get; set; }

	// Token: 0x170026B4 RID: 9908
	// (get) Token: 0x06018918 RID: 100632 RVA: 0x0077405A File Offset: 0x0077225A
	// (set) Token: 0x06018919 RID: 100633 RVA: 0x00774062 File Offset: 0x00772262
	public float? ReturnTimeoutFailed { get; set; }

	// Token: 0x170026B5 RID: 9909
	// (get) Token: 0x0601891A RID: 100634 RVA: 0x0077406B File Offset: 0x0077226B
	// (set) Token: 0x0601891B RID: 100635 RVA: 0x00774073 File Offset: 0x00772273
	public double? Distance { get; set; } = new double?((double)MoveToPointConfig.DefaultDistance);

	// Token: 0x170026B6 RID: 9910
	// (get) Token: 0x0601891C RID: 100636 RVA: 0x0077407C File Offset: 0x0077227C
	// (set) Token: 0x0601891D RID: 100637 RVA: 0x00774084 File Offset: 0x00772284
	public float? TurnSpeed { get; set; } = new float?(MoveToPointConfig.DefaultTurnSpeed);

	// Token: 0x170026B7 RID: 9911
	// (get) Token: 0x0601891E RID: 100638 RVA: 0x0077408D File Offset: 0x0077228D
	// (set) Token: 0x0601891F RID: 100639 RVA: 0x00774095 File Offset: 0x00772295
	public ECharMoveState? MoveState { get; set; }

	// Token: 0x170026B8 RID: 9912
	// (get) Token: 0x06018920 RID: 100640 RVA: 0x0077409E File Offset: 0x0077229E
	// (set) Token: 0x06018921 RID: 100641 RVA: 0x007740A6 File Offset: 0x007722A6
	public bool? UseNearestDirection { get; set; }

	// Token: 0x170026B9 RID: 9913
	// (get) Token: 0x06018922 RID: 100642 RVA: 0x007740AF File Offset: 0x007722AF
	// (set) Token: 0x06018923 RID: 100643 RVA: 0x007740B7 File Offset: 0x007722B7
	public float? MoveSpeed { get; set; }

	// Token: 0x170026BA RID: 9914
	// (get) Token: 0x06018924 RID: 100644 RVA: 0x007740C0 File Offset: 0x007722C0
	// (set) Token: 0x06018925 RID: 100645 RVA: 0x007740C8 File Offset: 0x007722C8
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

	// Token: 0x170026BB RID: 9915
	// (get) Token: 0x06018926 RID: 100646 RVA: 0x007740D1 File Offset: 0x007722D1
	// (set) Token: 0x06018927 RID: 100647 RVA: 0x007740D9 File Offset: 0x007722D9
	public Vector FaceToPosition { get; set; }

	// Token: 0x170026BC RID: 9916
	// (get) Token: 0x06018928 RID: 100648 RVA: 0x007740E2 File Offset: 0x007722E2
	// (set) Token: 0x06018929 RID: 100649 RVA: 0x007740EA File Offset: 0x007722EA
	public Func<bool> ResetCondition { get; set; }

	// Token: 0x170026BD RID: 9917
	// (get) Token: 0x0601892A RID: 100650 RVA: 0x007740F3 File Offset: 0x007722F3
	// (set) Token: 0x0601892B RID: 100651 RVA: 0x007740FB File Offset: 0x007722FB
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

	// Token: 0x170026BE RID: 9918
	// (get) Token: 0x0601892C RID: 100652 RVA: 0x00774104 File Offset: 0x00772304
	// (set) Token: 0x0601892D RID: 100653 RVA: 0x0077410C File Offset: 0x0077230C
	public bool? ForceResetOnLargeDelta { get; set; } = new bool?(false);

	// Token: 0x170026BF RID: 9919
	// (get) Token: 0x0601892E RID: 100654 RVA: 0x00774115 File Offset: 0x00772315
	// (set) Token: 0x0601892F RID: 100655 RVA: 0x0077411D File Offset: 0x0077231D
	public int? LargeDeltaResetMinMove { get; set; } = new int?(120);

	// Token: 0x06018930 RID: 100656 RVA: 0x00774128 File Offset: 0x00772328
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

	// Token: 0x06018931 RID: 100657 RVA: 0x00774344 File Offset: 0x00772544
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

	// Token: 0x06018932 RID: 100658 RVA: 0x007744B4 File Offset: 0x007726B4
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

	// Token: 0x06018933 RID: 100659 RVA: 0x00774520 File Offset: 0x00772720
	public void Clear()
	{
		if (this.CallbackList != null)
		{
			this.CallbackList.Clear();
		}
		this.ResetCondition = null;
		this.NextMovePointConfig = null;
	}

	// Token: 0x06018934 RID: 100660 RVA: 0x00774544 File Offset: 0x00772744
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

	// Token: 0x06018935 RID: 100661 RVA: 0x00774581 File Offset: 0x00772781
	public bool HasNextPoint()
	{
		return this.NextMovePointConfig != null && !this.NextMovePointConfig.Empty;
	}

	// Token: 0x06018936 RID: 100662 RVA: 0x0077459B File Offset: 0x0077279B
	public static void CreateStaticDefaultValue()
	{
		MoveToPointConfig.DefaultDistance = 30f;
		MoveToPointConfig.DefaultTurnSpeed = 360f;
	}

	// Token: 0x06018937 RID: 100663 RVA: 0x007745B1 File Offset: 0x007727B1
	public static void ResetStaticDefaultValue()
	{
		MoveToPointConfig.DefaultDistance = 0f;
		MoveToPointConfig.DefaultTurnSpeed = 0f;
	}

	// Token: 0x0400D509 RID: 54537
	public static float DefaultDistance;

	// Token: 0x0400D50A RID: 54538
	public static float DefaultTurnSpeed;

	// Token: 0x0400D50B RID: 54539
	private Vector PositionInternal;
}
