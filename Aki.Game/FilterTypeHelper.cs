using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A2C RID: 10796
[NullableContext(1)]
[Nullable(0)]
public static class FilterTypeHelper
{
	// Token: 0x0601B344 RID: 111428 RVA: 0x0085A5DC File Offset: 0x008587DC
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

	// Token: 0x0400EC54 RID: 60500
	[StaticVariableRuleIgnore]
	public static readonly EFilterType[] FilterTypePriority = new EFilterType[]
	{
		EFilterType.Top,
		EFilterType.BindGroup,
		EFilterType.Black
	};

	// Token: 0x0400EC55 RID: 60501
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
