using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006DA RID: 1754
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlidePerformType
	{
		// Token: 0x060025CC RID: 9676 RVA: 0x00065A50 File Offset: 0x00063C50
		private ISlidePerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlidePerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlidePerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlidePerformType_SetValue());
			}
			return result;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00065A88 File Offset: 0x00063C88
		public static ISlidePerformType Create([Nullable(2)] ISlidePerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlidePerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00065A9B File Offset: 0x00063C9B
		public static ISlidePerformType CreateFromSetValue([Nullable(2)] ISlidePerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlidePerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00065AAE File Offset: 0x00063CAE
		public ISlidePerformType_SetValue ToSetValue()
		{
			return new ISlidePerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x00065AC1 File Offset: 0x00063CC1
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x00065AEC File Offset: 0x00063CEC
		public virtual ESlidePerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040019C4 RID: 6596
		[Nullable(2)]
		protected ISlidePerformType FbInstance;

		// Token: 0x040019C5 RID: 6597
		[Nullable(2)]
		protected ISlidePerformType_SetValue PocoInterface;
	}
}
