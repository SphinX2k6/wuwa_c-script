using System;
using System.Runtime.CompilerServices;

// Token: 0x020024F1 RID: 9457
[NullableContext(1)]
[Nullable(0)]
public class ModifyFuLuoLuoSpecialEnergy : PeriodExecution
{
	// Token: 0x060176E6 RID: 95974 RVA: 0x006E8944 File Offset: 0x006E6B44
	public ModifyFuLuoLuoSpecialEnergy(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176E7 RID: 95975 RVA: 0x006E8958 File Offset: 0x006E6B58
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			this.NumberParams = Array.Empty<int>();
			return;
		}
		this.NumberParams = new int[extraEffectParameters_.Length];
		for (int i = 0; i < extraEffectParameters_.Length; i++)
		{
			this.NumberParams[i] = int.Parse(extraEffectParameters_[i]);
		}
	}

	// Token: 0x060176E8 RID: 95976 RVA: 0x006E89A8 File Offset: 0x006E6BA8
	[return: Nullable(2)]
	public unsafe override object OnExecute(params object[] args)
	{
		if (base.OwnerEntity != null)
		{
			int energyType = (this.NumberParams.Length != 0) ? this.NumberParams[0] : 0;
			if (!AbilityUtils.ModifyFuLuoLuoSpecialEnergy(base.OwnerEntity, energyType))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity ownerEntity = base.OwnerEntity;
				string message = "buff额外效果修改弗洛洛特殊能量失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "handle";
				IActiveBuff buff = this.Buff;
				ptr = new ValueTuple<string, object>(item, (buff != null) ? new int?(buff.Handle) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", this.BuffId);
				instance.Error(flag, ownerEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		return null;
	}

	// Token: 0x060176E9 RID: 95977 RVA: 0x006E8A6C File Offset: 0x006E6C6C
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" 修改弗洛洛特殊能量 ");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", this.NumberParams));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C720 RID: 50976
	private int[] NumberParams = Array.Empty<int>();
}
