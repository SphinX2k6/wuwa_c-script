using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000688 RID: 1672
	[NullableContext(1)]
	[Nullable(0)]
	public class IRewardRefreshConfig
	{
		// Token: 0x060023D2 RID: 9170 RVA: 0x000618C4 File Offset: 0x0005FAC4
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

		// Token: 0x060023D3 RID: 9171 RVA: 0x000618FC File Offset: 0x0005FAFC
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

		// Token: 0x060023D4 RID: 9172 RVA: 0x0006190F File Offset: 0x0005FB0F
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

		// Token: 0x060023D5 RID: 9173 RVA: 0x00061922 File Offset: 0x0005FB22
		public IRewardRefreshConfig_SetValue ToSetValue()
		{
			return new IRewardRefreshConfig_SetValue
			{
				RefreshCondition = this.RefreshCondition,
				RefreshType = this.RefreshType,
				MaxCount = this.MaxCount
			};
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x0006194D File Offset: 0x0005FB4D
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x00061974 File Offset: 0x0005FB74
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

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x00061982 File Offset: 0x0005FB82
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x000619A9 File Offset: 0x0005FBA9
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

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x000619B8 File Offset: 0x0005FBB8
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x000619F2 File Offset: 0x0005FBF2
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

		// Token: 0x040018B2 RID: 6322
		[Nullable(2)]
		protected IRewardRefreshConfig FbInstance;

		// Token: 0x040018B3 RID: 6323
		[Nullable(2)]
		protected IRewardRefreshConfig_SetValue PocoInterface;
	}
}
