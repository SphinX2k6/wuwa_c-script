using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200267F RID: 9855
	public class IClaimDynamicEntityRewardType
	{
		// Token: 0x0600DCC9 RID: 56521 RVA: 0x0020D4FD File Offset: 0x0020B6FD
		[NullableContext(1)]
		public static IClaimDynamicEntityRewardType Create(IClaimDynamicEntityRewardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClaimDynamicEntityRewardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x0600DCCA RID: 56522 RVA: 0x0020D51C File Offset: 0x0020B71C
		public virtual EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x04007AAF RID: 31407
		private IClaimDynamicEntityRewardType Instance;
	}
}
