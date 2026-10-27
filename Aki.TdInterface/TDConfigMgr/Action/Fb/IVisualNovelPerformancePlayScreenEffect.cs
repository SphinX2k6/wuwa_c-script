using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200257E RID: 9598
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformancePlayScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D773 RID: 55155 RVA: 0x0020179A File Offset: 0x001FF99A
		public static IVisualNovelPerformancePlayScreenEffect Create(IVisualNovelPerformancePlayScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformancePlayScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0600D774 RID: 55156 RVA: 0x002017B9 File Offset: 0x001FF9B9
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0600D775 RID: 55157 RVA: 0x002017C8 File Offset: 0x001FF9C8
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

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600D776 RID: 55158 RVA: 0x002017FE File Offset: 0x001FF9FE
		public virtual string ScreenEffectDa
		{
			get
			{
				return this.Instance.ScreenEffectDa;
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600D777 RID: 55159 RVA: 0x0020180C File Offset: 0x001FFA0C
		public virtual float? DestroyCountdown
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DestroyCountdown);
			}
		}

		// Token: 0x04007740 RID: 30528
		private IVisualNovelPerformancePlayScreenEffect Instance;
	}
}
