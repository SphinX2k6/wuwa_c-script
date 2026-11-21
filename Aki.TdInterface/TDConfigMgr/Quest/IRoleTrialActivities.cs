using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001246 RID: 4678
	public class IRoleTrialActivities : IShowUi
	{
		// Token: 0x060068C9 RID: 26825 RVA: 0x000FAC28 File Offset: 0x000F8E28
		private IRoleTrialActivities_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTrialActivities 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTrialActivities_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTrialActivities_SetValue());
			}
			return result;
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x000FAC60 File Offset: 0x000F8E60
		public static IRoleTrialActivities Create([Nullable(2)] IRoleTrialActivities instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTrialActivities
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x000FAC73 File Offset: 0x000F8E73
		public static IRoleTrialActivities CreateFromSetValue([Nullable(2)] IRoleTrialActivities_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTrialActivities
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x000FAC86 File Offset: 0x000F8E86
		public new IRoleTrialActivities_SetValue ToSetValue()
		{
			return new IRoleTrialActivities_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x060068CD RID: 26829 RVA: 0x000FAC99 File Offset: 0x000F8E99
		// (set) Token: 0x060068CE RID: 26830 RVA: 0x000FACC4 File Offset: 0x000F8EC4
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E92 RID: 16018
		[Nullable(2)]
		protected new IRoleTrialActivities FbInstance;

		// Token: 0x04003E93 RID: 16019
		[Nullable(2)]
		protected new IRoleTrialActivities_SetValue PocoInterface;
	}
}
