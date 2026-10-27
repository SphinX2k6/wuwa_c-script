using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB4 RID: 8116
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithMp4 : ITeleportTransitionType
	{
		// Token: 0x0600B27C RID: 45692 RVA: 0x0019FEB0 File Offset: 0x0019E0B0
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

		// Token: 0x0600B27D RID: 45693 RVA: 0x0019FEE8 File Offset: 0x0019E0E8
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

		// Token: 0x0600B27E RID: 45694 RVA: 0x0019FEFB File Offset: 0x0019E0FB
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

		// Token: 0x0600B27F RID: 45695 RVA: 0x0019FF10 File Offset: 0x0019E110
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

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600B280 RID: 45696 RVA: 0x0019FF6A File Offset: 0x0019E16A
		// (set) Token: 0x0600B281 RID: 45697 RVA: 0x0019FF95 File Offset: 0x0019E195
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

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x0019FFA3 File Offset: 0x0019E1A3
		// (set) Token: 0x0600B283 RID: 45699 RVA: 0x0019FFCE File Offset: 0x0019E1CE
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

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x0019FFDC File Offset: 0x0019E1DC
		// (set) Token: 0x0600B285 RID: 45701 RVA: 0x001A0016 File Offset: 0x0019E216
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

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x001A0024 File Offset: 0x0019E224
		// (set) Token: 0x0600B287 RID: 45703 RVA: 0x001A005E File Offset: 0x0019E25E
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

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x001A006C File Offset: 0x0019E26C
		// (set) Token: 0x0600B289 RID: 45705 RVA: 0x001A00CD File Offset: 0x0019E2CD
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

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x001A00E4 File Offset: 0x0019E2E4
		// (set) Token: 0x0600B28B RID: 45707 RVA: 0x001A011E File Offset: 0x0019E31E
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

		// Token: 0x04006BC7 RID: 27591
		[Nullable(2)]
		protected new ITeleportTransitionWithMp4 FbInstance;

		// Token: 0x04006BC8 RID: 27592
		[Nullable(2)]
		protected new ITeleportTransitionWithMp4_SetValue PocoInterface;

		// Token: 0x04006BC9 RID: 27593
		private IMp4BackgroundColor _BackgroundColorCache;

		// Token: 0x04006BCA RID: 27594
		private bool _BackgroundColorInited;
	}
}
