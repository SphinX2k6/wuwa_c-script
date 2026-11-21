using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E99 RID: 3737
	public class IChargeSlashControl : ICurveControlConfig
	{
		// Token: 0x0600545E RID: 21598 RVA: 0x000CFEC2 File Offset: 0x000CE0C2
		public static IChargeSlashControl Create(IChargeSlashControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChargeSlashControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x000CFEE1 File Offset: 0x000CE0E1
		public override ECurveControlType Type
		{
			get
			{
				return (ECurveControlType)this.Instance.Type;
			}
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06005460 RID: 21600 RVA: 0x000CFEEE File Offset: 0x000CE0EE
		public virtual int UpHeight
		{
			get
			{
				return this.Instance.UpHeight;
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06005461 RID: 21601 RVA: 0x000CFEFB File Offset: 0x000CE0FB
		[Nullable(2)]
		public virtual string UpCurvePath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.UpCurvePath;
			}
		}

		// Token: 0x04003044 RID: 12356
		private IChargeSlashControl Instance;
	}
}
