using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x020030F3 RID: 12531
[NullableContext(2)]
public interface IPatrolParams
{
	// Token: 0x170024F5 RID: 9461
	// (get) Token: 0x0601AD97 RID: 109975
	// (set) Token: 0x0601AD98 RID: 109976
	bool? DebugMode { get; set; }

	// Token: 0x170024F6 RID: 9462
	// (get) Token: 0x0601AD99 RID: 109977
	// (set) Token: 0x0601AD9A RID: 109978
	bool? ReturnFalseWhenNavigationFailed { get; set; }

	// Token: 0x170024F7 RID: 9463
	// (get) Token: 0x0601AD9B RID: 109979
	// (set) Token: 0x0601AD9C RID: 109980
	EPatrolStartMode? StartMode { get; set; }

	// Token: 0x170024F8 RID: 9464
	// (get) Token: 0x0601AD9D RID: 109981
	// (set) Token: 0x0601AD9E RID: 109982
	List<double> RandomDistanceRange { get; set; }

	// Token: 0x170024F9 RID: 9465
	// (get) Token: 0x0601AD9F RID: 109983
	// (set) Token: 0x0601ADA0 RID: 109984
	bool? IsFollowStrictly { get; set; }

	// Token: 0x170024FA RID: 9466
	// (get) Token: 0x0601ADA1 RID: 109985
	// (set) Token: 0x0601ADA2 RID: 109986
	int? StartPointIndex { get; set; }

	// Token: 0x170024FB RID: 9467
	// (get) Token: 0x0601ADA3 RID: 109987
	// (set) Token: 0x0601ADA4 RID: 109988
	int? EndPointIndex { get; set; }

	// Token: 0x170024FC RID: 9468
	// (get) Token: 0x0601ADA5 RID: 109989
	// (set) Token: 0x0601ADA6 RID: 109990
	bool? NoRequestServer { get; set; }

	// Token: 0x170024FD RID: 9469
	// (get) Token: 0x0601ADA7 RID: 109991
	// (set) Token: 0x0601ADA8 RID: 109992
	bool? NoSyncPoint { get; set; }

	// Token: 0x170024FE RID: 9470
	// (get) Token: 0x0601ADA9 RID: 109993
	// (set) Token: 0x0601ADAA RID: 109994
	float? TurnSpeed { get; set; }

	// Token: 0x170024FF RID: 9471
	// (get) Token: 0x0601ADAB RID: 109995
	// (set) Token: 0x0601ADAC RID: 109996
	Action<int> OnArrivePointHandle { get; set; }

	// Token: 0x17002500 RID: 9472
	// (get) Token: 0x0601ADAD RID: 109997
	// (set) Token: 0x0601ADAE RID: 109998
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	Action<IList<ActionInfo>> OnTriggerActionsHandle { [return: Nullable(new byte[]
	{
		2,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1
	})] set; }

	// Token: 0x17002501 RID: 9473
	// (get) Token: 0x0601ADAF RID: 109999
	// (set) Token: 0x0601ADB0 RID: 110000
	Action<ELevelEventState> OnPatrolEndHandle { get; set; }

	// Token: 0x17002502 RID: 9474
	// (get) Token: 0x0601ADB1 RID: 110001
	// (set) Token: 0x0601ADB2 RID: 110002
	Action OnResetLocationCallback { get; set; }
}
