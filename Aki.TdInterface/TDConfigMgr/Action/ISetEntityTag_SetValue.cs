using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002050 RID: 8272
	public class ISetEntityTag_SetValue
	{
		// Token: 0x04006884 RID: 26756
		public int EntityId;

		// Token: 0x04006885 RID: 26757
		public string GameplayTag;

		// Token: 0x04006886 RID: 26758
		public ESetEntityTagType SetType;

		// Token: 0x04006887 RID: 26759
		public float? DelayTime;

		// Token: 0x04006888 RID: 26760
		public bool? BeforeHide;
	}
}
