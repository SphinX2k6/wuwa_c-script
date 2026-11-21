using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D61 RID: 3425
	public class IDefaultAttachTiming : IAttachTiming
	{
		// Token: 0x06004DEC RID: 19948 RVA: 0x000C25AF File Offset: 0x000C07AF
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

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06004DED RID: 19949 RVA: 0x000C25CE File Offset: 0x000C07CE
		public override EAttachTimingType Type
		{
			get
			{
				return (EAttachTimingType)this.Instance.Type;
			}
		}

		// Token: 0x04002C3E RID: 11326
		private IDefaultAttachTiming Instance;
	}
}
