using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200155E RID: 5470
	public class IRollBlockStartupMethodBase
	{
		// Token: 0x06007B59 RID: 31577 RVA: 0x0012566E File Offset: 0x0012386E
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

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x0012568D File Offset: 0x0012388D
		public virtual ERollBlockLaunchMethod Type
		{
			get
			{
				return (ERollBlockLaunchMethod)this.Instance.Type;
			}
		}

		// Token: 0x0400470C RID: 18188
		private IRollBlockStartupMethodBase Instance;
	}
}
