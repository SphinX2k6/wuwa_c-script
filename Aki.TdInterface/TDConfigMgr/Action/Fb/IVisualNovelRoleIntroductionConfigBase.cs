using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200258B RID: 9611
	public class IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600D7AF RID: 55215 RVA: 0x00201DB6 File Offset: 0x001FFFB6
		[NullableContext(1)]
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

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0600D7B0 RID: 55216 RVA: 0x00201DD5 File Offset: 0x001FFFD5
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007757 RID: 30551
		private IVisualNovelRoleIntroductionConfigBase Instance;
	}
}
