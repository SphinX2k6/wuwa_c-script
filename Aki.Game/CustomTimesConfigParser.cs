using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023EE RID: 9198
public static class CustomTimesConfigParser
{
	// Token: 0x060170A1 RID: 94369 RVA: 0x006BA6B0 File Offset: 0x006B88B0
	[return: Nullable(new byte[]
	{
		1,
		2
	})]
	public static CustomTimesConfig[] ParseConfigs([Nullable(new byte[]
	{
		2,
		1
	})] string[] grow3Params, long buffId)
	{
		string[] array = grow3Params ?? Array.Empty<string>();
		CustomTimesConfig[] array2 = new CustomTimesConfig[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			string[] array3 = (text != null) ? text.Split('#', StringSplitOptions.None) : null;
			int num;
			if (array3 != null && array3.Length != 0 && int.TryParse(array3[0], out num) && num == 1)
			{
				array2[i] = CustomTimesConfigParser.ParseConfig(text, buffId);
			}
			else
			{
				array2[i] = null;
			}
		}
		return array2;
	}

	// Token: 0x060170A2 RID: 94370 RVA: 0x006BA720 File Offset: 0x006B8920
	[NullableContext(2)]
	private unsafe static CustomTimesConfig ParseConfig(string config, long buffId)
	{
		if (string.IsNullOrEmpty(config))
		{
			return null;
		}
		string[] array = config.Split('#', StringSplitOptions.None);
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = array[i].Trim();
		}
		if (array2.Length < 6)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "自定义Times(Buff配置的ExtraEffectParametersGrow3)参数个数错误";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("config", config);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		int num = 0;
		int calcType;
		int attributeId;
		int valueTarget;
		int valueType;
		float rate;
		float limit;
		if (!int.TryParse(array2[num++], out calcType) || !int.TryParse(array2[num++], out attributeId) || !int.TryParse(array2[num++], out valueTarget) || !int.TryParse(array2[num++], out valueType) || !float.TryParse(array2[num++], out rate) || !float.TryParse(array2[num++], out limit))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.GHY;
			string message2 = "自定义Times(Buff配置的ExtraEffectParametersGrow3)存在无法解析为数字的字段";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("config", config);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		return new CustomTimesConfig
		{
			CalcType = (ECustomTimesCalcType)calcType,
			AttributeId = attributeId,
			ValueTarget = (ECustomTimesValueTarget)valueTarget,
			ValueType = (ECustomTimesValueType)valueType,
			Rate = rate,
			Limit = limit
		};
	}

	// Token: 0x060170A3 RID: 94371 RVA: 0x006BA8B9 File Offset: 0x006B8AB9
	[NullableContext(1)]
	public static float CalcCustomTimes(CustomTimesConfig config, BaseAttributeComponent attrComp)
	{
		return Math.Min((float)Math.Floor((double)(((config.ValueType == ECustomTimesValueType.CurrentValue) ? attrComp.GetCurrentValue((EAttributeType)config.AttributeId) : attrComp.GetBaseValue((EAttributeType)config.AttributeId)) * config.Rate)), config.Limit);
	}

	// Token: 0x0400C1C9 RID: 49609
	private const int CUSTOM_TIMES_PARAM_COUNT = 6;
}
