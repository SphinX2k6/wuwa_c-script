using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001242 RID: 4674
	public class IRoleTowerSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060068B5 RID: 26805 RVA: 0x000FA9BC File Offset: 0x000F8BBC
		private IRoleTowerSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x000FA9F4 File Offset: 0x000F8BF4
		public static IRoleTowerSystemConfig Create([Nullable(2)] IRoleTowerSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x000FAA07 File Offset: 0x000F8C07
		public static IRoleTowerSystemConfig CreateFromSetValue([Nullable(2)] IRoleTowerSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x000FAA1A File Offset: 0x000F8C1A
		public new IRoleTowerSystemConfig_SetValue ToSetValue()
		{
			return new IRoleTowerSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x060068B9 RID: 26809 RVA: 0x000FAA39 File Offset: 0x000F8C39
		// (set) Token: 0x060068BA RID: 26810 RVA: 0x000FAA64 File Offset: 0x000F8C64
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x060068BB RID: 26811 RVA: 0x000FAA74 File Offset: 0x000F8C74
		// (set) Token: 0x060068BC RID: 26812 RVA: 0x000FAB07 File Offset: 0x000F8D07
		public virtual List<IRoleTowerSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				if (this.FbInstance != null)
				{
					List<IRoleTowerSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IRoleTowerSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IRoleTowerSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IRoleTowerSystemConfig_SetValue pocoInterface = this.PocoInterface;
					this._VarsCache = ((pocoInterface != null) ? pocoInterface.Vars : null);
				}
				return this._VarsCache;
			}
			set
			{
				this.GetOrCreatePoco().Vars = value;
				this._VarsInited = false;
			}
		}

		// Token: 0x04003E88 RID: 16008
		[Nullable(2)]
		protected new IRoleTowerSystemConfig FbInstance;

		// Token: 0x04003E89 RID: 16009
		[Nullable(2)]
		protected new IRoleTowerSystemConfig_SetValue PocoInterface;

		// Token: 0x04003E8A RID: 16010
		private List<IRoleTowerSystemVar> _VarsCache;

		// Token: 0x04003E8B RID: 16011
		private bool _VarsInited;
	}
}
