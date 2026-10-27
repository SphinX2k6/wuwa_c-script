using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013BE RID: 5054
	public class IVisionSystemQuestSetActivated : IVisionSystemQuestBase
	{
		// Token: 0x0600736E RID: 29550 RVA: 0x001150DA File Offset: 0x001132DA
		[NullableContext(1)]
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

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x0600736F RID: 29551 RVA: 0x001150F9 File Offset: 0x001132F9
		public override EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x06007370 RID: 29552 RVA: 0x00115106 File Offset: 0x00113306
		public virtual EVisionSetType SetType
		{
			get
			{
				return (EVisionSetType)this.Instance.SetType;
			}
		}

		// Token: 0x040042CE RID: 17102
		private IVisionSystemQuestSetActivated Instance;
	}
}
