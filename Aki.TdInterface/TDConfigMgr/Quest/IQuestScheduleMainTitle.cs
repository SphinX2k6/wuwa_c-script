using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D3 RID: 4563
	public class IQuestScheduleMainTitle
	{
		// Token: 0x0600661B RID: 26139 RVA: 0x000F5AF0 File Offset: 0x000F3CF0
		private IQuestScheduleMainTitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleMainTitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleMainTitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleMainTitle_SetValue());
			}
			return result;
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x000F5B28 File Offset: 0x000F3D28
		public static IQuestScheduleMainTitle Create([Nullable(2)] IQuestScheduleMainTitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleMainTitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x000F5B3B File Offset: 0x000F3D3B
		public static IQuestScheduleMainTitle CreateFromSetValue([Nullable(2)] IQuestScheduleMainTitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleMainTitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x000F5B4E File Offset: 0x000F3D4E
		public IQuestScheduleMainTitle_SetValue ToSetValue()
		{
			return new IQuestScheduleMainTitle_SetValue
			{
				TidTitle = this.TidTitle,
				QuestScheduleType = this.QuestScheduleType,
				CustomIcon = this.CustomIcon,
				EdTidTitle = this.EdTidTitle
			};
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600661F RID: 26143 RVA: 0x000F5B85 File Offset: 0x000F3D85
		// (set) Token: 0x06006620 RID: 26144 RVA: 0x000F5BB0 File Offset: 0x000F3DB0
		public virtual string TidTitle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTitle;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidTitle;
			}
			set
			{
				this.GetOrCreatePoco().TidTitle = value;
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06006621 RID: 26145 RVA: 0x000F5BBE File Offset: 0x000F3DBE
		// (set) Token: 0x06006622 RID: 26146 RVA: 0x000F5BE5 File Offset: 0x000F3DE5
		[Nullable(2)]
		public virtual IQuestScheduleType QuestScheduleType
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestScheduleType;
				}
				IQuestScheduleMainTitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.QuestScheduleType;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().QuestScheduleType = value;
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06006623 RID: 26147 RVA: 0x000F5BF4 File Offset: 0x000F3DF4
		// (set) Token: 0x06006624 RID: 26148 RVA: 0x000F5C2E File Offset: 0x000F3E2E
		public virtual int? CustomIcon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomIcon;
				}
				IQuestScheduleMainTitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CustomIcon;
			}
			set
			{
				this.GetOrCreatePoco().CustomIcon = value;
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06006625 RID: 26149 RVA: 0x000F5C3C File Offset: 0x000F3E3C
		// (set) Token: 0x06006626 RID: 26150 RVA: 0x000F5C53 File Offset: 0x000F3E53
		[Nullable(2)]
		public virtual string EdTidTitle
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTitle;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidTitle = value;
			}
		}

		// Token: 0x04003D45 RID: 15685
		[Nullable(2)]
		protected IQuestScheduleMainTitle FbInstance;

		// Token: 0x04003D46 RID: 15686
		[Nullable(2)]
		protected IQuestScheduleMainTitle_SetValue PocoInterface;
	}
}
