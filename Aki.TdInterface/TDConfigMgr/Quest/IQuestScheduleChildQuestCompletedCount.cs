using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011CB RID: 4555
	public class IQuestScheduleChildQuestCompletedCount : IQuestScheduleType
	{
		// Token: 0x060065EB RID: 26091 RVA: 0x000F5468 File Offset: 0x000F3668
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

		// Token: 0x060065EC RID: 26092 RVA: 0x000F54A0 File Offset: 0x000F36A0
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

		// Token: 0x060065ED RID: 26093 RVA: 0x000F54B3 File Offset: 0x000F36B3
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

		// Token: 0x060065EE RID: 26094 RVA: 0x000F54C6 File Offset: 0x000F36C6
		public new IQuestScheduleChildQuestCompletedCount_SetValue ToSetValue()
		{
			return new IQuestScheduleChildQuestCompletedCount_SetValue
			{
				Type = this.Type,
				AssociatedChildQuestIds = this.AssociatedChildQuestIds
			};
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x060065EF RID: 26095 RVA: 0x000F54E5 File Offset: 0x000F36E5
		// (set) Token: 0x060065F0 RID: 26096 RVA: 0x000F5510 File Offset: 0x000F3710
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

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x060065F1 RID: 26097 RVA: 0x000F551E File Offset: 0x000F371E
		// (set) Token: 0x060065F2 RID: 26098 RVA: 0x000F5545 File Offset: 0x000F3745
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

		// Token: 0x04003D27 RID: 15655
		[Nullable(2)]
		protected new IQuestScheduleChildQuestCompletedCount FbInstance;

		// Token: 0x04003D28 RID: 15656
		[Nullable(2)]
		protected new IQuestScheduleChildQuestCompletedCount_SetValue PocoInterface;
	}
}
