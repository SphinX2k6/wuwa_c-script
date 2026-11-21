using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B78 RID: 2936
	public class IDynamicEntityRewardType
	{
		// Token: 0x06004339 RID: 17209 RVA: 0x000AAACD File Offset: 0x000A8CCD
		public static IDynamicEntityRewardType Create(IDynamicEntityRewardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicEntityRewardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600433A RID: 17210 RVA: 0x000AAAEC File Offset: 0x000A8CEC
		public virtual EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x04002523 RID: 9507
		private IDynamicEntityRewardType Instance;
	}
}
