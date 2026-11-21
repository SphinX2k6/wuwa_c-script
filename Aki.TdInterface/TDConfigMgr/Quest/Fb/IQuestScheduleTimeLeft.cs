using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001477 RID: 5239
	public class IQuestScheduleTimeLeft : IQuestScheduleType
	{
		// Token: 0x0600771A RID: 30490 RVA: 0x0011DEE1 File Offset: 0x0011C0E1
		public static IQuestScheduleTimeLeft Create(IQuestScheduleTimeLeft? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleTimeLeft
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x0600771B RID: 30491 RVA: 0x0011DF00 File Offset: 0x0011C100
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x0600771C RID: 30492 RVA: 0x0011DF0D File Offset: 0x0011C10D
		public virtual ETimerType TimerType
		{
			get
			{
				return (ETimerType)this.Instance.TimerType;
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x0600771D RID: 30493 RVA: 0x0011DF1A File Offset: 0x0011C11A
		public virtual int TimeLeft
		{
			get
			{
				return this.Instance.TimeLeft;
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x0011DF27 File Offset: 0x0011C127
		public virtual ETimeLeftIconType IconType
		{
			get
			{
				return (ETimeLeftIconType)this.Instance.IconType;
			}
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x0600771F RID: 30495 RVA: 0x0011DF34 File Offset: 0x0011C134
		public virtual bool? ShowTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowTime);
			}
		}

		// Token: 0x0400445F RID: 17503
		private IQuestScheduleTimeLeft Instance;
	}
}
