using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008CA RID: 2250
	public class LevelQteComponent : IComponentBase
	{
		// Token: 0x0600309D RID: 12445 RVA: 0x0007CE7C File Offset: 0x0007B07C
		private LevelQteComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LevelQteComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LevelQteComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LevelQteComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x0007CEB4 File Offset: 0x0007B0B4
		public static LevelQteComponent Create([Nullable(2)] LevelQteComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelQteComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x0007CEC7 File Offset: 0x0007B0C7
		public static LevelQteComponent CreateFromSetValue([Nullable(2)] LevelQteComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LevelQteComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0007CEDA File Offset: 0x0007B0DA
		public new LevelQteComponent_SetValue ToSetValue()
		{
			return new LevelQteComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				QteConfig = this.QteConfig
			};
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x0007CF08 File Offset: 0x0007B108
		// (set) Token: 0x060030A2 RID: 12450 RVA: 0x0007CF42 File Offset: 0x0007B142
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LevelQteComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x0007CF50 File Offset: 0x0007B150
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x0007CF7A File Offset: 0x0007B17A
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

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x0007CF88 File Offset: 0x0007B188
		// (set) Token: 0x060030A6 RID: 12454 RVA: 0x0007CFE9 File Offset: 0x0007B1E9
		public virtual ISingleBtnQte QteConfig
		{
			get
			{
				if (this._QteConfigInited)
				{
					return this._QteConfigCache;
				}
				this._QteConfigInited = true;
				if (this.FbInstance != null)
				{
					this._QteConfigCache = ISingleBtnQte.Create(this.FbInstance.QteConfig);
				}
				else
				{
					LevelQteComponent_SetValue pocoInterface = this.PocoInterface;
					this._QteConfigCache = ((pocoInterface != null) ? pocoInterface.QteConfig : null);
				}
				return this._QteConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().QteConfig = value;
				this._QteConfigInited = false;
			}
		}

		// Token: 0x0400201D RID: 8221
		[Nullable(2)]
		protected new LevelQteComponent FbInstance;

		// Token: 0x0400201E RID: 8222
		[Nullable(2)]
		protected new LevelQteComponent_SetValue PocoInterface;

		// Token: 0x0400201F RID: 8223
		private ISingleBtnQte _QteConfigCache;

		// Token: 0x04002020 RID: 8224
		private bool _QteConfigInited;
	}
}
