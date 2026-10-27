using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001467 RID: 5223
	public class ITetrisPlayModeBase
	{
		// Token: 0x060076DF RID: 30431 RVA: 0x0011C330 File Offset: 0x0011A530
		[NullableContext(1)]
		public static ITetrisPlayModeBase Create(ITetrisPlayModeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x060076E0 RID: 30432 RVA: 0x0011C34F File Offset: 0x0011A54F
		public virtual ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x0400451D RID: 17693
		private ITetrisPlayModeBase Instance;
	}
}
