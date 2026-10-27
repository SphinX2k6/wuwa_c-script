using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AAF RID: 2735
	public class IDynamicTrafficReward : IDynamicEntityRewardType
	{
		// Token: 0x06003F12 RID: 16146 RVA: 0x000A150D File Offset: 0x0009F70D
		[NullableContext(1)]
		public static IDynamicTrafficReward Create(IDynamicTrafficReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicTrafficReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003F13 RID: 16147 RVA: 0x000A152C File Offset: 0x0009F72C
		public override EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x000A1539 File Offset: 0x0009F739
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x04002308 RID: 8968
		private IDynamicTrafficReward Instance;
	}
}
