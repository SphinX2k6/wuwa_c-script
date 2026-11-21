using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB8 RID: 7096
[NullableContext(1)]
[Nullable(0)]
public abstract class RacingBetsCommandBase : IDangoDungeonCommand, IStaticVariableResetter
{
	// Token: 0x06011AD3 RID: 72403 RVA: 0x005360B7 File Offset: 0x005342B7
	static RacingBetsCommandBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsCommandBase.CreateStaticDefaultValue), new Action(RacingBetsCommandBase.ResetStaticDefaultValue));
	}

	// Token: 0x06011AD4 RID: 72404 RVA: 0x005360D6 File Offset: 0x005342D6
	public RacingBetsCommandBase()
	{
		this.CommandIndex = ++RacingBetsCommandBase.SelfIncrementId;
	}

	// Token: 0x06011AD5 RID: 72405 RVA: 0x005360FC File Offset: 0x005342FC
	public static void CreateStaticDefaultValue()
	{
		RacingBetsCommandBase.SelfIncrementId = 0;
	}

	// Token: 0x06011AD6 RID: 72406 RVA: 0x00536104 File Offset: 0x00534304
	public static void ResetStaticDefaultValue()
	{
		RacingBetsCommandBase.SelfIncrementId = 0;
	}

	// Token: 0x17001A9B RID: 6811
	// (get) Token: 0x06011AD7 RID: 72407 RVA: 0x0053610C File Offset: 0x0053430C
	// (set) Token: 0x06011AD8 RID: 72408 RVA: 0x00536114 File Offset: 0x00534314
	public int CommandIndex { get; set; }

	// Token: 0x17001A9C RID: 6812
	// (get) Token: 0x06011AD9 RID: 72409
	public abstract ERacingBetsCommandType CommandType { get; }

	// Token: 0x17001A9D RID: 6813
	// (get) Token: 0x06011ADA RID: 72410 RVA: 0x0053611D File Offset: 0x0053431D
	// (set) Token: 0x06011ADB RID: 72411 RVA: 0x00536125 File Offset: 0x00534325
	public int ActionIndex { get; set; }

	// Token: 0x17001A9E RID: 6814
	// (get) Token: 0x06011ADC RID: 72412 RVA: 0x0053612E File Offset: 0x0053432E
	// (set) Token: 0x06011ADD RID: 72413 RVA: 0x00536136 File Offset: 0x00534336
	public bool IsAborted { get; set; }

	// Token: 0x06011ADE RID: 72414 RVA: 0x00536140 File Offset: 0x00534340
	public UniTask Execute()
	{
		RacingBetsCommandBase.<Execute>d__20 <Execute>d__;
		<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Execute>d__.<>4__this = this;
		<Execute>d__.<>1__state = -1;
		<Execute>d__.<>t__builder.Start<RacingBetsCommandBase.<Execute>d__20>(ref <Execute>d__);
		return <Execute>d__.<>t__builder.Task;
	}

	// Token: 0x06011ADF RID: 72415 RVA: 0x00536183 File Offset: 0x00534383
	public virtual void OnActive()
	{
	}

	// Token: 0x06011AE0 RID: 72416 RVA: 0x00536185 File Offset: 0x00534385
	public virtual void OnDeActive()
	{
	}

	// Token: 0x06011AE1 RID: 72417 RVA: 0x00536187 File Offset: 0x00534387
	public virtual UniTask OnExecute()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06011AE2 RID: 72418 RVA: 0x0053618E File Offset: 0x0053438E
	public virtual string LogInfo()
	{
		return "RacingBetsCommandBase";
	}

	// Token: 0x06011AE3 RID: 72419 RVA: 0x00536195 File Offset: 0x00534395
	public void PushBulletScreenTimes(List<BulletScreenTimes> bulletScreenTimes)
	{
		this.BulletScreenTimes = bulletScreenTimes;
	}

	// Token: 0x06011AE4 RID: 72420 RVA: 0x005361A0 File Offset: 0x005343A0
	protected int GetRandomBulletScreen(List<BulletScreenTimes> bulletScreenTimes)
	{
		int num = 0;
		foreach (BulletScreenTimes bulletScreenTimes2 in bulletScreenTimes)
		{
			num += bulletScreenTimes2.Num;
		}
		if (num == 0)
		{
			return 0;
		}
		int num2 = Random.Shared.Next(num);
		foreach (BulletScreenTimes bulletScreenTimes3 in bulletScreenTimes)
		{
			if (num2 < bulletScreenTimes3.Num)
			{
				BulletScreenTimes bulletScreenTimes4 = bulletScreenTimes3;
				int num3 = bulletScreenTimes4.Num;
				bulletScreenTimes4.Num = num3 - 1;
				return bulletScreenTimes3.BulletScreenId;
			}
			num2 -= bulletScreenTimes3.Num;
		}
		return 0;
	}

	// Token: 0x06011AE5 RID: 72421 RVA: 0x00536270 File Offset: 0x00534470
	private void BroadcastBulletScreen()
	{
		List<int> list = new List<int>();
		int randomBulletScreen;
		while ((randomBulletScreen = this.GetRandomBulletScreen(this.BulletScreenTimes)) != 0)
		{
			list.Add(randomBulletScreen);
		}
		if (list.Count <= 0)
		{
			return;
		}
		EventSystem.Instance.Emit<IReadOnlyList<int>, bool>(EEventName.OnRacingBetsPushBulletScreen, list, false);
	}

	// Token: 0x04009A6C RID: 39532
	private static int SelfIncrementId;

	// Token: 0x04009A6D RID: 39533
	protected List<BulletScreenTimes> BulletScreenTimes = new List<BulletScreenTimes>();
}
