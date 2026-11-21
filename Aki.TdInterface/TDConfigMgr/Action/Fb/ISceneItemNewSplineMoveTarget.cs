using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F3 RID: 10739
	public class ISceneItemNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600ED84 RID: 60804 RVA: 0x0022EA54 File Offset: 0x0022CC54
		public static ISceneItemNewSplineMoveTarget Create(ISceneItemNewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemNewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x0600ED85 RID: 60805 RVA: 0x0022EA73 File Offset: 0x0022CC73
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x0600ED86 RID: 60806 RVA: 0x0022EA80 File Offset: 0x0022CC80
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x0600ED87 RID: 60807 RVA: 0x0022EA90 File Offset: 0x0022CC90
		public virtual bool? IsLookDir
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLookDir);
			}
		}

		// Token: 0x040082BB RID: 33467
		private ISceneItemNewSplineMoveTarget Instance;
	}
}
