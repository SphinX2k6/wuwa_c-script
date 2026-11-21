using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D40 RID: 11584
	public class ReignsTriggerGuide : ActionParams
	{
		// Token: 0x0600FD04 RID: 64772 RVA: 0x00248EC3 File Offset: 0x002470C3
		public static ReignsTriggerGuide Create(IReignsTriggerGuide? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsTriggerGuide
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x0600FD05 RID: 64773 RVA: 0x00248EE2 File Offset: 0x002470E2
		public virtual int GuideId
		{
			get
			{
				return this.Instance.GuideId;
			}
		}

		// Token: 0x04008A22 RID: 35362
		private IReignsTriggerGuide Instance;
	}
}
