using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D60 RID: 3424
	public class IAttachTiming
	{
		// Token: 0x06004DE9 RID: 19945 RVA: 0x000C257B File Offset: 0x000C077B
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

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06004DEA RID: 19946 RVA: 0x000C259A File Offset: 0x000C079A
		public virtual EAttachTimingType Type
		{
			get
			{
				return (EAttachTimingType)this.Instance.Type;
			}
		}

		// Token: 0x04002C3D RID: 11325
		private IAttachTiming Instance;
	}
}
