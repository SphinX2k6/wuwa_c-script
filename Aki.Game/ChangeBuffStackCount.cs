using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F9C RID: 12188
[NullableContext(1)]
[Nullable(0)]
public class ChangeBuffStackCount : PeriodExecution
{
	// Token: 0x06019DD0 RID: 105936 RVA: 0x006C1CE0 File Offset: 0x006BFEE0
	public ChangeBuffStackCount(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DD1 RID: 105937 RVA: 0x006C1D18 File Offset: 0x006BFF18
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			this.BuffIds = Array.Empty<long>();
			this.StackChange = Array.Empty<int>();
			this.StackDurationRefreshPolicy = Array.Empty<EBuffStackDurationOverride>();
			this.StackPeriodResetPolicy = Array.Empty<EBuffStackPeriodResetOverride>();
			return;
		}
		if (extraEffectParameters_.Length != 0 && !string.IsNullOrEmpty(extraEffectParameters_[0]))
		{
			string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
			this.BuffIds = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.BuffIds[i] = long.Parse(array[i]);
			}
		}
		else
		{
			this.BuffIds = Array.Empty<long>();
		}
		if (extraEffectParameters_.Length > 1 && !string.IsNullOrEmpty(extraEffectParameters_[1]))
		{
			string[] array2 = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
			this.StackChange = new int[array2.Length];
			for (int j = 0; j < array2.Length; j++)
			{
				this.StackChange[j] = int.Parse(array2[j]);
			}
		}
		else
		{
			this.StackChange = Array.Empty<int>();
		}
		if (extraEffectParameters_.Length > 2 && !string.IsNullOrEmpty(extraEffectParameters_[2]))
		{
			string[] array3 = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
			this.StackDurationRefreshPolicy = new EBuffStackDurationOverride[array3.Length];
			for (int k = 0; k < array3.Length; k++)
			{
				this.StackDurationRefreshPolicy[k] = (EBuffStackDurationOverride)int.Parse(array3[k]);
			}
		}
		else
		{
			this.StackDurationRefreshPolicy = Array.Empty<EBuffStackDurationOverride>();
		}
		if (extraEffectParameters_.Length > 3 && !string.IsNullOrEmpty(extraEffectParameters_[3]))
		{
			string[] array4 = extraEffectParameters_[3].Split('#', StringSplitOptions.None);
			this.StackPeriodResetPolicy = new EBuffStackPeriodResetOverride[array4.Length];
			for (int l = 0; l < array4.Length; l++)
			{
				this.StackPeriodResetPolicy[l] = (EBuffStackPeriodResetOverride)int.Parse(array4[l]);
			}
			return;
		}
		this.StackPeriodResetPolicy = Array.Empty<EBuffStackPeriodResetOverride>();
	}

	// Token: 0x06019DD2 RID: 105938 RVA: 0x006C1EC8 File Offset: 0x006C00C8
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		for (int i = 0; i < this.BuffIds.Length; i++)
		{
			int num = (i < this.StackChange.Length) ? this.StackChange[i] : 0;
			EBuffStackDurationOverride ebuffStackDurationOverride = (i < this.StackDurationRefreshPolicy.Length) ? this.StackDurationRefreshPolicy[i] : EBuffStackDurationOverride.Default;
			EBuffStackPeriodResetOverride ebuffStackPeriodResetOverride = (i < this.StackPeriodResetPolicy.Length) ? this.StackPeriodResetPolicy[i] : EBuffStackPeriodResetOverride.Default;
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null)
			{
				long buffId = this.BuffIds[i];
				EBuffStackDurationOverride stackDurationRefreshPolicy = ebuffStackDurationOverride;
				EBuffStackPeriodResetOverride stackPeriodResetPolicy = ebuffStackPeriodResetOverride;
				int stackChange = num;
				string reason = "buff 79号额外效果";
				IActiveBuff buff = this.Buff;
				ownerBuffComponent.ChangeBuffStack(buffId, stackDurationRefreshPolicy, stackPeriodResetPolicy, stackChange, reason, (buff != null) ? buff.InstigatorId : null);
			}
		}
		return null;
	}

	// Token: 0x06019DD3 RID: 105939 RVA: 0x006C1F70 File Offset: 0x006C0170
	public override string GetDebugEffectString()
	{
		List<string> list = new List<string>();
		for (int i = 0; i < this.BuffIds.Length; i++)
		{
			int value = (i < this.StackChange.Length) ? this.StackChange[i] : 0;
			EBuffStackDurationOverride ebuffStackDurationOverride = (i < this.StackDurationRefreshPolicy.Length) ? this.StackDurationRefreshPolicy[i] : EBuffStackDurationOverride.Default;
			EBuffStackPeriodResetOverride ebuffStackPeriodResetOverride = (i < this.StackPeriodResetPolicy.Length) ? this.StackPeriodResetPolicy[i] : EBuffStackPeriodResetOverride.Default;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 4);
			defaultInterpolatedStringHandler.AppendLiteral("buff");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffIds[i]);
			defaultInterpolatedStringHandler.AppendLiteral(" 层数更改");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral(" 持续时间是否刷新:");
			defaultInterpolatedStringHandler.AppendFormatted((ebuffStackDurationOverride != EBuffStackDurationOverride.Default) ? "不刷新" : "读取buff配置");
			defaultInterpolatedStringHandler.AppendLiteral(" 周期是否刷新: ");
			defaultInterpolatedStringHandler.AppendFormatted((ebuffStackPeriodResetOverride != EBuffStackPeriodResetOverride.Default) ? "不刷新" : "读取buff配置");
			string item = defaultInterpolatedStringHandler.ToStringAndClear();
			list.Add(item);
		}
		return string.Join("\n", list);
	}

	// Token: 0x0400C373 RID: 50035
	protected long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C374 RID: 50036
	protected int[] StackChange = Array.Empty<int>();

	// Token: 0x0400C375 RID: 50037
	protected EBuffStackDurationOverride[] StackDurationRefreshPolicy = Array.Empty<EBuffStackDurationOverride>();

	// Token: 0x0400C376 RID: 50038
	protected EBuffStackPeriodResetOverride[] StackPeriodResetPolicy = Array.Empty<EBuffStackPeriodResetOverride>();
}
