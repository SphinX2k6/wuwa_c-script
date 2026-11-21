using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283C RID: 10300
	public class IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600E536 RID: 58678 RVA: 0x0021DC36 File Offset: 0x0021BE36
		public static IVisualNovelActivityActionConfigBase Create(IVisualNovelActivityActionConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelActivityActionConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x0600E537 RID: 58679 RVA: 0x0021DC55 File Offset: 0x0021BE55
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007DC2 RID: 32194
		private IVisualNovelActivityActionConfigBase Instance;
	}
}
