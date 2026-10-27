using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002665 RID: 9829
	public class IHandInItemViewStyle : IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x0600DC45 RID: 56389 RVA: 0x0020C43E File Offset: 0x0020A63E
		[NullableContext(1)]
		public static IHandInItemViewStyle Create(IHandInItemViewStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItemViewStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x0600DC46 RID: 56390 RVA: 0x0020C45D File Offset: 0x0020A65D
		public override EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				return (EDeliverItemProbeCollectibleViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007A69 RID: 31337
		private IHandInItemViewStyle Instance;
	}
}
