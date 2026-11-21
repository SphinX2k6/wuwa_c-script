using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001533 RID: 5427
	public class ICheckTrapDefenseBdBuffQualityUp : ICheckTrapDefenseEventBase
	{
		// Token: 0x06007AB8 RID: 31416 RVA: 0x00124847 File Offset: 0x00122A47
		public static ICheckTrapDefenseBdBuffQualityUp Create(ICheckTrapDefenseBdBuffQualityUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseBdBuffQualityUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x06007AB9 RID: 31417 RVA: 0x00124866 File Offset: 0x00122A66
		public override ECheckTrapDefenseEvent Type
		{
			get
			{
				return (ECheckTrapDefenseEvent)this.Instance.Type;
			}
		}

		// Token: 0x040046B1 RID: 18097
		private ICheckTrapDefenseBdBuffQualityUp Instance;
	}
}
