using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D57 RID: 3415
	public class TurntableControlComponent : IComponentBase
	{
		// Token: 0x06004DC2 RID: 19906 RVA: 0x000C208D File Offset: 0x000C028D
		public static TurntableControlComponent Create(ITurntableControlComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TurntableControlComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06004DC3 RID: 19907 RVA: 0x000C20AC File Offset: 0x000C02AC
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

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x000C20E4 File Offset: 0x000C02E4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06004DC5 RID: 19909 RVA: 0x000C20FA File Offset: 0x000C02FA
		public virtual ITurntableControlType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ComponentReadHelper.ReadTurntableControlComponent_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04002C24 RID: 11300
		private ITurntableControlComponent Instance;

		// Token: 0x04002C25 RID: 11301
		private ITurntableControlType _ConfigCache;

		// Token: 0x04002C26 RID: 11302
		private bool _ConfigInited;
	}
}
