using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010A5 RID: 4261
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestScheduleMainTitle
	{
		// Token: 0x06006022 RID: 24610 RVA: 0x000E89D0 File Offset: 0x000E6BD0
		[NullableContext(1)]
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

		// Token: 0x06006023 RID: 24611 RVA: 0x000E8A08 File Offset: 0x000E6C08
		[NullableContext(1)]
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

		// Token: 0x06006024 RID: 24612 RVA: 0x000E8A1B File Offset: 0x000E6C1B
		[NullableContext(1)]
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

		// Token: 0x06006025 RID: 24613 RVA: 0x000E8A2E File Offset: 0x000E6C2E
		[NullableContext(1)]
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

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06006026 RID: 24614 RVA: 0x000E8A65 File Offset: 0x000E6C65
		// (set) Token: 0x06006027 RID: 24615 RVA: 0x000E8A90 File Offset: 0x000E6C90
		[Nullable(1)]
		public virtual string TidTitle
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().TidTitle = value;
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06006028 RID: 24616 RVA: 0x000E8A9E File Offset: 0x000E6C9E
		// (set) Token: 0x06006029 RID: 24617 RVA: 0x000E8AC5 File Offset: 0x000E6CC5
		public virtual IQuestScheduleType QuestScheduleType
		{
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
			set
			{
				this.GetOrCreatePoco().QuestScheduleType = value;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600602A RID: 24618 RVA: 0x000E8AD4 File Offset: 0x000E6CD4
		// (set) Token: 0x0600602B RID: 24619 RVA: 0x000E8B0E File Offset: 0x000E6D0E
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

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600602C RID: 24620 RVA: 0x000E8B1C File Offset: 0x000E6D1C
		// (set) Token: 0x0600602D RID: 24621 RVA: 0x000E8B33 File Offset: 0x000E6D33
		public virtual string EdTidTitle
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTitle;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTitle = value;
			}
		}

		// Token: 0x040039F8 RID: 14840
		protected IQuestScheduleMainTitle FbInstance;

		// Token: 0x040039F9 RID: 14841
		protected IQuestScheduleMainTitle_SetValue PocoInterface;
	}
}
