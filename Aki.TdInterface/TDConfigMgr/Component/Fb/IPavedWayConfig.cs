using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C61 RID: 3169
	public class IPavedWayConfig
	{
		// Token: 0x06004895 RID: 18581 RVA: 0x000B642C File Offset: 0x000B462C
		[NullableContext(1)]
		public static IPavedWayConfig Create(IPavedWayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPavedWayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x000B644B File Offset: 0x000B464B
		public virtual bool AutoSprint
		{
			get
			{
				return this.Instance.AutoSprint;
			}
		}

		// Token: 0x0400295E RID: 10590
		private IPavedWayConfig Instance;
	}
}
