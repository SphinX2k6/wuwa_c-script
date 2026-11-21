using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA3 RID: 2979
	public class IAkEventTypeConfig
	{
		// Token: 0x06004424 RID: 17444 RVA: 0x000ACE5A File Offset: 0x000AB05A
		public static IAkEventTypeConfig Create(IAkEventTypeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAkEventTypeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x000ACE79 File Offset: 0x000AB079
		public virtual EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x040025BA RID: 9658
		private IAkEventTypeConfig Instance;
	}
}
