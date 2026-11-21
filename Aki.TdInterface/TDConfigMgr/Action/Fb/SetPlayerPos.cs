using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002980 RID: 10624
	public class SetPlayerPos : ActionParams
	{
		// Token: 0x0600EBA9 RID: 60329 RVA: 0x0022B63F File Offset: 0x0022983F
		public static SetPlayerPos Create(ISetPlayerPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x0600EBAA RID: 60330 RVA: 0x0022B65E File Offset: 0x0022985E
		public virtual ITeleportConfig TelePortConfig
		{
			get
			{
				if (this._TelePortConfigInited)
				{
					return this._TelePortConfigCache;
				}
				this._TelePortConfigInited = true;
				this._TelePortConfigCache = ActionReadHelper.ReadSetPlayerPos_TelePortConfig(this.Instance);
				return this._TelePortConfigCache;
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x0600EBAB RID: 60331 RVA: 0x0022B68D File Offset: 0x0022988D
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
				this._TeammateTeleportConfigCache = ITelePortAfterTimeOut.Create(this.Instance.TeammateTeleportConfig);
				return this._TeammateTeleportConfigCache;
			}
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x0600EBAC RID: 60332 RVA: 0x0022B6C1 File Offset: 0x002298C1
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = ActionReadHelper.ReadSetPlayerPos_TransitionOption(this.Instance);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x0600EBAD RID: 60333 RVA: 0x0022B6F0 File Offset: 0x002298F0
		public virtual bool? DisableAutoFadeInScreen
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableAutoFadeInScreen);
			}
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x0600EBAE RID: 60334 RVA: 0x0022B728 File Offset: 0x00229928
		public virtual bool? OnlinePreciseTransport
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlinePreciseTransport);
			}
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x0600EBAF RID: 60335 RVA: 0x0022B760 File Offset: 0x00229960
		public virtual bool? IsBanMapSound
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsBanMapSound);
			}
		}

		// Token: 0x040081C2 RID: 33218
		private ISetPlayerPos Instance;

		// Token: 0x040081C3 RID: 33219
		private ITeleportConfig _TelePortConfigCache;

		// Token: 0x040081C4 RID: 33220
		private bool _TelePortConfigInited;

		// Token: 0x040081C5 RID: 33221
		[Nullable(2)]
		private ITelePortAfterTimeOut _TeammateTeleportConfigCache;

		// Token: 0x040081C6 RID: 33222
		private bool _TeammateTeleportConfigInited;

		// Token: 0x040081C7 RID: 33223
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x040081C8 RID: 33224
		private bool _TransitionOptionInited;
	}
}
