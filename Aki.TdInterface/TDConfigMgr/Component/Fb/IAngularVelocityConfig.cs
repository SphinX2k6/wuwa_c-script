using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1B RID: 3099
	[NullableContext(2)]
	[Nullable(0)]
	public class IAngularVelocityConfig
	{
		// Token: 0x06004703 RID: 18179 RVA: 0x000B442B File Offset: 0x000B262B
		[NullableContext(0)]
		public static IAngularVelocityConfig Create(IAngularVelocityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAngularVelocityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x000B444A File Offset: 0x000B264A
		public virtual IRangedRandom X
		{
			get
			{
				if (this._XInited)
				{
					return this._XCache;
				}
				this._XInited = true;
				this._XCache = IRangedRandom.Create(this.Instance.X);
				return this._XCache;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06004705 RID: 18181 RVA: 0x000B447E File Offset: 0x000B267E
		public virtual IRangedRandom Y
		{
			get
			{
				if (this._YInited)
				{
					return this._YCache;
				}
				this._YInited = true;
				this._YCache = IRangedRandom.Create(this.Instance.Y);
				return this._YCache;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x000B44B2 File Offset: 0x000B26B2
		public virtual IRangedRandom Z
		{
			get
			{
				if (this._ZInited)
				{
					return this._ZCache;
				}
				this._ZInited = true;
				this._ZCache = IRangedRandom.Create(this.Instance.Z);
				return this._ZCache;
			}
		}

		// Token: 0x040027CC RID: 10188
		private IAngularVelocityConfig Instance;

		// Token: 0x040027CD RID: 10189
		private IRangedRandom _XCache;

		// Token: 0x040027CE RID: 10190
		private bool _XInited;

		// Token: 0x040027CF RID: 10191
		private IRangedRandom _YCache;

		// Token: 0x040027D0 RID: 10192
		private bool _YInited;

		// Token: 0x040027D1 RID: 10193
		private IRangedRandom _ZCache;

		// Token: 0x040027D2 RID: 10194
		private bool _ZInited;
	}
}
