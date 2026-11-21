using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F34 RID: 3892
	public class IWellStreamingRenderSelfConfig
	{
		// Token: 0x06005768 RID: 22376 RVA: 0x000D62CD File Offset: 0x000D44CD
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

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06005769 RID: 22377 RVA: 0x000D62EC File Offset: 0x000D44EC
		public virtual string RtActorRefKey
		{
			get
			{
				return this.Instance.RtActorRefKey;
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x000D62F9 File Offset: 0x000D44F9
		public virtual string FallbackCubeMapKey
		{
			get
			{
				return this.Instance.FallbackCubeMapKey;
			}
		}

		// Token: 0x0400322F RID: 12847
		private IWellStreamingRenderSelfConfig Instance;
	}
}
