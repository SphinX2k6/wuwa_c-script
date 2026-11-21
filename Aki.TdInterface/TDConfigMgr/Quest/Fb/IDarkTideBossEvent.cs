using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001439 RID: 5177
	public class IDarkTideBossEvent
	{
		// Token: 0x06007531 RID: 30001 RVA: 0x001198CD File Offset: 0x00117ACD
		public static IDarkTideBossEvent Create(IDarkTideBossEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideBossEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x06007532 RID: 30002 RVA: 0x001198EC File Offset: 0x00117AEC
		public virtual EDarkTideBossEventType Type
		{
			get
			{
				return (EDarkTideBossEventType)this.Instance.Type;
			}
		}

		// Token: 0x040042DF RID: 17119
		private IDarkTideBossEvent Instance;
	}
}
