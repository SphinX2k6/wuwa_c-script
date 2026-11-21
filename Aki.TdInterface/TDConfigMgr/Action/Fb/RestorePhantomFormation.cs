using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA5 RID: 11173
	public class RestorePhantomFormation : ActionParams
	{
		// Token: 0x0600F63D RID: 63037 RVA: 0x0023DFB5 File Offset: 0x0023C1B5
		public static RestorePhantomFormation Create(IRestorePhantomFormation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestorePhantomFormation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x0600F63E RID: 63038 RVA: 0x0023DFD4 File Offset: 0x0023C1D4
		public virtual int? TeleportEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TeleportEntityId);
			}
		}

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x0600F63F RID: 63039 RVA: 0x0023E00C File Offset: 0x0023C20C
		public virtual bool? RetainPhantom
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RetainPhantom);
			}
		}

		// Token: 0x04008709 RID: 34569
		private IRestorePhantomFormation Instance;
	}
}
