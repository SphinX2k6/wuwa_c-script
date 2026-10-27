using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AD8 RID: 2776
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioRangeConfig
	{
		// Token: 0x06003FF7 RID: 16375 RVA: 0x000A3832 File Offset: 0x000A1A32
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

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06003FF8 RID: 16376 RVA: 0x000A3851 File Offset: 0x000A1A51
		public virtual string LeaveAkEvent
		{
			get
			{
				return this.Instance.LeaveAkEvent;
			}
		}

		// Token: 0x0400239D RID: 9117
		private IAudioRangeConfig Instance;
	}
}
