using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200148A RID: 5258
	public class IQuestScheduleMainTitle
	{
		// Token: 0x0600776B RID: 30571 RVA: 0x0011E678 File Offset: 0x0011C878
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

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x0600776C RID: 30572 RVA: 0x0011E697 File Offset: 0x0011C897
		public virtual string TidTitle
		{
			get
			{
				return this.Instance.TidTitle;
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x0600776D RID: 30573 RVA: 0x0011E6A4 File Offset: 0x0011C8A4
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

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x0600776E RID: 30574 RVA: 0x0011E6D4 File Offset: 0x0011C8D4
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

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x0600776F RID: 30575 RVA: 0x0011E70A File Offset: 0x0011C90A
		[Nullable(2)]
		public virtual string EdTidTitle
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x0400448E RID: 17550
		private IQuestScheduleMainTitle Instance;

		// Token: 0x0400448F RID: 17551
		private IQuestScheduleType _QuestScheduleTypeCache;

		// Token: 0x04004490 RID: 17552
		private bool _QuestScheduleTypeInited;
	}
}
