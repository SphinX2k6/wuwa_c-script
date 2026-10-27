using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BB7 RID: 7095
public class LimitCountStrategy : ILimitStrategy
{
	// Token: 0x0600D398 RID: 54168 RVA: 0x0030A730 File Offset: 0x00308930
	[NullableContext(1)]
	public unsafe IValidationResult<ELimitReason> CheckLimit(ILimitContext ctx)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[LimitCountStrategy.CheckLimit] P3-2 stub:dungeonId={DungeonId} 当前 {Count} 人 默认放行";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("{DungeonId}", ctx.DungeonId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("{Count}", ctx.CurrentRoleIds.Count);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return FormationLimitResult.Ok();
	}
}
