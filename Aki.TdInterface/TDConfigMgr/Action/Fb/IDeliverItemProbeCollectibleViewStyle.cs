using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002664 RID: 9828
	public class IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x0600DC42 RID: 56386 RVA: 0x0020C40A File Offset: 0x0020A60A
		[NullableContext(1)]
		public static IDeliverItemProbeCollectibleViewStyle Create(IDeliverItemProbeCollectibleViewStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectibleViewStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x0600DC43 RID: 56387 RVA: 0x0020C429 File Offset: 0x0020A629
		public virtual EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				return (EDeliverItemProbeCollectibleViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007A68 RID: 31336
		private IDeliverItemProbeCollectibleViewStyle Instance;
	}
}
