using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02001B45 RID: 6981
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDayStartTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF5A RID: 53082 RVA: 0x002F3E87 File Offset: 0x002F2087
	public FloroRanchDayStartTask(FloroRanchDayStart dayStartData)
	{
		this.DayStartData = dayStartData;
	}

	// Token: 0x0600CF5B RID: 53083 RVA: 0x002F3E96 File Offset: 0x002F2096
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.DayStart(this.DayStartData).ContinueWith(delegate()
		{
			base.AsyncComplete(null);
		});
	}

	// Token: 0x04005F5B RID: 24411
	private readonly FloroRanchDayStart DayStartData;
}
