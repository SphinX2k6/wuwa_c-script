using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001974 RID: 6516
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeadeyeEnergyConfig
	{
		// Token: 0x06008B95 RID: 35733 RVA: 0x00148164 File Offset: 0x00146364
		private IDeadeyeEnergyConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadeyeEnergyConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadeyeEnergyConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadeyeEnergyConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x0014819C File Offset: 0x0014639C
		public static IDeadeyeEnergyConfig Create([Nullable(2)] IDeadeyeEnergyConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeEnergyConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x001481AF File Offset: 0x001463AF
		public static IDeadeyeEnergyConfig CreateFromSetValue([Nullable(2)] IDeadeyeEnergyConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadeyeEnergyConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x001481C2 File Offset: 0x001463C2
		public IDeadeyeEnergyConfig_SetValue ToSetValue()
		{
			return new IDeadeyeEnergyConfig_SetValue
			{
				MaxEnergy = this.MaxEnergy,
				BulletConsumption = this.BulletConsumption,
				TimeConsumption = this.TimeConsumption
			};
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x06008B99 RID: 35737 RVA: 0x001481ED File Offset: 0x001463ED
		// (set) Token: 0x06008B9A RID: 35738 RVA: 0x00148218 File Offset: 0x00146418
		public virtual int MaxEnergy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxEnergy;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxEnergy;
			}
			set
			{
				this.GetOrCreatePoco().MaxEnergy = value;
			}
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x06008B9B RID: 35739 RVA: 0x00148226 File Offset: 0x00146426
		// (set) Token: 0x06008B9C RID: 35740 RVA: 0x00148251 File Offset: 0x00146451
		public virtual int BulletConsumption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletConsumption;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BulletConsumption;
			}
			set
			{
				this.GetOrCreatePoco().BulletConsumption = value;
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x06008B9D RID: 35741 RVA: 0x0014825F File Offset: 0x0014645F
		// (set) Token: 0x06008B9E RID: 35742 RVA: 0x0014828A File Offset: 0x0014648A
		public virtual int TimeConsumption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeConsumption;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TimeConsumption;
			}
			set
			{
				this.GetOrCreatePoco().TimeConsumption = value;
			}
		}

		// Token: 0x0400570C RID: 22284
		[Nullable(2)]
		protected IDeadeyeEnergyConfig FbInstance;

		// Token: 0x0400570D RID: 22285
		[Nullable(2)]
		protected IDeadeyeEnergyConfig_SetValue PocoInterface;
	}
}
