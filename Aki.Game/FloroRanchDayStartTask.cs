using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02001004 RID: 4100
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDayStartTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A36B RID: 41835 RVA: 0x002FEF5F File Offset: 0x002FD15F
	public FloroRanchDayStartTask(FloroRanchDayStart dayStartData)
	{
		this.DayStartData = dayStartData;
	}

	// Token: 0x0600A36C RID: 41836 RVA: 0x002FEF6E File Offset: 0x002FD16E
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.DayStart(this.DayStartData).ContinueWith(delegate()
		{
			base.AsyncComplete(null);
		});
	}

	// Token: 0x0400602A RID: 24618
	private readonly FloroRanchDayStart DayStartData;
}
