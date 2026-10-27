using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4D RID: 2893
	[NullableContext(2)]
	[Nullable(0)]
	public class IAngularVelocityConfig
	{
		// Token: 0x060042AA RID: 17066 RVA: 0x000AA367 File Offset: 0x000A8567
		[NullableContext(1)]
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

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x000AA386 File Offset: 0x000A8586
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

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x000AA3BA File Offset: 0x000A85BA
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

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x000AA3EE File Offset: 0x000A85EE
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

		// Token: 0x04002584 RID: 9604
		private IAngularVelocityConfig Instance;

		// Token: 0x04002585 RID: 9605
		private IRangedRandom _XCache;

		// Token: 0x04002586 RID: 9606
		private bool _XInited;

		// Token: 0x04002587 RID: 9607
		private IRangedRandom _YCache;

		// Token: 0x04002588 RID: 9608
		private bool _YInited;

		// Token: 0x04002589 RID: 9609
		private IRangedRandom _ZCache;

		// Token: 0x0400258A RID: 9610
		private bool _ZInited;
	}
}
