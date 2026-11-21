using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001512 RID: 5394
	public class IVisionSystemQuestBase
	{
		// Token: 0x06007A21 RID: 31265 RVA: 0x001238CD File Offset: 0x00121ACD
		public static IVisionSystemQuestBase Create(IVisionSystemQuestBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x001238EC File Offset: 0x00121AEC
		public virtual EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x04004656 RID: 18006
		private IVisionSystemQuestBase Instance;
	}
}
