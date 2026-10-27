using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

// Token: 0x02002D95 RID: 11669
[NullableContext(1)]
[Nullable(0)]
public class BulletActionRunner : IStaticVariableResetter
{
	// Token: 0x06018837 RID: 100407 RVA: 0x00641F13 File Offset: 0x00640113
	static BulletActionRunner()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletActionRunner.CreateStaticDefaultValue), new Action(BulletActionRunner.ResetStaticDefaultValue));
	}

	// Token: 0x1700211E RID: 8478
	// (get) Token: 0x06018838 RID: 100408 RVA: 0x00641F4B File Offset: 0x0064014B
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private static List<Stat> ActionStatList
	{
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		get
		{
			return BulletActionRunner._actionStatList;
		}
	}

	// Token: 0x06018839 RID: 100409 RVA: 0x00641F52 File Offset: 0x00640152
	public void Init()
	{
		this.ActionCenter.Init();
	}

	// Token: 0x0601883A RID: 100410 RVA: 0x00641F5F File Offset: 0x0064015F
	public void Clear()
	{
		this.ActionCenter.Clear();
	}

	// Token: 0x0601883B RID: 100411 RVA: 0x00641F6C File Offset: 0x0064016C
	public BulletActionCenter GetActionCenter()
	{
		return this.ActionCenter;
	}

	// Token: 0x0601883C RID: 100412 RVA: 0x00641F74 File Offset: 0x00640174
	public void Pause()
	{
		if (this.State != EBulletActionRunnerState.Idle)
		{
			Log.Instance.Error(ELogModule.Temp, ELogAuthor.CFT, "当前不是空闲状态，不允许暂停", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.State = EBulletActionRunnerState.Pause;
	}

	// Token: 0x0601883D RID: 100413 RVA: 0x00641FAC File Offset: 0x006401AC
	public void Resume()
	{
		if (this.State != EBulletActionRunnerState.Pause)
		{
			Log.Instance.Error(ELogModule.Temp, ELogAuthor.CFT, "当前不是暂停状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.State = EBulletActionRunnerState.Idle;
	}

	// Token: 0x0601883E RID: 100414 RVA: 0x00641FE8 File Offset: 0x006401E8
	public void Run(float delta = 0f, bool isAfterTick = false)
	{
		if (this.State != EBulletActionRunnerState.Idle)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "当前不是空闲状态，不允许切换到运行状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.State = EBulletActionRunnerState.Running;
		OrderedDictionary<int, BulletEntity> bulletEntityMap = BulletModel.Instance.GetBulletEntityMap();
		if (delta > 0f)
		{
			this.BulletInfoList.Clear();
			this.NextBulletInfoList.Clear();
			foreach (BulletEntity bulletEntity in bulletEntityMap.Values)
			{
				BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
				this.BulletInfoList.Add(bulletInfo);
			}
		}
		this.RunCurBulletInfoList(delta, isAfterTick);
		this.BulletInfoList.Clear();
		while (this.NextBulletInfoList.Count > 0)
		{
			List<BulletInfo> bulletInfoList = this.BulletInfoList;
			this.BulletInfoList = this.NextBulletInfoList;
			this.NextBulletInfoList = bulletInfoList;
			this.RunCurBulletInfoList(0f, false);
			this.BulletInfoList.Clear();
		}
		this.State = EBulletActionRunnerState.ClearBullet;
		BulletModel.Instance.ClearDestroyedBullets();
		this.State = EBulletActionRunnerState.Idle;
	}

	// Token: 0x0601883F RID: 100415 RVA: 0x00642108 File Offset: 0x00640308
	private unsafe void RunCurBulletInfoList(float delta = 0f, bool isAfterTick = false)
	{
		double num = 0.0;
		foreach (BulletInfo bulletInfo in this.BulletInfoList)
		{
			if (PerformanceController.Instance.IsEntityTickPerformanceTest)
			{
				num = KuroTime.GetMilliseconds64();
			}
			try
			{
				this.CurRunningBulletInfo = bulletInfo;
				BulletActionCenter actionCenter = bulletInfo.ActionCenter;
				if (delta > 0f)
				{
					List<BulletActionBase> persistentActionList = bulletInfo.PersistentActionList;
					if (!isAfterTick)
					{
						using (List<BulletActionBase>.Enumerator enumerator2 = persistentActionList.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								BulletActionBase bulletActionBase = enumerator2.Current;
								bulletActionBase.Tick(delta);
							}
							goto IL_BD;
						}
					}
					foreach (BulletActionBase bulletActionBase2 in persistentActionList)
					{
						bulletActionBase2.AfterTick(delta);
					}
					IL_BD:
					for (int i = persistentActionList.Count - 1; i >= 0; i--)
					{
						BulletActionBase bulletActionBase3 = persistentActionList[i];
						if (bulletActionBase3.IsFinish)
						{
							persistentActionList.RemoveAt(i);
							actionCenter.RecycleBulletAction(bulletActionBase3);
						}
					}
				}
				while (bulletInfo.ActionInfoList.Count > 0 || bulletInfo.NextActionInfoList.Count > 0)
				{
					foreach (BulletActionInfoBase bulletActionInfoBase in bulletInfo.ActionInfoList)
					{
						BulletActionBase bulletActionBase4 = actionCenter.CreateBulletAction(bulletActionInfoBase.Type);
						if (BulletConstant.Instance.OpenActionStat)
						{
							bulletActionBase4.Execute(bulletInfo, bulletActionInfoBase);
						}
						else
						{
							bulletActionBase4.Execute(bulletInfo, bulletActionInfoBase);
						}
						if (!bulletActionBase4.IsInPool)
						{
							if (bulletActionBase4.IsFinish)
							{
								actionCenter.RecycleBulletAction(bulletActionBase4);
							}
							else
							{
								bulletInfo.PersistentActionList.Add(bulletActionBase4);
							}
						}
						else
						{
							actionCenter.RecycleBulletAction(bulletActionBase4);
						}
					}
					bulletInfo.SwapActionInfoList();
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Bullet;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "Run BulletAction Error";
				Exception error = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletEntityId", bulletInfo.BulletEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BulletRowName", bulletInfo.BulletRowName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			if (PerformanceController.Instance.IsEntityTickPerformanceTest)
			{
				PerformanceController.Instance.CollectTickPerformanceInfo("Bullet", false, KuroTime.GetMilliseconds64() - num, EMeasureMode.Tick, bulletInfo.BornFrameCount);
			}
		}
		this.CurRunningBulletInfo = null;
	}

	// Token: 0x06018840 RID: 100416 RVA: 0x0064242C File Offset: 0x0064062C
	public void AddAction(BulletInfo bulletInfo, BulletActionInfoBase actionInfo)
	{
		switch (this.State)
		{
		case EBulletActionRunnerState.Idle:
			bulletInfo.ActionInfoList.Add(actionInfo);
			this.BulletInfoList.Add(bulletInfo);
			this.Run(0f, false);
			return;
		case EBulletActionRunnerState.Pause:
			bulletInfo.ActionInfoList.Add(actionInfo);
			return;
		case EBulletActionRunnerState.Running:
			bulletInfo.NextActionInfoList.Add(actionInfo);
			if (bulletInfo != this.CurRunningBulletInfo)
			{
				this.NextBulletInfoList.Add(bulletInfo);
				return;
			}
			break;
		case EBulletActionRunnerState.ClearBullet:
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "清理子弹数据期间不允许有新的行为进来，请检查代码逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		default:
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "当前状态异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			break;
		}
	}

	// Token: 0x06018841 RID: 100417 RVA: 0x006424E5 File Offset: 0x006406E5
	public bool IsRunning()
	{
		return this.State == EBulletActionRunnerState.Running;
	}

	// Token: 0x06018842 RID: 100418 RVA: 0x006424F0 File Offset: 0x006406F0
	public static void InitStat()
	{
		if (!BulletConstant.Instance.OpenActionStat)
		{
			return;
		}
		if (BulletActionRunner.ActionStatList.Count > 0)
		{
			return;
		}
		for (int i = 0; i < 20; i++)
		{
			if (i == 6)
			{
				BulletActionRunner.ActionStatList.Add(Stat.Create("BulletActionInitCollision", "", ""));
			}
			else if (i == 3)
			{
				BulletActionRunner.ActionStatList.Add(Stat.Create("BulletActionInitMove", "", ""));
			}
			else if (i == 7)
			{
				BulletActionRunner.ActionStatList.Add(Stat.Create("BulletActionUpdateEffect", "", ""));
			}
			else if (i == 13)
			{
				BulletActionRunner.ActionStatList.Add(Stat.Create("BulletActionDestroyBullet", "", ""));
			}
			else if (i == 11)
			{
				BulletActionRunner.ActionStatList.Add(Stat.Create("BulletActionSummonBullet", "", ""));
			}
			else if (BulletConstant.Instance.OpenAllActionStat)
			{
				Stat item = null;
				BulletActionRunner.ActionStatList.Add(item);
			}
			else
			{
				BulletActionRunner.ActionStatList.Add(null);
			}
		}
	}

	// Token: 0x06018843 RID: 100419 RVA: 0x0064260D File Offset: 0x0064080D
	public static void CreateStaticDefaultValue()
	{
		BulletActionRunner._actionStatList = new List<Stat>();
	}

	// Token: 0x06018844 RID: 100420 RVA: 0x00642619 File Offset: 0x00640819
	public static void ResetStaticDefaultValue()
	{
		BulletActionRunner._actionStatList = null;
	}

	// Token: 0x0400B5D8 RID: 46552
	[StaticVariableRuleIgnore]
	private static readonly Stat RunStat = Stat.Create("BulletActionRunner", "", "");

	// Token: 0x0400B5D9 RID: 46553
	[Nullable(2)]
	private static List<Stat> _actionStatList;

	// Token: 0x0400B5DA RID: 46554
	private readonly BulletActionCenter ActionCenter = new BulletActionCenter();

	// Token: 0x0400B5DB RID: 46555
	private EBulletActionRunnerState State;

	// Token: 0x0400B5DC RID: 46556
	private List<BulletInfo> BulletInfoList = new List<BulletInfo>();

	// Token: 0x0400B5DD RID: 46557
	private List<BulletInfo> NextBulletInfoList = new List<BulletInfo>();

	// Token: 0x0400B5DE RID: 46558
	[Nullable(2)]
	private BulletInfo CurRunningBulletInfo;
}
