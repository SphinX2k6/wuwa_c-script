using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A4 RID: 9636
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAt : ActionParams
	{
		// Token: 0x0600D8D7 RID: 55511 RVA: 0x00205D3B File Offset: 0x00203F3B
		public static IActorLookAt Create(IActorLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0600D8D8 RID: 55512 RVA: 0x00205D5A File Offset: 0x00203F5A
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0600D8D9 RID: 55513 RVA: 0x00205D67 File Offset: 0x00203F67
		public virtual IActorLookAtData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIActorLookAt_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x0600D8DA RID: 55514 RVA: 0x00205D98 File Offset: 0x00203F98
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x0600D8DB RID: 55515 RVA: 0x00205DD0 File Offset: 0x00203FD0
		public virtual float? LookAtSpeedRate
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LookAtSpeedRate);
			}
		}

		// Token: 0x0400787C RID: 30844
		private IActorLookAt Instance;

		// Token: 0x0400787D RID: 30845
		private IActorLookAtData _TargetCache;

		// Token: 0x0400787E RID: 30846
		private bool _TargetInited;
	}
}
