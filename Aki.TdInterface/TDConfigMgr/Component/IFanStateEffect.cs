using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037A RID: 890
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanStateEffect
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x0003B530 File Offset: 0x00039730
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

		// Token: 0x060011AC RID: 4524 RVA: 0x0003B568 File Offset: 0x00039768
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

		// Token: 0x060011AD RID: 4525 RVA: 0x0003B57B File Offset: 0x0003977B
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

		// Token: 0x060011AE RID: 4526 RVA: 0x0003B58E File Offset: 0x0003978E
		public IFanStateEffect_SetValue ToSetValue()
		{
			return new IFanStateEffect_SetValue
			{
				EntityState = this.EntityState,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0003B5AD File Offset: 0x000397AD
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0003B5D8 File Offset: 0x000397D8
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0003B5E8 File Offset: 0x000397E8
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0003B649 File Offset: 0x00039849
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

		// Token: 0x04000E6F RID: 3695
		[Nullable(2)]
		protected IFanStateEffect FbInstance;

		// Token: 0x04000E70 RID: 3696
		[Nullable(2)]
		protected IFanStateEffect_SetValue PocoInterface;

		// Token: 0x04000E71 RID: 3697
		private IFanEffectConfig _EffectConfigCache;

		// Token: 0x04000E72 RID: 3698
		private bool _EffectConfigInited;
	}
}
