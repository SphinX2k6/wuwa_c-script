using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001409 RID: 5129
	public class IRollBlockLaunchMethodRange : IRollBlockStartupMethodBase
	{
		// Token: 0x0600749F RID: 29855 RVA: 0x00116CFF File Offset: 0x00114EFF
		[NullableContext(1)]
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

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x00116D1E File Offset: 0x00114F1E
		public override ERollBlockLaunchMethod Type
		{
			get
			{
				return (ERollBlockLaunchMethod)this.Instance.Type;
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x00116D2B File Offset: 0x00114F2B
		public virtual int TargetId
		{
			get
			{
				return this.Instance.TargetId;
			}
		}

		// Token: 0x0400437D RID: 17277
		private IRollBlockLaunchMethodRange Instance;
	}
}
