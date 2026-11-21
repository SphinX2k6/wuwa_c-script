using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x0200264B RID: 9803
[NullableContext(2)]
public interface IPatrolParams
{
	// Token: 0x17002683 RID: 9859
	// (get) Token: 0x060187B8 RID: 100280
	// (set) Token: 0x060187B9 RID: 100281
	bool? DebugMode { get; set; }

	// Token: 0x17002684 RID: 9860
	// (get) Token: 0x060187BA RID: 100282
	// (set) Token: 0x060187BB RID: 100283
	bool? ReturnFalseWhenNavigationFailed { get; set; }

	// Token: 0x17002685 RID: 9861
	// (get) Token: 0x060187BC RID: 100284
	// (set) Token: 0x060187BD RID: 100285
	EPatrolStartMode? StartMode { get; set; }

	// Token: 0x17002686 RID: 9862
	// (get) Token: 0x060187BE RID: 100286
	// (set) Token: 0x060187BF RID: 100287
	List<double> RandomDistanceRange { get; set; }

	// Token: 0x17002687 RID: 9863
	// (get) Token: 0x060187C0 RID: 100288
	// (set) Token: 0x060187C1 RID: 100289
	bool? IsFollowStrictly { get; set; }

	// Token: 0x17002688 RID: 9864
	// (get) Token: 0x060187C2 RID: 100290
	// (set) Token: 0x060187C3 RID: 100291
	int? StartPointIndex { get; set; }

	// Token: 0x17002689 RID: 9865
	// (get) Token: 0x060187C4 RID: 100292
	// (set) Token: 0x060187C5 RID: 100293
	int? EndPointIndex { get; set; }

	// Token: 0x1700268A RID: 9866
	// (get) Token: 0x060187C6 RID: 100294
	// (set) Token: 0x060187C7 RID: 100295
	bool? NoRequestServer { get; set; }

	// Token: 0x1700268B RID: 9867
	// (get) Token: 0x060187C8 RID: 100296
	// (set) Token: 0x060187C9 RID: 100297
	bool? NoSyncPoint { get; set; }

	// Token: 0x1700268C RID: 9868
	// (get) Token: 0x060187CA RID: 100298
	// (set) Token: 0x060187CB RID: 100299
	float? TurnSpeed { get; set; }

	// Token: 0x1700268D RID: 9869
	// (get) Token: 0x060187CC RID: 100300
	// (set) Token: 0x060187CD RID: 100301
	Action<int> OnArrivePointHandle { get; set; }

	// Token: 0x1700268E RID: 9870
	// (get) Token: 0x060187CE RID: 100302
	// (set) Token: 0x060187CF RID: 100303
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

	// Token: 0x1700268F RID: 9871
	// (get) Token: 0x060187D0 RID: 100304
	// (set) Token: 0x060187D1 RID: 100305
	Action<ELevelEventState> OnPatrolEndHandle { get; set; }

	// Token: 0x17002690 RID: 9872
	// (get) Token: 0x060187D2 RID: 100306
	// (set) Token: 0x060187D3 RID: 100307
	Action OnResetLocationCallback { get; set; }
}
