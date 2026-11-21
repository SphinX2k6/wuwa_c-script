using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F7 RID: 8695
	public class ITeleportTransitionWithMp4 : ITeleportTransitionType
	{
		// Token: 0x0600BD80 RID: 48512 RVA: 0x001B6260 File Offset: 0x001B4460
		private ITeleportTransitionWithMp4_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithMp4 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithMp4_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithMp4_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD81 RID: 48513 RVA: 0x001B6298 File Offset: 0x001B4498
		public static ITeleportTransitionWithMp4 Create([Nullable(2)] ITeleportTransitionWithMp4 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithMp4
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x001B62AB File Offset: 0x001B44AB
		public static ITeleportTransitionWithMp4 CreateFromSetValue([Nullable(2)] ITeleportTransitionWithMp4_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithMp4
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x001B62C0 File Offset: 0x001B44C0
		public new ITeleportTransitionWithMp4_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithMp4_SetValue
			{
				Type = this.Type,
				Mp4Path = this.Mp4Path,
				IsFadeInScreenAfterTeleport = this.IsFadeInScreenAfterTeleport,
				ReplayWhenReLogin = this.ReplayWhenReLogin,
				BackgroundColor = this.BackgroundColor,
				AfterTeleportScreenColor = this.AfterTeleportScreenColor
			};
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600BD84 RID: 48516 RVA: 0x001B631A File Offset: 0x001B451A
		// (set) Token: 0x0600BD85 RID: 48517 RVA: 0x001B6345 File Offset: 0x001B4545
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0600BD86 RID: 48518 RVA: 0x001B6353 File Offset: 0x001B4553
		// (set) Token: 0x0600BD87 RID: 48519 RVA: 0x001B637E File Offset: 0x001B457E
		public virtual string Mp4Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mp4Path;
			}
			set
			{
				this.GetOrCreatePoco().Mp4Path = value;
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0600BD88 RID: 48520 RVA: 0x001B638C File Offset: 0x001B458C
		// (set) Token: 0x0600BD89 RID: 48521 RVA: 0x001B63C6 File Offset: 0x001B45C6
		public virtual bool? IsFadeInScreenAfterTeleport
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFadeInScreenAfterTeleport;
				}
				ITeleportTransitionWithMp4_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFadeInScreenAfterTeleport;
			}
			set
			{
				this.GetOrCreatePoco().IsFadeInScreenAfterTeleport = value;
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600BD8A RID: 48522 RVA: 0x001B63D4 File Offset: 0x001B45D4
		// (set) Token: 0x0600BD8B RID: 48523 RVA: 0x001B640E File Offset: 0x001B460E
		public virtual bool? ReplayWhenReLogin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReplayWhenReLogin;
				}
				ITeleportTransitionWithMp4_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ReplayWhenReLogin;
			}
			set
			{
				this.GetOrCreatePoco().ReplayWhenReLogin = value;
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0600BD8C RID: 48524 RVA: 0x001B641C File Offset: 0x001B461C
		// (set) Token: 0x0600BD8D RID: 48525 RVA: 0x001B647D File Offset: 0x001B467D
		[Nullable(2)]
		public virtual IMp4BackgroundColor BackgroundColor
		{
			[NullableContext(2)]
			get
			{
				if (this._BackgroundColorInited)
				{
					return this._BackgroundColorCache;
				}
				this._BackgroundColorInited = true;
				if (this.FbInstance != null)
				{
					this._BackgroundColorCache = IMp4BackgroundColor.Create(this.FbInstance.BackgroundColor);
				}
				else
				{
					ITeleportTransitionWithMp4_SetValue pocoInterface = this.PocoInterface;
					this._BackgroundColorCache = ((pocoInterface != null) ? pocoInterface.BackgroundColor : null);
				}
				return this._BackgroundColorCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BackgroundColor = value;
				this._BackgroundColorInited = false;
			}
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0600BD8E RID: 48526 RVA: 0x001B6494 File Offset: 0x001B4694
		// (set) Token: 0x0600BD8F RID: 48527 RVA: 0x001B64CE File Offset: 0x001B46CE
		public virtual EAfterTeleportScreenColor? AfterTeleportScreenColor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AfterTeleportScreenColor;
				}
				ITeleportTransitionWithMp4_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AfterTeleportScreenColor;
			}
			set
			{
				this.GetOrCreatePoco().AfterTeleportScreenColor = value;
			}
		}

		// Token: 0x040071C2 RID: 29122
		[Nullable(2)]
		protected new ITeleportTransitionWithMp4 FbInstance;

		// Token: 0x040071C3 RID: 29123
		[Nullable(2)]
		protected new ITeleportTransitionWithMp4_SetValue PocoInterface;

		// Token: 0x040071C4 RID: 29124
		private IMp4BackgroundColor _BackgroundColorCache;

		// Token: 0x040071C5 RID: 29125
		private bool _BackgroundColorInited;
	}
}
