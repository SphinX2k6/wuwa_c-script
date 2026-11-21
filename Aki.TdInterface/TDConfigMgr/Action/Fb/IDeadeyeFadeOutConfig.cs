using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DAD RID: 11693
	public class IDeadeyeFadeOutConfig
	{
		// Token: 0x0600FEBF RID: 65215 RVA: 0x0024BB95 File Offset: 0x00249D95
		public static IDeadeyeFadeOutConfig Create(IDeadeyeFadeOutConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFadeOutConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005013 RID: 20499
		// (get) Token: 0x0600FEC0 RID: 65216 RVA: 0x0024BBB4 File Offset: 0x00249DB4
		public virtual float TransitionTime
		{
			get
			{
				return this.Instance.TransitionTime;
			}
		}

		// Token: 0x04008B0B RID: 35595
		private IDeadeyeFadeOutConfig Instance;
	}
}
