using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0D RID: 3597
	public class IFollowShooterMontage
	{
		// Token: 0x0600517B RID: 20859 RVA: 0x000C9BCE File Offset: 0x000C7DCE
		public static IFollowShooterMontage Create(IFollowShooterMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x000C9BED File Offset: 0x000C7DED
		public virtual EFollowShooterMontageType Name
		{
			get
			{
				return (EFollowShooterMontageType)this.Instance.Name;
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x0600517D RID: 20861 RVA: 0x000C9BFA File Offset: 0x000C7DFA
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04002E7A RID: 11898
		private IFollowShooterMontage Instance;
	}
}
