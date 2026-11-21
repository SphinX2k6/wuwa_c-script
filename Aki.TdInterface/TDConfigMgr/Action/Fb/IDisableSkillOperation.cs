using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C27 RID: 11303
	public class IDisableSkillOperation : ISkillOperationType
	{
		// Token: 0x0600F8B6 RID: 63670 RVA: 0x00242545 File Offset: 0x00240745
		public static IDisableSkillOperation Create(IDisableSkillOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableSkillOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x0600F8B7 RID: 63671 RVA: 0x00242564 File Offset: 0x00240764
		public override ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x0600F8B8 RID: 63672 RVA: 0x00242574 File Offset: 0x00240774
		public virtual EDisplayModeInSkillOp? DisplayMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EDisplayModeInSkillOp?((EDisplayModeInSkillOp)this.Instance.DisplayMode);
			}
		}

		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x0600F8B9 RID: 63673 RVA: 0x002425AC File Offset: 0x002407AC
		public virtual bool? DisableSkillWheel
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSkillWheel);
			}
		}

		// Token: 0x0400880B RID: 34827
		private IDisableSkillOperation Instance;
	}
}
