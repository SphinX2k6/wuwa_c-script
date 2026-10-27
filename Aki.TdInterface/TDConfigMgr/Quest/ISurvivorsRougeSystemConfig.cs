using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001162 RID: 4450
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006502 RID: 25858 RVA: 0x000F2798 File Offset: 0x000F0998
		private ISurvivorsRougeSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x000F27D0 File Offset: 0x000F09D0
		public static ISurvivorsRougeSystemConfig Create([Nullable(2)] ISurvivorsRougeSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x000F27E3 File Offset: 0x000F09E3
		public static ISurvivorsRougeSystemConfig CreateFromSetValue([Nullable(2)] ISurvivorsRougeSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x000F27F6 File Offset: 0x000F09F6
		public new ISurvivorsRougeSystemConfig_SetValue ToSetValue()
		{
			return new ISurvivorsRougeSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06006506 RID: 25862 RVA: 0x000F2815 File Offset: 0x000F0A15
		// (set) Token: 0x06006507 RID: 25863 RVA: 0x000F2840 File Offset: 0x000F0A40
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

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06006508 RID: 25864 RVA: 0x000F2850 File Offset: 0x000F0A50
		// (set) Token: 0x06006509 RID: 25865 RVA: 0x000F28E3 File Offset: 0x000F0AE3
		public virtual List<ISurvivorsRougeSystemVar> Vars
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
					List<ISurvivorsRougeSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<ISurvivorsRougeSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(ISurvivorsRougeSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					ISurvivorsRougeSystemConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003C9A RID: 15514
		[Nullable(2)]
		protected new ISurvivorsRougeSystemConfig FbInstance;

		// Token: 0x04003C9B RID: 15515
		[Nullable(2)]
		protected new ISurvivorsRougeSystemConfig_SetValue PocoInterface;

		// Token: 0x04003C9C RID: 15516
		private List<ISurvivorsRougeSystemVar> _VarsCache;

		// Token: 0x04003C9D RID: 15517
		private bool _VarsInited;
	}
}
