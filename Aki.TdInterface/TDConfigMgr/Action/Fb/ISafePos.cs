using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B9 RID: 9913
	public class ISafePos : ITeleportConfig
	{
		// Token: 0x0600DDC3 RID: 56771 RVA: 0x0020ED55 File Offset: 0x0020CF55
		[NullableContext(1)]
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

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x0600DDC4 RID: 56772 RVA: 0x0020ED74 File Offset: 0x0020CF74
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x0600DDC5 RID: 56773 RVA: 0x0020ED84 File Offset: 0x0020CF84
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

		// Token: 0x04007B1F RID: 31519
		private ISafePos Instance;
	}
}
