using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026CD RID: 9933
[NullableContext(1)]
[Nullable(0)]
public abstract class RacingBetsCommandBase : IDangoDungeonCommand, IStaticVariableResetter
{
	// Token: 0x060145F1 RID: 83441 RVA: 0x0052737F File Offset: 0x0052557F
	static RacingBetsCommandBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsCommandBase.CreateStaticDefaultValue), new Action(RacingBetsCommandBase.ResetStaticDefaultValue));
	}

	// Token: 0x060145F2 RID: 83442 RVA: 0x0052739E File Offset: 0x0052559E
	public RacingBetsCommandBase()
	{
		this.CommandIndex = ++RacingBetsCommandBase.SelfIncrementId;
	}

	// Token: 0x060145F3 RID: 83443 RVA: 0x005273C4 File Offset: 0x005255C4
	public static void CreateStaticDefaultValue()
	{
		RacingBetsCommandBase.SelfIncrementId = 0;
	}

	// Token: 0x060145F4 RID: 83444 RVA: 0x005273CC File Offset: 0x005255CC
	public static void ResetStaticDefaultValue()
	{
		RacingBetsCommandBase.SelfIncrementId = 0;
	}

	// Token: 0x17001A63 RID: 6755
	// (get) Token: 0x060145F5 RID: 83445 RVA: 0x005273D4 File Offset: 0x005255D4
	// (set) Token: 0x060145F6 RID: 83446 RVA: 0x005273DC File Offset: 0x005255DC
	public int CommandIndex { get; set; }

	// Token: 0x17001A64 RID: 6756
	// (get) Token: 0x060145F7 RID: 83447
	public abstract ERacingBetsCommandType CommandType { get; }

	// Token: 0x17001A65 RID: 6757
	// (get) Token: 0x060145F8 RID: 83448 RVA: 0x005273E5 File Offset: 0x005255E5
	// (set) Token: 0x060145F9 RID: 83449 RVA: 0x005273ED File Offset: 0x005255ED
	public int ActionIndex { get; set; }

	// Token: 0x17001A66 RID: 6758
	// (get) Token: 0x060145FA RID: 83450 RVA: 0x005273F6 File Offset: 0x005255F6
	// (set) Token: 0x060145FB RID: 83451 RVA: 0x005273FE File Offset: 0x005255FE
	public bool IsAborted { get; set; }

	// Token: 0x060145FC RID: 83452 RVA: 0x00527408 File Offset: 0x00525608
	public UniTask Execute()
	{
		RacingBetsCommandBase.<Execute>d__20 <Execute>d__;
		<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Execute>d__.<>4__this = this;
		<Execute>d__.<>1__state = -1;
		<Execute>d__.<>t__builder.Start<RacingBetsCommandBase.<Execute>d__20>(ref <Execute>d__);
		return <Execute>d__.<>t__builder.Task;
	}

	// Token: 0x060145FD RID: 83453 RVA: 0x0052744B File Offset: 0x0052564B
	public virtual void OnActive()
	{
	}

	// Token: 0x060145FE RID: 83454 RVA: 0x0052744D File Offset: 0x0052564D
	public virtual void OnDeActive()
	{
	}

	// Token: 0x060145FF RID: 83455 RVA: 0x0052744F File Offset: 0x0052564F
	public virtual UniTask OnExecute()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06014600 RID: 83456 RVA: 0x00527456 File Offset: 0x00525656
	public virtual string LogInfo()
	{
		return "RacingBetsCommandBase";
	}

	// Token: 0x06014601 RID: 83457 RVA: 0x0052745D File Offset: 0x0052565D
	public void PushBulletScreenTimes(List<BulletScreenTimes> bulletScreenTimes)
	{
		this.BulletScreenTimes = bulletScreenTimes;
	}

	// Token: 0x06014602 RID: 83458 RVA: 0x00527468 File Offset: 0x00525668
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

	// Token: 0x06014603 RID: 83459 RVA: 0x00527538 File Offset: 0x00525738
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

	// Token: 0x04009914 RID: 39188
	private static int SelfIncrementId;

	// Token: 0x04009915 RID: 39189
	protected List<BulletScreenTimes> BulletScreenTimes = new List<BulletScreenTimes>();
}
