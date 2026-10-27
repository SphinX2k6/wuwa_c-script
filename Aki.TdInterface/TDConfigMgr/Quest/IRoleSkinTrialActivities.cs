using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010FE RID: 4350
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleSkinTrialActivities : IShowUi
	{
		// Token: 0x06006262 RID: 25186 RVA: 0x000ED034 File Offset: 0x000EB234
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

		// Token: 0x06006263 RID: 25187 RVA: 0x000ED06C File Offset: 0x000EB26C
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

		// Token: 0x06006264 RID: 25188 RVA: 0x000ED07F File Offset: 0x000EB27F
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

		// Token: 0x06006265 RID: 25189 RVA: 0x000ED092 File Offset: 0x000EB292
		public new IRoleSkinTrialActivities_SetValue ToSetValue()
		{
			return new IRoleSkinTrialActivities_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06006266 RID: 25190 RVA: 0x000ED0A5 File Offset: 0x000EB2A5
		// (set) Token: 0x06006267 RID: 25191 RVA: 0x000ED0D0 File Offset: 0x000EB2D0
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

		// Token: 0x04003B19 RID: 15129
		[Nullable(2)]
		protected new IRoleSkinTrialActivities FbInstance;

		// Token: 0x04003B1A RID: 15130
		[Nullable(2)]
		protected new IRoleSkinTrialActivities_SetValue PocoInterface;
	}
}
