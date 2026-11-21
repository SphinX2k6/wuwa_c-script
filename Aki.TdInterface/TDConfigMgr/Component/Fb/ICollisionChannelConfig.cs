using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE2 RID: 3554
	[NullableContext(2)]
	[Nullable(0)]
	public class ICollisionChannelConfig
	{
		// Token: 0x0600508C RID: 20620 RVA: 0x000C7CB2 File Offset: 0x000C5EB2
		[NullableContext(0)]
		public static ICollisionChannelConfig Create(ICollisionChannelConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICollisionChannelConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x000C7CD1 File Offset: 0x000C5ED1
		public virtual IOverrideCollisionChannel OverrideCollisionChannel
		{
			get
			{
				if (this._OverrideCollisionChannelInited)
				{
					return this._OverrideCollisionChannelCache;
				}
				this._OverrideCollisionChannelInited = true;
				this._OverrideCollisionChannelCache = IOverrideCollisionChannel.Create(this.Instance.OverrideCollisionChannel);
				return this._OverrideCollisionChannelCache;
			}
		}

		// Token: 0x04002DE1 RID: 11745
		private ICollisionChannelConfig Instance;

		// Token: 0x04002DE2 RID: 11746
		private IOverrideCollisionChannel _OverrideCollisionChannelCache;

		// Token: 0x04002DE3 RID: 11747
		private bool _OverrideCollisionChannelInited;
	}
}
