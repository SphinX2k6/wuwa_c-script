using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E9B RID: 7835
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpecialCustomLoadingOption
	{
		// Token: 0x0600A79E RID: 42910 RVA: 0x0017AC18 File Offset: 0x00178E18
		private ISpecialCustomLoadingOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialCustomLoadingOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialCustomLoadingOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialCustomLoadingOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x0017AC50 File Offset: 0x00178E50
		public static ISpecialCustomLoadingOption Create([Nullable(2)] ISpecialCustomLoadingOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialCustomLoadingOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x0017AC63 File Offset: 0x00178E63
		public static ISpecialCustomLoadingOption CreateFromSetValue([Nullable(2)] ISpecialCustomLoadingOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialCustomLoadingOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x0017AC76 File Offset: 0x00178E76
		public ISpecialCustomLoadingOption_SetValue ToSetValue()
		{
			return new ISpecialCustomLoadingOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600A7A2 RID: 42914 RVA: 0x0017AC89 File Offset: 0x00178E89
		// (set) Token: 0x0600A7A3 RID: 42915 RVA: 0x0017ACB4 File Offset: 0x00178EB4
		public virtual ESpecialCustomLoadingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialCustomLoadingType.HonamiStory;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063F5 RID: 25589
		[Nullable(2)]
		protected ISpecialCustomLoadingOption FbInstance;

		// Token: 0x040063F6 RID: 25590
		[Nullable(2)]
		protected ISpecialCustomLoadingOption_SetValue PocoInterface;
	}
}
