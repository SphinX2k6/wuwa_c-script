using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002588 RID: 9608
	public class IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600D7A3 RID: 55203 RVA: 0x00201C7E File Offset: 0x001FFE7E
		[NullableContext(1)]
		public static IVisualNovelTransitionPerformanceConfigBase Create(IVisualNovelTransitionPerformanceConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionPerformanceConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x00201C9D File Offset: 0x001FFE9D
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007750 RID: 30544
		private IVisualNovelTransitionPerformanceConfigBase Instance;
	}
}
