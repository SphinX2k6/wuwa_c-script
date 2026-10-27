using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001118 RID: 4376
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTrialActivities : IShowUi
	{
		// Token: 0x060062CE RID: 25294 RVA: 0x000EDAB4 File Offset: 0x000EBCB4
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

		// Token: 0x060062CF RID: 25295 RVA: 0x000EDAEC File Offset: 0x000EBCEC
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

		// Token: 0x060062D0 RID: 25296 RVA: 0x000EDAFF File Offset: 0x000EBCFF
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

		// Token: 0x060062D1 RID: 25297 RVA: 0x000EDB12 File Offset: 0x000EBD12
		public new IRoleTrialActivities_SetValue ToSetValue()
		{
			return new IRoleTrialActivities_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x060062D2 RID: 25298 RVA: 0x000EDB25 File Offset: 0x000EBD25
		// (set) Token: 0x060062D3 RID: 25299 RVA: 0x000EDB50 File Offset: 0x000EBD50
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

		// Token: 0x04003B44 RID: 15172
		[Nullable(2)]
		protected new IRoleTrialActivities FbInstance;

		// Token: 0x04003B45 RID: 15173
		[Nullable(2)]
		protected new IRoleTrialActivities_SetValue PocoInterface;
	}
}
