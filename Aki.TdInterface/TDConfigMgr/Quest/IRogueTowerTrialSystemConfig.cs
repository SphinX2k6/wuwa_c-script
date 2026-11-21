using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001228 RID: 4648
	public class IRogueTowerTrialSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006849 RID: 26697 RVA: 0x000F9F3C File Offset: 0x000F813C
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

		// Token: 0x0600684A RID: 26698 RVA: 0x000F9F74 File Offset: 0x000F8174
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

		// Token: 0x0600684B RID: 26699 RVA: 0x000F9F87 File Offset: 0x000F8187
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

		// Token: 0x0600684C RID: 26700 RVA: 0x000F9F9A File Offset: 0x000F819A
		public new IRogueTowerTrialSystemConfig_SetValue ToSetValue()
		{
			return new IRogueTowerTrialSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x0600684D RID: 26701 RVA: 0x000F9FB9 File Offset: 0x000F81B9
		// (set) Token: 0x0600684E RID: 26702 RVA: 0x000F9FE4 File Offset: 0x000F81E4
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

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x0600684F RID: 26703 RVA: 0x000F9FF4 File Offset: 0x000F81F4
		// (set) Token: 0x06006850 RID: 26704 RVA: 0x000FA087 File Offset: 0x000F8287
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

		// Token: 0x04003E5D RID: 15965
		[Nullable(2)]
		protected new IRogueTowerTrialSystemConfig FbInstance;

		// Token: 0x04003E5E RID: 15966
		[Nullable(2)]
		protected new IRogueTowerTrialSystemConfig_SetValue PocoInterface;

		// Token: 0x04003E5F RID: 15967
		private List<IRogueTowerTrialSystemVar> _VarsCache;

		// Token: 0x04003E60 RID: 15968
		private bool _VarsInited;
	}
}
