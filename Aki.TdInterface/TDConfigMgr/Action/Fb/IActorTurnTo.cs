using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285A RID: 10330
	public class IActorTurnTo : ActionParams
	{
		// Token: 0x0600E66B RID: 58987 RVA: 0x00221C5B File Offset: 0x0021FE5B
		public static IActorTurnTo Create(IActorTurnTo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnTo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x0600E66C RID: 58988 RVA: 0x00221C7A File Offset: 0x0021FE7A
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x0600E66D RID: 58989 RVA: 0x00221C87 File Offset: 0x0021FE87
		public virtual IActorTurnToData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIActorTurnTo_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x0600E66E RID: 58990 RVA: 0x00221CB8 File Offset: 0x0021FEB8
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

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x0600E66F RID: 58991 RVA: 0x00221CF0 File Offset: 0x0021FEF0
		public virtual bool? UseLookAtForSmallAngle
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseLookAtForSmallAngle);
			}
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x0600E670 RID: 58992 RVA: 0x00221D28 File Offset: 0x0021FF28
		public virtual bool? UpdatePosCache
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UpdatePosCache);
			}
		}

		// Token: 0x04007EEE RID: 32494
		private IActorTurnTo Instance;

		// Token: 0x04007EEF RID: 32495
		private IActorTurnToData _TargetCache;

		// Token: 0x04007EF0 RID: 32496
		private bool _TargetInited;
	}
}
