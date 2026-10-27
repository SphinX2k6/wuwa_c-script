using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8B RID: 7819
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlideRailRTPCParams
	{
		// Token: 0x0600A748 RID: 42824 RVA: 0x0017A254 File Offset: 0x00178454
		private ISlideRailRTPCParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideRailRTPCParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideRailRTPCParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideRailRTPCParams_SetValue());
			}
			return result;
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x0017A28C File Offset: 0x0017848C
		public static ISlideRailRTPCParams Create([Nullable(2)] ISlideRailRTPCParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailRTPCParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x0017A29F File Offset: 0x0017849F
		public static ISlideRailRTPCParams CreateFromSetValue([Nullable(2)] ISlideRailRTPCParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideRailRTPCParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x0017A2B2 File Offset: 0x001784B2
		public ISlideRailRTPCParams_SetValue ToSetValue()
		{
			return new ISlideRailRTPCParams_SetValue
			{
				RTPCName = this.RTPCName
			};
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600A74C RID: 42828 RVA: 0x0017A2C5 File Offset: 0x001784C5
		// (set) Token: 0x0600A74D RID: 42829 RVA: 0x0017A2F0 File Offset: 0x001784F0
		public virtual string RTPCName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RTPCName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RTPCName;
			}
			set
			{
				this.GetOrCreatePoco().RTPCName = value;
			}
		}

		// Token: 0x040063CE RID: 25550
		[Nullable(2)]
		protected ISlideRailRTPCParams FbInstance;

		// Token: 0x040063CF RID: 25551
		[Nullable(2)]
		protected ISlideRailRTPCParams_SetValue PocoInterface;
	}
}
