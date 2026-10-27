using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025AB RID: 9643
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorTurnTo : ActionParams
	{
		// Token: 0x0600D8F1 RID: 55537 RVA: 0x00205F87 File Offset: 0x00204187
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

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x0600D8F2 RID: 55538 RVA: 0x00205FA6 File Offset: 0x002041A6
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x0600D8F3 RID: 55539 RVA: 0x00205FB3 File Offset: 0x002041B3
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

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x0600D8F4 RID: 55540 RVA: 0x00205FE4 File Offset: 0x002041E4
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

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x0600D8F5 RID: 55541 RVA: 0x0020601C File Offset: 0x0020421C
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

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x0600D8F6 RID: 55542 RVA: 0x00206054 File Offset: 0x00204254
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

		// Token: 0x04007887 RID: 30855
		private IActorTurnTo Instance;

		// Token: 0x04007888 RID: 30856
		private IActorTurnToData _TargetCache;

		// Token: 0x04007889 RID: 30857
		private bool _TargetInited;
	}
}
