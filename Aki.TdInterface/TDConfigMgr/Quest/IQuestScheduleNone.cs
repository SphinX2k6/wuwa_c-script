using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010AB RID: 4267
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleNone : IQuestScheduleType
	{
		// Token: 0x0600604A RID: 24650 RVA: 0x000E8E98 File Offset: 0x000E7098
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

		// Token: 0x0600604B RID: 24651 RVA: 0x000E8ED0 File Offset: 0x000E70D0
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

		// Token: 0x0600604C RID: 24652 RVA: 0x000E8EE3 File Offset: 0x000E70E3
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

		// Token: 0x0600604D RID: 24653 RVA: 0x000E8EF6 File Offset: 0x000E70F6
		public new IQuestScheduleNone_SetValue ToSetValue()
		{
			return new IQuestScheduleNone_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x0600604E RID: 24654 RVA: 0x000E8F09 File Offset: 0x000E7109
		// (set) Token: 0x0600604F RID: 24655 RVA: 0x000E8F34 File Offset: 0x000E7134
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

		// Token: 0x04003A0D RID: 14861
		[Nullable(2)]
		protected new IQuestScheduleNone FbInstance;

		// Token: 0x04003A0E RID: 14862
		[Nullable(2)]
		protected new IQuestScheduleNone_SetValue PocoInterface;
	}
}
