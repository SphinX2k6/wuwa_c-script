using System;
using System.Runtime.CompilerServices;

// Token: 0x0200249E RID: 9374
[NullableContext(1)]
[Nullable(0)]
public class ModifyBuffDurationOrPeriodByInstigator : BuffEffect
{
	// Token: 0x06017569 RID: 95593 RVA: 0x006DE5F0 File Offset: 0x006DC7F0
	public ModifyBuffDurationOrPeriodByInstigator(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601756A RID: 95594 RVA: 0x006DE60C File Offset: 0x006DC80C
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

	// Token: 0x0601756B RID: 95595 RVA: 0x006DE69C File Offset: 0x006DC89C
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

	// Token: 0x0601756C RID: 95596 RVA: 0x006DE700 File Offset: 0x006DC900
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x0601756D RID: 95597 RVA: 0x006DE704 File Offset: 0x006DC904
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

	// Token: 0x0601756E RID: 95598 RVA: 0x006DE744 File Offset: 0x006DC944
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

	// Token: 0x0400C5E7 RID: 50663
	protected long[] InvolvedBuffIds = Array.Empty<long>();

	// Token: 0x0400C5E8 RID: 50664
	protected float DurationRate;

	// Token: 0x0400C5E9 RID: 50665
	protected float PeriodRate;
}
