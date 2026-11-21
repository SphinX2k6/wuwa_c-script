using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005689 RID: 22153
	public class IElementalAbilityConfigT
	{
		// Token: 0x17009F42 RID: 40770
		// (get) Token: 0x06023705 RID: 145157 RVA: 0x004DFEBC File Offset: 0x004DE0BC
		// (set) Token: 0x06023706 RID: 145158 RVA: 0x004DFEC4 File Offset: 0x004DE0C4
		public EElementalType ElementalType { get; set; }

		// Token: 0x17009F43 RID: 40771
		// (get) Token: 0x06023707 RID: 145159 RVA: 0x004DFECD File Offset: 0x004DE0CD
		// (set) Token: 0x06023708 RID: 145160 RVA: 0x004DFED5 File Offset: 0x004DE0D5
		public bool IsInitialActive { get; set; }

		// Token: 0x17009F44 RID: 40772
		// (get) Token: 0x06023709 RID: 145161 RVA: 0x004DFEDE File Offset: 0x004DE0DE
		// (set) Token: 0x0602370A RID: 145162 RVA: 0x004DFEE6 File Offset: 0x004DE0E6
		public TTriggerShapeUnion Range { get; set; }

		// Token: 0x17009F45 RID: 40773
		// (get) Token: 0x0602370B RID: 145163 RVA: 0x004DFEEF File Offset: 0x004DE0EF
		// (set) Token: 0x0602370C RID: 145164 RVA: 0x004DFEF7 File Offset: 0x004DE0F7
		public bool IsEnableEnvEffect { get; set; }

		// Token: 0x17009F46 RID: 40774
		// (get) Token: 0x0602370D RID: 145165 RVA: 0x004DFF00 File Offset: 0x004DE100
		// (set) Token: 0x0602370E RID: 145166 RVA: 0x004DFF08 File Offset: 0x004DE108
		public List<IStateElementalEnableConfigT> StateEnableConfigs { get; set; }

		// Token: 0x17009F47 RID: 40775
		// (get) Token: 0x0602370F RID: 145167 RVA: 0x004DFF11 File Offset: 0x004DE111
		// (set) Token: 0x06023710 RID: 145168 RVA: 0x004DFF19 File Offset: 0x004DE119
		public byte NullMask { get; set; }

		// Token: 0x06023711 RID: 145169 RVA: 0x004DFF22 File Offset: 0x004DE122
		public IElementalAbilityConfigT()
		{
			this.ElementalType = EElementalType.Fire;
			this.IsInitialActive = false;
			this.Range = null;
			this.IsEnableEnvEffect = false;
			this.StateEnableConfigs = null;
			this.NullMask = 0;
		}
	}
}
