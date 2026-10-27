using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000885 RID: 2181
	[NullableContext(1)]
	[Nullable(0)]
	public class RotatorComponent2 : IComponentBase
	{
		// Token: 0x0600308D RID: 12429 RVA: 0x0007CDF4 File Offset: 0x0007AFF4
		private RotatorComponent2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RotatorComponent2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RotatorComponent2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RotatorComponent2_SetValue());
			}
			return result;
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x0007CE2C File Offset: 0x0007B02C
		public static RotatorComponent2 Create([Nullable(2)] RotatorComponent2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RotatorComponent2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x0007CE3F File Offset: 0x0007B03F
		public static RotatorComponent2 CreateFromSetValue([Nullable(2)] RotatorComponent2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RotatorComponent2
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x0007CE52 File Offset: 0x0007B052
		public new RotatorComponent2_SetValue ToSetValue()
		{
			return new RotatorComponent2_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x0007CE80 File Offset: 0x0007B080
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x0007CEBA File Offset: 0x0007B0BA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RotatorComponent2_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x0007CEC8 File Offset: 0x0007B0C8
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x0007CEF2 File Offset: 0x0007B0F2
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

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x0007CF00 File Offset: 0x0007B100
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x0007CF93 File Offset: 0x0007B193
		public virtual List<IStateRotationConfig> Config
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
					List<IStateRotationConfig> config = this.FbInstance.Config;
					if (config != null)
					{
						this._ConfigCache = new List<IStateRotationConfig>(config.Count);
						for (int i = 0; i < config.Count; i++)
						{
							this._ConfigCache.Add(IStateRotationConfig.Create(config[i]));
						}
					}
				}
				else
				{
					RotatorComponent2_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001FEE RID: 8174
		[Nullable(2)]
		protected new RotatorComponent2 FbInstance;

		// Token: 0x04001FEF RID: 8175
		[Nullable(2)]
		protected new RotatorComponent2_SetValue PocoInterface;

		// Token: 0x04001FF0 RID: 8176
		private List<IStateRotationConfig> _ConfigCache;

		// Token: 0x04001FF1 RID: 8177
		private bool _ConfigInited;
	}
}
