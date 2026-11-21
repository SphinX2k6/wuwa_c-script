using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011DB RID: 4571
	public class IQuestScheduleProgressValue : IQuestScheduleType
	{
		// Token: 0x0600664B RID: 26187 RVA: 0x000F6074 File Offset: 0x000F4274
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

		// Token: 0x0600664C RID: 26188 RVA: 0x000F60AC File Offset: 0x000F42AC
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

		// Token: 0x0600664D RID: 26189 RVA: 0x000F60BF File Offset: 0x000F42BF
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

		// Token: 0x0600664E RID: 26190 RVA: 0x000F60D2 File Offset: 0x000F42D2
		public new IQuestScheduleProgressValue_SetValue ToSetValue()
		{
			return new IQuestScheduleProgressValue_SetValue
			{
				Type = this.Type,
				TargetProgressEntity = this.TargetProgressEntity
			};
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x000F60F1 File Offset: 0x000F42F1
		// (set) Token: 0x06006650 RID: 26192 RVA: 0x000F611C File Offset: 0x000F431C
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

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06006651 RID: 26193 RVA: 0x000F612A File Offset: 0x000F432A
		// (set) Token: 0x06006652 RID: 26194 RVA: 0x000F6155 File Offset: 0x000F4355
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

		// Token: 0x04003D5D RID: 15709
		[Nullable(2)]
		protected new IQuestScheduleProgressValue FbInstance;

		// Token: 0x04003D5E RID: 15710
		[Nullable(2)]
		protected new IQuestScheduleProgressValue_SetValue PocoInterface;
	}
}
