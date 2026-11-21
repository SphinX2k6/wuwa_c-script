using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D9 RID: 4569
	public class IQuestScheduleNone : IQuestScheduleType
	{
		// Token: 0x06006643 RID: 26179 RVA: 0x000F5FB8 File Offset: 0x000F41B8
		private IQuestScheduleNone_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleNone 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleNone_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleNone_SetValue());
			}
			return result;
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x000F5FF0 File Offset: 0x000F41F0
		public static IQuestScheduleNone Create([Nullable(2)] IQuestScheduleNone instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleNone
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x000F6003 File Offset: 0x000F4203
		public static IQuestScheduleNone CreateFromSetValue([Nullable(2)] IQuestScheduleNone_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleNone
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x000F6016 File Offset: 0x000F4216
		public new IQuestScheduleNone_SetValue ToSetValue()
		{
			return new IQuestScheduleNone_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06006647 RID: 26183 RVA: 0x000F6029 File Offset: 0x000F4229
		// (set) Token: 0x06006648 RID: 26184 RVA: 0x000F6054 File Offset: 0x000F4254
		public override EQuestScheduleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EQuestScheduleType.None;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003D5A RID: 15706
		[Nullable(2)]
		protected new IQuestScheduleNone FbInstance;

		// Token: 0x04003D5B RID: 15707
		[Nullable(2)]
		protected new IQuestScheduleNone_SetValue PocoInterface;
	}
}
