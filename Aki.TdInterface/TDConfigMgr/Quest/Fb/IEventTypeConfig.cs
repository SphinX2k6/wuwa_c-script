using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001577 RID: 5495
	public class IEventTypeConfig
	{
		// Token: 0x06007BCD RID: 31693 RVA: 0x001264C5 File Offset: 0x001246C5
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

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x06007BCE RID: 31694 RVA: 0x001264E4 File Offset: 0x001246E4
		public virtual ECommonEventType Type
		{
			get
			{
				return (ECommonEventType)this.Instance.Type;
			}
		}

		// Token: 0x04004763 RID: 18275
		private IEventTypeConfig Instance;
	}
}
