using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E74 RID: 3700
	public class IGravityFlipConfig
	{
		// Token: 0x06005399 RID: 21401 RVA: 0x000CE276 File Offset: 0x000CC476
		public static IGravityFlipConfig Create(IGravityFlipConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityFlipConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x000CE295 File Offset: 0x000CC495
		public virtual EGravityFlipType Type
		{
			get
			{
				return (EGravityFlipType)this.Instance.Type;
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x0600539B RID: 21403 RVA: 0x000CE2A2 File Offset: 0x000CC4A2
		public virtual int LocationEntityId
		{
			get
			{
				return this.Instance.LocationEntityId;
			}
		}

		// Token: 0x04002FCF RID: 12239
		private IGravityFlipConfig Instance;
	}
}
