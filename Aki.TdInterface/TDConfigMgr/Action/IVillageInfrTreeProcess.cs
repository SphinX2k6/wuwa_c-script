using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002296 RID: 8854
	public class IVillageInfrTreeProcess : IVillageInfrBuildOption
	{
		// Token: 0x0600C0D8 RID: 49368 RVA: 0x001BC310 File Offset: 0x001BA510
		private IVillageInfrTreeProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVillageInfrTreeProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVillageInfrTreeProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVillageInfrTreeProcess_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0D9 RID: 49369 RVA: 0x001BC348 File Offset: 0x001BA548
		public static IVillageInfrTreeProcess Create([Nullable(2)] IVillageInfrTreeProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrTreeProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0DA RID: 49370 RVA: 0x001BC35B File Offset: 0x001BA55B
		public static IVillageInfrTreeProcess CreateFromSetValue([Nullable(2)] IVillageInfrTreeProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVillageInfrTreeProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x001BC36E File Offset: 0x001BA56E
		public new IVillageInfrTreeProcess_SetValue ToSetValue()
		{
			return new IVillageInfrTreeProcess_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600C0DC RID: 49372 RVA: 0x001BC38D File Offset: 0x001BA58D
		// (set) Token: 0x0600C0DD RID: 49373 RVA: 0x001BC3B8 File Offset: 0x001BA5B8
		public override EVillageInfrBuildType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVillageInfrBuildType.Village;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600C0DE RID: 49374 RVA: 0x001BC3C6 File Offset: 0x001BA5C6
		// (set) Token: 0x0600C0DF RID: 49375 RVA: 0x001BC3F1 File Offset: 0x001BA5F1
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

		// Token: 0x04007350 RID: 29520
		[Nullable(2)]
		protected new IVillageInfrTreeProcess FbInstance;

		// Token: 0x04007351 RID: 29521
		[Nullable(2)]
		protected new IVillageInfrTreeProcess_SetValue PocoInterface;
	}
}
