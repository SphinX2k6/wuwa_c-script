using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02001B44 RID: 6980
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDaySalarySettleTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF57 RID: 53079 RVA: 0x002F3E50 File Offset: 0x002F2050
	public FloroRanchDaySalarySettleTask(FloroRanchWageSettleTask wageSettleData)
	{
		this.WageSettleData = wageSettleData;
	}

	// Token: 0x0600CF58 RID: 53080 RVA: 0x002F3E5F File Offset: 0x002F205F
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.ExecuteWageSettleAction(this.WageSettleData).ContinueWith(delegate()
		{
			base.AsyncComplete(null);
		});
	}

	// Token: 0x04005F5A RID: 24410
	private readonly FloroRanchWageSettleTask WageSettleData;
}
