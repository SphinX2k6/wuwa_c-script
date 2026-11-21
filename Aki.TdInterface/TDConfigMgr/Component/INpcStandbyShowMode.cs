using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E9 RID: 1513
	public class INpcStandbyShowMode
	{
		// Token: 0x06001EEA RID: 7914 RVA: 0x00057300 File Offset: 0x00055500
		private INpcStandbyShowMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcStandbyShowMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcStandbyShowMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcStandbyShowMode_SetValue());
			}
			return result;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00057338 File Offset: 0x00055538
		public static INpcStandbyShowMode Create([Nullable(2)] INpcStandbyShowMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0005734B File Offset: 0x0005554B
		public static INpcStandbyShowMode CreateFromSetValue([Nullable(2)] INpcStandbyShowMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcStandbyShowMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0005735E File Offset: 0x0005555E
		public INpcStandbyShowMode_SetValue ToSetValue()
		{
			return new INpcStandbyShowMode_SetValue
			{
				Type = this.Type,
				LookAtConfigs = this.LookAtConfigs
			};
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x0005737D File Offset: 0x0005557D
		// (set) Token: 0x06001EEF RID: 7919 RVA: 0x000573A8 File Offset: 0x000555A8
		public virtual ENpcStandbyShowMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcStandbyShowMode.Finite;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x000573B8 File Offset: 0x000555B8
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x0005744B File Offset: 0x0005564B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.INpcLookAtConfig> lookAtConfigs = this.FbInstance.LookAtConfigs;
					if (lookAtConfigs != null)
					{
						this._LookAtConfigsCache = new List<Aki.TDConfigMgr.Action.INpcLookAtConfig>(lookAtConfigs.Count);
						for (int i = 0; i < lookAtConfigs.Count; i++)
						{
							this._LookAtConfigsCache.Add(Aki.TDConfigMgr.Action.INpcLookAtConfig.Create(lookAtConfigs[i]));
						}
					}
				}
				else
				{
					INpcStandbyShowMode_SetValue pocoInterface = this.PocoInterface;
					this._LookAtConfigsCache = ((pocoInterface != null) ? pocoInterface.LookAtConfigs : null);
				}
				return this._LookAtConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().LookAtConfigs = value;
				this._LookAtConfigsInited = false;
			}
		}

		// Token: 0x040015F9 RID: 5625
		[Nullable(2)]
		protected INpcStandbyShowMode FbInstance;

		// Token: 0x040015FA RID: 5626
		[Nullable(2)]
		protected INpcStandbyShowMode_SetValue PocoInterface;

		// Token: 0x040015FB RID: 5627
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040015FC RID: 5628
		private bool _LookAtConfigsInited;
	}
}
