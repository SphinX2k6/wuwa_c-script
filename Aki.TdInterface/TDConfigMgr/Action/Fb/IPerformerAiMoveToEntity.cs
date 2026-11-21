using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C75 RID: 11381
	public class IPerformerAiMoveToEntity : IPerformerAiMoveConfig
	{
		// Token: 0x0600FA0B RID: 64011 RVA: 0x00244AAA File Offset: 0x00242CAA
		public static IPerformerAiMoveToEntity Create(IPerformerAiMoveToEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveToEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x0600FA0C RID: 64012 RVA: 0x00244AC9 File Offset: 0x00242CC9
		public override EPerformerAiMoveToType Type
		{
			get
			{
				return (EPerformerAiMoveToType)this.Instance.Type;
			}
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x0600FA0D RID: 64013 RVA: 0x00244AD6 File Offset: 0x00242CD6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x0400889F RID: 34975
		private IPerformerAiMoveToEntity Instance;
	}
}
