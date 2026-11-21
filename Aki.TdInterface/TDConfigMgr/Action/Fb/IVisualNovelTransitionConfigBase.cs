using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002831 RID: 10289
	public class IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600E507 RID: 58631 RVA: 0x0021D7B2 File Offset: 0x0021B9B2
		public static IVisualNovelTransitionConfigBase Create(IVisualNovelTransitionConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x0600E508 RID: 58632 RVA: 0x0021D7D1 File Offset: 0x0021B9D1
		public virtual EVisualNovelTransitionType Type
		{
			get
			{
				return (EVisualNovelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x04007DAD RID: 32173
		private IVisualNovelTransitionConfigBase Instance;
	}
}
