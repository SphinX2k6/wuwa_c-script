using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000404 RID: 1028
	[NullableContext(1)]
	[Nullable(0)]
	public class IGuideLineCreatorScanOption
	{
		// Token: 0x060014BB RID: 5307 RVA: 0x00041E68 File Offset: 0x00040068
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

		// Token: 0x060014BC RID: 5308 RVA: 0x00041EA0 File Offset: 0x000400A0
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

		// Token: 0x060014BD RID: 5309 RVA: 0x00041EB3 File Offset: 0x000400B3
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

		// Token: 0x060014BE RID: 5310 RVA: 0x00041EC6 File Offset: 0x000400C6
		public IGuideLineCreatorScanOption_SetValue ToSetValue()
		{
			return new IGuideLineCreatorScanOption_SetValue
			{
				ResponseRange = this.ResponseRange
			};
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x00041ED9 File Offset: 0x000400D9
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00041F04 File Offset: 0x00040104
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

		// Token: 0x0400103C RID: 4156
		[Nullable(2)]
		protected IGuideLineCreatorScanOption FbInstance;

		// Token: 0x0400103D RID: 4157
		[Nullable(2)]
		protected IGuideLineCreatorScanOption_SetValue PocoInterface;
	}
}
