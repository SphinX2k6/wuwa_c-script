using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200326E RID: 12910
[NullableContext(1)]
[Nullable(0)]
public class DisableEntityHandle
{
	// Token: 0x0601BE6D RID: 114285 RVA: 0x007BCD0D File Offset: 0x007BAF0D
	public DisableEntityHandle(string type)
	{
		this.Type = type;
	}

	// Token: 0x17002664 RID: 9828
	// (get) Token: 0x0601BE6E RID: 114286 RVA: 0x007BCD27 File Offset: 0x007BAF27
	public bool Empty
	{
		get
		{
			return this.DisableMap.Count == 0;
		}
	}

	// Token: 0x0601BE6F RID: 114287 RVA: 0x007BCD38 File Offset: 0x007BAF38
	public unsafe int Disable(string reason, string constructorName)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "Disable的Reason不能使用undefined";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConstructorName", constructorName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		else if (reason.Length < 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "Disable的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ConstructorName", constructorName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		int num = this.DisableCount + 1;
		this.DisableCount = num;
		int num2 = num;
		this.DisableMap[num2] = reason;
		return num2;
	}

	// Token: 0x0601BE70 RID: 114288 RVA: 0x007BCE10 File Offset: 0x007BB010
	public unsafe bool Enable(int handle, string constructorName)
	{
		string text;
		if (!this.DisableMap.TryGetValue(handle, out text))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "激活句柄不存在";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", this.Type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConstructorName", constructorName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("handle", handle);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		return this.DisableMap.Remove(handle);
	}

	// Token: 0x0601BE71 RID: 114289 RVA: 0x007BCEAF File Offset: 0x007BB0AF
	public void Clear()
	{
		this.DisableMap.Clear();
	}

	// Token: 0x0601BE72 RID: 114290 RVA: 0x007BCEBC File Offset: 0x007BB0BC
	public string DumpDisableInfo()
	{
		List<string> list = new List<string>();
		string value = "";
		foreach (KeyValuePair<int, string> keyValuePair in this.DisableMap)
		{
			List<string> list2 = list;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("{Type:");
			defaultInterpolatedStringHandler.AppendFormatted(this.Type);
			defaultInterpolatedStringHandler.AppendLiteral(",Handle:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Key);
			defaultInterpolatedStringHandler.AppendLiteral(",Reason:");
			defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Value);
			defaultInterpolatedStringHandler.AppendLiteral("}");
			list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			value = " ";
		}
		return string.Join("", list);
	}

	// Token: 0x0400DC34 RID: 56372
	private int DisableCount;

	// Token: 0x0400DC35 RID: 56373
	private readonly Dictionary<int, string> DisableMap = new Dictionary<int, string>();

	// Token: 0x0400DC36 RID: 56374
	private readonly string Type;
}
