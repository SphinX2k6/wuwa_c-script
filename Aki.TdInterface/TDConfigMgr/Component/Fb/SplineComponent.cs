using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D40 RID: 3392
	public class SplineComponent : IComponentBase
	{
		// Token: 0x06004D4A RID: 19786 RVA: 0x000C11D9 File Offset: 0x000BF3D9
		public static SplineComponent Create(ISplineComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SplineComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x000C11F8 File Offset: 0x000BF3F8
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

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x000C1230 File Offset: 0x000BF430
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x000C1246 File Offset: 0x000BF446
		public virtual ISplineType Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ComponentReadHelper.ReadSplineComponent_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x04002BE1 RID: 11233
		private ISplineComponent Instance;

		// Token: 0x04002BE2 RID: 11234
		private ISplineType _OptionCache;

		// Token: 0x04002BE3 RID: 11235
		private bool _OptionInited;
	}
}
