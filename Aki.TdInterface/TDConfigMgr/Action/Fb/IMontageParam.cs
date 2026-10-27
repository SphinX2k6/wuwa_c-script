using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002885 RID: 10373
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageParam
	{
		// Token: 0x0600E5BF RID: 58815 RVA: 0x0021C43E File Offset: 0x0021A63E
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

		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x0021C45D File Offset: 0x0021A65D
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

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x0021C494 File Offset: 0x0021A694
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

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x0021C4CC File Offset: 0x0021A6CC
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

		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x0021C504 File Offset: 0x0021A704
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

		// Token: 0x04007F09 RID: 32521
		private IMontageParam Instance;

		// Token: 0x04007F0A RID: 32522
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x04007F0B RID: 32523
		private bool _MontageIdInited;
	}
}
