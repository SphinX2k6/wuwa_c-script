using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027DD RID: 10205
[NullableContext(1)]
[Nullable(0)]
public class DisableEntityHandle
{
	// Token: 0x06019A48 RID: 105032 RVA: 0x007E45E5 File Offset: 0x007E27E5
	public DisableEntityHandle(string type)
	{
		this.Type = type;
	}

	// Token: 0x170028F7 RID: 10487
	// (get) Token: 0x06019A49 RID: 105033 RVA: 0x007E45FF File Offset: 0x007E27FF
	public bool Empty
	{
		get
		{
			return this.DisableMap.Count == 0;
		}
	}

	// Token: 0x06019A4A RID: 105034 RVA: 0x007E4610 File Offset: 0x007E2810
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

	// Token: 0x06019A4B RID: 105035 RVA: 0x007E46E8 File Offset: 0x007E28E8
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

	// Token: 0x06019A4C RID: 105036 RVA: 0x007E4787 File Offset: 0x007E2987
	public void Clear()
	{
		this.DisableMap.Clear();
	}

	// Token: 0x06019A4D RID: 105037 RVA: 0x007E4794 File Offset: 0x007E2994
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

	// Token: 0x0400E0D3 RID: 57555
	private int DisableCount;

	// Token: 0x0400E0D4 RID: 57556
	private readonly Dictionary<int, string> DisableMap = new Dictionary<int, string>();

	// Token: 0x0400E0D5 RID: 57557
	private readonly string Type;
}
