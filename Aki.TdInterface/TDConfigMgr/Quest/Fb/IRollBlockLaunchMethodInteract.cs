using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001408 RID: 5128
	public class IRollBlockLaunchMethodInteract : IRollBlockStartupMethodBase
	{
		// Token: 0x0600749B RID: 29851 RVA: 0x00116CBE File Offset: 0x00114EBE
		[NullableContext(1)]
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

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x00116CDD File Offset: 0x00114EDD
		public override ERollBlockLaunchMethod Type
		{
			get
			{
				return (ERollBlockLaunchMethod)this.Instance.Type;
			}
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600749D RID: 29853 RVA: 0x00116CEA File Offset: 0x00114EEA
		public virtual int TargetId
		{
			get
			{
				return this.Instance.TargetId;
			}
		}

		// Token: 0x0400437C RID: 17276
		private IRollBlockLaunchMethodInteract Instance;
	}
}
