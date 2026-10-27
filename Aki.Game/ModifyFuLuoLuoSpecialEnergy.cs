using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F9D RID: 12189
[NullableContext(1)]
[Nullable(0)]
public class ModifyFuLuoLuoSpecialEnergy : PeriodExecution
{
	// Token: 0x06019DD4 RID: 105940 RVA: 0x006C207C File Offset: 0x006C027C
	public ModifyFuLuoLuoSpecialEnergy(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DD5 RID: 105941 RVA: 0x006C2090 File Offset: 0x006C0290
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

	// Token: 0x06019DD6 RID: 105942 RVA: 0x006C20E0 File Offset: 0x006C02E0
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

	// Token: 0x06019DD7 RID: 105943 RVA: 0x006C21A4 File Offset: 0x006C03A4
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" 修改弗洛洛特殊能量 ");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", this.NumberParams));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C377 RID: 50039
	private int[] NumberParams = Array.Empty<int>();
}
