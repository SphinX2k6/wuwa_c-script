using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DE RID: 8926
	public class IVisualNovelPerformanceSendAudioEvent : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C28A RID: 49802 RVA: 0x001BF678 File Offset: 0x001BD878
		private IVisualNovelPerformanceSendAudioEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceSendAudioEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceSendAudioEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceSendAudioEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600C28B RID: 49803 RVA: 0x001BF6B0 File Offset: 0x001BD8B0
		public static IVisualNovelPerformanceSendAudioEvent Create([Nullable(2)] IVisualNovelPerformanceSendAudioEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSendAudioEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C28C RID: 49804 RVA: 0x001BF6C3 File Offset: 0x001BD8C3
		public static IVisualNovelPerformanceSendAudioEvent CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceSendAudioEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSendAudioEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C28D RID: 49805 RVA: 0x001BF6D8 File Offset: 0x001BD8D8
		public new IVisualNovelPerformanceSendAudioEvent_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceSendAudioEvent_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				AudioEvent = this.AudioEvent,
				EndFadeOutTime = this.EndFadeOutTime,
				IsNotCountTimeAndNotInterrupted = this.IsNotCountTimeAndNotInterrupted,
				SkipOnUltraFastForward = this.SkipOnUltraFastForward
			};
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600C28E RID: 49806 RVA: 0x001BF732 File Offset: 0x001BD932
		// (set) Token: 0x0600C28F RID: 49807 RVA: 0x001BF75D File Offset: 0x001BD95D
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600C290 RID: 49808 RVA: 0x001BF76C File Offset: 0x001BD96C
		// (set) Token: 0x0600C291 RID: 49809 RVA: 0x001BF7A6 File Offset: 0x001BD9A6
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceSendAudioEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartTime;
			}
			set
			{
				this.GetOrCreatePoco().StartTime = value;
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0600C292 RID: 49810 RVA: 0x001BF7B4 File Offset: 0x001BD9B4
		// (set) Token: 0x0600C293 RID: 49811 RVA: 0x001BF7DF File Offset: 0x001BD9DF
		public virtual string AudioEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AudioEvent;
			}
			set
			{
				this.GetOrCreatePoco().AudioEvent = value;
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0600C294 RID: 49812 RVA: 0x001BF7F0 File Offset: 0x001BD9F0
		// (set) Token: 0x0600C295 RID: 49813 RVA: 0x001BF82A File Offset: 0x001BDA2A
		public virtual float? EndFadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndFadeOutTime;
				}
				IVisualNovelPerformanceSendAudioEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndFadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().EndFadeOutTime = value;
			}
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x0600C296 RID: 49814 RVA: 0x001BF838 File Offset: 0x001BDA38
		// (set) Token: 0x0600C297 RID: 49815 RVA: 0x001BF872 File Offset: 0x001BDA72
		public virtual bool? IsNotCountTimeAndNotInterrupted
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNotCountTimeAndNotInterrupted;
				}
				IVisualNovelPerformanceSendAudioEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNotCountTimeAndNotInterrupted;
			}
			set
			{
				this.GetOrCreatePoco().IsNotCountTimeAndNotInterrupted = value;
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0600C298 RID: 49816 RVA: 0x001BF880 File Offset: 0x001BDA80
		// (set) Token: 0x0600C299 RID: 49817 RVA: 0x001BF8BA File Offset: 0x001BDABA
		public virtual bool? SkipOnUltraFastForward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkipOnUltraFastForward;
				}
				IVisualNovelPerformanceSendAudioEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkipOnUltraFastForward;
			}
			set
			{
				this.GetOrCreatePoco().SkipOnUltraFastForward = value;
			}
		}

		// Token: 0x04007421 RID: 29729
		[Nullable(2)]
		protected new IVisualNovelPerformanceSendAudioEvent FbInstance;

		// Token: 0x04007422 RID: 29730
		[Nullable(2)]
		protected new IVisualNovelPerformanceSendAudioEvent_SetValue PocoInterface;
	}
}
