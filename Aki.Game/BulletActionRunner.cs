using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;

// Token: 0x020022EF RID: 8943
[NullableContext(1)]
[Nullable(0)]
public class BulletActionRunner : IStaticVariableResetter
{
	// Token: 0x060160DB RID: 90331 RVA: 0x00667CCF File Offset: 0x00665ECF
	static BulletActionRunner()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletActionRunner.CreateStaticDefaultValue), new Action(BulletActionRunner.ResetStaticDefaultValue));
	}

	// Token: 0x17002179 RID: 8569
	// (get) Token: 0x060160DC RID: 90332 RVA: 0x00667D07 File Offset: 0x00665F07
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

	// Token: 0x060160DD RID: 90333 RVA: 0x00667D0E File Offset: 0x00665F0E
	public void Init()
	{
		this.ActionCenter.Init();
	}

	// Token: 0x060160DE RID: 90334 RVA: 0x00667D1B File Offset: 0x00665F1B
	public void Clear()
	{
		this.ActionCenter.Clear();
	}

	// Token: 0x060160DF RID: 90335 RVA: 0x00667D28 File Offset: 0x00665F28
	public BulletActionCenter GetActionCenter()
	{
		return this.ActionCenter;
	}

	// Token: 0x060160E0 RID: 90336 RVA: 0x00667D30 File Offset: 0x00665F30
	public void Pause()
	{
		if (this.State != EBulletActionRunnerState.Idle)
		{
			Log.Instance.Error(ELogModule.Temp, ELogAuthor.CFT, "当前不是空闲状态，不允许暂停", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.State = EBulletActionRunnerState.Pause;
	}

	// Token: 0x060160E1 RID: 90337 RVA: 0x00667D68 File Offset: 0x00665F68
	public void Resume()
	{
		if (this.State != EBulletActionRunnerState.Pause)
		{
			Log.Instance.Error(ELogModule.Temp, ELogAuthor.CFT, "当前不是暂停状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.State = EBulletActionRunnerState.Idle;
	}

	// Token: 0x060160E2 RID: 90338 RVA: 0x00667DA4 File Offset: 0x00665FA4
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

	// Token: 0x060160E3 RID: 90339 RVA: 0x00667EC4 File Offset: 0x006660C4
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

	// Token: 0x060160E4 RID: 90340 RVA: 0x006681E8 File Offset: 0x006663E8
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

	// Token: 0x060160E5 RID: 90341 RVA: 0x006682A1 File Offset: 0x006664A1
	public bool IsRunning()
	{
		return this.State == EBulletActionRunnerState.Running;
	}

	// Token: 0x060160E6 RID: 90342 RVA: 0x006682AC File Offset: 0x006664AC
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

	// Token: 0x060160E7 RID: 90343 RVA: 0x006683C9 File Offset: 0x006665C9
	public static void CreateStaticDefaultValue()
	{
		BulletActionRunner._actionStatList = new List<Stat>();
	}

	// Token: 0x060160E8 RID: 90344 RVA: 0x006683D5 File Offset: 0x006665D5
	public static void ResetStaticDefaultValue()
	{
		BulletActionRunner._actionStatList = null;
	}

	// Token: 0x0400B94E RID: 47438
	[StaticVariableRuleIgnore]
	private static readonly Stat RunStat = Stat.Create("BulletActionRunner", "", "");

	// Token: 0x0400B94F RID: 47439
	[Nullable(2)]
	private static List<Stat> _actionStatList;

	// Token: 0x0400B950 RID: 47440
	private readonly BulletActionCenter ActionCenter = new BulletActionCenter();

	// Token: 0x0400B951 RID: 47441
	private EBulletActionRunnerState State;

	// Token: 0x0400B952 RID: 47442
	private List<BulletInfo> BulletInfoList = new List<BulletInfo>();

	// Token: 0x0400B953 RID: 47443
	private List<BulletInfo> NextBulletInfoList = new List<BulletInfo>();

	// Token: 0x0400B954 RID: 47444
	[Nullable(2)]
	private BulletInfo CurRunningBulletInfo;
}
