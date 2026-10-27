using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200133A RID: 4922
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleMainTitle
	{
		// Token: 0x060070CB RID: 28875 RVA: 0x0011010C File Offset: 0x0010E30C
		public static IQuestScheduleMainTitle Create(IQuestScheduleMainTitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleMainTitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x060070CC RID: 28876 RVA: 0x0011012B File Offset: 0x0010E32B
		public virtual string TidTitle
		{
			get
			{
				return this.Instance.TidTitle;
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x060070CD RID: 28877 RVA: 0x00110138 File Offset: 0x0010E338
		public virtual IQuestScheduleType QuestScheduleType
		{
			get
			{
				if (this._QuestScheduleTypeInited)
				{
					return this._QuestScheduleTypeCache;
				}
				this._QuestScheduleTypeInited = true;
				this._QuestScheduleTypeCache = QuestReadHelper.ReadIQuestScheduleMainTitle_QuestScheduleType(this.Instance);
				return this._QuestScheduleTypeCache;
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x060070CE RID: 28878 RVA: 0x00110168 File Offset: 0x0010E368
		public virtual int? CustomIcon
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.CustomIcon);
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x060070CF RID: 28879 RVA: 0x0011019E File Offset: 0x0010E39E
		[Nullable(2)]
		public virtual string EdTidTitle
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004112 RID: 16658
		private IQuestScheduleMainTitle Instance;

		// Token: 0x04004113 RID: 16659
		private IQuestScheduleType _QuestScheduleTypeCache;

		// Token: 0x04004114 RID: 16660
		private bool _QuestScheduleTypeInited;
	}
}
