using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002439 RID: 9273
	public class SetPlayerPos : ActionParams
	{
		// Token: 0x0600C9C1 RID: 51649 RVA: 0x001CCE18 File Offset: 0x001CB018
		private SetPlayerPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetPlayerPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetPlayerPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetPlayerPos_SetValue());
			}
			return result;
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x001CCE50 File Offset: 0x001CB050
		public static SetPlayerPos Create([Nullable(2)] SetPlayerPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x001CCE63 File Offset: 0x001CB063
		public static SetPlayerPos CreateFromSetValue([Nullable(2)] SetPlayerPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetPlayerPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x001CCE78 File Offset: 0x001CB078
		public SetPlayerPos_SetValue ToSetValue()
		{
			return new SetPlayerPos_SetValue
			{
				TelePortConfig = this.TelePortConfig,
				TeammateTeleportConfig = this.TeammateTeleportConfig,
				TransitionOption = this.TransitionOption,
				DisableAutoFadeInScreen = this.DisableAutoFadeInScreen,
				OnlinePreciseTransport = this.OnlinePreciseTransport,
				IsBanMapSound = this.IsBanMapSound
			};
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0600C9C5 RID: 51653 RVA: 0x001CCED2 File Offset: 0x001CB0D2
		// (set) Token: 0x0600C9C6 RID: 51654 RVA: 0x001CCEF9 File Offset: 0x001CB0F9
		public virtual ITeleportConfig TelePortConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TelePortConfig;
				}
				SetPlayerPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TelePortConfig;
			}
			set
			{
				this.GetOrCreatePoco().TelePortConfig = value;
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0600C9C7 RID: 51655 RVA: 0x001CCF08 File Offset: 0x001CB108
		// (set) Token: 0x0600C9C8 RID: 51656 RVA: 0x001CCF69 File Offset: 0x001CB169
		[Nullable(2)]
		public virtual ITelePortAfterTimeOut TeammateTeleportConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._TeammateTeleportConfigInited)
				{
					return this._TeammateTeleportConfigCache;
				}
				this._TeammateTeleportConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TeammateTeleportConfigCache = ITelePortAfterTimeOut.Create(this.FbInstance.TeammateTeleportConfig);
				}
				else
				{
					SetPlayerPos_SetValue pocoInterface = this.PocoInterface;
					this._TeammateTeleportConfigCache = ((pocoInterface != null) ? pocoInterface.TeammateTeleportConfig : null);
				}
				return this._TeammateTeleportConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TeammateTeleportConfig = value;
				this._TeammateTeleportConfigInited = false;
			}
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0600C9C9 RID: 51657 RVA: 0x001CCF7E File Offset: 0x001CB17E
		// (set) Token: 0x0600C9CA RID: 51658 RVA: 0x001CCFA5 File Offset: 0x001CB1A5
		[Nullable(2)]
		public virtual ITeleportTransitionType TransitionOption
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionOption;
				}
				SetPlayerPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionOption;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0600C9CB RID: 51659 RVA: 0x001CCFB4 File Offset: 0x001CB1B4
		// (set) Token: 0x0600C9CC RID: 51660 RVA: 0x001CCFEE File Offset: 0x001CB1EE
		public virtual bool? DisableAutoFadeInScreen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAutoFadeInScreen;
				}
				SetPlayerPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAutoFadeInScreen;
			}
			set
			{
				this.GetOrCreatePoco().DisableAutoFadeInScreen = value;
			}
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0600C9CD RID: 51661 RVA: 0x001CCFFC File Offset: 0x001CB1FC
		// (set) Token: 0x0600C9CE RID: 51662 RVA: 0x001CD036 File Offset: 0x001CB236
		public virtual bool? OnlinePreciseTransport
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlinePreciseTransport;
				}
				SetPlayerPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlinePreciseTransport;
			}
			set
			{
				this.GetOrCreatePoco().OnlinePreciseTransport = value;
			}
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0600C9CF RID: 51663 RVA: 0x001CD044 File Offset: 0x001CB244
		// (set) Token: 0x0600C9D0 RID: 51664 RVA: 0x001CD07E File Offset: 0x001CB27E
		public virtual bool? IsBanMapSound
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsBanMapSound;
				}
				SetPlayerPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsBanMapSound;
			}
			set
			{
				this.GetOrCreatePoco().IsBanMapSound = value;
			}
		}

		// Token: 0x040077AC RID: 30636
		[Nullable(2)]
		protected new SetPlayerPos FbInstance;

		// Token: 0x040077AD RID: 30637
		[Nullable(2)]
		protected SetPlayerPos_SetValue PocoInterface;

		// Token: 0x040077AE RID: 30638
		private ITelePortAfterTimeOut _TeammateTeleportConfigCache;

		// Token: 0x040077AF RID: 30639
		private bool _TeammateTeleportConfigInited;
	}
}
