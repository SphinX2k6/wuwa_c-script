using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002809 RID: 10249
	public class IAvgPlayRoleActionItem
	{
		// Token: 0x0600E43E RID: 58430 RVA: 0x0021C19E File Offset: 0x0021A39E
		public static IAvgPlayRoleActionItem Create(IAvgPlayRoleActionItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAvgPlayRoleActionItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x0600E43F RID: 58431 RVA: 0x0021C1BD File Offset: 0x0021A3BD
		public virtual EAvgPlayRoleActionType ActionType
		{
			get
			{
				return (EAvgPlayRoleActionType)this.Instance.ActionType;
			}
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x0600E440 RID: 58432 RVA: 0x0021C1CA File Offset: 0x0021A3CA
		public virtual int RoleId
		{
			get
			{
				return this.Instance.RoleId;
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x0600E441 RID: 58433 RVA: 0x0021C1D8 File Offset: 0x0021A3D8
		public virtual EAvgRolePosition? PositionConfig
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EAvgRolePosition?((EAvgRolePosition)this.Instance.PositionConfig);
			}
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x0600E442 RID: 58434 RVA: 0x0021C20E File Offset: 0x0021A40E
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				return (EAvgRoleAnimationType)this.Instance.AnimationType;
			}
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x0600E443 RID: 58435 RVA: 0x0021C21C File Offset: 0x0021A41C
		public virtual bool? IsAnimationLoop
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAnimationLoop);
			}
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x0600E444 RID: 58436 RVA: 0x0021C254 File Offset: 0x0021A454
		public virtual EAvgVisualEffect? VisualEffect
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new EAvgVisualEffect?((EAvgVisualEffect)this.Instance.VisualEffect);
			}
		}

		// Token: 0x04007D5B RID: 32091
		private IAvgPlayRoleActionItem Instance;
	}
}
