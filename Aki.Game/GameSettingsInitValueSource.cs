using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200028E RID: 654
public class GameSettingsInitValueSource
{
	// Token: 0x060028A7 RID: 10407 RVA: 0x000FCAF6 File Offset: 0x000FACF6
	public GameSettingsInitValueSource(EFunction functionId)
	{
		this.FunctionId = functionId;
	}

	// Token: 0x060028A8 RID: 10408 RVA: 0x000FCB10 File Offset: 0x000FAD10
	public unsafe void CacheValue(OneOf<int, float, double> value, EGameSettingsInitSourceType sourceType)
	{
		if (!this.InitSourceMap.ContainsKey(sourceType))
		{
			this.InitSourceMap[sourceType] = value;
			return;
		}
		OneOf<int, float, double> oneOf = this.InitSourceMap[sourceType];
		if (oneOf.Equals(value))
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.WZ;
		string message = "收集设置数据时，出现来源重复且值不一致。当前数据弃置";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)this.FunctionId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sourceType", sourceType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("existValue", oneOf);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("newValue", value);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x060028A9 RID: 10409 RVA: 0x000FCBF4 File Offset: 0x000FADF4
	public unsafe void RefreshCacheValue(OneOf<int, float, double> value, EGameSettingsInitSourceType sourceType)
	{
		this.InitSourceMap[sourceType] = value;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.TZJ;
		string message = "[GameSettingsInitValueSource] 刷新缓存值";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)this.FunctionId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sourceType", sourceType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("value", value);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x060028AA RID: 10410 RVA: 0x000FCC90 File Offset: 0x000FAE90
	public bool HasCachedSource(EGameSettingsInitSourceType sourceType)
	{
		return this.InitSourceMap.ContainsKey(sourceType);
	}

	// Token: 0x060028AB RID: 10411 RVA: 0x000FCCA0 File Offset: 0x000FAEA0
	public OneOf<int, float, double>? GetCachedValueBySourceType(EGameSettingsInitSourceType sourceType)
	{
		OneOf<int, float, double> value;
		if (this.InitSourceMap.TryGetValue(sourceType, out value))
		{
			return new OneOf<int, float, double>?(value);
		}
		return null;
	}

	// Token: 0x17000614 RID: 1556
	// (get) Token: 0x060028AC RID: 10412 RVA: 0x000FCCD0 File Offset: 0x000FAED0
	public OneOf<int, float, double>? ValidInitValue
	{
		get
		{
			if (GameSettingsDefine.gameSettingsInitSourceTypePriority == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GameSettings;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "gameSettingsInitSourceTypePriority 未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)this.FunctionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			foreach (EGameSettingsInitSourceType key in GameSettingsDefine.gameSettingsInitSourceTypePriority)
			{
				OneOf<int, float, double> value;
				if (this.InitSourceMap.TryGetValue(key, out value))
				{
					return new OneOf<int, float, double>?(value);
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "不能获得有效的数据缓存，返回undefined";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", (int)this.FunctionId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
	}

	// Token: 0x0400273C RID: 10044
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly Dictionary<EGameSettingsInitSourceType, OneOf<int, float, double>> InitSourceMap = new Dictionary<EGameSettingsInitSourceType, OneOf<int, float, double>>();

	// Token: 0x0400273D RID: 10045
	private readonly EFunction FunctionId;
}
