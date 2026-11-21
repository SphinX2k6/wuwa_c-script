using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2B RID: 3115
	public class IItemLockingConfig
	{
		// Token: 0x0600475C RID: 18268 RVA: 0x000B4FA3 File Offset: 0x000B31A3
		public static IItemLockingConfig Create(IItemLockingConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemLockingConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x000B4FC2 File Offset: 0x000B31C2
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x000B4FD0 File Offset: 0x000B31D0
		public virtual ETeleControlLockingPerform? TeleControlPerform
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ETeleControlLockingPerform?((ETeleControlLockingPerform)this.Instance.TeleControlPerform);
			}
		}

		// Token: 0x04002816 RID: 10262
		private IItemLockingConfig Instance;
	}
}
