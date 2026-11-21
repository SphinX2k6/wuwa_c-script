using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280C RID: 10252
	public class AvgFocusRole : ActionParams
	{
		// Token: 0x0600E450 RID: 58448 RVA: 0x0021C3DF File Offset: 0x0021A5DF
		public static AvgFocusRole Create(IAvgFocusRole? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgFocusRole
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x0600E451 RID: 58449 RVA: 0x0021C3FE File Offset: 0x0021A5FE
		public virtual bool IsFocus
		{
			get
			{
				return this.Instance.IsFocus;
			}
		}

		// Token: 0x04007D62 RID: 32098
		private IAvgFocusRole Instance;
	}
}
