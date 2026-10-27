using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001327 RID: 4903
	public class IQuestScheduleTimeLeft : IQuestScheduleType
	{
		// Token: 0x0600707A RID: 28794 RVA: 0x0010F975 File Offset: 0x0010DB75
		[NullableContext(1)]
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

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x0600707B RID: 28795 RVA: 0x0010F994 File Offset: 0x0010DB94
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600707C RID: 28796 RVA: 0x0010F9A1 File Offset: 0x0010DBA1
		public virtual ETimerType TimerType
		{
			get
			{
				return (ETimerType)this.Instance.TimerType;
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x0010F9AE File Offset: 0x0010DBAE
		public virtual int TimeLeft
		{
			get
			{
				return this.Instance.TimeLeft;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600707E RID: 28798 RVA: 0x0010F9BB File Offset: 0x0010DBBB
		public virtual ETimeLeftIconType IconType
		{
			get
			{
				return (ETimeLeftIconType)this.Instance.IconType;
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x0010F9C8 File Offset: 0x0010DBC8
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

		// Token: 0x040040E3 RID: 16611
		private IQuestScheduleTimeLeft Instance;
	}
}
