using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013BF RID: 5055
	public class IVisionSystemQuestDoIdentify : IVisionSystemQuestBase
	{
		// Token: 0x06007372 RID: 29554 RVA: 0x0011511B File Offset: 0x0011331B
		[NullableContext(1)]
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

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x06007373 RID: 29555 RVA: 0x0011513A File Offset: 0x0011333A
		public override EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x040042CF RID: 17103
		private IVisionSystemQuestDoIdentify Instance;
	}
}
