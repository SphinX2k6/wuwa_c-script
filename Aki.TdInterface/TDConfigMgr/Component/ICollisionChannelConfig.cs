using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024B RID: 587
	[NullableContext(1)]
	[Nullable(0)]
	public class ICollisionChannelConfig
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x0002BC68 File Offset: 0x00029E68
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

		// Token: 0x06000A93 RID: 2707 RVA: 0x0002BCA0 File Offset: 0x00029EA0
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

		// Token: 0x06000A94 RID: 2708 RVA: 0x0002BCB3 File Offset: 0x00029EB3
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

		// Token: 0x06000A95 RID: 2709 RVA: 0x0002BCC6 File Offset: 0x00029EC6
		public ICollisionChannelConfig_SetValue ToSetValue()
		{
			return new ICollisionChannelConfig_SetValue
			{
				OverrideCollisionChannel = this.OverrideCollisionChannel
			};
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002BCDC File Offset: 0x00029EDC
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0002BD3D File Offset: 0x00029F3D
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

		// Token: 0x04000A7E RID: 2686
		[Nullable(2)]
		protected ICollisionChannelConfig FbInstance;

		// Token: 0x04000A7F RID: 2687
		[Nullable(2)]
		protected ICollisionChannelConfig_SetValue PocoInterface;

		// Token: 0x04000A80 RID: 2688
		private IOverrideCollisionChannel _OverrideCollisionChannelCache;

		// Token: 0x04000A81 RID: 2689
		private bool _OverrideCollisionChannelInited;
	}
}
