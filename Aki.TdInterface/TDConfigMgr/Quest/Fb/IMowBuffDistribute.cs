using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F1 RID: 5361
	public class IMowBuffDistribute : IShowUi
	{
		// Token: 0x06007978 RID: 31096 RVA: 0x001223F5 File Offset: 0x001205F5
		public static IMowBuffDistribute Create(IMowBuffDistribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMowBuffDistribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x06007979 RID: 31097 RVA: 0x00122414 File Offset: 0x00120614
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600797A RID: 31098 RVA: 0x00122421 File Offset: 0x00120621
		public virtual int BoardId
		{
			get
			{
				return this.Instance.BoardId;
			}
		}

		// Token: 0x040045DF RID: 17887
		private IMowBuffDistribute Instance;
	}
}
