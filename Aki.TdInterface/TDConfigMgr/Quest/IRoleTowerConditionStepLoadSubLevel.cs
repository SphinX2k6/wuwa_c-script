using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123A RID: 4666
	public class IRoleTowerConditionStepLoadSubLevel : IRoleTowerConditionStepBase
	{
		// Token: 0x06006895 RID: 26773 RVA: 0x000FA6CC File Offset: 0x000F88CC
		private IRoleTowerConditionStepLoadSubLevel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepLoadSubLevel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepLoadSubLevel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepLoadSubLevel_SetValue());
			}
			return result;
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x000FA704 File Offset: 0x000F8904
		public static IRoleTowerConditionStepLoadSubLevel Create([Nullable(2)] IRoleTowerConditionStepLoadSubLevel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepLoadSubLevel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x000FA717 File Offset: 0x000F8917
		public static IRoleTowerConditionStepLoadSubLevel CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepLoadSubLevel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepLoadSubLevel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x000FA72A File Offset: 0x000F892A
		public new IRoleTowerConditionStepLoadSubLevel_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepLoadSubLevel_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x000FA73D File Offset: 0x000F893D
		// (set) Token: 0x0600689A RID: 26778 RVA: 0x000FA768 File Offset: 0x000F8968
		public override ERoleTowerConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoleTowerConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E7C RID: 15996
		[Nullable(2)]
		protected new IRoleTowerConditionStepLoadSubLevel FbInstance;

		// Token: 0x04003E7D RID: 15997
		[Nullable(2)]
		protected new IRoleTowerConditionStepLoadSubLevel_SetValue PocoInterface;
	}
}
