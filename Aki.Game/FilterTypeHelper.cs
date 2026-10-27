using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020034B8 RID: 13496
[NullableContext(1)]
[Nullable(0)]
public static class FilterTypeHelper
{
	// Token: 0x0601D645 RID: 120389 RVA: 0x008331BC File Offset: 0x008313BC
	[return: Nullable(2)]
	public unsafe static T TryCatchWrapper<[Nullable(2)] T>([Nullable(new byte[]
	{
		1,
		2
	})] Func<T> func, string errorMessage, string debugValue)
	{
		try
		{
			return func();
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FilterWithState;
			ELogAuthor author = ELogAuthor.XDW;
			Exception error = ex;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("debugValue", debugValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, errorMessage, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return default(T);
	}

	// Token: 0x0400E7A0 RID: 59296
	[StaticVariableRuleIgnore]
	public static readonly EFilterType[] FilterTypePriority = new EFilterType[]
	{
		EFilterType.Top,
		EFilterType.BindGroup,
		EFilterType.Black
	};

	// Token: 0x0400E7A1 RID: 59297
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EFilterType, bool> FilterResult = new Dictionary<EFilterType, bool>
	{
		{
			EFilterType.Top,
			true
		},
		{
			EFilterType.BindGroup,
			true
		},
		{
			EFilterType.Black,
			false
		}
	};
}
