using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C81 RID: 3201
	public class IAttachTiming
	{
		// Token: 0x0600494A RID: 18762 RVA: 0x000B7D77 File Offset: 0x000B5F77
		[NullableContext(1)]
		public static IAttachTiming Create(IAttachTiming? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttachTiming
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x000B7D96 File Offset: 0x000B5F96
		public virtual EAttachTimingType Type
		{
			get
			{
				return (EAttachTimingType)this.Instance.Type;
			}
		}

		// Token: 0x040029D0 RID: 10704
		private IAttachTiming Instance;
	}
}
