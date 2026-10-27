using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001180 RID: 4480
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TargetPlayMontageCondition
	{
		// Token: 0x060065C6 RID: 26054 RVA: 0x000F428C File Offset: 0x000F248C
		private ITakePhoto2TargetPlayMontageCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2TargetPlayMontageCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2TargetPlayMontageCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2TargetPlayMontageCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x000F42C4 File Offset: 0x000F24C4
		public static ITakePhoto2TargetPlayMontageCondition Create([Nullable(2)] ITakePhoto2TargetPlayMontageCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetPlayMontageCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x000F42D7 File Offset: 0x000F24D7
		public static ITakePhoto2TargetPlayMontageCondition CreateFromSetValue([Nullable(2)] ITakePhoto2TargetPlayMontageCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2TargetPlayMontageCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x000F42EA File Offset: 0x000F24EA
		public ITakePhoto2TargetPlayMontageCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetPlayMontageCondition_SetValue
			{
				MontagePath = this.MontagePath
			};
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x060065CA RID: 26058 RVA: 0x000F42FD File Offset: 0x000F24FD
		// (set) Token: 0x060065CB RID: 26059 RVA: 0x000F4328 File Offset: 0x000F2528
		public virtual string MontagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontagePath;
			}
			set
			{
				this.GetOrCreatePoco().MontagePath = value;
			}
		}

		// Token: 0x04003D17 RID: 15639
		[Nullable(2)]
		protected ITakePhoto2TargetPlayMontageCondition FbInstance;

		// Token: 0x04003D18 RID: 15640
		[Nullable(2)]
		protected ITakePhoto2TargetPlayMontageCondition_SetValue PocoInterface;
	}
}
