using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E38 RID: 3640
	[NullableContext(1)]
	[Nullable(0)]
	public class IWellStreamingRenderSelfConfig
	{
		// Token: 0x06005241 RID: 21057 RVA: 0x000CAA05 File Offset: 0x000C8C05
		public static IWellStreamingRenderSelfConfig Create(IWellStreamingRenderSelfConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWellStreamingRenderSelfConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x000CAA24 File Offset: 0x000C8C24
		public virtual string RtActorRefKey
		{
			get
			{
				return this.Instance.RtActorRefKey;
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06005243 RID: 21059 RVA: 0x000CAA31 File Offset: 0x000C8C31
		public virtual string FallbackCubeMapKey
		{
			get
			{
				return this.Instance.FallbackCubeMapKey;
			}
		}

		// Token: 0x04002F67 RID: 12135
		private IWellStreamingRenderSelfConfig Instance;
	}
}
