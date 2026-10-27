using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721B RID: 29211
	public class ISubScreenModeInitT
	{
		// Token: 0x1700D8D9 RID: 55513
		// (get) Token: 0x06033D16 RID: 212246 RVA: 0x006F94BF File Offset: 0x006F76BF
		// (set) Token: 0x06033D17 RID: 212247 RVA: 0x006F94C7 File Offset: 0x006F76C7
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x1700D8DA RID: 55514
		// (get) Token: 0x06033D18 RID: 212248 RVA: 0x006F94D0 File Offset: 0x006F76D0
		// (set) Token: 0x06033D19 RID: 212249 RVA: 0x006F94D8 File Offset: 0x006F76D8
		public List<TSubScreenInitDataUnion> InitConfigs { get; set; }

		// Token: 0x06033D1A RID: 212250 RVA: 0x006F94E1 File Offset: 0x006F76E1
		public ISubScreenModeInitT()
		{
			this.Type = ESubScreenOperationType.Init;
			this.InitConfigs = null;
		}
	}
}
