using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AB RID: 2219
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritCollectComponent : IComponentBase
	{
		// Token: 0x060031B7 RID: 12727 RVA: 0x0007F978 File Offset: 0x0007DB78
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

		// Token: 0x060031B8 RID: 12728 RVA: 0x0007F9B0 File Offset: 0x0007DBB0
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

		// Token: 0x060031B9 RID: 12729 RVA: 0x0007F9C3 File Offset: 0x0007DBC3
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

		// Token: 0x060031BA RID: 12730 RVA: 0x0007F9D8 File Offset: 0x0007DBD8
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

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x0007FA28 File Offset: 0x0007DC28
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x0007FA62 File Offset: 0x0007DC62
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x0007FA70 File Offset: 0x0007DC70
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x0007FA9A File Offset: 0x0007DC9A
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x0007FAA8 File Offset: 0x0007DCA8
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x0007FAD3 File Offset: 0x0007DCD3
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

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x0007FAE4 File Offset: 0x0007DCE4
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x0007FB1E File Offset: 0x0007DD1E
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

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x0007FB2C File Offset: 0x0007DD2C
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x0007FB8D File Offset: 0x0007DD8D
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

		// Token: 0x0400209E RID: 8350
		[Nullable(2)]
		protected new SunSpiritCollectComponent FbInstance;

		// Token: 0x0400209F RID: 8351
		[Nullable(2)]
		protected new SunSpiritCollectComponent_SetValue PocoInterface;

		// Token: 0x040020A0 RID: 8352
		private ISunSpiritPlayerBattleConfig _PlayerBattleConfigCache;

		// Token: 0x040020A1 RID: 8353
		private bool _PlayerBattleConfigInited;
	}
}
