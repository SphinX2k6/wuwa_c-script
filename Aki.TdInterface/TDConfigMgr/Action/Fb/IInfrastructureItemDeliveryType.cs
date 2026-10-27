using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A0 RID: 10656
	public class IInfrastructureItemDeliveryType
	{
		// Token: 0x0600EBDB RID: 60379 RVA: 0x002279AA File Offset: 0x00225BAA
		[NullableContext(1)]
		public static IInfrastructureItemDeliveryType Create(IInfrastructureItemDeliveryType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x0600EBDC RID: 60380 RVA: 0x002279C9 File Offset: 0x00225BC9
		public virtual EInfrastructureItemDeliveryType Type
		{
			get
			{
				return (EInfrastructureItemDeliveryType)this.Instance.Type;
			}
		}

		// Token: 0x040081E2 RID: 33250
		private IInfrastructureItemDeliveryType Instance;
	}
}
