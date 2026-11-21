using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ED4 RID: 3796
	public class ExhibitComponent : IComponentBase
	{
		// Token: 0x0600558B RID: 21899 RVA: 0x000D2244 File Offset: 0x000D0444
		public static ExhibitComponent Create(IExhibitComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExhibitComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x0600558C RID: 21900 RVA: 0x000D2264 File Offset: 0x000D0464
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

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x000D229C File Offset: 0x000D049C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x0600558E RID: 21902 RVA: 0x000D22B2 File Offset: 0x000D04B2
		public virtual IExhibitItemType ExhibitConfig
		{
			get
			{
				if (this._ExhibitConfigInited)
				{
					return this._ExhibitConfigCache;
				}
				this._ExhibitConfigInited = true;
				this._ExhibitConfigCache = ComponentReadHelper.ReadExhibitComponent_ExhibitConfig(this.Instance);
				return this._ExhibitConfigCache;
			}
		}

		// Token: 0x040030ED RID: 12525
		private IExhibitComponent Instance;

		// Token: 0x040030EE RID: 12526
		private IExhibitItemType _ExhibitConfigCache;

		// Token: 0x040030EF RID: 12527
		private bool _ExhibitConfigInited;
	}
}
