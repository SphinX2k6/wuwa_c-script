using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D92 RID: 3474
	[NullableContext(1)]
	[Nullable(0)]
	public class WindSourceComponent : IComponentBase
	{
		// Token: 0x06004EFF RID: 20223 RVA: 0x000C3E21 File Offset: 0x000C2021
		public static WindSourceComponent Create(IWindSourceComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WindSourceComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06004F00 RID: 20224 RVA: 0x000C3E40 File Offset: 0x000C2040
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x000C3E78 File Offset: 0x000C2078
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x000C3E8E File Offset: 0x000C208E
		public virtual IWindDirectional WindSource
		{
			get
			{
				if (this._WindSourceInited)
				{
					return this._WindSourceCache;
				}
				this._WindSourceInited = true;
				this._WindSourceCache = IWindDirectional.Create(this.Instance.WindSource);
				return this._WindSourceCache;
			}
		}

		// Token: 0x04002D69 RID: 11625
		private IWindSourceComponent Instance;

		// Token: 0x04002D6A RID: 11626
		[Nullable(2)]
		private IWindDirectional _WindSourceCache;

		// Token: 0x04002D6B RID: 11627
		private bool _WindSourceInited;
	}
}
