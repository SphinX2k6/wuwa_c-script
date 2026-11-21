using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5F RID: 2911
	public class IAiAlertSystemConfig
	{
		// Token: 0x06004274 RID: 17012 RVA: 0x000A8D07 File Offset: 0x000A6F07
		public static IAiAlertSystemConfig Create(IAiAlertSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiAlertSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x000A8D26 File Offset: 0x000A6F26
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x000A8D34 File Offset: 0x000A6F34
		public virtual float? PlayerHatredDeltaValue
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PlayerHatredDeltaValue);
			}
		}

		// Token: 0x040024CE RID: 9422
		private IAiAlertSystemConfig Instance;
	}
}
