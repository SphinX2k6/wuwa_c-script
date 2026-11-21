using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282E RID: 10286
	public class IVisualNovelPerformanceSendAudioEvent : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E4F7 RID: 58615 RVA: 0x0021D5BE File Offset: 0x0021B7BE
		public static IVisualNovelPerformanceSendAudioEvent Create(IVisualNovelPerformanceSendAudioEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSendAudioEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x0021D5DD File Offset: 0x0021B7DD
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x0021D5EC File Offset: 0x0021B7EC
		public override float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x0600E4FA RID: 58618 RVA: 0x0021D622 File Offset: 0x0021B822
		public virtual string AudioEvent
		{
			get
			{
				return this.Instance.AudioEvent;
			}
		}

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x0021D630 File Offset: 0x0021B830
		public virtual float? EndFadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.EndFadeOutTime);
			}
		}

		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x0600E4FC RID: 58620 RVA: 0x0021D668 File Offset: 0x0021B868
		public virtual bool? IsNotCountTimeAndNotInterrupted
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNotCountTimeAndNotInterrupted);
			}
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x0600E4FD RID: 58621 RVA: 0x0021D6A0 File Offset: 0x0021B8A0
		public virtual bool? SkipOnUltraFastForward
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SkipOnUltraFastForward);
			}
		}

		// Token: 0x04007DA8 RID: 32168
		private IVisualNovelPerformanceSendAudioEvent Instance;
	}
}
