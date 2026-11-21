using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E6 RID: 486
	[NullableContext(2)]
	[Nullable(0)]
	public class IAngularVelocityConfig
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x000259CC File Offset: 0x00023BCC
		[NullableContext(0)]
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

		// Token: 0x0600077F RID: 1919 RVA: 0x00025A04 File Offset: 0x00023C04
		[NullableContext(0)]
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

		// Token: 0x06000780 RID: 1920 RVA: 0x00025A17 File Offset: 0x00023C17
		[NullableContext(0)]
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

		// Token: 0x06000781 RID: 1921 RVA: 0x00025A2A File Offset: 0x00023C2A
		[NullableContext(0)]
		public IAngularVelocityConfig_SetValue ToSetValue()
		{
			return new IAngularVelocityConfig_SetValue
			{
				X = this.X,
				Y = this.Y,
				Z = this.Z
			};
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00025A58 File Offset: 0x00023C58
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00025AB9 File Offset: 0x00023CB9
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00025AD0 File Offset: 0x00023CD0
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00025B31 File Offset: 0x00023D31
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00025B48 File Offset: 0x00023D48
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00025BA9 File Offset: 0x00023DA9
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

		// Token: 0x040008F0 RID: 2288
		protected IAngularVelocityConfig FbInstance;

		// Token: 0x040008F1 RID: 2289
		protected IAngularVelocityConfig_SetValue PocoInterface;

		// Token: 0x040008F2 RID: 2290
		[Nullable(0)]
		private IRangedRandom _XCache;

		// Token: 0x040008F3 RID: 2291
		private bool _XInited;

		// Token: 0x040008F4 RID: 2292
		[Nullable(0)]
		private IRangedRandom _YCache;

		// Token: 0x040008F5 RID: 2293
		private bool _YInited;

		// Token: 0x040008F6 RID: 2294
		[Nullable(0)]
		private IRangedRandom _ZCache;

		// Token: 0x040008F7 RID: 2295
		private bool _ZInited;
	}
}
