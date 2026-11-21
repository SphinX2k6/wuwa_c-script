using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001316 RID: 4886
	public class ITrapDefenseSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E0F RID: 28175 RVA: 0x00105D90 File Offset: 0x00103F90
		private ITrapDefenseSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x00105DC8 File Offset: 0x00103FC8
		public static ITrapDefenseSystemConfig Create([Nullable(2)] ITrapDefenseSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x00105DDB File Offset: 0x00103FDB
		public static ITrapDefenseSystemConfig CreateFromSetValue([Nullable(2)] ITrapDefenseSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00105DEE File Offset: 0x00103FEE
		public new ITrapDefenseSystemConfig_SetValue ToSetValue()
		{
			return new ITrapDefenseSystemConfig_SetValue
			{
				Type = this.Type,
				TrapDefenseId = this.TrapDefenseId,
				Vars = this.Vars
			};
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x06006E13 RID: 28179 RVA: 0x00105E19 File Offset: 0x00104019
		// (set) Token: 0x06006E14 RID: 28180 RVA: 0x00105E44 File Offset: 0x00104044
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

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x06006E15 RID: 28181 RVA: 0x00105E52 File Offset: 0x00104052
		// (set) Token: 0x06006E16 RID: 28182 RVA: 0x00105E7D File Offset: 0x0010407D
		public virtual int TrapDefenseId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrapDefenseId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TrapDefenseId;
			}
			set
			{
				this.GetOrCreatePoco().TrapDefenseId = value;
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x06006E17 RID: 28183 RVA: 0x00105E8C File Offset: 0x0010408C
		// (set) Token: 0x06006E18 RID: 28184 RVA: 0x00105F1F File Offset: 0x0010411F
		public virtual List<ITrapDefenseSystemVar> Vars
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
					List<ITrapDefenseSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<ITrapDefenseSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(ITrapDefenseSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					ITrapDefenseSystemConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040041AE RID: 16814
		[Nullable(2)]
		protected new ITrapDefenseSystemConfig FbInstance;

		// Token: 0x040041AF RID: 16815
		[Nullable(2)]
		protected new ITrapDefenseSystemConfig_SetValue PocoInterface;

		// Token: 0x040041B0 RID: 16816
		private List<ITrapDefenseSystemVar> _VarsCache;

		// Token: 0x040041B1 RID: 16817
		private bool _VarsInited;
	}
}
