using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200109D RID: 4253
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleChildQuestCompletedCount : IQuestScheduleType
	{
		// Token: 0x06005FF2 RID: 24562 RVA: 0x000E8348 File Offset: 0x000E6548
		private IQuestScheduleChildQuestCompletedCount_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleChildQuestCompletedCount 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleChildQuestCompletedCount_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleChildQuestCompletedCount_SetValue());
			}
			return result;
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x000E8380 File Offset: 0x000E6580
		public static IQuestScheduleChildQuestCompletedCount Create([Nullable(2)] IQuestScheduleChildQuestCompletedCount instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleChildQuestCompletedCount
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x000E8393 File Offset: 0x000E6593
		public static IQuestScheduleChildQuestCompletedCount CreateFromSetValue([Nullable(2)] IQuestScheduleChildQuestCompletedCount_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleChildQuestCompletedCount
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x000E83A6 File Offset: 0x000E65A6
		public new IQuestScheduleChildQuestCompletedCount_SetValue ToSetValue()
		{
			return new IQuestScheduleChildQuestCompletedCount_SetValue
			{
				Type = this.Type,
				AssociatedChildQuestIds = this.AssociatedChildQuestIds
			};
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06005FF6 RID: 24566 RVA: 0x000E83C5 File Offset: 0x000E65C5
		// (set) Token: 0x06005FF7 RID: 24567 RVA: 0x000E83F0 File Offset: 0x000E65F0
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

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x000E83FE File Offset: 0x000E65FE
		// (set) Token: 0x06005FF9 RID: 24569 RVA: 0x000E8425 File Offset: 0x000E6625
		public virtual List<int> AssociatedChildQuestIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AssociatedChildQuestIds;
				}
				IQuestScheduleChildQuestCompletedCount_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AssociatedChildQuestIds;
			}
			set
			{
				this.GetOrCreatePoco().AssociatedChildQuestIds = value;
			}
		}

		// Token: 0x040039DA RID: 14810
		[Nullable(2)]
		protected new IQuestScheduleChildQuestCompletedCount FbInstance;

		// Token: 0x040039DB RID: 14811
		[Nullable(2)]
		protected new IQuestScheduleChildQuestCompletedCount_SetValue PocoInterface;
	}
}
