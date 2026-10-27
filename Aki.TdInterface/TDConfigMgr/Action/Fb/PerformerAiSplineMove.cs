using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298B RID: 10635
	public class PerformerAiSplineMove : ActionParams
	{
		// Token: 0x0600EB83 RID: 60291 RVA: 0x00227224 File Offset: 0x00225424
		[NullableContext(1)]
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

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x0600EB84 RID: 60292 RVA: 0x00227244 File Offset: 0x00225444
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

		// Token: 0x040081B5 RID: 33205
		private IPerformerAiSplineMove Instance;
	}
}
