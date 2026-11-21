using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004775 RID: 18293
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRewardItemData
	{
		// Token: 0x17005C78 RID: 23672
		// (get) Token: 0x0602DEF1 RID: 188145 RVA: 0x00CDAD7B File Offset: 0x00CD8F7B
		// (set) Token: 0x0602DEF2 RID: 188146 RVA: 0x00CDAD83 File Offset: 0x00CD8F83
		public int Id { get; set; }

		// Token: 0x17005C79 RID: 23673
		// (get) Token: 0x0602DEF3 RID: 188147 RVA: 0x00CDAD8C File Offset: 0x00CD8F8C
		// (set) Token: 0x0602DEF4 RID: 188148 RVA: 0x00CDAD94 File Offset: 0x00CD8F94
		public int Current { get; set; }

		// Token: 0x17005C7A RID: 23674
		// (get) Token: 0x0602DEF5 RID: 188149 RVA: 0x00CDAD9D File Offset: 0x00CD8F9D
		// (set) Token: 0x0602DEF6 RID: 188150 RVA: 0x00CDADA5 File Offset: 0x00CD8FA5
		public int Target { get; set; }

		// Token: 0x17005C7B RID: 23675
		// (get) Token: 0x0602DEF7 RID: 188151 RVA: 0x00CDADAE File Offset: 0x00CD8FAE
		// (set) Token: 0x0602DEF8 RID: 188152 RVA: 0x00CDADB6 File Offset: 0x00CD8FB6
		public EKurotatoRewardStatus Status { get; set; }

		// Token: 0x17005C7C RID: 23676
		// (get) Token: 0x0602DEF9 RID: 188153 RVA: 0x00CDADBF File Offset: 0x00CD8FBF
		// (set) Token: 0x0602DEFA RID: 188154 RVA: 0x00CDADC7 File Offset: 0x00CD8FC7
		public KurotatoResAward? NormalConfig { get; set; }

		// Token: 0x17005C7D RID: 23677
		// (get) Token: 0x0602DEFB RID: 188155 RVA: 0x00CDADD0 File Offset: 0x00CD8FD0
		// (set) Token: 0x0602DEFC RID: 188156 RVA: 0x00CDADD8 File Offset: 0x00CD8FD8
		public KurotatoLimitAward? LimitConfig { get; set; }

		// Token: 0x0602DEFD RID: 188157 RVA: 0x00CDADE1 File Offset: 0x00CD8FE1
		public KurotatoRewardItemData(int id, int current, int target, int status)
		{
			this.Id = id;
			this.Current = current;
			this.Target = target;
			this.Status = (EKurotatoRewardStatus)status;
		}

		// Token: 0x0602DEFE RID: 188158 RVA: 0x00CDAE06 File Offset: 0x00CD9006
		public void Refresh(ConditionTask data)
		{
			this.Current = data.Current;
			this.Target = data.Target;
			this.Status = (EKurotatoRewardStatus)data.Status;
		}

		// Token: 0x0602DEFF RID: 188159 RVA: 0x00CDAE2C File Offset: 0x00CD902C
		public virtual string GetTitle()
		{
			if (this.NormalConfig != null)
			{
				return this.NormalConfig.Value.Desc;
			}
			return this.LimitConfig.Value.Desc;
		}

		// Token: 0x0602DF00 RID: 188160 RVA: 0x00CDAE78 File Offset: 0x00CD9078
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
