using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AB RID: 22955
	public class IStateHintComponentT
	{
		// Token: 0x1700AC48 RID: 44104
		// (get) Token: 0x06026E42 RID: 159298 RVA: 0x0055A051 File Offset: 0x00558251
		// (set) Token: 0x06026E43 RID: 159299 RVA: 0x0055A059 File Offset: 0x00558259
		public bool Disabled { get; set; }

		// Token: 0x1700AC49 RID: 44105
		// (get) Token: 0x06026E44 RID: 159300 RVA: 0x0055A062 File Offset: 0x00558262
		// (set) Token: 0x06026E45 RID: 159301 RVA: 0x0055A06A File Offset: 0x0055826A
		public List<IEntityStateConditionT> ActiveConditions { get; set; }

		// Token: 0x1700AC4A RID: 44106
		// (get) Token: 0x06026E46 RID: 159302 RVA: 0x0055A073 File Offset: 0x00558273
		// (set) Token: 0x06026E47 RID: 159303 RVA: 0x0055A07B File Offset: 0x0055827B
		public byte NullMask { get; set; }

		// Token: 0x06026E48 RID: 159304 RVA: 0x0055A084 File Offset: 0x00558284
		public IStateHintComponentT()
		{
			this.Disabled = false;
			this.ActiveConditions = null;
			this.NullMask = 0;
		}
	}
}
