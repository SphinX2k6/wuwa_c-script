using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291B RID: 10523
	public class IInformationViewConfig
	{
		// Token: 0x0600E9E9 RID: 59881 RVA: 0x00228873 File Offset: 0x00226A73
		public static IInformationViewConfig Create(IInformationViewConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationViewConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x0600E9EA RID: 59882 RVA: 0x00228894 File Offset: 0x00226A94
		public virtual int? InfoDisplayGroup
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InfoDisplayGroup);
			}
		}

		// Token: 0x040080F5 RID: 33013
		private IInformationViewConfig Instance;
	}
}
