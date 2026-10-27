using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002583 RID: 9603
	public class IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600D78D RID: 55181 RVA: 0x00201A7E File Offset: 0x001FFC7E
		[NullableContext(1)]
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

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x0600D78E RID: 55182 RVA: 0x00201A9D File Offset: 0x001FFC9D
		public virtual EVisualNovelTransitionType Type
		{
			get
			{
				return (EVisualNovelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x04007747 RID: 30535
		private IVisualNovelTransitionConfigBase Instance;
	}
}
