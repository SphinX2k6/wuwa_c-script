using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B0 RID: 10672
	public class IMonsterMoveSplineConfig
	{
		// Token: 0x0600EC68 RID: 60520 RVA: 0x0022CC68 File Offset: 0x0022AE68
		public static IMonsterMoveSplineConfig Create(IMonsterMoveSplineConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterMoveSplineConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x0600EC69 RID: 60521 RVA: 0x0022CC87 File Offset: 0x0022AE87
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x0600EC6A RID: 60522 RVA: 0x0022CC94 File Offset: 0x0022AE94
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x0600EC6B RID: 60523 RVA: 0x0022CCA4 File Offset: 0x0022AEA4
		public virtual bool? IsStrict
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsStrict);
			}
		}

		// Token: 0x04008228 RID: 33320
		private IMonsterMoveSplineConfig Instance;
	}
}
