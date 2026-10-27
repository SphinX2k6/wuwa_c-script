using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005187 RID: 20871
	public class IEntityGroupFailureSequentialStateT
	{
		// Token: 0x1700987A RID: 39034
		// (get) Token: 0x06021BFD RID: 138237 RVA: 0x004AECF5 File Offset: 0x004ACEF5
		// (set) Token: 0x06021BFE RID: 138238 RVA: 0x004AECFD File Offset: 0x004ACEFD
		public EEntityGroupFailureCondition Type { get; set; }

		// Token: 0x1700987B RID: 39035
		// (get) Token: 0x06021BFF RID: 138239 RVA: 0x004AED06 File Offset: 0x004ACF06
		// (set) Token: 0x06021C00 RID: 138240 RVA: 0x004AED0E File Offset: 0x004ACF0E
		public List<IEntityStateConditionT> Order { get; set; }

		// Token: 0x1700987C RID: 39036
		// (get) Token: 0x06021C01 RID: 138241 RVA: 0x004AED17 File Offset: 0x004ACF17
		// (set) Token: 0x06021C02 RID: 138242 RVA: 0x004AED1F File Offset: 0x004ACF1F
		public byte NullMask { get; set; }

		// Token: 0x06021C03 RID: 138243 RVA: 0x004AED28 File Offset: 0x004ACF28
		public IEntityGroupFailureSequentialStateT()
		{
			this.Type = EEntityGroupFailureCondition.SequentialState;
			this.Order = null;
			this.NullMask = 0;
		}
	}
}
