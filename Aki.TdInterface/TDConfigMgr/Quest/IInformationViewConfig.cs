using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FC1 RID: 4033
	[NullableContext(2)]
	[Nullable(0)]
	public class IInformationViewConfig
	{
		// Token: 0x060059E8 RID: 23016 RVA: 0x000DACE8 File Offset: 0x000D8EE8
		[NullableContext(1)]
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

		// Token: 0x060059E9 RID: 23017 RVA: 0x000DAD20 File Offset: 0x000D8F20
		[NullableContext(1)]
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

		// Token: 0x060059EA RID: 23018 RVA: 0x000DAD33 File Offset: 0x000D8F33
		[NullableContext(1)]
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

		// Token: 0x060059EB RID: 23019 RVA: 0x000DAD46 File Offset: 0x000D8F46
		[NullableContext(1)]
		public IInformationViewConfig_SetValue ToSetValue()
		{
			return new IInformationViewConfig_SetValue
			{
				InformationView = this.InformationView
			};
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x000DAD59 File Offset: 0x000D8F59
		// (set) Token: 0x060059ED RID: 23021 RVA: 0x000DAD80 File Offset: 0x000D8F80
		public virtual IInformationViewType InformationView
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InformationView;
				}
				IInformationViewConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InformationView;
			}
			set
			{
				this.GetOrCreatePoco().InformationView = value;
			}
		}

		// Token: 0x0400363B RID: 13883
		protected IInformationViewConfig FbInstance;

		// Token: 0x0400363C RID: 13884
		protected IInformationViewConfig_SetValue PocoInterface;
	}
}
