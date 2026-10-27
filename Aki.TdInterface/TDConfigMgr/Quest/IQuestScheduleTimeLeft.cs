using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010B5 RID: 4277
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleTimeLeft : IQuestScheduleType
	{
		// Token: 0x06006086 RID: 24710 RVA: 0x000E9660 File Offset: 0x000E7860
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

		// Token: 0x06006087 RID: 24711 RVA: 0x000E9698 File Offset: 0x000E7898
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

		// Token: 0x06006088 RID: 24712 RVA: 0x000E96AB File Offset: 0x000E78AB
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

		// Token: 0x06006089 RID: 24713 RVA: 0x000E96C0 File Offset: 0x000E78C0
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

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x0600608A RID: 24714 RVA: 0x000E970E File Offset: 0x000E790E
		// (set) Token: 0x0600608B RID: 24715 RVA: 0x000E9739 File Offset: 0x000E7939
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

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x000E9747 File Offset: 0x000E7947
		// (set) Token: 0x0600608D RID: 24717 RVA: 0x000E9772 File Offset: 0x000E7972
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

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x0600608E RID: 24718 RVA: 0x000E9780 File Offset: 0x000E7980
		// (set) Token: 0x0600608F RID: 24719 RVA: 0x000E97AB File Offset: 0x000E79AB
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

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06006090 RID: 24720 RVA: 0x000E97B9 File Offset: 0x000E79B9
		// (set) Token: 0x06006091 RID: 24721 RVA: 0x000E97E4 File Offset: 0x000E79E4
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

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06006092 RID: 24722 RVA: 0x000E97F4 File Offset: 0x000E79F4
		// (set) Token: 0x06006093 RID: 24723 RVA: 0x000E982E File Offset: 0x000E7A2E
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

		// Token: 0x04003A2E RID: 14894
		[Nullable(2)]
		protected new IQuestScheduleTimeLeft FbInstance;

		// Token: 0x04003A2F RID: 14895
		[Nullable(2)]
		protected new IQuestScheduleTimeLeft_SetValue PocoInterface;
	}
}
