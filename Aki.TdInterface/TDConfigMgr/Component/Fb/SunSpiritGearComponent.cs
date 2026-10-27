using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBE RID: 3518
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritGearComponent : IComponentBase
	{
		// Token: 0x06004FD8 RID: 20440 RVA: 0x000C5843 File Offset: 0x000C3A43
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

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x000C5864 File Offset: 0x000C3A64
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

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x000C589C File Offset: 0x000C3A9C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x000C58B2 File Offset: 0x000C3AB2
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

		// Token: 0x04002DCB RID: 11723
		private ISunSpiritGearComponent Instance;

		// Token: 0x04002DCC RID: 11724
		private ISunSpiritGearPerformConfig _PerformConfigCache;

		// Token: 0x04002DCD RID: 11725
		private bool _PerformConfigInited;
	}
}
