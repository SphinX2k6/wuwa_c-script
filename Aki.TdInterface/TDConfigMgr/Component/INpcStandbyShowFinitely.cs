using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057A RID: 1402
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcStandbyShowFinitely : INpcStandbyShowMode
	{
		// Token: 0x06001CB2 RID: 7346 RVA: 0x00051C00 File Offset: 0x0004FE00
		private INpcStandbyShowFinitely_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcStandbyShowFinitely 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcStandbyShowFinitely_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcStandbyShowFinitely_SetValue());
			}
			return result;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00051C38 File Offset: 0x0004FE38
		public static INpcStandbyShowFinitely Create([Nullable(2)] INpcStandbyShowFinitely instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitely
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00051C4B File Offset: 0x0004FE4B
		public static INpcStandbyShowFinitely CreateFromSetValue([Nullable(2)] INpcStandbyShowFinitely_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitely
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00051C5E File Offset: 0x0004FE5E
		public new INpcStandbyShowFinitely_SetValue ToSetValue()
		{
			return new INpcStandbyShowFinitely_SetValue
			{
				Type = this.Type,
				LookAtConfigs = this.LookAtConfigs,
				PlayMode = this.PlayMode,
				Montages = this.Montages
			};
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00051C95 File Offset: 0x0004FE95
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x00051CC0 File Offset: 0x0004FEC0
		public override ENpcStandbyShowMode Type
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

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00051CD0 File Offset: 0x0004FED0
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00051D63 File Offset: 0x0004FF63
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.INpcLookAtConfig> LookAtConfigs
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
					INpcStandbyShowFinitely_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00051D78 File Offset: 0x0004FF78
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x00051DA3 File Offset: 0x0004FFA3
		public virtual ENpcStandbyShowFinitelyPlayMode PlayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayMode;
				}
				if (this.PocoInterface == null)
				{
					return ENpcStandbyShowFinitelyPlayMode.Randomly;
				}
				return this.PocoInterface.PlayMode;
			}
			set
			{
				this.GetOrCreatePoco().PlayMode = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00051DB4 File Offset: 0x0004FFB4
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x00051E47 File Offset: 0x00050047
		public virtual List<INpcStandbyShowFinitelyInfo> Montages
		{
			get
			{
				if (this._MontagesInited)
				{
					return this._MontagesCache;
				}
				this._MontagesInited = true;
				if (this.FbInstance != null)
				{
					List<INpcStandbyShowFinitelyInfo> montages = this.FbInstance.Montages;
					if (montages != null)
					{
						this._MontagesCache = new List<INpcStandbyShowFinitelyInfo>(montages.Count);
						for (int i = 0; i < montages.Count; i++)
						{
							this._MontagesCache.Add(INpcStandbyShowFinitelyInfo.Create(montages[i]));
						}
					}
				}
				else
				{
					INpcStandbyShowFinitely_SetValue pocoInterface = this.PocoInterface;
					this._MontagesCache = ((pocoInterface != null) ? pocoInterface.Montages : null);
				}
				return this._MontagesCache;
			}
			set
			{
				this.GetOrCreatePoco().Montages = value;
				this._MontagesInited = false;
			}
		}

		// Token: 0x04001467 RID: 5223
		[Nullable(2)]
		protected new INpcStandbyShowFinitely FbInstance;

		// Token: 0x04001468 RID: 5224
		[Nullable(2)]
		protected new INpcStandbyShowFinitely_SetValue PocoInterface;

		// Token: 0x04001469 RID: 5225
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x0400146A RID: 5226
		private bool _LookAtConfigsInited;

		// Token: 0x0400146B RID: 5227
		private List<INpcStandbyShowFinitelyInfo> _MontagesCache;

		// Token: 0x0400146C RID: 5228
		private bool _MontagesInited;
	}
}
