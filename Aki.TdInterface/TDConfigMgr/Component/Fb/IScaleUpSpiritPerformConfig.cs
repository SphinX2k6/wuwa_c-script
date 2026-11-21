using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB8 RID: 3768
	[NullableContext(2)]
	[Nullable(0)]
	public class IScaleUpSpiritPerformConfig
	{
		// Token: 0x060054F2 RID: 21746 RVA: 0x000D0F71 File Offset: 0x000CF171
		[NullableContext(0)]
		public static IScaleUpSpiritPerformConfig Create(IScaleUpSpiritPerformConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScaleUpSpiritPerformConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x000D0F90 File Offset: 0x000CF190
		public virtual bool? IsInitHide
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsInitHide);
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x060054F4 RID: 21748 RVA: 0x000D0FC6 File Offset: 0x000CF1C6
		public virtual string AppearEffectDa
		{
			get
			{
				return this.Instance.AppearEffectDa;
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x060054F5 RID: 21749 RVA: 0x000D0FD3 File Offset: 0x000CF1D3
		public virtual string ScaleUpEffectDa
		{
			get
			{
				return this.Instance.ScaleUpEffectDa;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x000D0FE0 File Offset: 0x000CF1E0
		public virtual int? ScaleUpPerformTag
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ScaleUpPerformTag);
			}
		}

		// Token: 0x0400308D RID: 12429
		private IScaleUpSpiritPerformConfig Instance;
	}
}
