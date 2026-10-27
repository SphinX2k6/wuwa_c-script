using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED4 RID: 28372
	public class IRoadNetworkNavigationTargetT
	{
		// Token: 0x1700D322 RID: 54050
		// (get) Token: 0x06032247 RID: 205383 RVA: 0x006C720A File Offset: 0x006C540A
		// (set) Token: 0x06032248 RID: 205384 RVA: 0x006C7212 File Offset: 0x006C5412
		public ERoadNetworkNavigationTarget Type { get; set; }

		// Token: 0x06032249 RID: 205385 RVA: 0x006C721B File Offset: 0x006C541B
		public IRoadNetworkNavigationTargetT()
		{
			this.Type = ERoadNetworkNavigationTarget.SceneItem;
		}
	}
}
