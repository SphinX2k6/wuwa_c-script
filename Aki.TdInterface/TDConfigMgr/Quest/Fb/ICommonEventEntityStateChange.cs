using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001579 RID: 5497
	public class ICommonEventEntityStateChange : IEventTypeConfig
	{
		// Token: 0x06007BD4 RID: 31700 RVA: 0x0012655C File Offset: 0x0012475C
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

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x06007BD5 RID: 31701 RVA: 0x0012657B File Offset: 0x0012477B
		public override ECommonEventType Type
		{
			get
			{
				return (ECommonEventType)this.Instance.Type;
			}
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x06007BD6 RID: 31702 RVA: 0x00126588 File Offset: 0x00124788
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04004767 RID: 18279
		private ICommonEventEntityStateChange Instance;
	}
}
