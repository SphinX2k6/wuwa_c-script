using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001188 RID: 4488
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhotoPosCondition
	{
		// Token: 0x060065F0 RID: 26096 RVA: 0x000F4848 File Offset: 0x000F2A48
		private ITakePhotoPosCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhotoPosCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhotoPosCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhotoPosCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x000F4880 File Offset: 0x000F2A80
		public static ITakePhotoPosCondition Create([Nullable(2)] ITakePhotoPosCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhotoPosCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x000F4893 File Offset: 0x000F2A93
		public static ITakePhotoPosCondition CreateFromSetValue([Nullable(2)] ITakePhotoPosCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhotoPosCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x000F48A6 File Offset: 0x000F2AA6
		public ITakePhotoPosCondition_SetValue ToSetValue()
		{
			return new ITakePhotoPosCondition_SetValue
			{
				RangeEntity = this.RangeEntity,
				TidDescription = this.TidDescription,
				EdTidDescription = this.EdTidDescription
			};
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x000F48D1 File Offset: 0x000F2AD1
		// (set) Token: 0x060065F5 RID: 26101 RVA: 0x000F48FC File Offset: 0x000F2AFC
		public virtual int RangeEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RangeEntity;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntity = value;
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x000F490A File Offset: 0x000F2B0A
		// (set) Token: 0x060065F7 RID: 26103 RVA: 0x000F4935 File Offset: 0x000F2B35
		public virtual string TidDescription
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDescription;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDescription;
			}
			set
			{
				this.GetOrCreatePoco().TidDescription = value;
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x060065F8 RID: 26104 RVA: 0x000F4943 File Offset: 0x000F2B43
		// (set) Token: 0x060065F9 RID: 26105 RVA: 0x000F495A File Offset: 0x000F2B5A
		[Nullable(2)]
		public virtual string EdTidDescription
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDescription;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidDescription = value;
			}
		}

		// Token: 0x04003D32 RID: 15666
		[Nullable(2)]
		protected ITakePhotoPosCondition FbInstance;

		// Token: 0x04003D33 RID: 15667
		[Nullable(2)]
		protected ITakePhotoPosCondition_SetValue PocoInterface;
	}
}
