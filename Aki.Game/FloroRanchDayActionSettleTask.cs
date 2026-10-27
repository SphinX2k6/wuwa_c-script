using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02001B42 RID: 6978
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDayActionSettleTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF52 RID: 53074 RVA: 0x002F3DF9 File Offset: 0x002F1FF9
	public FloroRanchDayActionSettleTask(FRUnitActions dayActionData)
	{
		this.DayActionData = dayActionData;
	}

	// Token: 0x0600CF53 RID: 53075 RVA: 0x002F3E08 File Offset: 0x002F2008
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.ExecuteActionList(new List<FloroRanchUnitActionMsg>(this.DayActionData.UnitActions)).ContinueWith(delegate()
		{
			base.AsyncComplete(null);
		});
	}

	// Token: 0x04005F59 RID: 24409
	private readonly FRUnitActions DayActionData;
}
