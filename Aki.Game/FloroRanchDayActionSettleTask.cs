using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02001001 RID: 4097
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDayActionSettleTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A363 RID: 41827 RVA: 0x002FEED1 File Offset: 0x002FD0D1
	public FloroRanchDayActionSettleTask(FRUnitActions dayActionData)
	{
		this.DayActionData = dayActionData;
	}

	// Token: 0x0600A364 RID: 41828 RVA: 0x002FEEE0 File Offset: 0x002FD0E0
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.ExecuteActionList(new List<FloroRanchUnitActionMsg>(this.DayActionData.UnitActions)).ContinueWith(delegate()
		{
			base.AsyncComplete(null);
		});
	}

	// Token: 0x04006028 RID: 24616
	private readonly FRUnitActions DayActionData;
}
