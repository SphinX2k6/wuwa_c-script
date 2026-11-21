using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B5A RID: 11098
	public class IMontageParam
	{
		// Token: 0x0600F3EE RID: 62446 RVA: 0x002393BE File Offset: 0x002375BE
		public static IMontageParam Create(IMontageParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x0600F3EF RID: 62447 RVA: 0x002393DD File Offset: 0x002375DD
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				this._MontageIdCache = IMontageId.Create(this.Instance.MontageId);
				return this._MontageIdCache;
			}
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x0600F3F0 RID: 62448 RVA: 0x00239414 File Offset: 0x00237614
		public virtual bool? IsLoop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLoop);
			}
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x0600F3F1 RID: 62449 RVA: 0x0023944C File Offset: 0x0023764C
		public virtual bool? KeepPose
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPose);
			}
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x0600F3F2 RID: 62450 RVA: 0x00239484 File Offset: 0x00237684
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x040085C8 RID: 34248
		private IMontageParam Instance;

		// Token: 0x040085C9 RID: 34249
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x040085CA RID: 34250
		private bool _MontageIdInited;
	}
}
