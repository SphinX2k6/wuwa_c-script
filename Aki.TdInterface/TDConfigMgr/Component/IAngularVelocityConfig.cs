using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C3 RID: 451
	[NullableContext(2)]
	[Nullable(0)]
	public class IAngularVelocityConfig
	{
		// Token: 0x0600072A RID: 1834 RVA: 0x000246C8 File Offset: 0x000228C8
		[NullableContext(1)]
		private IAngularVelocityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAngularVelocityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAngularVelocityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAngularVelocityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00024700 File Offset: 0x00022900
		[NullableContext(1)]
		public static IAngularVelocityConfig Create([Nullable(2)] IAngularVelocityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAngularVelocityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00024713 File Offset: 0x00022913
		[NullableContext(1)]
		public static IAngularVelocityConfig CreateFromSetValue([Nullable(2)] IAngularVelocityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAngularVelocityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00024726 File Offset: 0x00022926
		[NullableContext(1)]
		public IAngularVelocityConfig_SetValue ToSetValue()
		{
			return new IAngularVelocityConfig_SetValue
			{
				X = this.X,
				Y = this.Y,
				Z = this.Z
			};
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00024754 File Offset: 0x00022954
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x000247B5 File Offset: 0x000229B5
		public virtual IRangedRandom X
		{
			get
			{
				if (this._XInited)
				{
					return this._XCache;
				}
				this._XInited = true;
				if (this.FbInstance != null)
				{
					this._XCache = IRangedRandom.Create(this.FbInstance.X);
				}
				else
				{
					IAngularVelocityConfig_SetValue pocoInterface = this.PocoInterface;
					this._XCache = ((pocoInterface != null) ? pocoInterface.X : null);
				}
				return this._XCache;
			}
			set
			{
				this.GetOrCreatePoco().X = value;
				this._XInited = false;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000247CC File Offset: 0x000229CC
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0002482D File Offset: 0x00022A2D
		public virtual IRangedRandom Y
		{
			get
			{
				if (this._YInited)
				{
					return this._YCache;
				}
				this._YInited = true;
				if (this.FbInstance != null)
				{
					this._YCache = IRangedRandom.Create(this.FbInstance.Y);
				}
				else
				{
					IAngularVelocityConfig_SetValue pocoInterface = this.PocoInterface;
					this._YCache = ((pocoInterface != null) ? pocoInterface.Y : null);
				}
				return this._YCache;
			}
			set
			{
				this.GetOrCreatePoco().Y = value;
				this._YInited = false;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00024844 File Offset: 0x00022A44
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x000248A5 File Offset: 0x00022AA5
		public virtual IRangedRandom Z
		{
			get
			{
				if (this._ZInited)
				{
					return this._ZCache;
				}
				this._ZInited = true;
				if (this.FbInstance != null)
				{
					this._ZCache = IRangedRandom.Create(this.FbInstance.Z);
				}
				else
				{
					IAngularVelocityConfig_SetValue pocoInterface = this.PocoInterface;
					this._ZCache = ((pocoInterface != null) ? pocoInterface.Z : null);
				}
				return this._ZCache;
			}
			set
			{
				this.GetOrCreatePoco().Z = value;
				this._ZInited = false;
			}
		}

		// Token: 0x0400087C RID: 2172
		protected IAngularVelocityConfig FbInstance;

		// Token: 0x0400087D RID: 2173
		protected IAngularVelocityConfig_SetValue PocoInterface;

		// Token: 0x0400087E RID: 2174
		[Nullable(1)]
		private IRangedRandom _XCache;

		// Token: 0x0400087F RID: 2175
		private bool _XInited;

		// Token: 0x04000880 RID: 2176
		[Nullable(1)]
		private IRangedRandom _YCache;

		// Token: 0x04000881 RID: 2177
		private bool _YInited;

		// Token: 0x04000882 RID: 2178
		[Nullable(1)]
		private IRangedRandom _ZCache;

		// Token: 0x04000883 RID: 2179
		private bool _ZInited;
	}
}
