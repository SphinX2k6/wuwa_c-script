using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0D RID: 3085
	[NullableContext(2)]
	[Nullable(0)]
	public class IAudioEventConfig
	{
		// Token: 0x060046D0 RID: 18128 RVA: 0x000B2A3F File Offset: 0x000B0C3F
		[NullableContext(1)]
		public static IAudioEventConfig Create(IAudioEventConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioEventConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x000B2A5E File Offset: 0x000B0C5E
		public virtual string CollectAkEvent
		{
			get
			{
				return this.Instance.CollectAkEvent;
			}
		}

		// Token: 0x04002840 RID: 10304
		private IAudioEventConfig Instance;
	}
}
