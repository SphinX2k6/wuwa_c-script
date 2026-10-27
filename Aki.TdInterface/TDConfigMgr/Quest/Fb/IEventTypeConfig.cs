using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141F RID: 5151
	public class IEventTypeConfig
	{
		// Token: 0x06007508 RID: 29960 RVA: 0x00117A79 File Offset: 0x00115C79
		[NullableContext(1)]
		public static IEventTypeConfig Create(IEventTypeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEventTypeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x00117A98 File Offset: 0x00115C98
		public virtual ECommonEventType Type
		{
			get
			{
				return (ECommonEventType)this.Instance.Type;
			}
		}

		// Token: 0x040043CF RID: 17359
		private IEventTypeConfig Instance;
	}
}
