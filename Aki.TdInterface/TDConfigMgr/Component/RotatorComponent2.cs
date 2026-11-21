using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000928 RID: 2344
	public class RotatorComponent2 : IComponentBase
	{
		// Token: 0x060033C9 RID: 13257 RVA: 0x000842DC File Offset: 0x000824DC
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

		// Token: 0x060033CA RID: 13258 RVA: 0x00084314 File Offset: 0x00082514
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

		// Token: 0x060033CB RID: 13259 RVA: 0x00084327 File Offset: 0x00082527
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

		// Token: 0x060033CC RID: 13260 RVA: 0x0008433A File Offset: 0x0008253A
		public new RotatorComponent2_SetValue ToSetValue()
		{
			return new RotatorComponent2_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x00084368 File Offset: 0x00082568
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x000843A2 File Offset: 0x000825A2
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

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x000843B0 File Offset: 0x000825B0
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x000843DA File Offset: 0x000825DA
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

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x000843E8 File Offset: 0x000825E8
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x0008447B File Offset: 0x0008267B
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

		// Token: 0x04002200 RID: 8704
		[Nullable(2)]
		protected new RotatorComponent2 FbInstance;

		// Token: 0x04002201 RID: 8705
		[Nullable(2)]
		protected new RotatorComponent2_SetValue PocoInterface;

		// Token: 0x04002202 RID: 8706
		private List<IStateRotationConfig> _ConfigCache;

		// Token: 0x04002203 RID: 8707
		private bool _ConfigInited;
	}
}
