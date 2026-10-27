using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CEA RID: 3306
	[NullableContext(2)]
	[Nullable(0)]
	public class ICollisionChannelConfig
	{
		// Token: 0x06004B7F RID: 19327 RVA: 0x000BC7FE File Offset: 0x000BA9FE
		[NullableContext(1)]
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

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x000BC81D File Offset: 0x000BAA1D
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

		// Token: 0x04002B29 RID: 11049
		private ICollisionChannelConfig Instance;

		// Token: 0x04002B2A RID: 11050
		private IOverrideCollisionChannel _OverrideCollisionChannelCache;

		// Token: 0x04002B2B RID: 11051
		private bool _OverrideCollisionChannelInited;
	}
}
