using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C72 RID: 11378
	public class PerformerAiSplineMove : ActionParams
	{
		// Token: 0x0600FA01 RID: 64001 RVA: 0x002449B0 File Offset: 0x00242BB0
		public static PerformerAiSplineMove Create(IPerformerAiSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformerAiSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x0600FA02 RID: 64002 RVA: 0x002449D0 File Offset: 0x00242BD0
		public virtual int? SplineEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SplineEntityId);
			}
		}

		// Token: 0x0400889A RID: 34970
		private IPerformerAiSplineMove Instance;
	}
}
