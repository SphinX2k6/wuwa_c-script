using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002839 RID: 10297
	public class IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600E529 RID: 58665 RVA: 0x0021DAEA File Offset: 0x0021BCEA
		public static IVisualNovelRoleIntroductionConfigBase Create(IVisualNovelRoleIntroductionConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleIntroductionConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x0600E52A RID: 58666 RVA: 0x0021DB09 File Offset: 0x0021BD09
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007DBD RID: 32189
		private IVisualNovelRoleIntroductionConfigBase Instance;
	}
}
