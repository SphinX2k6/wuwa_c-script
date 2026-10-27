using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021CE RID: 8654
	[NullableContext(1)]
	[Nullable(0)]
	public class SetPlayerPos : ActionParams
	{
		// Token: 0x0600BE07 RID: 48647 RVA: 0x001B57E0 File Offset: 0x001B39E0
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

		// Token: 0x0600BE08 RID: 48648 RVA: 0x001B5818 File Offset: 0x001B3A18
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

		// Token: 0x0600BE09 RID: 48649 RVA: 0x001B582B File Offset: 0x001B3A2B
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

		// Token: 0x0600BE0A RID: 48650 RVA: 0x001B5840 File Offset: 0x001B3A40
		public SetPlayerPos_SetValue ToSetValue()
		{
			return new SetPlayerPos_SetValue
			{
				TelePortConfig = this.TelePortConfig,
				TeammateTeleportConfig = this.TeammateTeleportConfig,
				TransitionOption = this.TransitionOption,
				DisableAutoFadeInScreen = this.DisableAutoFadeInScreen,
				OnlinePreciseTransport = this.OnlinePreciseTransport
			};
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600BE0B RID: 48651 RVA: 0x001B588E File Offset: 0x001B3A8E
		// (set) Token: 0x0600BE0C RID: 48652 RVA: 0x001B58B5 File Offset: 0x001B3AB5
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

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600BE0D RID: 48653 RVA: 0x001B58C4 File Offset: 0x001B3AC4
		// (set) Token: 0x0600BE0E RID: 48654 RVA: 0x001B5925 File Offset: 0x001B3B25
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

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x001B593A File Offset: 0x001B3B3A
		// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x001B5961 File Offset: 0x001B3B61
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

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600BE11 RID: 48657 RVA: 0x001B5970 File Offset: 0x001B3B70
		// (set) Token: 0x0600BE12 RID: 48658 RVA: 0x001B59AA File Offset: 0x001B3BAA
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

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x001B59B8 File Offset: 0x001B3BB8
		// (set) Token: 0x0600BE14 RID: 48660 RVA: 0x001B59F2 File Offset: 0x001B3BF2
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

		// Token: 0x04007164 RID: 29028
		[Nullable(2)]
		protected new SetPlayerPos FbInstance;

		// Token: 0x04007165 RID: 29029
		[Nullable(2)]
		protected SetPlayerPos_SetValue PocoInterface;

		// Token: 0x04007166 RID: 29030
		private ITelePortAfterTimeOut _TeammateTeleportConfigCache;

		// Token: 0x04007167 RID: 29031
		private bool _TeammateTeleportConfigInited;
	}
}
