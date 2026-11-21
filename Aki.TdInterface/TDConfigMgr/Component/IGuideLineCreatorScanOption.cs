using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200045D RID: 1117
	public class IGuideLineCreatorScanOption
	{
		// Token: 0x06001655 RID: 5717 RVA: 0x00045BB0 File Offset: 0x00043DB0
		private IGuideLineCreatorScanOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGuideLineCreatorScanOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGuideLineCreatorScanOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGuideLineCreatorScanOption_SetValue());
			}
			return result;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00045BE8 File Offset: 0x00043DE8
		public static IGuideLineCreatorScanOption Create([Nullable(2)] IGuideLineCreatorScanOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGuideLineCreatorScanOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00045BFB File Offset: 0x00043DFB
		public static IGuideLineCreatorScanOption CreateFromSetValue([Nullable(2)] IGuideLineCreatorScanOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGuideLineCreatorScanOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00045C0E File Offset: 0x00043E0E
		public IGuideLineCreatorScanOption_SetValue ToSetValue()
		{
			return new IGuideLineCreatorScanOption_SetValue
			{
				ResponseRange = this.ResponseRange
			};
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00045C21 File Offset: 0x00043E21
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x00045C4C File Offset: 0x00043E4C
		public virtual int ResponseRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResponseRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ResponseRange;
			}
			set
			{
				this.GetOrCreatePoco().ResponseRange = value;
			}
		}

		// Token: 0x0400115E RID: 4446
		[Nullable(2)]
		protected IGuideLineCreatorScanOption FbInstance;

		// Token: 0x0400115F RID: 4447
		[Nullable(2)]
		protected IGuideLineCreatorScanOption_SetValue PocoInterface;
	}
}
