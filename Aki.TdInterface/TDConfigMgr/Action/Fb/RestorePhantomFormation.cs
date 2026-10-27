using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D0 RID: 10448
	public class RestorePhantomFormation : ActionParams
	{
		// Token: 0x0600E80E RID: 59406 RVA: 0x00221035 File Offset: 0x0021F235
		[NullableContext(1)]
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

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x0600E80F RID: 59407 RVA: 0x00221054 File Offset: 0x0021F254
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

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x0600E810 RID: 59408 RVA: 0x0022108C File Offset: 0x0021F28C
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

		// Token: 0x0400804A RID: 32842
		private IRestorePhantomFormation Instance;
	}
}
