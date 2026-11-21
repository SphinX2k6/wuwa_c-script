using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094E RID: 2382
	public class SunSpiritCollectComponent : IComponentBase
	{
		// Token: 0x060034F3 RID: 13555 RVA: 0x00086E60 File Offset: 0x00085060
		private SunSpiritCollectComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SunSpiritCollectComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SunSpiritCollectComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SunSpiritCollectComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00086E98 File Offset: 0x00085098
		public static SunSpiritCollectComponent Create([Nullable(2)] SunSpiritCollectComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SunSpiritCollectComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00086EAB File Offset: 0x000850AB
		public static SunSpiritCollectComponent CreateFromSetValue([Nullable(2)] SunSpiritCollectComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SunSpiritCollectComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00086EC0 File Offset: 0x000850C0
		public new SunSpiritCollectComponent_SetValue ToSetValue()
		{
			return new SunSpiritCollectComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AreaId = this.AreaId,
				SunSpiritScale = this.SunSpiritScale,
				PlayerBattleConfig = this.PlayerBattleConfig
			};
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x00086F10 File Offset: 0x00085110
		// (set) Token: 0x060034F8 RID: 13560 RVA: 0x00086F4A File Offset: 0x0008514A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SunSpiritCollectComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x00086F58 File Offset: 0x00085158
		// (set) Token: 0x060034FA RID: 13562 RVA: 0x00086F82 File Offset: 0x00085182
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x00086F90 File Offset: 0x00085190
		// (set) Token: 0x060034FC RID: 13564 RVA: 0x00086FBB File Offset: 0x000851BB
		public virtual int AreaId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AreaId;
			}
			set
			{
				this.GetOrCreatePoco().AreaId = value;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060034FD RID: 13565 RVA: 0x00086FCC File Offset: 0x000851CC
		// (set) Token: 0x060034FE RID: 13566 RVA: 0x00087006 File Offset: 0x00085206
		public virtual float? SunSpiritScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SunSpiritScale;
				}
				SunSpiritCollectComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SunSpiritScale;
			}
			set
			{
				this.GetOrCreatePoco().SunSpiritScale = value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060034FF RID: 13567 RVA: 0x00087014 File Offset: 0x00085214
		// (set) Token: 0x06003500 RID: 13568 RVA: 0x00087075 File Offset: 0x00085275
		[Nullable(2)]
		public virtual ISunSpiritPlayerBattleConfig PlayerBattleConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._PlayerBattleConfigInited)
				{
					return this._PlayerBattleConfigCache;
				}
				this._PlayerBattleConfigInited = true;
				if (this.FbInstance != null)
				{
					this._PlayerBattleConfigCache = ISunSpiritPlayerBattleConfig.Create(this.FbInstance.PlayerBattleConfig);
				}
				else
				{
					SunSpiritCollectComponent_SetValue pocoInterface = this.PocoInterface;
					this._PlayerBattleConfigCache = ((pocoInterface != null) ? pocoInterface.PlayerBattleConfig : null);
				}
				return this._PlayerBattleConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PlayerBattleConfig = value;
				this._PlayerBattleConfigInited = false;
			}
		}

		// Token: 0x040022B0 RID: 8880
		[Nullable(2)]
		protected new SunSpiritCollectComponent FbInstance;

		// Token: 0x040022B1 RID: 8881
		[Nullable(2)]
		protected new SunSpiritCollectComponent_SetValue PocoInterface;

		// Token: 0x040022B2 RID: 8882
		private ISunSpiritPlayerBattleConfig _PlayerBattleConfigCache;

		// Token: 0x040022B3 RID: 8883
		private bool _PlayerBattleConfigInited;
	}
}
