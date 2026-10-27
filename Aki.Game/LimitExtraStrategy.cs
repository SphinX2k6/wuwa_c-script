using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BB9 RID: 7097
public class LimitExtraStrategy : ILimitStrategy
{
	// Token: 0x0600D39C RID: 54172 RVA: 0x0030A83C File Offset: 0x00308A3C
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
