using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x0200265C RID: 9820
[NullableContext(2)]
public interface IMoveToPointConfig
{
	// Token: 0x170026C0 RID: 9920
	// (get) Token: 0x06018938 RID: 100664
	// (set) Token: 0x06018939 RID: 100665
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170026C1 RID: 9921
	// (get) Token: 0x0601893A RID: 100666
	// (set) Token: 0x0601893B RID: 100667
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Func<Vector> ReferencePosition { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170026C2 RID: 9922
	// (get) Token: 0x0601893C RID: 100668
	// (set) Token: 0x0601893D RID: 100669
	bool? IsFly { get; set; }

	// Token: 0x170026C3 RID: 9923
	// (get) Token: 0x0601893E RID: 100670
	// (set) Token: 0x0601893F RID: 100671
	bool? IsForward { get; set; }

	// Token: 0x170026C4 RID: 9924
	// (get) Token: 0x06018940 RID: 100672
	// (set) Token: 0x06018941 RID: 100673
	double? Distance { get; set; }

	// Token: 0x170026C5 RID: 9925
	// (get) Token: 0x06018942 RID: 100674
	// (set) Token: 0x06018943 RID: 100675
	ECharMoveState? MoveState { get; set; }

	// Token: 0x170026C6 RID: 9926
	// (get) Token: 0x06018944 RID: 100676
	// (set) Token: 0x06018945 RID: 100677
	float? MoveSpeed { get; set; }

	// Token: 0x170026C7 RID: 9927
	// (get) Token: 0x06018946 RID: 100678
	// (set) Token: 0x06018947 RID: 100679
	float? TurnSpeed { get; set; }

	// Token: 0x170026C8 RID: 9928
	// (get) Token: 0x06018948 RID: 100680
	// (set) Token: 0x06018949 RID: 100681
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Queue<Vector> NextMovePointConfig { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170026C9 RID: 9929
	// (get) Token: 0x0601894A RID: 100682
	// (set) Token: 0x0601894B RID: 100683
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<Action<ELevelEventState>> CallbackList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170026CA RID: 9930
	// (get) Token: 0x0601894C RID: 100684
	// (set) Token: 0x0601894D RID: 100685
	Func<bool> ResetCondition { get; set; }

	// Token: 0x170026CB RID: 9931
	// (get) Token: 0x0601894E RID: 100686
	// (set) Token: 0x0601894F RID: 100687
	bool? UseNearestDirection { get; set; }

	// Token: 0x170026CC RID: 9932
	// (get) Token: 0x06018950 RID: 100688
	// (set) Token: 0x06018951 RID: 100689
	Vector FaceToPosition { get; set; }

	// Token: 0x170026CD RID: 9933
	// (get) Token: 0x06018952 RID: 100690
	// (set) Token: 0x06018953 RID: 100691
	float? ReturnTimeoutFailed { get; set; }

	// Token: 0x170026CE RID: 9934
	// (get) Token: 0x06018954 RID: 100692
	// (set) Token: 0x06018955 RID: 100693
	bool? ForceResetOnLargeDelta { get; set; }

	// Token: 0x170026CF RID: 9935
	// (get) Token: 0x06018956 RID: 100694
	// (set) Token: 0x06018957 RID: 100695
	int? LargeDeltaResetMinMove { get; set; }
}
