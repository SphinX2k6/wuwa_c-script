using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A6B RID: 10859
	public class ISubScreenTransition
	{
		// Token: 0x0600EFBD RID: 61373 RVA: 0x0023251F File Offset: 0x0023071F
		public static ISubScreenTransition Create(ISubScreenTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004795 RID: 18325
		// (get) Token: 0x0600EFBE RID: 61374 RVA: 0x0023253E File Offset: 0x0023073E
		public virtual float TransitionDuration
		{
			get
			{
				return this.Instance.TransitionDuration;
			}
		}

		// Token: 0x17004796 RID: 18326
		// (get) Token: 0x0600EFBF RID: 61375 RVA: 0x0023254B File Offset: 0x0023074B
		public virtual string TransitionCurve
		{
			get
			{
				return this.Instance.TransitionCurve;
			}
		}

		// Token: 0x040083D3 RID: 33747
		private ISubScreenTransition Instance;
	}
}
