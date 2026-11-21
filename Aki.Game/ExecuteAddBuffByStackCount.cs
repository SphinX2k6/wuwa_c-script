using System;
using System.Runtime.CompilerServices;

// Token: 0x020024E6 RID: 9446
[NullableContext(1)]
[Nullable(0)]
public class ExecuteAddBuffByStackCount : PeriodExecution
{
	// Token: 0x060176BE RID: 95934 RVA: 0x006E69CF File Offset: 0x006E4BCF
	public ExecuteAddBuffByStackCount(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176BF RID: 95935 RVA: 0x006E69D8 File Offset: 0x006E4BD8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.TargetType = EExecutionTargetType.Self;
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			this.Ids = Array.Empty<long[]>();
			return;
		}
		this.Ids = new long[extraEffectParameters_.Length][];
		for (int i = 0; i < extraEffectParameters_.Length; i++)
		{
			long[][] ids = this.Ids;
			int num = i;
			string[] array = extraEffectParameters_[i].Split('#', StringSplitOptions.None);
			Converter<string, long> converter;
			if ((converter = ExecuteAddBuffByStackCount.<>O.<0>__Parse) == null)
			{
				converter = (ExecuteAddBuffByStackCount.<>O.<0>__Parse = new Converter<string, long>(long.Parse));
			}
			ids[num] = Array.ConvertAll<string, long>(array, converter);
		}
	}

	// Token: 0x060176C0 RID: 95936 RVA: 0x006E6A54 File Offset: 0x006E4C54
	[return: Nullable(2)]
	public unsafe override object OnExecute(params object[] args)
	{
		int stackCount = this.Buff.StackCount;
		long[] levelValue = AbilityUtils.GetLevelValue<long[]>(this.Ids, stackCount, Array.Empty<long>());
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "尝试执行添加buff的额外效果时找不到对应的buff接收者";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "持有者";
			IActiveBuff buff = this.Buff;
			ptr = new ValueTuple<string, object>(item, (buff != null) ? buff.GetOwnerDebugName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("施加者", this.Buff.InstigatorId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return null;
		}
		foreach (long num in levelValue)
		{
			IBuffComponent buffComponent = ownerBuffComponent;
			long buffId = num;
			IActiveBuff buff2 = this.Buff;
			int? stackCount2 = new int?(1);
			bool isIterable = true;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("因为其它瞬间型buff额外效果迭代添加（前置buff Id=");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			buffComponent.AddIterativeBuff(buffId, buff2, stackCount2, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
		}
		return null;
	}

	// Token: 0x0400C6FB RID: 50939
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public long[][] Ids;

	// Token: 0x02008830 RID: 34864
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402B90A RID: 178442
		[Nullable(0)]
		public static Converter<string, long> <0>__Parse;
	}
}
