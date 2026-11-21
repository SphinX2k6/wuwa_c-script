using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E3 RID: 1507
	public class INpcStandbyShowFinitely : INpcStandbyShowMode
	{
		// Token: 0x06001EB8 RID: 7864 RVA: 0x00056ABC File Offset: 0x00054CBC
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

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00056AF4 File Offset: 0x00054CF4
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

		// Token: 0x06001EBA RID: 7866 RVA: 0x00056B07 File Offset: 0x00054D07
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

		// Token: 0x06001EBB RID: 7867 RVA: 0x00056B1A File Offset: 0x00054D1A
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00056B51 File Offset: 0x00054D51
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00056B7C File Offset: 0x00054D7C
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00056B8C File Offset: 0x00054D8C
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00056C1F File Offset: 0x00054E1F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.INpcLookAtConfig> LookAtConfigs
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
					INpcStandbyShowFinitely_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00056C34 File Offset: 0x00054E34
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x00056C5F File Offset: 0x00054E5F
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00056C70 File Offset: 0x00054E70
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x00056D03 File Offset: 0x00054F03
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

		// Token: 0x040015D5 RID: 5589
		[Nullable(2)]
		protected new INpcStandbyShowFinitely FbInstance;

		// Token: 0x040015D6 RID: 5590
		[Nullable(2)]
		protected new INpcStandbyShowFinitely_SetValue PocoInterface;

		// Token: 0x040015D7 RID: 5591
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040015D8 RID: 5592
		private bool _LookAtConfigsInited;

		// Token: 0x040015D9 RID: 5593
		private List<INpcStandbyShowFinitelyInfo> _MontagesCache;

		// Token: 0x040015DA RID: 5594
		private bool _MontagesInited;
	}
}
