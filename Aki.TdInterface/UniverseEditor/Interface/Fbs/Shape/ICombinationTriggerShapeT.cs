using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BFF RID: 15359
	public class ICombinationTriggerShapeT
	{
		// Token: 0x1700697C RID: 27004
		// (get) Token: 0x06015259 RID: 86617 RVA: 0x00310827 File Offset: 0x0030EA27
		// (set) Token: 0x0601525A RID: 86618 RVA: 0x0031082F File Offset: 0x0030EA2F
		public ETriggerShape Type { get; set; }

		// Token: 0x1700697D RID: 27005
		// (get) Token: 0x0601525B RID: 86619 RVA: 0x00310838 File Offset: 0x0030EA38
		// (set) Token: 0x0601525C RID: 86620 RVA: 0x00310840 File Offset: 0x0030EA40
		public List<TCombinationTriggerShapeUnion> CombinationShapes { get; set; }

		// Token: 0x0601525D RID: 86621 RVA: 0x00310849 File Offset: 0x0030EA49
		public ICombinationTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.CombinationShapes = null;
		}
	}
}
