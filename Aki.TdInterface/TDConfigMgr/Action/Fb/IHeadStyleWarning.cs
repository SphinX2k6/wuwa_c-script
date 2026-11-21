using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AC RID: 10156
	public class IHeadStyleWarning : IHeadStyle
	{
		// Token: 0x0600E0DA RID: 57562 RVA: 0x002112EA File Offset: 0x0020F4EA
		public static IHeadStyleWarning Create(IHeadStyleWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x0600E0DB RID: 57563 RVA: 0x00211309 File Offset: 0x0020F509
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007A42 RID: 31298
		private IHeadStyleWarning Instance;
	}
}
