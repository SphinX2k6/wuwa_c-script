using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001711 RID: 5905
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecRiskHarvestEffect : ActionParams
	{
		// Token: 0x06007D1F RID: 32031 RVA: 0x0012C5F4 File Offset: 0x0012A7F4
		private ExecRiskHarvestEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExecRiskHarvestEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExecRiskHarvestEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExecRiskHarvestEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x0012C62C File Offset: 0x0012A82C
		public static ExecRiskHarvestEffect Create([Nullable(2)] ExecRiskHarvestEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecRiskHarvestEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x0012C63F File Offset: 0x0012A83F
		public static ExecRiskHarvestEffect CreateFromSetValue([Nullable(2)] ExecRiskHarvestEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExecRiskHarvestEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x0012C652 File Offset: 0x0012A852
		public ExecRiskHarvestEffect_SetValue ToSetValue()
		{
			return new ExecRiskHarvestEffect_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x06007D23 RID: 32035 RVA: 0x0012C665 File Offset: 0x0012A865
		// (set) Token: 0x06007D24 RID: 32036 RVA: 0x0012C690 File Offset: 0x0012A890
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04004FE5 RID: 20453
		[Nullable(2)]
		protected new ExecRiskHarvestEffect FbInstance;

		// Token: 0x04004FE6 RID: 20454
		[Nullable(2)]
		protected ExecRiskHarvestEffect_SetValue PocoInterface;
	}
}
