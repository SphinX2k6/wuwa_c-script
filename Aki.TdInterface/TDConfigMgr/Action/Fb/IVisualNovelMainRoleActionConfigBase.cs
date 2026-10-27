using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002582 RID: 9602
	public class IVisualNovelMainRoleActionConfigBase
	{
		// Token: 0x0600D78A RID: 55178 RVA: 0x00201A4A File Offset: 0x001FFC4A
		[NullableContext(1)]
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

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0600D78B RID: 55179 RVA: 0x00201A69 File Offset: 0x001FFC69
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007746 RID: 30534
		private IVisualNovelMainRoleActionConfigBase Instance;
	}
}
