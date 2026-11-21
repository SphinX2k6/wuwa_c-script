using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012BA RID: 4794
	public class ITakePhoto2TargetPlayMontageCondition
	{
		// Token: 0x06006BFD RID: 27645 RVA: 0x00101A58 File Offset: 0x000FFC58
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

		// Token: 0x06006BFE RID: 27646 RVA: 0x00101A90 File Offset: 0x000FFC90
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

		// Token: 0x06006BFF RID: 27647 RVA: 0x00101AA3 File Offset: 0x000FFCA3
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

		// Token: 0x06006C00 RID: 27648 RVA: 0x00101AB6 File Offset: 0x000FFCB6
		public ITakePhoto2TargetPlayMontageCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetPlayMontageCondition_SetValue
			{
				MontagePath = this.MontagePath
			};
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x06006C01 RID: 27649 RVA: 0x00101AC9 File Offset: 0x000FFCC9
		// (set) Token: 0x06006C02 RID: 27650 RVA: 0x00101AF4 File Offset: 0x000FFCF4
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

		// Token: 0x0400407F RID: 16511
		[Nullable(2)]
		protected ITakePhoto2TargetPlayMontageCondition FbInstance;

		// Token: 0x04004080 RID: 16512
		[Nullable(2)]
		protected ITakePhoto2TargetPlayMontageCondition_SetValue PocoInterface;
	}
}
