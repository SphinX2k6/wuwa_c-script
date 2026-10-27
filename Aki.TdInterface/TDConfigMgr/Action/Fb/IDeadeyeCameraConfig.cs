using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB6 RID: 10934
	public class IDeadeyeCameraConfig
	{
		// Token: 0x0600EFFC RID: 61436 RVA: 0x0022DD8D File Offset: 0x0022BF8D
		[NullableContext(1)]
		public static IDeadeyeCameraConfig Create(IDeadeyeCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x0600EFFD RID: 61437 RVA: 0x0022DDAC File Offset: 0x0022BFAC
		public virtual int LookAtPointId
		{
			get
			{
				return this.Instance.LookAtPointId;
			}
		}

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x0600EFFE RID: 61438 RVA: 0x0022DDBC File Offset: 0x0022BFBC
		public virtual int? SubLensTag
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SubLensTag);
			}
		}

		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x0600EFFF RID: 61439 RVA: 0x0022DDF2 File Offset: 0x0022BFF2
		public virtual float TransitionTime
		{
			get
			{
				return this.Instance.TransitionTime;
			}
		}

		// Token: 0x04008404 RID: 33796
		private IDeadeyeCameraConfig Instance;
	}
}
