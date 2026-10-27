using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000189 RID: 393
	[NullableContext(1)]
	[Nullable(0)]
	public class GravityFlipComponent : IComponentBase
	{
		// Token: 0x0600058A RID: 1418 RVA: 0x00020B10 File Offset: 0x0001ED10
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

		// Token: 0x0600058B RID: 1419 RVA: 0x00020B48 File Offset: 0x0001ED48
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

		// Token: 0x0600058C RID: 1420 RVA: 0x00020B5B File Offset: 0x0001ED5B
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

		// Token: 0x0600058D RID: 1421 RVA: 0x00020B6E File Offset: 0x0001ED6E
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00020BA8 File Offset: 0x0001EDA8
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00020BE2 File Offset: 0x0001EDE2
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00020BF0 File Offset: 0x0001EDF0
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00020C1A File Offset: 0x0001EE1A
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00020C28 File Offset: 0x0001EE28
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00020CBB File Offset: 0x0001EEBB
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00020CD0 File Offset: 0x0001EED0
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00020CFB File Offset: 0x0001EEFB
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

		// Token: 0x04000779 RID: 1913
		[Nullable(2)]
		protected new GravityFlipComponent FbInstance;

		// Token: 0x0400077A RID: 1914
		[Nullable(2)]
		protected new GravityFlipComponent_SetValue PocoInterface;

		// Token: 0x0400077B RID: 1915
		private List<IGravityFlipConfig> _ConfigCache;

		// Token: 0x0400077C RID: 1916
		private bool _ConfigInited;
	}
}
