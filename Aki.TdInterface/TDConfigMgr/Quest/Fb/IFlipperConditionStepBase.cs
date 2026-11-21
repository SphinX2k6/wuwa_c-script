using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001552 RID: 5458
	public class IFlipperConditionStepBase
	{
		// Token: 0x06007B22 RID: 31522 RVA: 0x00125114 File Offset: 0x00123314
		public static IFlipperConditionStepBase Create(IFlipperConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x06007B23 RID: 31523 RVA: 0x00125133 File Offset: 0x00123333
		public virtual EFlipperConditionStep Type
		{
			get
			{
				return (EFlipperConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046EA RID: 18154
		private IFlipperConditionStepBase Instance;
	}
}
