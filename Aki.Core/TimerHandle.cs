using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D5 RID: 213
public class TimerHandle : IStaticVariableResetter
{
	// Token: 0x060006D3 RID: 1747 RVA: 0x00023556 File Offset: 0x00021756
	static TimerHandle()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimerHandle.CreateStaticDefaultValue), new Action(TimerHandle.ResetStaticDefaultValue));
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00023575 File Offset: 0x00021775
	public static void CreateStaticDefaultValue()
	{
		TimerHandle.Increment = 0;
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x0002357D File Offset: 0x0002177D
	public static void ResetStaticDefaultValue()
	{
		TimerHandle.Increment = 0;
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00023585 File Offset: 0x00021785
	[NullableContext(1)]
	public TimerHandle(TimerSystemInstance instance)
	{
		this.Instance = instance;
		this.Id = ++TimerHandle.Increment;
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x000235A7 File Offset: 0x000217A7
	public bool Valid()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Has(this);
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x000235BB File Offset: 0x000217BB
	public bool Remove()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Remove(this);
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x000235CF File Offset: 0x000217CF
	[NullableContext(2)]
	public void PendingRemove_FinalizerThread(string reason)
	{
		TimerSystemInstance instance = this.Instance;
		if (instance == null)
		{
			return;
		}
		instance.PendingRemove_FinalizerThread(this, reason);
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x000235E3 File Offset: 0x000217E3
	public bool IsPause()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.IsPause(this);
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x000235F7 File Offset: 0x000217F7
	public bool Pause()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Pause(this, null);
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0002360C File Offset: 0x0002180C
	public bool Resume()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Resume(this);
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00023620 File Offset: 0x00021820
	public bool ChangeDilation(float dilation)
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.ChangeDilation(this, dilation, null);
	}

	// Token: 0x0400055C RID: 1372
	public readonly int Id;

	// Token: 0x0400055D RID: 1373
	private static int Increment;

	// Token: 0x0400055E RID: 1374
	[Nullable(2)]
	private readonly TimerSystemInstance Instance;
}
