using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200155F RID: 5471
	public class IRollBlockLaunchMethodInteract : IRollBlockStartupMethodBase
	{
		// Token: 0x06007B5C RID: 31580 RVA: 0x001256A2 File Offset: 0x001238A2
		public static IRollBlockLaunchMethodInteract Create(IRollBlockLaunchMethodInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x001256C1 File Offset: 0x001238C1
		public override ERollBlockLaunchMethod Type
		{
			get
			{
				return (ERollBlockLaunchMethod)this.Instance.Type;
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x001256CE File Offset: 0x001238CE
		public virtual int TargetId
		{
			get
			{
				return this.Instance.TargetId;
			}
		}

		// Token: 0x0400470D RID: 18189
		private IRollBlockLaunchMethodInteract Instance;
	}
}
