using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002580 RID: 9600
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceSendAudioEvent : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D77E RID: 55166 RVA: 0x002018C3 File Offset: 0x001FFAC3
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

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0600D77F RID: 55167 RVA: 0x002018E2 File Offset: 0x001FFAE2
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0600D780 RID: 55168 RVA: 0x002018F0 File Offset: 0x001FFAF0
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

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x0600D781 RID: 55169 RVA: 0x00201926 File Offset: 0x001FFB26
		public virtual string AudioEvent
		{
			get
			{
				return this.Instance.AudioEvent;
			}
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x0600D782 RID: 55170 RVA: 0x00201934 File Offset: 0x001FFB34
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

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600D783 RID: 55171 RVA: 0x0020196C File Offset: 0x001FFB6C
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

		// Token: 0x04007742 RID: 30530
		private IVisualNovelPerformanceSendAudioEvent Instance;
	}
}
