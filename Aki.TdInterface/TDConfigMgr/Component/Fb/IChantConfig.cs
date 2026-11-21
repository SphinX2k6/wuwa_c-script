using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF9 RID: 3065
	public class IChantConfig
	{
		// Token: 0x0600465D RID: 18013 RVA: 0x000B35CA File Offset: 0x000B17CA
		public static IChantConfig Create(IChantConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChantConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x000B35E9 File Offset: 0x000B17E9
		public virtual int ChantTime
		{
			get
			{
				return this.Instance.ChantTime;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x000B35F6 File Offset: 0x000B17F6
		public virtual string ChantCameraShake
		{
			get
			{
				return this.Instance.ChantCameraShake;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x000B3603 File Offset: 0x000B1803
		public virtual string ChantCameraStateTag
		{
			get
			{
				return this.Instance.ChantCameraStateTag;
			}
		}

		// Token: 0x0400278A RID: 10122
		private IChantConfig Instance;
	}
}
