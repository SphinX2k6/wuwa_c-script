using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002578 RID: 9592
	public class IVisualNovelPerformancePortraitEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D747 RID: 55111 RVA: 0x002011BF File Offset: 0x001FF3BF
		[NullableContext(1)]
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

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x0600D748 RID: 55112 RVA: 0x002011DE File Offset: 0x001FF3DE
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x0600D749 RID: 55113 RVA: 0x002011EC File Offset: 0x001FF3EC
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

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x0600D74A RID: 55114 RVA: 0x00201222 File Offset: 0x001FF422
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x0600D74B RID: 55115 RVA: 0x0020122F File Offset: 0x001FF42F
		public virtual EVisualNovelPortraitEffectType EffectType
		{
			get
			{
				return (EVisualNovelPortraitEffectType)this.Instance.EffectType;
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0600D74C RID: 55116 RVA: 0x0020123C File Offset: 0x001FF43C
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

		// Token: 0x0400772A RID: 30506
		private IVisualNovelPerformancePortraitEffect Instance;
	}
}
