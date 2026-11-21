using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF8 RID: 3576
	public class PortalComponent : IComponentBase
	{
		// Token: 0x06005107 RID: 20743 RVA: 0x000C8CFB File Offset: 0x000C6EFB
		public static PortalComponent Create(IPortalComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PortalComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x000C8D1C File Offset: 0x000C6F1C
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

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06005109 RID: 20745 RVA: 0x000C8D54 File Offset: 0x000C6F54
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x000C8D6A File Offset: 0x000C6F6A
		public virtual IPortalMode Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ComponentReadHelper.ReadPortalComponent_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04002E29 RID: 11817
		private IPortalComponent Instance;

		// Token: 0x04002E2A RID: 11818
		private IPortalMode _ConfigCache;

		// Token: 0x04002E2B RID: 11819
		private bool _ConfigInited;
	}
}
