using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000580 RID: 1408
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcStandbyShowMode
	{
		// Token: 0x06001CE4 RID: 7396 RVA: 0x00052444 File Offset: 0x00050644
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

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0005247C File Offset: 0x0005067C
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

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0005248F File Offset: 0x0005068F
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

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000524A2 File Offset: 0x000506A2
		public INpcStandbyShowMode_SetValue ToSetValue()
		{
			return new INpcStandbyShowMode_SetValue
			{
				Type = this.Type,
				LookAtConfigs = this.LookAtConfigs
			};
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x000524C1 File Offset: 0x000506C1
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x000524EC File Offset: 0x000506EC
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

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000524FC File Offset: 0x000506FC
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0005258F File Offset: 0x0005078F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().LookAtConfigs = value;
				this._LookAtConfigsInited = false;
			}
		}

		// Token: 0x0400148B RID: 5259
		[Nullable(2)]
		protected INpcStandbyShowMode FbInstance;

		// Token: 0x0400148C RID: 5260
		[Nullable(2)]
		protected INpcStandbyShowMode_SetValue PocoInterface;

		// Token: 0x0400148D RID: 5261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x0400148E RID: 5262
		private bool _LookAtConfigsInited;
	}
}
