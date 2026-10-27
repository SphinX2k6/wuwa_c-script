using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E9D RID: 7837
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpecificScanEffect
	{
		// Token: 0x0600A7A6 RID: 42918 RVA: 0x0017ACD4 File Offset: 0x00178ED4
		private ISpecificScanEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecificScanEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecificScanEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecificScanEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x0017AD0C File Offset: 0x00178F0C
		public static ISpecificScanEffect Create([Nullable(2)] ISpecificScanEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecificScanEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x0017AD1F File Offset: 0x00178F1F
		public static ISpecificScanEffect CreateFromSetValue([Nullable(2)] ISpecificScanEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecificScanEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x0017AD32 File Offset: 0x00178F32
		public ISpecificScanEffect_SetValue ToSetValue()
		{
			return new ISpecificScanEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600A7AA RID: 42922 RVA: 0x0017AD45 File Offset: 0x00178F45
		// (set) Token: 0x0600A7AB RID: 42923 RVA: 0x0017AD70 File Offset: 0x00178F70
		public virtual ESpecificScanType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (ESpecificScanType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063F8 RID: 25592
		[Nullable(2)]
		protected ISpecificScanEffect FbInstance;

		// Token: 0x040063F9 RID: 25593
		[Nullable(2)]
		protected ISpecificScanEffect_SetValue PocoInterface;
	}
}
