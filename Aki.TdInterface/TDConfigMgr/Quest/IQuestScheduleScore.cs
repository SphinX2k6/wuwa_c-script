using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010B1 RID: 4273
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleScore : IQuestScheduleType
	{
		// Token: 0x06006066 RID: 24678 RVA: 0x000E9150 File Offset: 0x000E7350
		private IQuestScheduleScore_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleScore 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleScore_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleScore_SetValue());
			}
			return result;
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x000E9188 File Offset: 0x000E7388
		public static IQuestScheduleScore Create([Nullable(2)] IQuestScheduleScore instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleScore
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x000E919B File Offset: 0x000E739B
		public static IQuestScheduleScore CreateFromSetValue([Nullable(2)] IQuestScheduleScore_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleScore
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x000E91AE File Offset: 0x000E73AE
		public new IQuestScheduleScore_SetValue ToSetValue()
		{
			return new IQuestScheduleScore_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x0600606A RID: 24682 RVA: 0x000E91C1 File Offset: 0x000E73C1
		// (set) Token: 0x0600606B RID: 24683 RVA: 0x000E91EC File Offset: 0x000E73EC
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

		// Token: 0x04003A18 RID: 14872
		[Nullable(2)]
		protected new IQuestScheduleScore FbInstance;

		// Token: 0x04003A19 RID: 14873
		[Nullable(2)]
		protected new IQuestScheduleScore_SetValue PocoInterface;
	}
}
