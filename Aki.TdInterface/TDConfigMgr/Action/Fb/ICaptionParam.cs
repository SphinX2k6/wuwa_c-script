using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C5 RID: 10181
	public class ICaptionParam
	{
		// Token: 0x0600E14F RID: 57679 RVA: 0x00211FA1 File Offset: 0x002101A1
		public static ICaptionParam Create(ICaptionParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICaptionParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0600E150 RID: 57680 RVA: 0x00211FC0 File Offset: 0x002101C0
		public virtual float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0600E151 RID: 57681 RVA: 0x00211FF8 File Offset: 0x002101F8
		public virtual float? TotalTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TotalTime);
			}
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x0600E152 RID: 57682 RVA: 0x00212030 File Offset: 0x00210230
		public virtual float? IntervalTime
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.IntervalTime);
			}
		}

		// Token: 0x04007A79 RID: 31353
		private ICaptionParam Instance;
	}
}
