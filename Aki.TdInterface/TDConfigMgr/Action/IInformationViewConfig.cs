using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B27 RID: 6951
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationViewConfig
	{
		// Token: 0x060094CE RID: 38094 RVA: 0x00158560 File Offset: 0x00156760
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

		// Token: 0x060094CF RID: 38095 RVA: 0x00158598 File Offset: 0x00156798
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

		// Token: 0x060094D0 RID: 38096 RVA: 0x001585AB File Offset: 0x001567AB
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

		// Token: 0x060094D1 RID: 38097 RVA: 0x001585BE File Offset: 0x001567BE
		public IInformationViewConfig_SetValue ToSetValue()
		{
			return new IInformationViewConfig_SetValue
			{
				InfoDisplayGroup = this.InfoDisplayGroup
			};
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x060094D2 RID: 38098 RVA: 0x001585D4 File Offset: 0x001567D4
		// (set) Token: 0x060094D3 RID: 38099 RVA: 0x0015860E File Offset: 0x0015680E
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

		// Token: 0x04005B27 RID: 23335
		[Nullable(2)]
		protected IInformationViewConfig FbInstance;

		// Token: 0x04005B28 RID: 23336
		[Nullable(2)]
		protected IInformationViewConfig_SetValue PocoInterface;
	}
}
