using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002799 RID: 10137
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenTransition
	{
		// Token: 0x0600E19F RID: 57759 RVA: 0x0021578B File Offset: 0x0021398B
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

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x0600E1A0 RID: 57760 RVA: 0x002157AA File Offset: 0x002139AA
		public virtual float TransitionDuration
		{
			get
			{
				return this.Instance.TransitionDuration;
			}
		}

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x0600E1A1 RID: 57761 RVA: 0x002157B7 File Offset: 0x002139B7
		public virtual string TransitionCurve
		{
			get
			{
				return this.Instance.TransitionCurve;
			}
		}

		// Token: 0x04007D1D RID: 32029
		private ISubScreenTransition Instance;
	}
}
