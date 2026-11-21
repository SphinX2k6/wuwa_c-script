using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011DF RID: 4575
	public class IQuestScheduleScore : IQuestScheduleType
	{
		// Token: 0x0600665F RID: 26207 RVA: 0x000F6270 File Offset: 0x000F4470
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

		// Token: 0x06006660 RID: 26208 RVA: 0x000F62A8 File Offset: 0x000F44A8
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

		// Token: 0x06006661 RID: 26209 RVA: 0x000F62BB File Offset: 0x000F44BB
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

		// Token: 0x06006662 RID: 26210 RVA: 0x000F62CE File Offset: 0x000F44CE
		public new IQuestScheduleScore_SetValue ToSetValue()
		{
			return new IQuestScheduleScore_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06006663 RID: 26211 RVA: 0x000F62E1 File Offset: 0x000F44E1
		// (set) Token: 0x06006664 RID: 26212 RVA: 0x000F630C File Offset: 0x000F450C
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

		// Token: 0x04003D65 RID: 15717
		[Nullable(2)]
		protected new IQuestScheduleScore FbInstance;

		// Token: 0x04003D66 RID: 15718
		[Nullable(2)]
		protected new IQuestScheduleScore_SetValue PocoInterface;
	}
}
