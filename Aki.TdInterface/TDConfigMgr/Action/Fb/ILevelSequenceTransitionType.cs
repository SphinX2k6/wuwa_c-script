using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE3 RID: 11235
	public class ILevelSequenceTransitionType
	{
		// Token: 0x0600F77B RID: 63355 RVA: 0x002404A0 File Offset: 0x0023E6A0
		public static ILevelSequenceTransitionType Create(ILevelSequenceTransitionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelSequenceTransitionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x0600F77C RID: 63356 RVA: 0x002404BF File Offset: 0x0023E6BF
		public virtual ELevelSequenceTransition Type
		{
			get
			{
				return (ELevelSequenceTransition)this.Instance.Type;
			}
		}

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x0600F77D RID: 63357 RVA: 0x002404CC File Offset: 0x0023E6CC
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x04008787 RID: 34695
		private ILevelSequenceTransitionType Instance;
	}
}
