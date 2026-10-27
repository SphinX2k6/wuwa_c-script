using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001114 RID: 4372
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060062BA RID: 25274 RVA: 0x000ED848 File Offset: 0x000EBA48
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

		// Token: 0x060062BB RID: 25275 RVA: 0x000ED880 File Offset: 0x000EBA80
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

		// Token: 0x060062BC RID: 25276 RVA: 0x000ED893 File Offset: 0x000EBA93
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

		// Token: 0x060062BD RID: 25277 RVA: 0x000ED8A6 File Offset: 0x000EBAA6
		public new IRoleTowerSystemConfig_SetValue ToSetValue()
		{
			return new IRoleTowerSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x060062BE RID: 25278 RVA: 0x000ED8C5 File Offset: 0x000EBAC5
		// (set) Token: 0x060062BF RID: 25279 RVA: 0x000ED8F0 File Offset: 0x000EBAF0
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

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x060062C0 RID: 25280 RVA: 0x000ED900 File Offset: 0x000EBB00
		// (set) Token: 0x060062C1 RID: 25281 RVA: 0x000ED993 File Offset: 0x000EBB93
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

		// Token: 0x04003B3A RID: 15162
		[Nullable(2)]
		protected new IRoleTowerSystemConfig FbInstance;

		// Token: 0x04003B3B RID: 15163
		[Nullable(2)]
		protected new IRoleTowerSystemConfig_SetValue PocoInterface;

		// Token: 0x04003B3C RID: 15164
		private List<IRoleTowerSystemVar> _VarsCache;

		// Token: 0x04003B3D RID: 15165
		private bool _VarsInited;
	}
}
