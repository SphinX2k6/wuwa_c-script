using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015AF RID: 5551
	public class IRecallConfig
	{
		// Token: 0x06007D25 RID: 32037 RVA: 0x0012966C File Offset: 0x0012786C
		public static IRecallConfig Create(IRecallConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x0012968B File Offset: 0x0012788B
		public virtual int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x0400484F RID: 18511
		private IRecallConfig Instance;
	}
}
