using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010AD RID: 4269
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleProgressValue : IQuestScheduleType
	{
		// Token: 0x06006052 RID: 24658 RVA: 0x000E8F54 File Offset: 0x000E7154
		private IQuestScheduleProgressValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleProgressValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleProgressValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleProgressValue_SetValue());
			}
			return result;
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x000E8F8C File Offset: 0x000E718C
		public static IQuestScheduleProgressValue Create([Nullable(2)] IQuestScheduleProgressValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleProgressValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x000E8F9F File Offset: 0x000E719F
		public static IQuestScheduleProgressValue CreateFromSetValue([Nullable(2)] IQuestScheduleProgressValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleProgressValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x000E8FB2 File Offset: 0x000E71B2
		public new IQuestScheduleProgressValue_SetValue ToSetValue()
		{
			return new IQuestScheduleProgressValue_SetValue
			{
				Type = this.Type,
				TargetProgressEntity = this.TargetProgressEntity
			};
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x000E8FD1 File Offset: 0x000E71D1
		// (set) Token: 0x06006057 RID: 24663 RVA: 0x000E8FFC File Offset: 0x000E71FC
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

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06006058 RID: 24664 RVA: 0x000E900A File Offset: 0x000E720A
		// (set) Token: 0x06006059 RID: 24665 RVA: 0x000E9035 File Offset: 0x000E7235
		public virtual int TargetProgressEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetProgressEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetProgressEntity;
			}
			set
			{
				this.GetOrCreatePoco().TargetProgressEntity = value;
			}
		}

		// Token: 0x04003A10 RID: 14864
		[Nullable(2)]
		protected new IQuestScheduleProgressValue FbInstance;

		// Token: 0x04003A11 RID: 14865
		[Nullable(2)]
		protected new IQuestScheduleProgressValue_SetValue PocoInterface;
	}
}
