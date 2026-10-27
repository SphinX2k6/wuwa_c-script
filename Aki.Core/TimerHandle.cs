using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D3 RID: 211
public class TimerHandle : IStaticVariableResetter
{
	// Token: 0x06000692 RID: 1682 RVA: 0x00022F86 File Offset: 0x00021186
	static TimerHandle()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimerHandle.CreateStaticDefaultValue), new Action(TimerHandle.ResetStaticDefaultValue));
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00022FA5 File Offset: 0x000211A5
	public static void CreateStaticDefaultValue()
	{
		TimerHandle.Increment = 0;
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00022FAD File Offset: 0x000211AD
	public static void ResetStaticDefaultValue()
	{
		TimerHandle.Increment = 0;
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00022FB5 File Offset: 0x000211B5
	[NullableContext(1)]
	public TimerHandle(TimerSystemInstance instance)
	{
		this.Instance = instance;
		this.Id = ++TimerHandle.Increment;
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00022FD7 File Offset: 0x000211D7
	public bool Valid()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Has(this);
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00022FEB File Offset: 0x000211EB
	public bool Remove()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Remove(this);
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00022FFF File Offset: 0x000211FF
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

	// Token: 0x06000699 RID: 1689 RVA: 0x00023013 File Offset: 0x00021213
	public bool IsPause()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.IsPause(this);
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00023027 File Offset: 0x00021227
	public bool Pause()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Pause(this, null);
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x0002303C File Offset: 0x0002123C
	public bool Resume()
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.Resume(this);
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00023050 File Offset: 0x00021250
	public bool ChangeDilation(float dilation)
	{
		TimerSystemInstance instance = this.Instance;
		return instance != null && instance.ChangeDilation(this, dilation, null);
	}

	// Token: 0x0400054D RID: 1357
	public readonly int Id;

	// Token: 0x0400054E RID: 1358
	private static int Increment;

	// Token: 0x0400054F RID: 1359
	[Nullable(2)]
	private readonly TimerSystemInstance Instance;
}
