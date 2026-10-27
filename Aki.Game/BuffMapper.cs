using System;
using System.Runtime.CompilerServices;

// Token: 0x02002FA4 RID: 12196
[NullableContext(1)]
[Nullable(0)]
public class BuffMapper : PeriodExecution
{
	// Token: 0x06019DE5 RID: 105957 RVA: 0x006C2827 File Offset: 0x006C0A27
	public BuffMapper(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DE6 RID: 105958 RVA: 0x006C2830 File Offset: 0x006C0A30
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			this.CheckBuffIds = null;
			this.RemoveBuffIds = null;
			this.AddBuffIds = null;
			this.DefaultBuffId = null;
			return;
		}
		if (extraEffectParameters_.Length != 0 && !string.IsNullOrEmpty(extraEffectParameters_[0]))
		{
			string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
			this.CheckBuffIds = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.CheckBuffIds[i] = long.Parse(array[i]);
			}
		}
		else
		{
			this.CheckBuffIds = Array.Empty<long>();
		}
		if (extraEffectParameters_.Length > 1 && !string.IsNullOrEmpty(extraEffectParameters_[1]))
		{
			string[] array2 = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
			this.RemoveBuffIds = new long[array2.Length];
			for (int j = 0; j < array2.Length; j++)
			{
				this.RemoveBuffIds[j] = long.Parse(array2[j]);
			}
		}
		else
		{
			this.RemoveBuffIds = Array.Empty<long>();
		}
		if (extraEffectParameters_.Length > 2 && !string.IsNullOrEmpty(extraEffectParameters_[2]))
		{
			string[] array3 = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
			this.AddBuffIds = new long[array3.Length];
			for (int k = 0; k < array3.Length; k++)
			{
				this.AddBuffIds[k] = long.Parse(array3[k]);
			}
		}
		else
		{
			this.AddBuffIds = Array.Empty<long>();
		}
		this.DefaultBuffId = ((extraEffectParameters_.Length > 3 && !string.IsNullOrEmpty(extraEffectParameters_[3])) ? new long?(long.Parse(extraEffectParameters_[3])) : null);
	}

	// Token: 0x06019DE7 RID: 105959 RVA: 0x006C29A8 File Offset: 0x006C0BA8
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		if (this.OwnerBuffComponent == null)
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Buff, base.OwnerEntity, "buff:BuffMapper失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		long[] array = this.CheckBuffIds ?? Array.Empty<long>();
		long[] array2 = this.RemoveBuffIds ?? Array.Empty<long>();
		long[] array3 = this.AddBuffIds ?? Array.Empty<long>();
		bool flag = false;
		for (int i = 0; i < array.Length; i++)
		{
			long buffId = array[i];
			if (this.OwnerBuffComponent.HasBuff(buffId, false))
			{
				long num = (i < array2.Length) ? array2[i] : 0L;
				if (num > 0L)
				{
					IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
					long buffId2 = num;
					int stackCount = -1;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
					defaultInterpolatedStringHandler.AppendLiteral("BuffMapper");
					ownerBuffComponent.RemoveBuff(buffId2, stackCount, defaultInterpolatedStringHandler.ToStringAndClear(), null, null, null);
				}
				long num2 = (i < array3.Length) ? array3[i] : 0L;
				if (num2 > 0L)
				{
					IBuffComponent ownerBuffComponent2 = this.OwnerBuffComponent;
					long buffId3 = num2;
					IActiveBuff buff = this.Buff;
					int? stackCount2 = null;
					bool isIterable = true;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Buff");
					defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
					defaultInterpolatedStringHandler.AppendLiteral("的额外效果BuffMapper导致的添加");
					ownerBuffComponent2.AddIterativeBuff(buffId3, buff, stackCount2, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
				}
				flag = true;
				break;
			}
		}
		if (!flag && this.DefaultBuffId != null)
		{
			long? defaultBuffId = this.DefaultBuffId;
			long num3 = 0L;
			if (defaultBuffId.GetValueOrDefault() > num3 & defaultBuffId != null)
			{
				IBuffComponent ownerBuffComponent3 = this.OwnerBuffComponent;
				long value = this.DefaultBuffId.Value;
				IActiveBuff buff2 = this.Buff;
				int? stackCount3 = null;
				bool isIterable2 = true;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Buff");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral("的额外效果BuffMapper导致的添加");
				ownerBuffComponent3.AddIterativeBuff(value, buff2, stackCount3, isIterable2, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
			}
		}
		return null;
	}

	// Token: 0x06019DE8 RID: 105960 RVA: 0x006C2BCC File Offset: 0x006C0DCC
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 5);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" buff映射 检查buff");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<long>(",", this.CheckBuffIds ?? Array.Empty<long>()));
		defaultInterpolatedStringHandler.AppendLiteral(" 移除buff");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<long>(",", this.RemoveBuffIds ?? Array.Empty<long>()));
		defaultInterpolatedStringHandler.AppendLiteral(" 添加buff");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<long>(",", this.AddBuffIds ?? Array.Empty<long>()));
		defaultInterpolatedStringHandler.AppendLiteral(" 默认buff");
		defaultInterpolatedStringHandler.AppendFormatted<long?>(this.DefaultBuffId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C388 RID: 50056
	[Nullable(2)]
	private long[] CheckBuffIds;

	// Token: 0x0400C389 RID: 50057
	[Nullable(2)]
	private long[] RemoveBuffIds;

	// Token: 0x0400C38A RID: 50058
	[Nullable(2)]
	private long[] AddBuffIds;

	// Token: 0x0400C38B RID: 50059
	private long? DefaultBuffId;
}
