using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD6 RID: 7382
	public class IInformationViewConfig
	{
		// Token: 0x06009CB8 RID: 40120 RVA: 0x0016923C File Offset: 0x0016743C
		private IInformationViewConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInformationViewConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInformationViewConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInformationViewConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009CB9 RID: 40121 RVA: 0x00169274 File Offset: 0x00167474
		public static IInformationViewConfig Create([Nullable(2)] IInformationViewConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationViewConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x00169287 File Offset: 0x00167487
		public static IInformationViewConfig CreateFromSetValue([Nullable(2)] IInformationViewConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInformationViewConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x0016929A File Offset: 0x0016749A
		public IInformationViewConfig_SetValue ToSetValue()
		{
			return new IInformationViewConfig_SetValue
			{
				InfoDisplayGroup = this.InfoDisplayGroup
			};
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06009CBC RID: 40124 RVA: 0x001692B0 File Offset: 0x001674B0
		// (set) Token: 0x06009CBD RID: 40125 RVA: 0x001692EA File Offset: 0x001674EA
		public virtual int? InfoDisplayGroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InfoDisplayGroup;
				}
				IInformationViewConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InfoDisplayGroup;
			}
			set
			{
				this.GetOrCreatePoco().InfoDisplayGroup = value;
			}
		}

		// Token: 0x04005FC5 RID: 24517
		[Nullable(2)]
		protected IInformationViewConfig FbInstance;

		// Token: 0x04005FC6 RID: 24518
		[Nullable(2)]
		protected IInformationViewConfig_SetValue PocoInterface;
	}
}
