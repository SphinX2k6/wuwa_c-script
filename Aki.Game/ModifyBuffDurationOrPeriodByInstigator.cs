using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F4B RID: 12107
[NullableContext(1)]
[Nullable(0)]
public class ModifyBuffDurationOrPeriodByInstigator : BuffEffect
{
	// Token: 0x06019C5E RID: 105566 RVA: 0x006B82D4 File Offset: 0x006B64D4
	public ModifyBuffDurationOrPeriodByInstigator(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C5F RID: 105567 RVA: 0x006B82F0 File Offset: 0x006B64F0
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.DurationRate = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
		this.PeriodRate = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
			this.InvolvedBuffIds = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.InvolvedBuffIds[i] = long.Parse(array[i].Trim());
			}
		}
	}

	// Token: 0x06019C60 RID: 105568 RVA: 0x006B8380 File Offset: 0x006B6580
	public override void OnCreated()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent != null && (this.DurationRate != 0f || this.PeriodRate != 0f))
		{
			foreach (long targetBuffId in this.InvolvedBuffIds)
			{
				ownerBuffComponent.AddBuffTimeModifier(targetBuffId, this.ActiveHandleId, this.PeriodRate, this.DurationRate, true);
			}
		}
	}

	// Token: 0x06019C61 RID: 105569 RVA: 0x006B83E4 File Offset: 0x006B65E4
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C62 RID: 105570 RVA: 0x006B83E8 File Offset: 0x006B65E8
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent != null)
		{
			foreach (long targetBuffId in this.InvolvedBuffIds)
			{
				ownerBuffComponent.RemoveBuffTimeModifier(targetBuffId, this.ActiveHandleId, true);
			}
		}
	}

	// Token: 0x06019C63 RID: 105571 RVA: 0x006B8428 File Offset: 0x006B6628
	public override string GetDebugEffectString()
	{
		string str = "修改由该持有者施加的buff" + string.Join<long>(",", this.InvolvedBuffIds);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
		defaultInterpolatedStringHandler.AppendLiteral(" 持续时间");
		defaultInterpolatedStringHandler.AppendFormatted((this.DurationRate >= 0f) ? "+" : "");
		defaultInterpolatedStringHandler.AppendFormatted<double>((double)this.DurationRate * 0.01, "F1");
		defaultInterpolatedStringHandler.AppendLiteral("%");
		string str2 = str + defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
		defaultInterpolatedStringHandler.AppendLiteral(" 周期");
		defaultInterpolatedStringHandler.AppendFormatted((this.DurationRate >= 0f) ? "+" : "");
		defaultInterpolatedStringHandler.AppendFormatted<double>((double)this.PeriodRate * 0.01, "F1");
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return str2 + defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C245 RID: 49733
	protected long[] InvolvedBuffIds = Array.Empty<long>();

	// Token: 0x0400C246 RID: 49734
	protected float DurationRate;

	// Token: 0x0400C247 RID: 49735
	protected float PeriodRate;
}
