using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DAC RID: 11692
	public class IDeadeyeFollowShooterConfig
	{
		// Token: 0x0600FEBC RID: 65212 RVA: 0x0024BB61 File Offset: 0x00249D61
		public static IDeadeyeFollowShooterConfig Create(IDeadeyeFollowShooterConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFollowShooterConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005012 RID: 20498
		// (get) Token: 0x0600FEBD RID: 65213 RVA: 0x0024BB80 File Offset: 0x00249D80
		public virtual string DeadeyeShooterDa
		{
			get
			{
				return this.Instance.DeadeyeShooterDa;
			}
		}

		// Token: 0x04008B0A RID: 35594
		private IDeadeyeFollowShooterConfig Instance;
	}
}
