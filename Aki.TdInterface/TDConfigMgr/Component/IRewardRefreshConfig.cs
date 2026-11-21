using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000729 RID: 1833
	public class IRewardRefreshConfig
	{
		// Token: 0x060026EE RID: 9966 RVA: 0x0006888C File Offset: 0x00066A8C
		private IRewardRefreshConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRewardRefreshConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRewardRefreshConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRewardRefreshConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000688C4 File Offset: 0x00066AC4
		public static IRewardRefreshConfig Create([Nullable(2)] IRewardRefreshConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRewardRefreshConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000688D7 File Offset: 0x00066AD7
		public static IRewardRefreshConfig CreateFromSetValue([Nullable(2)] IRewardRefreshConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRewardRefreshConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000688EA File Offset: 0x00066AEA
		public IRewardRefreshConfig_SetValue ToSetValue()
		{
			return new IRewardRefreshConfig_SetValue
			{
				RefreshCondition = this.RefreshCondition,
				RefreshType = this.RefreshType,
				MaxCount = this.MaxCount
			};
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x00068915 File Offset: 0x00066B15
		// (set) Token: 0x060026F3 RID: 9971 RVA: 0x0006893C File Offset: 0x00066B3C
		[Nullable(2)]
		public virtual IRefreshConditionBase RefreshCondition
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshCondition;
				}
				IRewardRefreshConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefreshCondition;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RefreshCondition = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x0006894A File Offset: 0x00066B4A
		// (set) Token: 0x060026F5 RID: 9973 RVA: 0x00068971 File Offset: 0x00066B71
		public virtual IRefreshRule RefreshType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshType;
				}
				IRewardRefreshConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefreshType;
			}
			set
			{
				this.GetOrCreatePoco().RefreshType = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x00068980 File Offset: 0x00066B80
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x000689BA File Offset: 0x00066BBA
		public virtual int? MaxCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxCount;
				}
				IRewardRefreshConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxCount = value;
			}
		}

		// Token: 0x04001AAF RID: 6831
		[Nullable(2)]
		protected IRewardRefreshConfig FbInstance;

		// Token: 0x04001AB0 RID: 6832
		[Nullable(2)]
		protected IRewardRefreshConfig_SetValue PocoInterface;
	}
}
