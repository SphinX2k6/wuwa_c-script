using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000DDC RID: 3548
public class GameSettingsInitValueSource
{
	// Token: 0x06005514 RID: 21780 RVA: 0x000F5410 File Offset: 0x000F3610
	public GameSettingsInitValueSource(EFunction functionId)
	{
		this.FunctionId = functionId;
	}

	// Token: 0x06005515 RID: 21781 RVA: 0x000F542C File Offset: 0x000F362C
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

	// Token: 0x06005516 RID: 21782 RVA: 0x000F5510 File Offset: 0x000F3710
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

	// Token: 0x06005517 RID: 21783 RVA: 0x000F55AC File Offset: 0x000F37AC
	public bool HasCachedSource(EGameSettingsInitSourceType sourceType)
	{
		return this.InitSourceMap.ContainsKey(sourceType);
	}

	// Token: 0x06005518 RID: 21784 RVA: 0x000F55BC File Offset: 0x000F37BC
	public OneOf<int, float, double>? GetCachedValueBySourceType(EGameSettingsInitSourceType sourceType)
	{
		OneOf<int, float, double> value;
		if (this.InitSourceMap.TryGetValue(sourceType, out value))
		{
			return new OneOf<int, float, double>?(value);
		}
		return null;
	}

	// Token: 0x170005EE RID: 1518
	// (get) Token: 0x06005519 RID: 21785 RVA: 0x000F55EC File Offset: 0x000F37EC
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

	// Token: 0x040026B1 RID: 9905
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly Dictionary<EGameSettingsInitSourceType, OneOf<int, float, double>> InitSourceMap = new Dictionary<EGameSettingsInitSourceType, OneOf<int, float, double>>();

	// Token: 0x040026B2 RID: 9906
	private readonly EFunction FunctionId;
}
