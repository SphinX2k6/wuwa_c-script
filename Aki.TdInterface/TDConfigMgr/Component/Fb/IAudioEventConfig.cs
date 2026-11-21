using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CDD RID: 3293
	public class IAudioEventConfig
	{
		// Token: 0x06004B33 RID: 19251 RVA: 0x000BCC0B File Offset: 0x000BAE0B
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

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x000BCC2A File Offset: 0x000BAE2A
		[Nullable(2)]
		public virtual string CollectAkEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CollectAkEvent;
			}
		}

		// Token: 0x04002A8C RID: 10892
		private IAudioEventConfig Instance;
	}
}
