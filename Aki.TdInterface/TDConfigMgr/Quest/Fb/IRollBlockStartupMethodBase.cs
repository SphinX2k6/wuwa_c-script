using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001407 RID: 5127
	public class IRollBlockStartupMethodBase
	{
		// Token: 0x06007498 RID: 29848 RVA: 0x00116C8A File Offset: 0x00114E8A
		[NullableContext(1)]
		public static IRollBlockStartupMethodBase Create(IRollBlockStartupMethodBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockStartupMethodBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x06007499 RID: 29849 RVA: 0x00116CA9 File Offset: 0x00114EA9
		public virtual ERollBlockLaunchMethod Type
		{
			get
			{
				return (ERollBlockLaunchMethod)this.Instance.Type;
			}
		}

		// Token: 0x0400437B RID: 17275
		private IRollBlockStartupMethodBase Instance;
	}
}
