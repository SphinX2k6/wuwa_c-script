using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297B RID: 10619
	public class IGravityFlipFixedPos : ITeleportConfig
	{
		// Token: 0x0600EB96 RID: 60310 RVA: 0x0022B4B4 File Offset: 0x002296B4
		public static IGravityFlipFixedPos Create(IGravityFlipFixedPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityFlipFixedPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x0600EB97 RID: 60311 RVA: 0x0022B4D3 File Offset: 0x002296D3
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x0600EB98 RID: 60312 RVA: 0x0022B4E0 File Offset: 0x002296E0
		public virtual int GravityAndPosEntityId
		{
			get
			{
				return this.Instance.GravityAndPosEntityId;
			}
		}

		// Token: 0x040081BB RID: 33211
		private IGravityFlipFixedPos Instance;
	}
}
