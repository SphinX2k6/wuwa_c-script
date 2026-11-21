using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02001003 RID: 4099
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDaySalarySettleTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A368 RID: 41832 RVA: 0x002FEF28 File Offset: 0x002FD128
	public FloroRanchDaySalarySettleTask(FloroRanchWageSettleTask wageSettleData)
	{
		this.WageSettleData = wageSettleData;
	}

	// Token: 0x0600A369 RID: 41833 RVA: 0x002FEF37 File Offset: 0x002FD137
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.ExecuteWageSettleAction(this.WageSettleData).ContinueWith(delegate()
		{
			base.AsyncComplete(null);
		});
	}

	// Token: 0x04006029 RID: 24617
	private readonly FloroRanchWageSettleTask WageSettleData;
}
