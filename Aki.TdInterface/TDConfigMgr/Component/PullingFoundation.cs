using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000861 RID: 2145
	[NullableContext(1)]
	[Nullable(0)]
	public class PullingFoundation : IComponentBase
	{
		// Token: 0x06002F6D RID: 12141 RVA: 0x0007A638 File Offset: 0x00078838
		private PullingFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PullingFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PullingFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PullingFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x0007A670 File Offset: 0x00078870
		public static PullingFoundation Create([Nullable(2)] PullingFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PullingFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x0007A683 File Offset: 0x00078883
		public static PullingFoundation CreateFromSetValue([Nullable(2)] PullingFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PullingFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x0007A696 File Offset: 0x00078896
		public new PullingFoundation_SetValue ToSetValue()
		{
			return new PullingFoundation_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x0007A6C4 File Offset: 0x000788C4
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x0007A6FE File Offset: 0x000788FE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				PullingFoundation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x0007A70C File Offset: 0x0007890C
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x0007A736 File Offset: 0x00078936
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x0007A744 File Offset: 0x00078944
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x0007A7A5 File Offset: 0x000789A5
		public virtual IPullingCategoryMatchingFoundation Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IPullingCategoryMatchingFoundation.Create(this.FbInstance.Config);
				}
				else
				{
					PullingFoundation_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x04001F4A RID: 8010
		[Nullable(2)]
		protected new PullingFoundation FbInstance;

		// Token: 0x04001F4B RID: 8011
		[Nullable(2)]
		protected new PullingFoundation_SetValue PocoInterface;

		// Token: 0x04001F4C RID: 8012
		private IPullingCategoryMatchingFoundation _ConfigCache;

		// Token: 0x04001F4D RID: 8013
		private bool _ConfigInited;
	}
}
