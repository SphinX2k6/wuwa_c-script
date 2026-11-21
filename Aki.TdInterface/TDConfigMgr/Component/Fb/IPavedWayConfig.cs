using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3A RID: 3386
	public class IPavedWayConfig
	{
		// Token: 0x06004D1A RID: 19738 RVA: 0x000C0A20 File Offset: 0x000BEC20
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

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x000C0A3F File Offset: 0x000BEC3F
		public virtual bool AutoSprint
		{
			get
			{
				return this.Instance.AutoSprint;
			}
		}

		// Token: 0x04002BBF RID: 11199
		private IPavedWayConfig Instance;
	}
}
