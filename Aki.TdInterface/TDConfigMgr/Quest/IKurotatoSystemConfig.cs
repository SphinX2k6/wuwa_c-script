using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001115 RID: 4373
	public class IKurotatoSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006084 RID: 24708 RVA: 0x000E8D50 File Offset: 0x000E6F50
		private IKurotatoSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x000E8D88 File Offset: 0x000E6F88
		public static IKurotatoSystemConfig Create([Nullable(2)] IKurotatoSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x000E8D9B File Offset: 0x000E6F9B
		public static IKurotatoSystemConfig CreateFromSetValue([Nullable(2)] IKurotatoSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x000E8DAE File Offset: 0x000E6FAE
		public new IKurotatoSystemConfig_SetValue ToSetValue()
		{
			return new IKurotatoSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06006088 RID: 24712 RVA: 0x000E8DCD File Offset: 0x000E6FCD
		// (set) Token: 0x06006089 RID: 24713 RVA: 0x000E8DF8 File Offset: 0x000E6FF8
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

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600608A RID: 24714 RVA: 0x000E8E08 File Offset: 0x000E7008
		// (set) Token: 0x0600608B RID: 24715 RVA: 0x000E8E9B File Offset: 0x000E709B
		public virtual List<IKurotatoSystemVar> Vars
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
					List<IKurotatoSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IKurotatoSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IKurotatoSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IKurotatoSystemConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040039C7 RID: 14791
		[Nullable(2)]
		protected new IKurotatoSystemConfig FbInstance;

		// Token: 0x040039C8 RID: 14792
		[Nullable(2)]
		protected new IKurotatoSystemConfig_SetValue PocoInterface;

		// Token: 0x040039C9 RID: 14793
		private List<IKurotatoSystemVar> _VarsCache;

		// Token: 0x040039CA RID: 14794
		private bool _VarsInited;
	}
}
