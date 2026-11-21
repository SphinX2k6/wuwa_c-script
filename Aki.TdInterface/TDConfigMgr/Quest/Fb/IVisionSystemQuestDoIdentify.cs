using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001515 RID: 5397
	public class IVisionSystemQuestDoIdentify : IVisionSystemQuestBase
	{
		// Token: 0x06007A2C RID: 31276 RVA: 0x00123983 File Offset: 0x00121B83
		public static IVisionSystemQuestDoIdentify Create(IVisionSystemQuestDoIdentify? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestDoIdentify
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x06007A2D RID: 31277 RVA: 0x001239A2 File Offset: 0x00121BA2
		public override EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x04004659 RID: 18009
		private IVisionSystemQuestDoIdentify Instance;
	}
}
