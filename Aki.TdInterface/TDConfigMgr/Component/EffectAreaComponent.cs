using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000A8 RID: 168
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectAreaComponent : IComponentBase
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0001BA84 File Offset: 0x00019C84
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

		// Token: 0x06000361 RID: 865 RVA: 0x0001BABC File Offset: 0x00019CBC
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

		// Token: 0x06000362 RID: 866 RVA: 0x0001BACF File Offset: 0x00019CCF
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

		// Token: 0x06000363 RID: 867 RVA: 0x0001BAE2 File Offset: 0x00019CE2
		public new EffectAreaComponent_SetValue ToSetValue()
		{
			return new EffectAreaComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0001BB10 File Offset: 0x00019D10
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0001BB4A File Offset: 0x00019D4A
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0001BB58 File Offset: 0x00019D58
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0001BB82 File Offset: 0x00019D82
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0001BB90 File Offset: 0x00019D90
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0001BBF1 File Offset: 0x00019DF1
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

		// Token: 0x040003EA RID: 1002
		[Nullable(2)]
		protected new EffectAreaComponent FbInstance;

		// Token: 0x040003EB RID: 1003
		[Nullable(2)]
		protected new EffectAreaComponent_SetValue PocoInterface;

		// Token: 0x040003EC RID: 1004
		private IBuffArea _ConfigCache;

		// Token: 0x040003ED RID: 1005
		private bool _ConfigInited;
	}
}
