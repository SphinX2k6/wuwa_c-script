using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FF RID: 10751
	public class ISceneNewItemSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600EDB5 RID: 60853 RVA: 0x0022EEDC File Offset: 0x0022D0DC
		public static ISceneNewItemSplineStopTarget Create(ISceneNewItemSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneNewItemSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x0600EDB6 RID: 60854 RVA: 0x0022EEFB File Offset: 0x0022D0FB
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x0600EDB7 RID: 60855 RVA: 0x0022EF08 File Offset: 0x0022D108
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040082CD RID: 33485
		private ISceneNewItemSplineStopTarget Instance;
	}
}
