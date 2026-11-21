using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122C RID: 4652
	public class IRoleSkinTrialActivities : IShowUi
	{
		// Token: 0x0600685D RID: 26717 RVA: 0x000FA1A8 File Offset: 0x000F83A8
		private IRoleSkinTrialActivities_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleSkinTrialActivities 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleSkinTrialActivities_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleSkinTrialActivities_SetValue());
			}
			return result;
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x000FA1E0 File Offset: 0x000F83E0
		public static IRoleSkinTrialActivities Create([Nullable(2)] IRoleSkinTrialActivities instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleSkinTrialActivities
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x000FA1F3 File Offset: 0x000F83F3
		public static IRoleSkinTrialActivities CreateFromSetValue([Nullable(2)] IRoleSkinTrialActivities_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleSkinTrialActivities
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x000FA206 File Offset: 0x000F8406
		public new IRoleSkinTrialActivities_SetValue ToSetValue()
		{
			return new IRoleSkinTrialActivities_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06006861 RID: 26721 RVA: 0x000FA219 File Offset: 0x000F8419
		// (set) Token: 0x06006862 RID: 26722 RVA: 0x000FA244 File Offset: 0x000F8444
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

		// Token: 0x04003E67 RID: 15975
		[Nullable(2)]
		protected new IRoleSkinTrialActivities FbInstance;

		// Token: 0x04003E68 RID: 15976
		[Nullable(2)]
		protected new IRoleSkinTrialActivities_SetValue PocoInterface;
	}
}
