using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002657 RID: 9815
	public class IInformationViewConfig
	{
		// Token: 0x0600DC0D RID: 56333 RVA: 0x0020BF9B File Offset: 0x0020A19B
		[NullableContext(1)]
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

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x0600DC0E RID: 56334 RVA: 0x0020BFBC File Offset: 0x0020A1BC
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

		// Token: 0x04007A53 RID: 31315
		private IInformationViewConfig Instance;
	}
}
