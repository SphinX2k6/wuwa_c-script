using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010B9 RID: 4281
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleType
	{
		// Token: 0x0600609E RID: 24734 RVA: 0x000E9908 File Offset: 0x000E7B08
		private IQuestScheduleType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleType_SetValue());
			}
			return result;
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x000E9940 File Offset: 0x000E7B40
		public static IQuestScheduleType Create([Nullable(2)] IQuestScheduleType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x000E9953 File Offset: 0x000E7B53
		public static IQuestScheduleType CreateFromSetValue([Nullable(2)] IQuestScheduleType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x000E9966 File Offset: 0x000E7B66
		public IQuestScheduleType_SetValue ToSetValue()
		{
			return new IQuestScheduleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x000E9979 File Offset: 0x000E7B79
		// (set) Token: 0x060060A3 RID: 24739 RVA: 0x000E99A4 File Offset: 0x000E7BA4
		public virtual EQuestScheduleType Type
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

		// Token: 0x04003A38 RID: 14904
		[Nullable(2)]
		protected IQuestScheduleType FbInstance;

		// Token: 0x04003A39 RID: 14905
		[Nullable(2)]
		protected IQuestScheduleType_SetValue PocoInterface;
	}
}
