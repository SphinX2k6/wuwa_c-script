using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001560 RID: 5472
	public class IRollBlockLaunchMethodRange : IRollBlockStartupMethodBase
	{
		// Token: 0x06007B60 RID: 31584 RVA: 0x001256E3 File Offset: 0x001238E3
		public static IRollBlockLaunchMethodRange Create(IRollBlockLaunchMethodRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x06007B61 RID: 31585 RVA: 0x00125702 File Offset: 0x00123902
		public override ERollBlockLaunchMethod Type
		{
			get
			{
				return (ERollBlockLaunchMethod)this.Instance.Type;
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x06007B62 RID: 31586 RVA: 0x0012570F File Offset: 0x0012390F
		public virtual int TargetId
		{
			get
			{
				return this.Instance.TargetId;
			}
		}

		// Token: 0x0400470E RID: 18190
		private IRollBlockLaunchMethodRange Instance;
	}
}
