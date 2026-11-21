using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA2 RID: 2978
	public class IAudioRangeConfig
	{
		// Token: 0x06004421 RID: 17441 RVA: 0x000ACE26 File Offset: 0x000AB026
		public static IAudioRangeConfig Create(IAudioRangeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioRangeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x000ACE45 File Offset: 0x000AB045
		public virtual string LeaveAkEvent
		{
			get
			{
				return this.Instance.LeaveAkEvent;
			}
		}

		// Token: 0x040025B9 RID: 9657
		private IAudioRangeConfig Instance;
	}
}
