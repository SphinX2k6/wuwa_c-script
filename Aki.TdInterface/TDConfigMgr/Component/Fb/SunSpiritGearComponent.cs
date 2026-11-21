using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EBA RID: 3770
	public class SunSpiritGearComponent : IComponentBase
	{
		// Token: 0x060054FD RID: 21757 RVA: 0x000D1093 File Offset: 0x000CF293
		public static SunSpiritGearComponent Create(ISunSpiritGearComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SunSpiritGearComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x060054FE RID: 21758 RVA: 0x000D10B4 File Offset: 0x000CF2B4
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

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x000D10EC File Offset: 0x000CF2EC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x000D1102 File Offset: 0x000CF302
		public virtual ISunSpiritGearPerformConfig PerformConfig
		{
			get
			{
				if (this._PerformConfigInited)
				{
					return this._PerformConfigCache;
				}
				this._PerformConfigInited = true;
				this._PerformConfigCache = ComponentReadHelper.ReadSunSpiritGearComponent_PerformConfig(this.Instance);
				return this._PerformConfigCache;
			}
		}

		// Token: 0x04003091 RID: 12433
		private ISunSpiritGearComponent Instance;

		// Token: 0x04003092 RID: 12434
		private ISunSpiritGearPerformConfig _PerformConfigCache;

		// Token: 0x04003093 RID: 12435
		private bool _PerformConfigInited;
	}
}
