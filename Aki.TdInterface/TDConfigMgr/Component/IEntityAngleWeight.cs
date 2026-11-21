using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000350 RID: 848
	public class IEntityAngleWeight
	{
		// Token: 0x0600103D RID: 4157 RVA: 0x00038798 File Offset: 0x00036998
		private IEntityAngleWeight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityAngleWeight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityAngleWeight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityAngleWeight_SetValue());
			}
			return result;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000387D0 File Offset: 0x000369D0
		public static IEntityAngleWeight Create([Nullable(2)] IEntityAngleWeight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityAngleWeight
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000387E3 File Offset: 0x000369E3
		public static IEntityAngleWeight CreateFromSetValue([Nullable(2)] IEntityAngleWeight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityAngleWeight
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000387F6 File Offset: 0x000369F6
		public IEntityAngleWeight_SetValue ToSetValue()
		{
			return new IEntityAngleWeight_SetValue
			{
				Angle = this.Angle,
				Weight = this.Weight
			};
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00038815 File Offset: 0x00036A15
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x00038840 File Offset: 0x00036A40
		public virtual int Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0003884E File Offset: 0x00036A4E
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x00038879 File Offset: 0x00036A79
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x04000DFD RID: 3581
		[Nullable(2)]
		protected IEntityAngleWeight FbInstance;

		// Token: 0x04000DFE RID: 3582
		[Nullable(2)]
		protected IEntityAngleWeight_SetValue PocoInterface;
	}
}
