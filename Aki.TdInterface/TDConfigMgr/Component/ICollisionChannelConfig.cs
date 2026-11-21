using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200028C RID: 652
	public class ICollisionChannelConfig
	{
		// Token: 0x06000BA0 RID: 2976 RVA: 0x0002E818 File Offset: 0x0002CA18
		private ICollisionChannelConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICollisionChannelConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICollisionChannelConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICollisionChannelConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0002E850 File Offset: 0x0002CA50
		public static ICollisionChannelConfig Create([Nullable(2)] ICollisionChannelConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICollisionChannelConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0002E863 File Offset: 0x0002CA63
		public static ICollisionChannelConfig CreateFromSetValue([Nullable(2)] ICollisionChannelConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICollisionChannelConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0002E876 File Offset: 0x0002CA76
		public ICollisionChannelConfig_SetValue ToSetValue()
		{
			return new ICollisionChannelConfig_SetValue
			{
				OverrideCollisionChannel = this.OverrideCollisionChannel
			};
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0002E88C File Offset: 0x0002CA8C
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0002E8ED File Offset: 0x0002CAED
		[Nullable(2)]
		public virtual IOverrideCollisionChannel OverrideCollisionChannel
		{
			[NullableContext(2)]
			get
			{
				if (this._OverrideCollisionChannelInited)
				{
					return this._OverrideCollisionChannelCache;
				}
				this._OverrideCollisionChannelInited = true;
				if (this.FbInstance != null)
				{
					this._OverrideCollisionChannelCache = IOverrideCollisionChannel.Create(this.FbInstance.OverrideCollisionChannel);
				}
				else
				{
					ICollisionChannelConfig_SetValue pocoInterface = this.PocoInterface;
					this._OverrideCollisionChannelCache = ((pocoInterface != null) ? pocoInterface.OverrideCollisionChannel : null);
				}
				return this._OverrideCollisionChannelCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OverrideCollisionChannel = value;
				this._OverrideCollisionChannelInited = false;
			}
		}

		// Token: 0x04000B5A RID: 2906
		[Nullable(2)]
		protected ICollisionChannelConfig FbInstance;

		// Token: 0x04000B5B RID: 2907
		[Nullable(2)]
		protected ICollisionChannelConfig_SetValue PocoInterface;

		// Token: 0x04000B5C RID: 2908
		private IOverrideCollisionChannel _OverrideCollisionChannelCache;

		// Token: 0x04000B5D RID: 2909
		private bool _OverrideCollisionChannelInited;
	}
}
