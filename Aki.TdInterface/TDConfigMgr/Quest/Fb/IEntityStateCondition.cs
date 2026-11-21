using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014AC RID: 5292
	public class IEntityStateCondition
	{
		// Token: 0x06007818 RID: 30744 RVA: 0x0011FCB5 File Offset: 0x0011DEB5
		public static IEntityStateCondition Create(IEntityStateCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityStateCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x06007819 RID: 30745 RVA: 0x0011FCD4 File Offset: 0x0011DED4
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x0600781A RID: 30746 RVA: 0x0011FCE1 File Offset: 0x0011DEE1
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04004508 RID: 17672
		private IEntityStateCondition Instance;
	}
}
