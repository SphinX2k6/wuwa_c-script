using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013BC RID: 5052
	public class IVisionSystemQuestBase
	{
		// Token: 0x06007367 RID: 29543 RVA: 0x00115065 File Offset: 0x00113265
		[NullableContext(1)]
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

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06007368 RID: 29544 RVA: 0x00115084 File Offset: 0x00113284
		public virtual EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x040042CC RID: 17100
		private IVisionSystemQuestBase Instance;
	}
}
