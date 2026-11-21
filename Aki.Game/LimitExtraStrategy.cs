using System;
using System.Runtime.CompilerServices;

// Token: 0x02001078 RID: 4216
public class LimitExtraStrategy : ILimitStrategy
{
	// Token: 0x0600A7AE RID: 42926 RVA: 0x00315930 File Offset: 0x00313B30
	[NullableContext(1)]
	public IValidationResult<ELimitReason> CheckLimit(ILimitContext ctx)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[LimitExtraStrategy.CheckLimit] P3-2 stub:dungeonId={DungeonId} 默认放行";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("{DungeonId}", ctx.DungeonId);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return FormationLimitResult.Ok();
	}
}
