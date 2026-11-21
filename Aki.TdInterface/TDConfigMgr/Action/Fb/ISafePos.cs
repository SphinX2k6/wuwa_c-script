using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297C RID: 10620
	public class ISafePos : ITeleportConfig
	{
		// Token: 0x0600EB9A RID: 60314 RVA: 0x0022B4F5 File Offset: 0x002296F5
		public static ISafePos Create(ISafePos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISafePos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x0600EB9B RID: 60315 RVA: 0x0022B514 File Offset: 0x00229714
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x0600EB9C RID: 60316 RVA: 0x0022B524 File Offset: 0x00229724
		public virtual int? FinalSafePosEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FinalSafePosEntityId);
			}
		}

		// Token: 0x040081BC RID: 33212
		private ISafePos Instance;
	}
}
