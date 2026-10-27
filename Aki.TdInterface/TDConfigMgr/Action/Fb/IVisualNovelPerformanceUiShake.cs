using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002579 RID: 9593
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceUiShake : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D74E RID: 55118 RVA: 0x0020127A File Offset: 0x001FF47A
		[NullableContext(1)]
		public static IVisualNovelPerformanceUiShake Create(IVisualNovelPerformanceUiShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceUiShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0600D74F RID: 55119 RVA: 0x00201299 File Offset: 0x001FF499
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0600D750 RID: 55120 RVA: 0x002012A8 File Offset: 0x001FF4A8
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

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0600D751 RID: 55121 RVA: 0x002012DE File Offset: 0x001FF4DE
		public virtual EVisualNovelUiShakeType ShakeType
		{
			get
			{
				return (EVisualNovelUiShakeType)this.Instance.ShakeType;
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0600D752 RID: 55122 RVA: 0x002012EB File Offset: 0x001FF4EB
		public virtual EVisualNovelShakeIntensity Intensity
		{
			get
			{
				return (EVisualNovelShakeIntensity)this.Instance.Intensity;
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0600D753 RID: 55123 RVA: 0x002012F8 File Offset: 0x001FF4F8
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0600D754 RID: 55124 RVA: 0x0020132E File Offset: 0x001FF52E
		public virtual string ScreenEffectDa
		{
			get
			{
				return this.Instance.ScreenEffectDa;
			}
		}

		// Token: 0x0400772B RID: 30507
		private IVisualNovelPerformanceUiShake Instance;
	}
}
