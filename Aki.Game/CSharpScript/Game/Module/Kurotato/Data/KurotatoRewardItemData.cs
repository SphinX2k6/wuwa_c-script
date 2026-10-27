using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200579E RID: 22430
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRewardItemData
	{
		// Token: 0x170088B0 RID: 34992
		// (get) Token: 0x06038FE1 RID: 233441 RVA: 0x00D8BFFF File Offset: 0x00D8A1FF
		// (set) Token: 0x06038FE2 RID: 233442 RVA: 0x00D8C007 File Offset: 0x00D8A207
		public int Id { get; set; }

		// Token: 0x170088B1 RID: 34993
		// (get) Token: 0x06038FE3 RID: 233443 RVA: 0x00D8C010 File Offset: 0x00D8A210
		// (set) Token: 0x06038FE4 RID: 233444 RVA: 0x00D8C018 File Offset: 0x00D8A218
		public int Current { get; set; }

		// Token: 0x170088B2 RID: 34994
		// (get) Token: 0x06038FE5 RID: 233445 RVA: 0x00D8C021 File Offset: 0x00D8A221
		// (set) Token: 0x06038FE6 RID: 233446 RVA: 0x00D8C029 File Offset: 0x00D8A229
		public int Target { get; set; }

		// Token: 0x170088B3 RID: 34995
		// (get) Token: 0x06038FE7 RID: 233447 RVA: 0x00D8C032 File Offset: 0x00D8A232
		// (set) Token: 0x06038FE8 RID: 233448 RVA: 0x00D8C03A File Offset: 0x00D8A23A
		public EKurotatoRewardStatus Status { get; set; }

		// Token: 0x170088B4 RID: 34996
		// (get) Token: 0x06038FE9 RID: 233449 RVA: 0x00D8C043 File Offset: 0x00D8A243
		// (set) Token: 0x06038FEA RID: 233450 RVA: 0x00D8C04B File Offset: 0x00D8A24B
		public KurotatoResAward? NormalConfig { get; set; }

		// Token: 0x170088B5 RID: 34997
		// (get) Token: 0x06038FEB RID: 233451 RVA: 0x00D8C054 File Offset: 0x00D8A254
		// (set) Token: 0x06038FEC RID: 233452 RVA: 0x00D8C05C File Offset: 0x00D8A25C
		public KurotatoLimitAward? LimitConfig { get; set; }

		// Token: 0x06038FED RID: 233453 RVA: 0x00D8C065 File Offset: 0x00D8A265
		public KurotatoRewardItemData(int id, int current, int target, int status)
		{
			this.Id = id;
			this.Current = current;
			this.Target = target;
			this.Status = (EKurotatoRewardStatus)status;
		}

		// Token: 0x06038FEE RID: 233454 RVA: 0x00D8C08A File Offset: 0x00D8A28A
		public void Refresh(ConditionTask data)
		{
			this.Current = data.Current;
			this.Target = data.Target;
			this.Status = (EKurotatoRewardStatus)data.Status;
		}

		// Token: 0x06038FEF RID: 233455 RVA: 0x00D8C0B0 File Offset: 0x00D8A2B0
		public virtual string GetTitle()
		{
			if (this.NormalConfig != null)
			{
				return this.NormalConfig.Value.Desc;
			}
			return this.LimitConfig.Value.Desc;
		}

		// Token: 0x06038FF0 RID: 233456 RVA: 0x00D8C0FC File Offset: 0x00D8A2FC
		public virtual int GetDropId()
		{
			if (this.NormalConfig != null)
			{
				return this.NormalConfig.Value.DropId;
			}
			return this.LimitConfig.Value.DropId;
		}
	}
}
