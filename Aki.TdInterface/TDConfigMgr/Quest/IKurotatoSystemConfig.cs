using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE9 RID: 4073
	[NullableContext(1)]
	[Nullable(0)]
	public class IKurotatoSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005AA4 RID: 23204 RVA: 0x000DC110 File Offset: 0x000DA310
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

		// Token: 0x06005AA5 RID: 23205 RVA: 0x000DC148 File Offset: 0x000DA348
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

		// Token: 0x06005AA6 RID: 23206 RVA: 0x000DC15B File Offset: 0x000DA35B
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

		// Token: 0x06005AA7 RID: 23207 RVA: 0x000DC16E File Offset: 0x000DA36E
		public new IKurotatoSystemConfig_SetValue ToSetValue()
		{
			return new IKurotatoSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x000DC18D File Offset: 0x000DA38D
		// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x000DC1B8 File Offset: 0x000DA3B8
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

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x000DC1C8 File Offset: 0x000DA3C8
		// (set) Token: 0x06005AAB RID: 23211 RVA: 0x000DC25B File Offset: 0x000DA45B
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

		// Token: 0x0400368F RID: 13967
		[Nullable(2)]
		protected new IKurotatoSystemConfig FbInstance;

		// Token: 0x04003690 RID: 13968
		[Nullable(2)]
		protected new IKurotatoSystemConfig_SetValue PocoInterface;

		// Token: 0x04003691 RID: 13969
		private List<IKurotatoSystemVar> _VarsCache;

		// Token: 0x04003692 RID: 13970
		private bool _VarsInited;
	}
}
