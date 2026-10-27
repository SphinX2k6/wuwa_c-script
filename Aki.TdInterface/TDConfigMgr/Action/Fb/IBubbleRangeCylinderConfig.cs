using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002716 RID: 10006
	[NullableContext(1)]
	[Nullable(0)]
	public class IBubbleRangeCylinderConfig
	{
		// Token: 0x0600DF2F RID: 57135 RVA: 0x002112E2 File Offset: 0x0020F4E2
		public static IBubbleRangeCylinderConfig Create(IBubbleRangeCylinderConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleRangeCylinderConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x0600DF30 RID: 57136 RVA: 0x00211301 File Offset: 0x0020F501
		public virtual IBubbleCylinderConfig InnerConfig
		{
			get
			{
				if (this._InnerConfigInited)
				{
					return this._InnerConfigCache;
				}
				this._InnerConfigInited = true;
				this._InnerConfigCache = IBubbleCylinderConfig.Create(this.Instance.InnerConfig);
				return this._InnerConfigCache;
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x0600DF31 RID: 57137 RVA: 0x00211335 File Offset: 0x0020F535
		public virtual IBubbleCylinderConfig OuterConfig
		{
			get
			{
				if (this._OuterConfigInited)
				{
					return this._OuterConfigCache;
				}
				this._OuterConfigInited = true;
				this._OuterConfigCache = IBubbleCylinderConfig.Create(this.Instance.OuterConfig);
				return this._OuterConfigCache;
			}
		}

		// Token: 0x04007BD8 RID: 31704
		private IBubbleRangeCylinderConfig Instance;

		// Token: 0x04007BD9 RID: 31705
		[Nullable(2)]
		private IBubbleCylinderConfig _InnerConfigCache;

		// Token: 0x04007BDA RID: 31706
		private bool _InnerConfigInited;

		// Token: 0x04007BDB RID: 31707
		[Nullable(2)]
		private IBubbleCylinderConfig _OuterConfigCache;

		// Token: 0x04007BDC RID: 31708
		private bool _OuterConfigInited;
	}
}
