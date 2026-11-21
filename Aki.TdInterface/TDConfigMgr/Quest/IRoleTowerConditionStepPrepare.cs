using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123C RID: 4668
	public class IRoleTowerConditionStepPrepare : IRoleTowerConditionStepBase
	{
		// Token: 0x0600689D RID: 26781 RVA: 0x000FA788 File Offset: 0x000F8988
		private IRoleTowerConditionStepPrepare_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepPrepare 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepPrepare_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepPrepare_SetValue());
			}
			return result;
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x000FA7C0 File Offset: 0x000F89C0
		public static IRoleTowerConditionStepPrepare Create([Nullable(2)] IRoleTowerConditionStepPrepare instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepPrepare
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x000FA7D3 File Offset: 0x000F89D3
		public static IRoleTowerConditionStepPrepare CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepPrepare_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepPrepare
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x000FA7E6 File Offset: 0x000F89E6
		public new IRoleTowerConditionStepPrepare_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepPrepare_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x000FA7F9 File Offset: 0x000F89F9
		// (set) Token: 0x060068A2 RID: 26786 RVA: 0x000FA824 File Offset: 0x000F8A24
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

		// Token: 0x04003E7F RID: 15999
		[Nullable(2)]
		protected new IRoleTowerConditionStepPrepare FbInstance;

		// Token: 0x04003E80 RID: 16000
		[Nullable(2)]
		protected new IRoleTowerConditionStepPrepare_SetValue PocoInterface;
	}
}
