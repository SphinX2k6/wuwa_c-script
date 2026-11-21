using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE6 RID: 11238
	public class ILoopRange
	{
		// Token: 0x0600F78A RID: 63370 RVA: 0x00240657 File Offset: 0x0023E857
		public static ILoopRange Create(ILoopRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILoopRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x0600F78B RID: 63371 RVA: 0x00240676 File Offset: 0x0023E876
		public virtual string LeftMark
		{
			get
			{
				return this.Instance.LeftMark;
			}
		}

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x0600F78C RID: 63372 RVA: 0x00240683 File Offset: 0x0023E883
		public virtual string RightMark
		{
			get
			{
				return this.Instance.RightMark;
			}
		}

		// Token: 0x0400878E RID: 34702
		private ILoopRange Instance;
	}
}
