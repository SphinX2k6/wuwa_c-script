using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C3 RID: 963
	public class IFanStateEffect
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x0003E814 File Offset: 0x0003CA14
		private IFanStateEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFanStateEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFanStateEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFanStateEffect_SetValue());
			}
			return result;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0003E84C File Offset: 0x0003CA4C
		public static IFanStateEffect Create([Nullable(2)] IFanStateEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanStateEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0003E85F File Offset: 0x0003CA5F
		public static IFanStateEffect CreateFromSetValue([Nullable(2)] IFanStateEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFanStateEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0003E872 File Offset: 0x0003CA72
		public IFanStateEffect_SetValue ToSetValue()
		{
			return new IFanStateEffect_SetValue
			{
				EntityState = this.EntityState,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x0003E891 File Offset: 0x0003CA91
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x0003E8BC File Offset: 0x0003CABC
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0003E8CC File Offset: 0x0003CACC
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x0003E92D File Offset: 0x0003CB2D
		public virtual IFanEffectConfig EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EffectConfigCache = IFanEffectConfig.Create(this.FbInstance.EffectConfig);
				}
				else
				{
					IFanStateEffect_SetValue pocoInterface = this.PocoInterface;
					this._EffectConfigCache = ((pocoInterface != null) ? pocoInterface.EffectConfig : null);
				}
				return this._EffectConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectConfig = value;
				this._EffectConfigInited = false;
			}
		}

		// Token: 0x04000F66 RID: 3942
		[Nullable(2)]
		protected IFanStateEffect FbInstance;

		// Token: 0x04000F67 RID: 3943
		[Nullable(2)]
		protected IFanStateEffect_SetValue PocoInterface;

		// Token: 0x04000F68 RID: 3944
		private IFanEffectConfig _EffectConfigCache;

		// Token: 0x04000F69 RID: 3945
		private bool _EffectConfigInited;
	}
}
