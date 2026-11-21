using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291A RID: 10522
	public class IMapConfig
	{
		// Token: 0x0600E9E6 RID: 59878 RVA: 0x0022883F File Offset: 0x00226A3F
		public static IMapConfig Create(IMapConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMapConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x0600E9E7 RID: 59879 RVA: 0x0022885E File Offset: 0x00226A5E
		public virtual bool ExpandAreaTerminal
		{
			get
			{
				return this.Instance.ExpandAreaTerminal;
			}
		}

		// Token: 0x040080F4 RID: 33012
		private IMapConfig Instance;
	}
}
