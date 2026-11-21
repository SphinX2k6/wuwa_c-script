using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E3 RID: 4579
	public class IQuestScheduleTimeLeft : IQuestScheduleType
	{
		// Token: 0x0600667F RID: 26239 RVA: 0x000F6780 File Offset: 0x000F4980
		private IQuestScheduleTimeLeft_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleTimeLeft 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleTimeLeft_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleTimeLeft_SetValue());
			}
			return result;
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x000F67B8 File Offset: 0x000F49B8
		public static IQuestScheduleTimeLeft Create([Nullable(2)] IQuestScheduleTimeLeft instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleTimeLeft
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x000F67CB File Offset: 0x000F49CB
		public static IQuestScheduleTimeLeft CreateFromSetValue([Nullable(2)] IQuestScheduleTimeLeft_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleTimeLeft
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x000F67E0 File Offset: 0x000F49E0
		public new IQuestScheduleTimeLeft_SetValue ToSetValue()
		{
			return new IQuestScheduleTimeLeft_SetValue
			{
				Type = this.Type,
				TimerType = this.TimerType,
				TimeLeft = this.TimeLeft,
				IconType = this.IconType,
				ShowTime = this.ShowTime
			};
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06006683 RID: 26243 RVA: 0x000F682E File Offset: 0x000F4A2E
		// (set) Token: 0x06006684 RID: 26244 RVA: 0x000F6859 File Offset: 0x000F4A59
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

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06006685 RID: 26245 RVA: 0x000F6867 File Offset: 0x000F4A67
		// (set) Token: 0x06006686 RID: 26246 RVA: 0x000F6892 File Offset: 0x000F4A92
		public virtual ETimerType TimerType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimerType;
				}
				if (this.PocoInterface == null)
				{
					return ETimerType.CountDownChallenge;
				}
				return this.PocoInterface.TimerType;
			}
			set
			{
				this.GetOrCreatePoco().TimerType = value;
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06006687 RID: 26247 RVA: 0x000F68A0 File Offset: 0x000F4AA0
		// (set) Token: 0x06006688 RID: 26248 RVA: 0x000F68CB File Offset: 0x000F4ACB
		public virtual int TimeLeft
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeLeft;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TimeLeft;
			}
			set
			{
				this.GetOrCreatePoco().TimeLeft = value;
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x000F68D9 File Offset: 0x000F4AD9
		// (set) Token: 0x0600668A RID: 26250 RVA: 0x000F6904 File Offset: 0x000F4B04
		public virtual ETimeLeftIconType IconType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IconType;
				}
				if (this.PocoInterface == null)
				{
					return ETimeLeftIconType.AkiWorld;
				}
				return this.PocoInterface.IconType;
			}
			set
			{
				this.GetOrCreatePoco().IconType = value;
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x000F6914 File Offset: 0x000F4B14
		// (set) Token: 0x0600668C RID: 26252 RVA: 0x000F694E File Offset: 0x000F4B4E
		public virtual bool? ShowTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowTime;
				}
				IQuestScheduleTimeLeft_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowTime;
			}
			set
			{
				this.GetOrCreatePoco().ShowTime = value;
			}
		}

		// Token: 0x04003D7B RID: 15739
		[Nullable(2)]
		protected new IQuestScheduleTimeLeft FbInstance;

		// Token: 0x04003D7C RID: 15740
		[Nullable(2)]
		protected new IQuestScheduleTimeLeft_SetValue PocoInterface;
	}
}
