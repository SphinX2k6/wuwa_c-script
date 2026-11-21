using System;
using System.Runtime.CompilerServices;

// Token: 0x02001075 RID: 4213
public class LimitRoleStrategy : ILimitStrategy
{
	// Token: 0x0600A7A8 RID: 42920 RVA: 0x003157A0 File Offset: 0x003139A0
	[NullableContext(1)]
	public unsafe IValidationResult<ELimitReason> CheckLimit(ILimitContext ctx)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[LimitRoleStrategy.CheckLimit] P3-2 stub:dungeonId={DungeonId} roleId={RoleId} 默认放行";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("{DungeonId}", ctx.DungeonId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("{RoleId}", ctx.CandidateRoleId);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return FormationLimitResult.Ok();
	}
}
