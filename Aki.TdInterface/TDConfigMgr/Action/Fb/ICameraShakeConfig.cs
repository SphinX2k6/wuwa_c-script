using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BEF RID: 11247
	public class ICameraShakeConfig
	{
		// Token: 0x0600F7BB RID: 63419 RVA: 0x00240C29 File Offset: 0x0023EE29
		public static ICameraShakeConfig Create(ICameraShakeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraShakeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x0600F7BC RID: 63420 RVA: 0x00240C48 File Offset: 0x0023EE48
		public virtual ECameraShakeType Type
		{
			get
			{
				return (ECameraShakeType)this.Instance.Type;
			}
		}

		// Token: 0x040087A5 RID: 34725
		private ICameraShakeConfig Instance;
	}
}
