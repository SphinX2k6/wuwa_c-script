using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002560 RID: 9568
	public class IAvgPlayRoleActionItem
	{
		// Token: 0x0600D6D4 RID: 54996 RVA: 0x002005A2 File Offset: 0x001FE7A2
		[NullableContext(1)]
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

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x0600D6D5 RID: 54997 RVA: 0x002005C1 File Offset: 0x001FE7C1
		public virtual EAvgPlayRoleActionType ActionType
		{
			get
			{
				return (EAvgPlayRoleActionType)this.Instance.ActionType;
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x0600D6D6 RID: 54998 RVA: 0x002005CE File Offset: 0x001FE7CE
		public virtual int RoleId
		{
			get
			{
				return this.Instance.RoleId;
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0600D6D7 RID: 54999 RVA: 0x002005DC File Offset: 0x001FE7DC
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

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0600D6D8 RID: 55000 RVA: 0x00200612 File Offset: 0x001FE812
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				return (EAvgRoleAnimationType)this.Instance.AnimationType;
			}
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0600D6D9 RID: 55001 RVA: 0x00200620 File Offset: 0x001FE820
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

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600D6DA RID: 55002 RVA: 0x00200658 File Offset: 0x001FE858
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

		// Token: 0x040076FE RID: 30462
		private IAvgPlayRoleActionItem Instance;
	}
}
