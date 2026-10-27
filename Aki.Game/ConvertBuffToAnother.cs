using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F99 RID: 12185
[NullableContext(1)]
[Nullable(0)]
public class ConvertBuffToAnother : PeriodExecution
{
	// Token: 0x06019DC6 RID: 105926 RVA: 0x006C18C2 File Offset: 0x006BFAC2
	public ConvertBuffToAnother(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DC7 RID: 105927 RVA: 0x006C18D8 File Offset: 0x006BFAD8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			this.SourceBuffIds = Array.Empty<long>();
			this.TargetBuffId = 0L;
			this.SaveSourceBuff = false;
			return;
		}
		if (!string.IsNullOrEmpty(extraEffectParameters_[0]))
		{
			string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
			this.SourceBuffIds = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.SourceBuffIds[i] = long.Parse(array[i]);
			}
		}
		else
		{
			this.SourceBuffIds = Array.Empty<long>();
		}
		this.TargetBuffId = ((extraEffectParameters_.Length > 1 && !string.IsNullOrEmpty(extraEffectParameters_[1])) ? long.Parse(extraEffectParameters_[1]) : 0L);
		this.SaveSourceBuff = (extraEffectParameters_.Length > 2 && !string.IsNullOrEmpty(extraEffectParameters_[2]) && int.Parse(extraEffectParameters_[2]) == 1);
	}

	// Token: 0x06019DC8 RID: 105928 RVA: 0x006C19A4 File Offset: 0x006BFBA4
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return null;
		}
		int num = 0;
		for (int i = 0; i < this.SourceBuffIds.Length; i++)
		{
			num += ownerBuffComponent.GetBuffTotalStackById(this.SourceBuffIds[i], false);
		}
		if (!this.SaveSourceBuff)
		{
			for (int j = 0; j < this.SourceBuffIds.Length; j++)
			{
				ownerBuffComponent.RemoveBuff(this.SourceBuffIds[j], -1, "Buff转换效果", null, null, null);
			}
		}
		if (num == 0)
		{
			return null;
		}
		if (this.TargetBuffId > 0L)
		{
			ownerBuffComponent.AddIterativeBuff(this.TargetBuffId, this.Buff, new int?(num), true, "Buff转换效果", null, null);
		}
		return null;
	}

	// Token: 0x0400C36E RID: 50030
	private long[] SourceBuffIds = Array.Empty<long>();

	// Token: 0x0400C36F RID: 50031
	private long TargetBuffId;

	// Token: 0x0400C370 RID: 50032
	private bool SaveSourceBuff;
}
