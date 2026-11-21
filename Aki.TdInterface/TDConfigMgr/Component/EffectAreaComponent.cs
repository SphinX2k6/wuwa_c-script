using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000AE RID: 174
	public class EffectAreaComponent : IComponentBase
	{
		// Token: 0x06000364 RID: 868 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		private EffectAreaComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EffectAreaComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EffectAreaComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EffectAreaComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001C430 File Offset: 0x0001A630
		public static EffectAreaComponent Create([Nullable(2)] EffectAreaComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EffectAreaComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0001C443 File Offset: 0x0001A643
		public static EffectAreaComponent CreateFromSetValue([Nullable(2)] EffectAreaComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EffectAreaComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001C456 File Offset: 0x0001A656
		public new EffectAreaComponent_SetValue ToSetValue()
		{
			return new EffectAreaComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0001C484 File Offset: 0x0001A684
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0001C4BE File Offset: 0x0001A6BE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EffectAreaComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0001C4CC File Offset: 0x0001A6CC
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0001C4F6 File Offset: 0x0001A6F6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0001C504 File Offset: 0x0001A704
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0001C565 File Offset: 0x0001A765
		public virtual IBuffArea Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IBuffArea.Create(this.FbInstance.Config);
				}
				else
				{
					EffectAreaComponent_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x04000406 RID: 1030
		[Nullable(2)]
		protected new EffectAreaComponent FbInstance;

		// Token: 0x04000407 RID: 1031
		[Nullable(2)]
		protected new EffectAreaComponent_SetValue PocoInterface;

		// Token: 0x04000408 RID: 1032
		private IBuffArea _ConfigCache;

		// Token: 0x04000409 RID: 1033
		private bool _ConfigInited;
	}
}
