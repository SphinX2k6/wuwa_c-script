using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C73 RID: 11379
	public class IPerformerAiMoveConfig
	{
		// Token: 0x0600FA04 RID: 64004 RVA: 0x00244A0E File Offset: 0x00242C0E
		public static IPerformerAiMoveConfig Create(IPerformerAiMoveConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x0600FA05 RID: 64005 RVA: 0x00244A2D File Offset: 0x00242C2D
		public virtual EPerformerAiMoveToType Type
		{
			get
			{
				return (EPerformerAiMoveToType)this.Instance.Type;
			}
		}

		// Token: 0x0400889B RID: 34971
		private IPerformerAiMoveConfig Instance;
	}
}
