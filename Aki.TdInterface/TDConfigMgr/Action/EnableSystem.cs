using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017B5 RID: 6069
	public class EnableSystem : ActionParams
	{
		// Token: 0x06008363 RID: 33635 RVA: 0x0013A650 File Offset: 0x00138850
		private EnableSystem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableSystem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableSystem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableSystem_SetValue());
			}
			return result;
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x0013A688 File Offset: 0x00138888
		public static EnableSystem Create([Nullable(2)] EnableSystem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableSystem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008365 RID: 33637 RVA: 0x0013A69B File Offset: 0x0013889B
		public static EnableSystem CreateFromSetValue([Nullable(2)] EnableSystem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableSystem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x0013A6AE File Offset: 0x001388AE
		public EnableSystem_SetValue ToSetValue()
		{
			return new EnableSystem_SetValue
			{
				SystemType = this.SystemType,
				IsEnable = this.IsEnable
			};
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x06008367 RID: 33639 RVA: 0x0013A6CD File Offset: 0x001388CD
		// (set) Token: 0x06008368 RID: 33640 RVA: 0x0013A6F8 File Offset: 0x001388F8
		public virtual ESystem SystemType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SystemType;
				}
				if (this.PocoInterface == null)
				{
					return (ESystem)0;
				}
				return this.PocoInterface.SystemType;
			}
			set
			{
				this.GetOrCreatePoco().SystemType = value;
			}
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x06008369 RID: 33641 RVA: 0x0013A706 File Offset: 0x00138906
		// (set) Token: 0x0600836A RID: 33642 RVA: 0x0013A731 File Offset: 0x00138931
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x0400506B RID: 20587
		[Nullable(2)]
		protected new EnableSystem FbInstance;

		// Token: 0x0400506C RID: 20588
		[Nullable(2)]
		protected EnableSystem_SetValue PocoInterface;
	}
}
