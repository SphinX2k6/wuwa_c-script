using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A0 RID: 416
	public class GravityFlipComponent : IComponentBase
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x000216EC File Offset: 0x0001F8EC
		private GravityFlipComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GravityFlipComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GravityFlipComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GravityFlipComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00021724 File Offset: 0x0001F924
		public static GravityFlipComponent Create([Nullable(2)] GravityFlipComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GravityFlipComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00021737 File Offset: 0x0001F937
		public static GravityFlipComponent CreateFromSetValue([Nullable(2)] GravityFlipComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GravityFlipComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0002174A File Offset: 0x0001F94A
		public new GravityFlipComponent_SetValue ToSetValue()
		{
			return new GravityFlipComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config,
				DefaultGravity = this.DefaultGravity
			};
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00021784 File Offset: 0x0001F984
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x000217BE File Offset: 0x0001F9BE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				GravityFlipComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x000217CC File Offset: 0x0001F9CC
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x000217F6 File Offset: 0x0001F9F6
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

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00021804 File Offset: 0x0001FA04
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00021897 File Offset: 0x0001FA97
		public virtual List<IGravityFlipConfig> Config
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
					List<IGravityFlipConfig> config = this.FbInstance.Config;
					if (config != null)
					{
						this._ConfigCache = new List<IGravityFlipConfig>(config.Count);
						for (int i = 0; i < config.Count; i++)
						{
							this._ConfigCache.Add(IGravityFlipConfig.Create(config[i]));
						}
					}
				}
				else
				{
					GravityFlipComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000218AC File Offset: 0x0001FAAC
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x000218D7 File Offset: 0x0001FAD7
		public virtual EGravityFlipType DefaultGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultGravity;
				}
				if (this.PocoInterface == null)
				{
					return (EGravityFlipType)0;
				}
				return this.PocoInterface.DefaultGravity;
			}
			set
			{
				this.GetOrCreatePoco().DefaultGravity = value;
			}
		}

		// Token: 0x040007CF RID: 1999
		[Nullable(2)]
		protected new GravityFlipComponent FbInstance;

		// Token: 0x040007D0 RID: 2000
		[Nullable(2)]
		protected new GravityFlipComponent_SetValue PocoInterface;

		// Token: 0x040007D1 RID: 2001
		private List<IGravityFlipConfig> _ConfigCache;

		// Token: 0x040007D2 RID: 2002
		private bool _ConfigInited;
	}
}
