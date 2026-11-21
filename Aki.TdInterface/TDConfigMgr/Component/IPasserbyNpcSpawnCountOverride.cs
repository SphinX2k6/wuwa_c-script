using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200065D RID: 1629
	public class IPasserbyNpcSpawnCountOverride
	{
		// Token: 0x06002236 RID: 8758 RVA: 0x0005E938 File Offset: 0x0005CB38
		private IPasserbyNpcSpawnCountOverride_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSpawnCountOverride 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSpawnCountOverride_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSpawnCountOverride_SetValue());
			}
			return result;
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0005E970 File Offset: 0x0005CB70
		public static IPasserbyNpcSpawnCountOverride Create([Nullable(2)] IPasserbyNpcSpawnCountOverride instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCountOverride
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0005E983 File Offset: 0x0005CB83
		public static IPasserbyNpcSpawnCountOverride CreateFromSetValue([Nullable(2)] IPasserbyNpcSpawnCountOverride_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCountOverride
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0005E996 File Offset: 0x0005CB96
		public IPasserbyNpcSpawnCountOverride_SetValue ToSetValue()
		{
			return new IPasserbyNpcSpawnCountOverride_SetValue
			{
				PcSpawnCount = this.PcSpawnCount,
				MobileSpawnCount = this.MobileSpawnCount
			};
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0005E9B8 File Offset: 0x0005CBB8
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x0005E9F2 File Offset: 0x0005CBF2
		public virtual int? PcSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PcSpawnCount;
				}
				IPasserbyNpcSpawnCountOverride_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PcSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().PcSpawnCount = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0005EA00 File Offset: 0x0005CC00
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0005EA3A File Offset: 0x0005CC3A
		public virtual int? MobileSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MobileSpawnCount;
				}
				IPasserbyNpcSpawnCountOverride_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MobileSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().MobileSpawnCount = value;
			}
		}

		// Token: 0x0400180B RID: 6155
		[Nullable(2)]
		protected IPasserbyNpcSpawnCountOverride FbInstance;

		// Token: 0x0400180C RID: 6156
		[Nullable(2)]
		protected IPasserbyNpcSpawnCountOverride_SetValue PocoInterface;
	}
}
