using System;
using System.Runtime.CompilerServices;

// Token: 0x020024ED RID: 9453
[NullableContext(1)]
[Nullable(0)]
public class ConvertBuffToAnother : PeriodExecution
{
	// Token: 0x060176D8 RID: 95960 RVA: 0x006E818A File Offset: 0x006E638A
	public ConvertBuffToAnother(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176D9 RID: 95961 RVA: 0x006E81A0 File Offset: 0x006E63A0
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

	// Token: 0x060176DA RID: 95962 RVA: 0x006E826C File Offset: 0x006E646C
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

	// Token: 0x0400C717 RID: 50967
	private long[] SourceBuffIds = Array.Empty<long>();

	// Token: 0x0400C718 RID: 50968
	private long TargetBuffId;

	// Token: 0x0400C719 RID: 50969
	private bool SaveSourceBuff;
}
