using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002821 RID: 10273
	public class IVisualNovelPerformancePortraitEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E4B3 RID: 58547 RVA: 0x0021CE03 File Offset: 0x0021B003
		public static IVisualNovelPerformancePortraitEffect Create(IVisualNovelPerformancePortraitEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformancePortraitEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x0600E4B4 RID: 58548 RVA: 0x0021CE22 File Offset: 0x0021B022
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x0021CE30 File Offset: 0x0021B030
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

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x0021CE66 File Offset: 0x0021B066
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x0600E4B7 RID: 58551 RVA: 0x0021CE73 File Offset: 0x0021B073
		public virtual EVisualNovelPortraitEffectType EffectType
		{
			get
			{
				return (EVisualNovelPortraitEffectType)this.Instance.EffectType;
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x0600E4B8 RID: 58552 RVA: 0x0021CE80 File Offset: 0x0021B080
		public virtual EVisualNovelAmplitude? Amplitude
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EVisualNovelAmplitude?((EVisualNovelAmplitude)this.Instance.Amplitude);
			}
		}

		// Token: 0x04007D87 RID: 32135
		private IVisualNovelPerformancePortraitEffect Instance;
	}
}
