using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C82 RID: 3202
	public class IDefaultAttachTiming : IAttachTiming
	{
		// Token: 0x0600494D RID: 18765 RVA: 0x000B7DAB File Offset: 0x000B5FAB
		[NullableContext(1)]
		public static IDefaultAttachTiming Create(IDefaultAttachTiming? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultAttachTiming
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x000B7DCA File Offset: 0x000B5FCA
		public override EAttachTimingType Type
		{
			get
			{
				return (EAttachTimingType)this.Instance.Type;
			}
		}

		// Token: 0x040029D1 RID: 10705
		private IDefaultAttachTiming Instance;
	}
}
