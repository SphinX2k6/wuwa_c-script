using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C67 RID: 3175
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineComponent : IComponentBase
	{
		// Token: 0x060048C5 RID: 18629 RVA: 0x000B6BE5 File Offset: 0x000B4DE5
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

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x060048C6 RID: 18630 RVA: 0x000B6C04 File Offset: 0x000B4E04
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

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x000B6C3C File Offset: 0x000B4E3C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x060048C8 RID: 18632 RVA: 0x000B6C52 File Offset: 0x000B4E52
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

		// Token: 0x04002980 RID: 10624
		private ISplineComponent Instance;

		// Token: 0x04002981 RID: 10625
		private ISplineType _OptionCache;

		// Token: 0x04002982 RID: 10626
		private bool _OptionInited;
	}
}
