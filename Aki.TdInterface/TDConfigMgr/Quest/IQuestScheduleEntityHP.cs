using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010A3 RID: 4259
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleEntityHP : IQuestScheduleType
	{
		// Token: 0x06006018 RID: 24600 RVA: 0x000E88D0 File Offset: 0x000E6AD0
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

		// Token: 0x06006019 RID: 24601 RVA: 0x000E8908 File Offset: 0x000E6B08
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

		// Token: 0x0600601A RID: 24602 RVA: 0x000E891B File Offset: 0x000E6B1B
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

		// Token: 0x0600601B RID: 24603 RVA: 0x000E892E File Offset: 0x000E6B2E
		public new IQuestScheduleEntityHP_SetValue ToSetValue()
		{
			return new IQuestScheduleEntityHP_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x000E894D File Offset: 0x000E6B4D
		// (set) Token: 0x0600601D RID: 24605 RVA: 0x000E8978 File Offset: 0x000E6B78
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

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x000E8986 File Offset: 0x000E6B86
		// (set) Token: 0x0600601F RID: 24607 RVA: 0x000E89B1 File Offset: 0x000E6BB1
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

		// Token: 0x040039F4 RID: 14836
		[Nullable(2)]
		protected new IQuestScheduleEntityHP FbInstance;

		// Token: 0x040039F5 RID: 14837
		[Nullable(2)]
		protected new IQuestScheduleEntityHP_SetValue PocoInterface;
	}
}
