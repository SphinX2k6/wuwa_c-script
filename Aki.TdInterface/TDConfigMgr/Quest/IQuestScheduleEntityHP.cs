using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D1 RID: 4561
	public class IQuestScheduleEntityHP : IQuestScheduleType
	{
		// Token: 0x06006611 RID: 26129 RVA: 0x000F59F0 File Offset: 0x000F3BF0
		private IQuestScheduleEntityHP_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleEntityHP 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleEntityHP_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleEntityHP_SetValue());
			}
			return result;
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x000F5A28 File Offset: 0x000F3C28
		public static IQuestScheduleEntityHP Create([Nullable(2)] IQuestScheduleEntityHP instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleEntityHP
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x000F5A3B File Offset: 0x000F3C3B
		public static IQuestScheduleEntityHP CreateFromSetValue([Nullable(2)] IQuestScheduleEntityHP_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleEntityHP
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x000F5A4E File Offset: 0x000F3C4E
		public new IQuestScheduleEntityHP_SetValue ToSetValue()
		{
			return new IQuestScheduleEntityHP_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06006615 RID: 26133 RVA: 0x000F5A6D File Offset: 0x000F3C6D
		// (set) Token: 0x06006616 RID: 26134 RVA: 0x000F5A98 File Offset: 0x000F3C98
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

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06006617 RID: 26135 RVA: 0x000F5AA6 File Offset: 0x000F3CA6
		// (set) Token: 0x06006618 RID: 26136 RVA: 0x000F5AD1 File Offset: 0x000F3CD1
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04003D41 RID: 15681
		[Nullable(2)]
		protected new IQuestScheduleEntityHP FbInstance;

		// Token: 0x04003D42 RID: 15682
		[Nullable(2)]
		protected new IQuestScheduleEntityHP_SetValue PocoInterface;
	}
}
