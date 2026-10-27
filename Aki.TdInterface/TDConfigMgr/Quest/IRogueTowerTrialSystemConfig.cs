using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010FA RID: 4346
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueTowerTrialSystemConfig : IEnableSystemConfig
	{
		// Token: 0x0600624E RID: 25166 RVA: 0x000ECDC8 File Offset: 0x000EAFC8
		private IRogueTowerTrialSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueTowerTrialSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueTowerTrialSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueTowerTrialSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x000ECE00 File Offset: 0x000EB000
		public static IRogueTowerTrialSystemConfig Create([Nullable(2)] IRogueTowerTrialSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueTowerTrialSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x000ECE13 File Offset: 0x000EB013
		public static IRogueTowerTrialSystemConfig CreateFromSetValue([Nullable(2)] IRogueTowerTrialSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueTowerTrialSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x000ECE26 File Offset: 0x000EB026
		public new IRogueTowerTrialSystemConfig_SetValue ToSetValue()
		{
			return new IRogueTowerTrialSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06006252 RID: 25170 RVA: 0x000ECE45 File Offset: 0x000EB045
		// (set) Token: 0x06006253 RID: 25171 RVA: 0x000ECE70 File Offset: 0x000EB070
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

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x000ECE80 File Offset: 0x000EB080
		// (set) Token: 0x06006255 RID: 25173 RVA: 0x000ECF13 File Offset: 0x000EB113
		public virtual List<IRogueTowerTrialSystemVar> Vars
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
					List<IRogueTowerTrialSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IRogueTowerTrialSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IRogueTowerTrialSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IRogueTowerTrialSystemConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003B0F RID: 15119
		[Nullable(2)]
		protected new IRogueTowerTrialSystemConfig FbInstance;

		// Token: 0x04003B10 RID: 15120
		[Nullable(2)]
		protected new IRogueTowerTrialSystemConfig_SetValue PocoInterface;

		// Token: 0x04003B11 RID: 15121
		private List<IRogueTowerTrialSystemVar> _VarsCache;

		// Token: 0x04003B12 RID: 15122
		private bool _VarsInited;
	}
}
