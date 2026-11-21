using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000961 RID: 2401
	public class TeleportComponent : IComponentBase
	{
		// Token: 0x06003593 RID: 13715 RVA: 0x000886CC File Offset: 0x000868CC
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

		// Token: 0x06003594 RID: 13716 RVA: 0x00088704 File Offset: 0x00086904
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

		// Token: 0x06003595 RID: 13717 RVA: 0x00088717 File Offset: 0x00086917
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

		// Token: 0x06003596 RID: 13718 RVA: 0x0008872C File Offset: 0x0008692C
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

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x0008877C File Offset: 0x0008697C
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x000887B6 File Offset: 0x000869B6
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

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x000887C4 File Offset: 0x000869C4
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x000887EE File Offset: 0x000869EE
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

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x000887FC File Offset: 0x000869FC
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x00088827 File Offset: 0x00086A27
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

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x00088838 File Offset: 0x00086A38
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x00088899 File Offset: 0x00086A99
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

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x000888B0 File Offset: 0x00086AB0
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x00088911 File Offset: 0x00086B11
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

		// Token: 0x04002319 RID: 8985
		[Nullable(2)]
		protected new TeleportComponent FbInstance;

		// Token: 0x0400231A RID: 8986
		[Nullable(2)]
		protected new TeleportComponent_SetValue PocoInterface;

		// Token: 0x0400231B RID: 8987
		private PosA _TeleportPosCache;

		// Token: 0x0400231C RID: 8988
		private bool _TeleportPosInited;

		// Token: 0x0400231D RID: 8989
		private IGravityFlipTeleportConfig _GravityConfigCache;

		// Token: 0x0400231E RID: 8990
		private bool _GravityConfigInited;
	}
}
