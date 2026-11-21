using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001514 RID: 5396
	public class IVisionSystemQuestSetActivated : IVisionSystemQuestBase
	{
		// Token: 0x06007A28 RID: 31272 RVA: 0x00123942 File Offset: 0x00121B42
		public static IVisionSystemQuestSetActivated Create(IVisionSystemQuestSetActivated? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestSetActivated
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x06007A29 RID: 31273 RVA: 0x00123961 File Offset: 0x00121B61
		public override EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x06007A2A RID: 31274 RVA: 0x0012396E File Offset: 0x00121B6E
		public virtual EVisionSetType SetType
		{
			get
			{
				return (EVisionSetType)this.Instance.SetType;
			}
		}

		// Token: 0x04004658 RID: 18008
		private IVisionSystemQuestSetActivated Instance;
	}
}
