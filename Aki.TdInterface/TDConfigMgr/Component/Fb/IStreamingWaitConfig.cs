using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E32 RID: 3634
	public class IStreamingWaitConfig
	{
		// Token: 0x0600522A RID: 21034 RVA: 0x000CA78C File Offset: 0x000C898C
		[NullableContext(1)]
		public static IStreamingWaitConfig Create(IStreamingWaitConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingWaitConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x000CA7AB File Offset: 0x000C89AB
		public virtual float MinWaitStreamDuration
		{
			get
			{
				return this.Instance.MinWaitStreamDuration;
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x000CA7B8 File Offset: 0x000C89B8
		public virtual float MaxWaitStreamDuration
		{
			get
			{
				return this.Instance.MaxWaitStreamDuration;
			}
		}

		// Token: 0x04002F59 RID: 12121
		private IStreamingWaitConfig Instance;
	}
}
