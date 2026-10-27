using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C78 RID: 3192
	[NullableContext(1)]
	[Nullable(0)]
	public class TurntableControlComponent : IComponentBase
	{
		// Token: 0x06004923 RID: 18723 RVA: 0x000B7889 File Offset: 0x000B5A89
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

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x000B78A8 File Offset: 0x000B5AA8
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

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x000B78E0 File Offset: 0x000B5AE0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x000B78F6 File Offset: 0x000B5AF6
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

		// Token: 0x040029B7 RID: 10679
		private ITurntableControlComponent Instance;

		// Token: 0x040029B8 RID: 10680
		private ITurntableControlType _ConfigCache;

		// Token: 0x040029B9 RID: 10681
		private bool _ConfigInited;
	}
}
