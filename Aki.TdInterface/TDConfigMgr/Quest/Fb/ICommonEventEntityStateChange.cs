using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001421 RID: 5153
	public class ICommonEventEntityStateChange : IEventTypeConfig
	{
		// Token: 0x0600750F RID: 29967 RVA: 0x00117B10 File Offset: 0x00115D10
		[NullableContext(1)]
		public static ICommonEventEntityStateChange Create(ICommonEventEntityStateChange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonEventEntityStateChange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x06007510 RID: 29968 RVA: 0x00117B2F File Offset: 0x00115D2F
		public override ECommonEventType Type
		{
			get
			{
				return (ECommonEventType)this.Instance.Type;
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x00117B3C File Offset: 0x00115D3C
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040043D3 RID: 17363
		private ICommonEventEntityStateChange Instance;
	}
}
