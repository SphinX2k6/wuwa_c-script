using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001419 RID: 5145
	public class ISheriffReasoningBoardConfig
	{
		// Token: 0x060074EB RID: 29931 RVA: 0x001176C2 File Offset: 0x001158C2
		[NullableContext(1)]
		public static ISheriffReasoningBoardConfig Create(ISheriffReasoningBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffReasoningBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x060074EC RID: 29932 RVA: 0x001176E1 File Offset: 0x001158E1
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040043B1 RID: 17329
		private ISheriffReasoningBoardConfig Instance;
	}
}
