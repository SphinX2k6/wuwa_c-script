using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBC RID: 3516
	[NullableContext(2)]
	[Nullable(0)]
	public class IScaleUpSpiritPerformConfig
	{
		// Token: 0x06004FCD RID: 20429 RVA: 0x000C5721 File Offset: 0x000C3921
		[NullableContext(1)]
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

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06004FCE RID: 20430 RVA: 0x000C5740 File Offset: 0x000C3940
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

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x000C5776 File Offset: 0x000C3976
		public virtual string AppearEffectDa
		{
			get
			{
				return this.Instance.AppearEffectDa;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x000C5783 File Offset: 0x000C3983
		public virtual string ScaleUpEffectDa
		{
			get
			{
				return this.Instance.ScaleUpEffectDa;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x000C5790 File Offset: 0x000C3990
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

		// Token: 0x04002DC7 RID: 11719
		private IScaleUpSpiritPerformConfig Instance;
	}
}
