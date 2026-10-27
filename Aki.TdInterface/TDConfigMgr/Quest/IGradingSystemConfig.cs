using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FA5 RID: 4005
	[NullableContext(1)]
	[Nullable(0)]
	public class IGradingSystemConfig : IEnableSystemConfig
	{
		// Token: 0x0600593A RID: 22842 RVA: 0x000D97A4 File Offset: 0x000D79A4
		private IGradingSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGradingSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGradingSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGradingSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x000D97DC File Offset: 0x000D79DC
		public static IGradingSystemConfig Create([Nullable(2)] IGradingSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGradingSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x000D97EF File Offset: 0x000D79EF
		public static IGradingSystemConfig CreateFromSetValue([Nullable(2)] IGradingSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGradingSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x000D9802 File Offset: 0x000D7A02
		public new IGradingSystemConfig_SetValue ToSetValue()
		{
			return new IGradingSystemConfig_SetValue
			{
				Type = this.Type,
				GradingSystemId = this.GradingSystemId,
				Vars = this.Vars
			};
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x000D982D File Offset: 0x000D7A2D
		// (set) Token: 0x0600593F RID: 22847 RVA: 0x000D9858 File Offset: 0x000D7A58
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

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x000D9866 File Offset: 0x000D7A66
		// (set) Token: 0x06005941 RID: 22849 RVA: 0x000D9891 File Offset: 0x000D7A91
		public virtual int GradingSystemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GradingSystemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GradingSystemId;
			}
			set
			{
				this.GetOrCreatePoco().GradingSystemId = value;
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x000D98A0 File Offset: 0x000D7AA0
		// (set) Token: 0x06005943 RID: 22851 RVA: 0x000D9933 File Offset: 0x000D7B33
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IGradingSystemVar> Vars
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				if (this.FbInstance != null)
				{
					List<IGradingSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IGradingSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IGradingSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IGradingSystemConfig_SetValue pocoInterface = this.PocoInterface;
					this._VarsCache = ((pocoInterface != null) ? pocoInterface.Vars : null);
				}
				return this._VarsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Vars = value;
				this._VarsInited = false;
			}
		}

		// Token: 0x040035DE RID: 13790
		[Nullable(2)]
		protected new IGradingSystemConfig FbInstance;

		// Token: 0x040035DF RID: 13791
		[Nullable(2)]
		protected new IGradingSystemConfig_SetValue PocoInterface;

		// Token: 0x040035E0 RID: 13792
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IGradingSystemVar> _VarsCache;

		// Token: 0x040035E1 RID: 13793
		private bool _VarsInited;
	}
}
