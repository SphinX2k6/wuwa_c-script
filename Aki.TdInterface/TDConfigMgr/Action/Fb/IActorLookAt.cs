using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002853 RID: 10323
	public class IActorLookAt : ActionParams
	{
		// Token: 0x0600E651 RID: 58961 RVA: 0x00221A0F File Offset: 0x0021FC0F
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

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x0600E652 RID: 58962 RVA: 0x00221A2E File Offset: 0x0021FC2E
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x0600E653 RID: 58963 RVA: 0x00221A3B File Offset: 0x0021FC3B
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

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x0600E654 RID: 58964 RVA: 0x00221A6C File Offset: 0x0021FC6C
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

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x0600E655 RID: 58965 RVA: 0x00221AA4 File Offset: 0x0021FCA4
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

		// Token: 0x04007EE3 RID: 32483
		private IActorLookAt Instance;

		// Token: 0x04007EE4 RID: 32484
		private IActorLookAtData _TargetCache;

		// Token: 0x04007EE5 RID: 32485
		private bool _TargetInited;
	}
}
