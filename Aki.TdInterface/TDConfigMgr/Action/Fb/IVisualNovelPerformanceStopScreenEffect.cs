using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200257F RID: 9599
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceStopScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D779 RID: 55161 RVA: 0x0020184A File Offset: 0x001FFA4A
		public static IVisualNovelPerformanceStopScreenEffect Create(IVisualNovelPerformanceStopScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceStopScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600D77A RID: 55162 RVA: 0x00201869 File Offset: 0x001FFA69
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0600D77B RID: 55163 RVA: 0x00201878 File Offset: 0x001FFA78
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

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0600D77C RID: 55164 RVA: 0x002018AE File Offset: 0x001FFAAE
		public virtual string ScreenEffectDa
		{
			get
			{
				return this.Instance.ScreenEffectDa;
			}
		}

		// Token: 0x04007741 RID: 30529
		private IVisualNovelPerformanceStopScreenEffect Instance;
	}
}
