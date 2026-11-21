using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E6B RID: 3691
	public class ITowardEntityConfig
	{
		// Token: 0x0600536B RID: 21355 RVA: 0x000CDCB5 File Offset: 0x000CBEB5
		public static ITowardEntityConfig Create(ITowardEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITowardEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x000CDCD4 File Offset: 0x000CBED4
		public virtual string ReferenceActorKey
		{
			get
			{
				return this.Instance.ReferenceActorKey;
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x0600536D RID: 21357 RVA: 0x000CDCE1 File Offset: 0x000CBEE1
		public virtual int TargetEntityId
		{
			get
			{
				return this.Instance.TargetEntityId;
			}
		}

		// Token: 0x04002FAC RID: 12204
		private ITowardEntityConfig Instance;
	}
}
