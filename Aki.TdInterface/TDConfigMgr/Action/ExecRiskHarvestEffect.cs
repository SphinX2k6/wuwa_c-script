using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200188E RID: 6286
	public class ExecRiskHarvestEffect : ActionParams
	{
		// Token: 0x060083FD RID: 33789 RVA: 0x0013B6A0 File Offset: 0x001398A0
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

		// Token: 0x060083FE RID: 33790 RVA: 0x0013B6D8 File Offset: 0x001398D8
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

		// Token: 0x060083FF RID: 33791 RVA: 0x0013B6EB File Offset: 0x001398EB
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

		// Token: 0x06008400 RID: 33792 RVA: 0x0013B6FE File Offset: 0x001398FE
		public ExecRiskHarvestEffect_SetValue ToSetValue()
		{
			return new ExecRiskHarvestEffect_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x06008401 RID: 33793 RVA: 0x0013B711 File Offset: 0x00139911
		// (set) Token: 0x06008402 RID: 33794 RVA: 0x0013B73C File Offset: 0x0013993C
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

		// Token: 0x04005414 RID: 21524
		[Nullable(2)]
		protected new ExecRiskHarvestEffect FbInstance;

		// Token: 0x04005415 RID: 21525
		[Nullable(2)]
		protected ExecRiskHarvestEffect_SetValue PocoInterface;
	}
}
