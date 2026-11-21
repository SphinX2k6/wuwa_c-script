using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002830 RID: 10288
	public class IVisualNovelMainRoleActionConfigBase
	{
		// Token: 0x0600E504 RID: 58628 RVA: 0x0021D77E File Offset: 0x0021B97E
		public static IVisualNovelMainRoleActionConfigBase Create(IVisualNovelMainRoleActionConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelMainRoleActionConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x0600E505 RID: 58629 RVA: 0x0021D79D File Offset: 0x0021B99D
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007DAC RID: 32172
		private IVisualNovelMainRoleActionConfigBase Instance;
	}
}
