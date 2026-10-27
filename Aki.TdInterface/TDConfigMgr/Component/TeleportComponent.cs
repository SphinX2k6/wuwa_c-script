using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BE RID: 2238
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportComponent : IComponentBase
	{
		// Token: 0x06003257 RID: 12887 RVA: 0x000811E4 File Offset: 0x0007F3E4
		private TeleportComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TeleportComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TeleportComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TeleportComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x0008121C File Offset: 0x0007F41C
		public static TeleportComponent Create([Nullable(2)] TeleportComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x0008122F File Offset: 0x0007F42F
		public static TeleportComponent CreateFromSetValue([Nullable(2)] TeleportComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TeleportComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x00081244 File Offset: 0x0007F444
		public new TeleportComponent_SetValue ToSetValue()
		{
			return new TeleportComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TeleporterId = this.TeleporterId,
				TeleportPos = this.TeleportPos,
				GravityConfig = this.GravityConfig
			};
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x00081294 File Offset: 0x0007F494
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x000812CE File Offset: 0x0007F4CE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TeleportComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x000812DC File Offset: 0x0007F4DC
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x00081306 File Offset: 0x0007F506
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

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x00081314 File Offset: 0x0007F514
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x0008133F File Offset: 0x0007F53F
		public virtual int TeleporterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleporterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TeleporterId;
			}
			set
			{
				this.GetOrCreatePoco().TeleporterId = value;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x00081350 File Offset: 0x0007F550
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x000813B1 File Offset: 0x0007F5B1
		public virtual PosA TeleportPos
		{
			get
			{
				if (this._TeleportPosInited)
				{
					return this._TeleportPosCache;
				}
				this._TeleportPosInited = true;
				if (this.FbInstance != null)
				{
					this._TeleportPosCache = PosA.Create(this.FbInstance.TeleportPos);
				}
				else
				{
					TeleportComponent_SetValue pocoInterface = this.PocoInterface;
					this._TeleportPosCache = ((pocoInterface != null) ? pocoInterface.TeleportPos : null);
				}
				return this._TeleportPosCache;
			}
			set
			{
				this.GetOrCreatePoco().TeleportPos = value;
				this._TeleportPosInited = false;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x000813C8 File Offset: 0x0007F5C8
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x00081429 File Offset: 0x0007F629
		[Nullable(2)]
		public virtual IGravityFlipTeleportConfig GravityConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._GravityConfigInited)
				{
					return this._GravityConfigCache;
				}
				this._GravityConfigInited = true;
				if (this.FbInstance != null)
				{
					this._GravityConfigCache = IGravityFlipTeleportConfig.Create(this.FbInstance.GravityConfig);
				}
				else
				{
					TeleportComponent_SetValue pocoInterface = this.PocoInterface;
					this._GravityConfigCache = ((pocoInterface != null) ? pocoInterface.GravityConfig : null);
				}
				return this._GravityConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().GravityConfig = value;
				this._GravityConfigInited = false;
			}
		}

		// Token: 0x04002107 RID: 8455
		[Nullable(2)]
		protected new TeleportComponent FbInstance;

		// Token: 0x04002108 RID: 8456
		[Nullable(2)]
		protected new TeleportComponent_SetValue PocoInterface;

		// Token: 0x04002109 RID: 8457
		private PosA _TeleportPosCache;

		// Token: 0x0400210A RID: 8458
		private bool _TeleportPosInited;

		// Token: 0x0400210B RID: 8459
		private IGravityFlipTeleportConfig _GravityConfigCache;

		// Token: 0x0400210C RID: 8460
		private bool _GravityConfigInited;
	}
}
