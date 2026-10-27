using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026BC RID: 9916
	[NullableContext(1)]
	[Nullable(0)]
	public class SetPlayerPos : ActionParams
	{
		// Token: 0x0600DDCE RID: 56782 RVA: 0x0020EE37 File Offset: 0x0020D037
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

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x0600DDCF RID: 56783 RVA: 0x0020EE56 File Offset: 0x0020D056
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

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x0600DDD0 RID: 56784 RVA: 0x0020EE85 File Offset: 0x0020D085
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

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x0600DDD1 RID: 56785 RVA: 0x0020EEB9 File Offset: 0x0020D0B9
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

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x0600DDD2 RID: 56786 RVA: 0x0020EEE8 File Offset: 0x0020D0E8
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

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x0600DDD3 RID: 56787 RVA: 0x0020EF20 File Offset: 0x0020D120
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

		// Token: 0x04007B22 RID: 31522
		private ISetPlayerPos Instance;

		// Token: 0x04007B23 RID: 31523
		private ITeleportConfig _TelePortConfigCache;

		// Token: 0x04007B24 RID: 31524
		private bool _TelePortConfigInited;

		// Token: 0x04007B25 RID: 31525
		[Nullable(2)]
		private ITelePortAfterTimeOut _TeammateTeleportConfigCache;

		// Token: 0x04007B26 RID: 31526
		private bool _TeammateTeleportConfigInited;

		// Token: 0x04007B27 RID: 31527
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x04007B28 RID: 31528
		private bool _TransitionOptionInited;
	}
}
